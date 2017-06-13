using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PDF_Viwer
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                var n = new Note();
                n.Show();
                Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
        }
    }
}

