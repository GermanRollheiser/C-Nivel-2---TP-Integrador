using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using helper;
using product;

namespace presentacion
{
    public partial class frmMain : Form
    {
        private Articulo seleccionado;
        public List<Articulo> listArticulos;
        private ArticuloNegocio negocio = new ArticuloNegocio();
        private CargarImagen box = new CargarImagen();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta agregar = new frmAlta();
            agregar.ShowDialog();
            toLoad();
        }

        private void lblBusquedaAvanzada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFiltro lista = new frmFiltro();
            lista.ShowDialog();
            toLoadSortedBy(lista);
        }

        private void toLoadSortedBy(frmFiltro lista)
        {
            if (lista.txtBuscarAvanzado.Text != "")
            {
                string campo = lista.cboCampo.SelectedItem.ToString();
                string criterio = lista.cboCriterio.SelectedItem.ToString();
                string filtro = lista.txtBuscarAvanzado.Text;

                listArticulos = negocio.toSortBy(campo, criterio, filtro);
                dgvArticulos.DataSource = listArticulos;

                if (dgvArticulos.RowCount < 1)
                {
                    pbxMain.Load("https://tagcor.com/jobs_assets/images/icons/error.png");
                }
            }

            toHideColumns();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toLoad();
        }

        private void toLoad()
        {
            try
            {
                listArticulos = negocio.toList();
                dgvArticulos.DataSource = listArticulos;

                toHideColumns();

                box.toLoadPic(pbxMain, listArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toHideColumns()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
                box.toLoadPic(pbxMain, seleccionado.ImagenUrl);
            }
        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetalle detalle = new frmDetalle();
            int row = e.RowIndex;

            if (row == -1)
            {
                return;
            }

            detalle.txtDetalle.Text = "Código: " + Convert.ToString(dgvArticulos[5, row].Value) + Environment.NewLine
                 + "Nombre: " + Convert.ToString(dgvArticulos[0, row].Value) + Environment.NewLine
                 + "Marca: " + Convert.ToString(dgvArticulos[1, row].Value) + Environment.NewLine
                 + "Categoría: " + Convert.ToString(dgvArticulos[2, row].Value) + Environment.NewLine
                 + "Precio: " + Convert.ToString(dgvArticulos[3, row].Value) + Environment.NewLine
                 + "Descripción: " + Convert.ToString(dgvArticulos[6, row].Value);

            detalle.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            seleccionado = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            frmAlta modificar = new frmAlta(seleccionado);
            modificar.ShowDialog();
            toLoad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Eliminar el artículo seleccionado?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
                    negocio.toDelete(seleccionado.Id);
                    MessageBox.Show("Artículo eliminado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> busquedaRapida;
            string busqueda = txtBuscar.Text;

            if (busqueda.Length > 0) 
            {
                busquedaRapida = listArticulos.FindAll(x => x.Nombre.ToUpper().Contains(busqueda.ToUpper()));
            }
            else
            {
                busquedaRapida = listArticulos;
            }

            dgvArticulos.DataSource = busquedaRapida;
            toHideColumns();
        }

        private void lblLimpiarFiltro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toLoad();
            txtBuscar.Clear();
        }
    }
}
