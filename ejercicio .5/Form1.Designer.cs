namespace ejercicio_._5
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            imageList1 = new ImageList(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            butto1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 265);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "50";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "100";
            // 
            // butto1
            // 
            butto1.Location = new Point(267, 55);
            butto1.Name = "butto1";
            butto1.Size = new Size(86, 29);
            butto1.TabIndex = 3;
            butto1.Text = "button1";
            butto1.UseVisualStyleBackColor = true;
            butto1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butto1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList imageList1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button butto1;
    }
}
