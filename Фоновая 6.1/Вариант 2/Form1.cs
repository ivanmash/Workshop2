using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вариант_2
{
    public partial class Form1 : Form
    {
        int x; int w; int rast1;
        int y; int h; int rast2;
        int width;
        public Form1()
        {
            InitializeComponent();
            x = button2.Left;
            y = button2.Top;
            width = button1.Width;
            h = this.ClientSize.Height;
            w = this.ClientSize.Width;
            rast1 = this.ClientSize.Width - button2.Right;
            rast2 = this.ClientSize.Height - button2.Top - button2.Height;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (rast2 > 0 && rast1 > 0)
            {
                if (rast2 >= 4 && rast1 >= 2)
                {
                    button2.Top = button2.Top + 4;
                    button2.Left = button2.Left + 2;
                    rast1 = rast1 - 2;
                    rast2 = rast2 - 4;
                }
                if(rast2 < 4)
                {
                    button2.Top = button2.Top + this.ClientSize.Height - button2.Top - button2.Height;
                    rast2 = 0;
                }
                if (rast1 < 2)
                {
                    button2.Left = button2.Left + (this.ClientSize.Width - button2.Right);
                    rast1 = 0;
                }
            }
            else
            {
                button2.Location = new Point(x, y);
                rast1 = this.ClientSize.Width - button2.Right;
                rast2 = this.ClientSize.Height - button2.Top - button2.Height;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button1.Width <= 50)
                button1.Width = width;
            else button1.Width = button1.Width - 2;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(x, y);
            w = w + 2;
            h = h + 2;
            this.Size = new System.Drawing.Size(w, h);
            rast1 = this.ClientSize.Width - button2.Right;
            rast2 = this.ClientSize.Height - button2.Top - button2.Height;
        }
    }
}
