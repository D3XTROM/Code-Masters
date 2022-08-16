using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Esc_MouseEnter(object sender, EventArgs e)
        {
            Esc.ForeColor = Color.Red;
            
        }

        private void Esc_MouseLeave(object sender, EventArgs e)
        {
            Esc.ForeColor = Color.White;
        }
        
        Point LastPoint;

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top+=e.Y - LastPoint.Y;

            }

        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
