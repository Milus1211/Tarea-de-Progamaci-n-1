namespace Ejercicio_11
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
            dtpFecha = new DateTimePicker();
            btnMostrarFecha = new Button();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(12, 57);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 0;
            // 
            // btnMostrarFecha
            // 
            btnMostrarFecha.Location = new Point(12, 116);
            btnMostrarFecha.Name = "btnMostrarFecha";
            btnMostrarFecha.Size = new Size(112, 34);
            btnMostrarFecha.TabIndex = 1;
            btnMostrarFecha.Text = "\"Mostrar Fecha\"";
            btnMostrarFecha.UseVisualStyleBackColor = true;
            btnMostrarFecha.Click += button1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(161, 125);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 25);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "label1";
            lblFecha.Click += lblFecha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 308);
            Controls.Add(lblFecha);
            Controls.Add(btnMostrarFecha);
            Controls.Add(dtpFecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Button btnMostrarFecha;
        private Label lblFecha;
    }
}
