namespace Ejercicio
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
            listBox1Elemento = new ListBox();
            button1Agregar = new Button();
            textBox1Elemento = new TextBox();
            SuspendLayout();
            // 
            // listBox1Elemento
            // 
            listBox1Elemento.FormattingEnabled = true;
            listBox1Elemento.ItemHeight = 25;
            listBox1Elemento.Location = new Point(127, 126);
            listBox1Elemento.Name = "listBox1Elemento";
            listBox1Elemento.Size = new Size(364, 129);
            listBox1Elemento.TabIndex = 0;
            // 
            // button1Agregar
            // 
            button1Agregar.Location = new Point(157, 87);
            button1Agregar.Name = "button1Agregar";
            button1Agregar.Size = new Size(112, 34);
            button1Agregar.TabIndex = 1;
            button1Agregar.Text = "button1";
            button1Agregar.UseVisualStyleBackColor = true;
            button1Agregar.Click += button1Agregar_Click;
            // 
            // textBox1Elemento
            // 
            textBox1Elemento.Location = new Point(275, 89);
            textBox1Elemento.Name = "textBox1Elemento";
            textBox1Elemento.Size = new Size(150, 31);
            textBox1Elemento.TabIndex = 2;
            textBox1Elemento.TextChanged += textBox1Elemento_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 377);
            Controls.Add(textBox1Elemento);
            Controls.Add(button1Agregar);
            Controls.Add(listBox1Elemento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1Elemento;
        private Button button1Agregar;
        private TextBox textBox1Elemento;
    }
}
