using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PDF_Viwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Color HeaderColor = new Color();
        public static Color BodyColor = new Color();
        public static Color FooterColor = new Color();






        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
            var ff = new Exit();
            ff.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = true;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            notifyIcon1.BalloonTipText = " Your Program Is Now Minimized Here You Can Click Me To Bring It Back";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Firebrick)
            {
                button1.BackColor = Color.DimGray;
                button1.ForeColor = Color.White;
            }

            button1.BackColor = Color.Firebrick;
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = f.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var F = new ColorDialogForm();
            F.ShowDialog();



            header.GradientBottomLeft = HeaderColor;
            header.GradientBottomRight = HeaderColor;
            header.GradientTopLeft = HeaderColor;
            header.GradientTopRight = HeaderColor;
            body.GradientBottomLeft = BodyColor;
            body.GradientBottomRight = BodyColor;
            body.GradientTopLeft = BodyColor;
            body.GradientTopRight = BodyColor;
            footer.GradientBottomLeft = FooterColor;
            footer.GradientBottomRight = FooterColor;
            footer.GradientTopLeft = FooterColor;
            footer.GradientTopRight = FooterColor;
        }
    }
}
