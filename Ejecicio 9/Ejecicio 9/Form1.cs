using System.Diagnostics.Eventing.Reader;

namespace Ejecicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEntrada.Text, out _))
            {
                MessageBox.Show("Es un n�mero v�lido.", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
 else
        {
                MessageBox.Show("Entrada no valida. Por favor, ingresa un n�mero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}