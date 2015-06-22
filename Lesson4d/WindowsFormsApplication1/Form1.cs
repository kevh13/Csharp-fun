using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] myArray = new string[4];
            //myArray[0] = "Kev";
            //myArray[1] = "Kevin";
            //myArray[2] = "Ke";
            //myArray[3] = "K";

            //MessageBox.Show(myArray[1]);
        
            //foreach (var nickname in myArray)
            //{
            //    MessageBox.Show(nickname);
            //}
            //string[] myArray = { "Kev", "Kevin", "Ke", "K" };
            //for (int i =0; i < myArray.Length; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}
            //int i = 0;
            //while (i < int.Parse(textBox1.Text))
            //{
            //   i++;
            //}
            //MessageBox.Show("The final value was: " + i.ToString());

            //string[] myArray = { "Kev", "Kevin", "Ke", "K" };

            //for(int i = 0; i < myArray.Length;)
            //{
            //    foreach (var nickname in myArray)
            //    {
            //        MessageBox.Show(i++ + " " + nickname);
            //    }
            //}
            
            //string[] myArray = { "Kev", "Kevin", "Ke", "K" };
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] == "Kevin")
            //    {
            //       MessageBox.Show("Found Kevin");

            //    }
            //}

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                switch (listBox1.SelectedItems[i].ToString())
                {
                    case "Foobar":
                        MessageBox.Show("Foobar");
                        break;
                    case "Bazquirk":
                        MessageBox.Show("Bazquirk");
                        break;
                    case "Widgets":
                        MessageBox.Show("Widgets");
                        break;
                    case "Gadgets":
                        MessageBox.Show("Gadgets");
                        break;
                }
            }

        
        
        
        }

    }
}
