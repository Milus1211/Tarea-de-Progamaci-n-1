using System.Security.Permissions;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1Colores.Items.AddRange(new string[] { "Rojo", "Verde", "Azul" });
        }

        private void comboBox1Colores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorSeleccionado = comboBox1Colores.SelectedItem.ToString();
            switch (colorSeleccionado)
   {
                case "Rojo": 
                    this.BackColor = Color.Red;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                case "Azul":
                   this.BackColor = Color.Blue;

                    break; 

            }
        }
    }
}



