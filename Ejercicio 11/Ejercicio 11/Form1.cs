namespace Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value;
            lblFecha.Text = "Fecha seleccionada:" + fechaSeleccionada.ToShortDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
