using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PDF_Viwer
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Hide();
            var ff1 = new Form1();
            ff1.Show();
        }
    }
}
