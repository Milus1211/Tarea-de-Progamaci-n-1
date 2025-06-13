namespace Ejercicio_6
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
            comboBox1Colores = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1Colores
            // 
            comboBox1Colores.FormattingEnabled = true;
            comboBox1Colores.Location = new Point(281, 111);
            comboBox1Colores.Name = "comboBox1Colores";
            comboBox1Colores.Size = new Size(182, 33);
            comboBox1Colores.TabIndex = 0;
            comboBox1Colores.SelectedIndexChanged += comboBox1Colores_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1Colores);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1Colores;
    }
}
