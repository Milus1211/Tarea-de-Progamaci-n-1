namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            
            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
