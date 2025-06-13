namespace Ejecicio_9
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
            lblInstruccion = new Label();
            txtEntrada = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(366, 170);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(42, 25);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "100";
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(315, 245);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(150, 31);
            txtEntrada.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(333, 62);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(112, 34);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "\"Validar número\"";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 380);
            Controls.Add(btnValidar);
            Controls.Add(txtEntrada);
            Controls.Add(lblInstruccion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruccion;
        private TextBox txtEntrada;
        private Button btnValidar;
    }
}
