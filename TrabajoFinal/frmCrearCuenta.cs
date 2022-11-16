using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class frmCrearCuenta : MaterialSkin.Controls.MaterialForm
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Estás seguro de salir?", "componentes",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSaldo.Clear();
            txtContrasena.Clear();
            txtContrasena1.Clear();
            txtSaldo.Clear();
            txtCedula.Clear();
        }
    }
}
