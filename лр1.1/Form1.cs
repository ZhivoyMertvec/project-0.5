using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            Random r = new Random();
            int id = 0;
            for (int i = 0; i < 20; i++)
            {
               string p = "", d = "";
                for (int l = 0; l < 4; l++)
                {
                    int a = r.Next(1, 3);
                    if (a == 1) id = r.Next(97, 123);
                    if (a == 2)
                    {
                        id = r.Next(1025, 1072);
                        while ((id > 1025) & (id < 1040))
                            id = r.Next(1025, 1072);
                    }                        
                    char s = (char)id;
                    p = Convert.ToString(s);
                    d += p;
                }
                textBox1.Text += d + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            Random r = new Random();
            int id = 0;
            for (int i = 0; i < 20; i++)
            {
                string p = "", d = "";
                for (int l = 0; l < 7; l++)
                {
                    int a = r.Next(1, 3);
                    if (a == 1) id = r.Next(33, 43);
                    if (a == 2)
                    {
                        id = r.Next(1072, 1106);
                        while (id == 1104)
                            id = r.Next(1072, 1106);
                    }
                    char s = (char)id;
                    p = Convert.ToString(s);
                    d += p;
                }
                textBox1.Text += d + Environment.NewLine;
            }
        }
    }
}
