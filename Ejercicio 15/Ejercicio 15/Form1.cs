
using System;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContenido.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtContenido.Text);
            }
        }
        private void txtContenido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
