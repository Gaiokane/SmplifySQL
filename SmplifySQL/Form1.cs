using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmplifySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richtxtboxNew_MouseClick(object sender, MouseEventArgs e)
        {
            string oldSql = richtxtboxOld.Text;
            richtxtboxNew.Text = oldSql.Replace("\n", " ").Replace("\t", " ").Replace("\r", " ");
        }
    }
}