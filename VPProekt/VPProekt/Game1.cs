using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProekt
{
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
            this.BackgroundImage = Form1.ResizeImg(VPProekt.Properties.Resources.game1bg,this.Width,this.Height);
            groupBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.Yellow;
            button1.FlatAppearance.BorderSize = 1;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.Yellow;
            button2.FlatAppearance.BorderSize = 1;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.Yellow;
            button3.FlatAppearance.BorderSize = 1;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
