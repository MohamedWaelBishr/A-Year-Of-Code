using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PDF_Viwer
{
    public partial class ColorDialogForm : Form
    {
        public ColorDialogForm()
        {
            InitializeComponent();

            button1.BackColor = HeaderColor2;
            button2.BackColor = BodyColor2;
            button3.BackColor = FooterColor2;
        }

        public static Color DefualtHeader = Color.FromArgb(53, 53, 53);
        public static Color DefualtBody = Color.FromArgb(53, 53, 53);
        public static Color DefualtFooter = Color.FromArgb(53, 53, 53);
        public static Color HeaderColor2 = new Color();
        public static Color BodyColor2 = new Color();
        public static Color FooterColor2 = new Color();

        private void button1_Click(object sender, EventArgs e)
        {
            var c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                HeaderColor2 = c.Color;
                button1.BackColor = c.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cc = new ColorDialog();
            if (cc.ShowDialog() == DialogResult.OK)
            {
                BodyColor2 = cc.Color;
                button2.BackColor = cc.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ccc = new ColorDialog();
            if (ccc.ShowDialog() == DialogResult.OK)
            {
                FooterColor2 = ccc.Color;
                button3.BackColor = ccc.Color;
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            Form1.HeaderColor = HeaderColor2;
            Form1.BodyColor = BodyColor2;
            Form1.FooterColor = FooterColor2;
            BackColor = HeaderColor2;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.HeaderColor = DefualtHeader;
            Form1.BodyColor = DefualtBody;
            Form1.FooterColor = DefualtFooter;
            HeaderColor2 = DefualtHeader;
            BodyColor2 = DefualtBody;
            FooterColor2 = DefualtFooter;
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
