namespace Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 200;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
                
        }

        private void btnDeterner_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
           }
            
           else
                {
                    timer1.Stop();

            }
        }
    }
}
