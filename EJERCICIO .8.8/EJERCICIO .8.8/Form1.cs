namespace EJERCICIO_._8._8
{
    public partial class Form1 : Form
    {
        int Contador = 0;
        public Form1()
        {
            InitializeComponent();
            lblContador.Text = "presionado 0 veces";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contador++;
            lblContador.Text = $"presionado {Contador} Veces.";
        } 

        private void lblContador_Click(object sender, EventArgs e)
        {

        }
    }
}
