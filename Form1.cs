using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        private int[] lot = new int[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;

            for (int i = 0; i < 7; i++)
            {
                while (true)
                {
                    n = r.Next() % 45 + 1;
                    if (!lot.Contains(n))
                    {                  
                        lot[i] = n;
                        break;
                    }
                }
            }

            num1.Text = lot[0].ToString();
            num2.Text = lot[1].ToString();
            num3.Text = lot[2].ToString();
            num4.Text = lot[3].ToString();
            num5.Text = lot[4].ToString();
            num6.Text = lot[5].ToString();
            num7.Text = lot[6].ToString();
        }


    }
    
}
