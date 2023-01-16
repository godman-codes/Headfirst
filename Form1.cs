using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headfirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is a comment
            string name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            MessageBox.Show($"Name is {name} \nx is {x} \nd is {d}");
        }
    }
}
