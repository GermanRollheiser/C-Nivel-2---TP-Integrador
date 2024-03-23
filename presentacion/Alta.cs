using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using helper;
using product;
using System.Configuration;

namespace presentacion
{
    public partial class frmAlta : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        private CargarImagen box = new CargarImagen();

        public frmAlta()
        {
            InitializeComponent();
        }

        public frmAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar artículo";
        }

        private void toInsertItem(ArticuloNegocio negocio)
        {
            negocio.toAdd(articulo);
            MessageBox.Show("Artículo agregado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toUpdateItem(ArticuloNegocio negocio)
        {
            negocio.toModify(articulo);
            MessageBox.Show("Artículo modificado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                toAddNewItemData();

                if (articulo.Id == 0)
                {
                    toInsertItem(negocio);
                }
                else
                {
                    toUpdateItem(negocio);
                }

                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    if (!(File.Exists(ConfigurationManager.AppSettings["images"] + archivo.SafeFileName)))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images"] + archivo.SafeFileName);
                    }
                    else
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images"] + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_(copia)_" + archivo.SafeFileName);
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toAddNewItemData()
        {
            articulo.Codigo = txtCodigo.Text.ToUpper();
            articulo.Nombre = txtNombre.Text.toTitleCase();
            articulo.Descripcion = txtDescripcion.Text.toTitleCase();
            articulo.Marca = cboMarca.SelectedItem as Marca;
            articulo.Categoria = cboCategoria.SelectedItem as Categoria;
            articulo.ImagenUrl = txtImagenUrl.Text;

            if (txtPrecio.Text != "")
            {
                articulo.Precio = decimal.Parse(txtPrecio.Text);
            }
            else
            {
                articulo.Precio = 0.00m;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            try
            {
                toLoadMarcaItems();
                toLoadCategoriaItems();

                if (articulo != null)
                {
                    toLoadItemData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toLoadItemData()
        {
            txtCodigo.Text = articulo.Codigo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            cboMarca.SelectedValue = articulo.Marca.Id;
            cboCategoria.SelectedValue = articulo.Categoria.Id;
            txtImagenUrl.Text = articulo.ImagenUrl;
            box.toLoadPicAlta(pbxAlta, articulo.ImagenUrl);
            txtPrecio.Text = articulo.Precio.ToString();
        }

        private void toLoadCategoriaItems()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cboCategoria.DataSource = categoriaNegocio.toList();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
        }

        private void toLoadMarcaItems()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cboMarca.DataSource = marcaNegocio.toList();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            box.toLoadPicAlta(pbxAlta, txtImagenUrl.Text);
        }

        private void pbxAlta_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                box.toLoadPicAlta(pbxAlta, archivo.FileName);
            }
            else
            {
                archivo = null;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',' || txtPrecio.SelectionStart == 0 || txtPrecio.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }
    }
}
