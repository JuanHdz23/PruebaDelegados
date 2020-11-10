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
    
    public partial class Form2 : Form
    {
        public event Delegado ValueUpdate;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newValue = textBox1.Text;
            ValueUpdate valueArgs = new ValueUpdate(newValue);
            ValueUpdate(this, valueArgs);
        }
    }
}
