namespace Ejercicio_12
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
            lblTitulo = new Label();
            txtCelsius = new TextBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(133, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\"Celsius a Fahrenheit\"";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(24, 160);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(150, 31);
            txtCelsius.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(24, 105);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(112, 34);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "\"Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(254, 166);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(txtCelsius);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtCelsius;
        private Button btnConvertir;
        private Label lblResultado;
    }
}
