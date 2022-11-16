namespace TrabajoFinal
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            frmCrearCuenta openPage02 = new frmCrearCuenta();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_CheckedChanged(object sender, EventArgs e)
        {
            frmIniciarSesion openPage02 = new frmIniciarSesion();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();

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
    }
}