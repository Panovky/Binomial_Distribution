using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teorver_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExe_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            double p = Convert.ToDouble(inputProb.Text.Replace(".", ","));
            double q = 1 - p;

            int n = Convert.ToInt32(inputCountIsp.Text);
            int N = Convert.ToInt32(inputCountSeries.Text);

            int[] Nk = new int[n + 1];
            int num;
            double x;
            Random r = new Random();

            for (int i = 0; i < N; i++)
            {
                num = 0;
                for (int j = 0; j < n; j++)
                {
                    x = r.NextDouble();
                    if (x <= p)
                    {
                        num += 1;
                    }
                }

                Nk[num] += 1; 
            }

            for (int k = 0; k <= n; k++)
            {
                Console.WriteLine(Nk[k] / (double) N);
                this.chart1.Series[0].Points.AddXY(k, Nk[k] / (double)N); 
            }

            double g, n1, n2, n3;

            for (int k = 0; k <= n; k++)
            {
                n1 = 0; n2 = 0; n3 = 0;

                if (k == 0)
                {
                    g = n * Math.Log(q);
                } 
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        n1 += Math.Log(i);
                    }

                    for (int i = 1; i <= k; i++)
                    {
                        n2 += Math.Log(i);
                    }

                    for (int i = 1; i <= n - k; i++)
                    {
                        n3 += Math.Log(i);
                    }

                    g = n1 - n2 - n3 + k * Math.Log(p) + (n - k) * Math.Log(q);
                }
               
                this.chart1.Series[1].Points.AddXY(k, Math.Exp(g));  
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            inputProb.Clear();
            inputCountIsp.Clear();
            inputCountSeries.Clear();
        }
    }
}
