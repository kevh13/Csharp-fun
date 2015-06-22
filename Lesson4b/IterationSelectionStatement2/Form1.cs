using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterationSelectionStatement2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (comboBox1.Text == "Kev") 
            { MessageBox.Show("You picked Kev");
                comboBox1.Text = ""; 
            } 
            if (comboBox1.Text == "Kevin")
                MessageBox.Show("You picked Kevin");
            */
            if (comboBox1.Text != "Kev")
                if (comboBox1.Text == "Kevin")
                    {
                        MessageBox.Show("You picked Kevin");
                    }
                    else
                    {
                        MessageBox.Show("I'm not sure who you picked?");
                    }
            else
            {
                MessageBox.Show("You picked Kev");
            }
        }
    }
}
