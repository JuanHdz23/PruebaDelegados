using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDelegados
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.ValueUpdate += new Delegado(form2_ValueUpdate);
            form2.Show();
        }

        private void form2_ValueUpdate(object sender, ValueUpdate e )
        {
            label1.Text = e.newValue;
        }
    }
}
