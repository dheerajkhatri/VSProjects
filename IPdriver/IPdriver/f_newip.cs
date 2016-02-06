using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPdriver
{
    public partial class f_newip : Form
    {
        public f_newip()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            //second argument true for appending, false for writing in empty file
            TextWriter tw = new StreamWriter("F://workspace//VS2013 Projects//savedData.txt",true);

            
            tw.Write(t_name.Text + " ");
            tw.Write(t_ipaddress.Text + " ");
            tw.Write(t_subnetmask.Text + " ");
            tw.WriteLine(t_defaultgateway.Text);
            tw.Close();

            MessageBox.Show("IP saved Successfully");
            
            this.Close();            
        }
    }
}
