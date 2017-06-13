using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PDF_Viwer
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                Hide();
                Application.Exit();
            }
        }
    }
}
