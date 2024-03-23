using domain;
using helper;
using product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmFiltro : Form
    {
        public frmFiltro()
        {
            InitializeComponent();
        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            toLoadFieldItems();
            toLoadPriceItems();
            toLoadTextItems();
        }

        private void toLoadFieldItems()
        {
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Precio");
            cboCampo.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (toValidateSearchOperation())
                {
                    return;
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toLoadTextItems()
        {
            cboCriterio.Items.Clear();
            cboCriterio.Items.Add("Comienza con");
            cboCriterio.Items.Add("Termina con");
            cboCriterio.Items.Add("Contiene");
            cboCriterio.SelectedIndex = 0;
        }

        private void toLoadPriceItems()
        {
            cboCriterio.Items.Clear();
            cboCriterio.Items.Add("Mayor a");
            cboCriterio.Items.Add("Menor a");
            cboCriterio.Items.Add("Igual a");
            cboCriterio.SelectedIndex = 0;
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                toLoadPriceItems();
            }
            else
            {
                toLoadTextItems();
            }
        }

        private bool toValidateSearchOperation()
        {
            if (string.IsNullOrEmpty(txtBuscarAvanzado.Text))
            {
                MessageBox.Show("Por favor, complete el cuadro de busqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(isValidValue(txtBuscarAvanzado.Text)))
                {
                    MessageBox.Show("Por favor, solo ingrese números enteros.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBuscarAvanzado.Clear();
                    return true;
                }
            }

            return false;
        }

        private bool isValidValue(string precio)
        {

            foreach (char caracter in precio)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            txtBuscarAvanzado.Clear();
        }
    }
}
