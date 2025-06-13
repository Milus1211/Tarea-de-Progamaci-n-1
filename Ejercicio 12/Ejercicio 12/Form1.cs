namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double Celsius)) 
            {
                double fahrenheit = (Celsius * 9 / 5) + 32;
                lblResultado.Text = $"Resultado: {fahrenheit}°F";
        }
    else
            {
                MessageBox.Show("Por favor, ingresa un número valido", "Error", MessageBoxButtons.OK);
            }
        }
    }
}