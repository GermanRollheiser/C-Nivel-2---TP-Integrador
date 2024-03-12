using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using product;

namespace presentacion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta agregar = new frmAlta();
            agregar.ShowDialog();
        }

        private void lblBusquedaAvanzada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetalle detalle = new frmDetalle();
            detalle.ShowDialog();
        }
    }
}
