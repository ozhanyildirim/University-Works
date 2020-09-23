using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sepalBoy = Convert.ToDouble(textBox1.Text);
            double sepalWidth = Convert.ToDouble(textBox2.Text);
            double petalBoy = Convert.ToDouble(textBox3.Text);
            double petalWidth = Convert.ToDouble(textBox4.Text);
            string iris;


            if (sepalBoy <= 2.6 )
            {
                iris = "İRİS SETOSA";
                label5.Text = Convert.ToString(iris);
            }

            if (sepalBoy > 2.6 && sepalWidth <= 1.750 )
            {
                iris = "İRİS VERSİCOLOR";
                label5.Text = Convert.ToString(iris);
            
           
            }
            if (sepalBoy > 2.6 && sepalWidth > 1.750 && petalBoy > 6 && petalWidth > 1)
            {
                iris = "İRİS VİRGİNİCA";
                label5.Text = Convert.ToString(iris);
            }
            if (sepalBoy > 2.6 && sepalWidth > 1.750 && petalBoy <= 6 && petalWidth > 1)
            {
                if (petalWidth <= 5.850)
                {
                    iris = "İRİS VİRGİNİCA";
                    label5.Text = Convert.ToString(iris);
                }
                else
                {
                    iris = "İRİS VERSİCOLOR";
                    label5.Text = Convert.ToString(iris);
                }
            }

        }
    }
}
