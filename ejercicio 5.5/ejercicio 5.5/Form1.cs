namespace ejercicio_5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1resultado.Text = "Seleccionaste: Opci�n 1";
            }
            else if (radioButton2.Checked)
            {
                label1resultado.Text = "Seleccionaste: Opci�n 2";
            }


            else if (radioButton3.Checked)
            {
                label1resultado.Text = "Seleccionaste: Opci�n 3";
            }
            else
            {
                label1resultado.Text = "No seleccionaste ninguna opci�n.";

            }
        }
    }
}




