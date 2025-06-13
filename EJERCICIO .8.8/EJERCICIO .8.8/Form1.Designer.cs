namespace EJERCICIO_._8._8
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
            lblContador = new Label();
            btnContar = new Button();
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(111, 135);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(165, 25);
            lblContador.TabIndex = 0;
            lblContador.Text = "presionado 0 veces";
            lblContador.Click += lblContador_Click;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(120, 72);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(112, 34);
            btnContar.TabIndex = 1;
            btnContar.Text = "button1";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContar);
            Controls.Add(lblContador);
            Name = "Form1";
            Text = "Presionado 0 veces";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContador;
        private Button btnContar;
    }
}
