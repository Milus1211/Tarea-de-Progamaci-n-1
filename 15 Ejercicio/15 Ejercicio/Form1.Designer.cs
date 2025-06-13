namespace _15_Ejercicio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAbrir = new Button();
            btnGuardar = new Button();
            textBoxContenido = new TextBox();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(175, 54);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(112, 34);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(352, 54);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBoxContenido
            // 
            textBoxContenido.Location = new Point(133, 125);
            textBoxContenido.Multiline = true;
            textBoxContenido.Name = "textBoxContenido";
            textBoxContenido.ScrollBars = ScrollBars.Both;
            textBoxContenido.Size = new Size(420, 254);
            textBoxContenido.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxContenido);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private Button btnGuardar;
        private TextBox textBoxContenido;
    }
}
