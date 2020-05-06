using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z3_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int fun(int x)
        {
            return (x % 2) != 0 ? 0 : x / 2;
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            int x = int.Parse(num.Text);
            int a = fun(x);
            rez_1.Text = a.ToString();
        }
        static double f(double x)
        {
            double y=0.0;
            if (x == 1) y = 0.0;
            if (x > 1) y = 1 / Math.Pow(1 + x, 2);
            if (x < 1) y = Math.Pow((x * x) - 1, 2);
            return y;
        }
        private void Culculate_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(per_a.Text);
            double b = Convert.ToDouble(per_b.Text);
            double h = Convert.ToDouble(per_h.Text);
            string rez = "";
            for (double i = a; i <= b; i += h)
            {
                rez += "f(" + i.ToString() + ") = " + f(i).ToString() + "\n";
            }
            rez_2and3.Text = rez;
        }
    }
}
