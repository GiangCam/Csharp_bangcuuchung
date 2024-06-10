using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_bangcuuchung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            lbsKQ.Items.Clear();
            int cc = Convert.ToInt32(txtso.Text);
            for (int i = 1; i <= 10; i++)
            {
                lbsKQ.Items.Add(txtso.Text + "*" + i.ToString() + "=" + Convert.ToString(cc * i));

            }
        }

        private void lbsKQ_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            //cách 2 lbsKQ.Items.Add(String.Format("{0}*{1}={2}",txtso.Text+"")
        }
    }
}
