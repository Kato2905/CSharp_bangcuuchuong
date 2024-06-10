using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lsbkq_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           lsbkq.Items.Clear();
            int cc=Convert.ToInt32(lsbkq.Text);
            for (int i = 1; i <= 10; i++)
                // { lsbkq.Items.Add(txtso.Text + "x" + i.ToString() + "=" + (cc * i)); }    
                lsbkq.Items.Add(String.Format("{0}x{1}={2}"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
