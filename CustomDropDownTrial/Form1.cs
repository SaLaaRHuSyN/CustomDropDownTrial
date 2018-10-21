using CustomDropDownTrial.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDropDownTrial
{
    public partial class Form1 : Form
    {
        private bool isCollapsed = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button1.Image = Resources.Collapse_Arrow_20px;
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    
                    isCollapsed = false;
                }
            }
            else
            {
                panel1.Height -= 10;
                button1.Image = Resources.Expand_Arrow_20px;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    
                    isCollapsed = true;
                }
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
            button1_MouseHover(sender,e);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isCollapsed = false;
            timer1.Start();
        }
    }
}
