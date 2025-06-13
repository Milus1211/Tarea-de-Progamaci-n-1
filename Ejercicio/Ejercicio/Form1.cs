namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Agregar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBox1Elemento.Text.Trim();
            if (!string.IsNullOrEmpty(nuevoElemento))
            {
                listBox1Elemento.Items.Add(nuevoElemento);
                textBox1Elemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un elemento válido.");
            }

        }

        private void textBox1Elemento_TextChanged(object sender, EventArgs e)
        {

        }
    }

}