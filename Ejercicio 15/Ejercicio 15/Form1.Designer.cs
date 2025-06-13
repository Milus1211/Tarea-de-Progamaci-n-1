using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        
        private System.ComponentModel.IContainer components = null;

       
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            txtContenido = new TextBox();
            btnAbrir = new Button();
            btnGuardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            
            txtContenido.Location = new Point(55, 142);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(489, 31);
            txtContenido.TabIndex = 0;
            txtContenido.Text = File.ReadAllText(openFileDialog1.FileName);

            btnAbrir.Location = new Point(42, 102);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(112, 34);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "btnAbrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(176, 102);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "btnGuardar";
            btnGuardar.BackColor = SystemColors.Control;    
            btnGuardar.ForeColor = SystemColors.ControlText; 
            btnGuardar.Click += btnGuardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 533);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Controls.Add(txtContenido);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenido;
        private Button btnAbrir;
        private Button btnGuardar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
