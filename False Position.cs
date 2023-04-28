using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;
using System.IO;


namespace NumericalPRG
{
    public partial class False_Position : Form
    {

        private double f(double x)
        {
            string equationString = txtEquation.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = equation.Evaluate(variables).RealValue;
            return result;

        }








        public False_Position()
        {
            InitializeComponent();
        }

        private void False_Position_Load(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            double xl = double.Parse(txtxl.Text);
            double xu = double.Parse(txtxu.Text);
            double eps = double.Parse(txteps.Text);
            double xr = 0;
            double xrold = 0;
            double error = 0;
            int iteration = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Iteration");
            dt.Columns.Add("XL");
            dt.Columns.Add("XU");
            dt.Columns.Add("XR");
            dt.Columns.Add("F(XL)");
            dt.Columns.Add("F(XU)");
            dt.Columns.Add("F(XR)");
            dt.Columns.Add("ERROR");


            while (true)
            {
                xrold = xr;
                xr = xu - (f(xu) * (xl - xu)) / (f(xl) - f(xu)); 
                error = Math.Abs((xr - xrold) / xr) * 100;
                DataRow row = dt.NewRow();
                row["Iteration"] = iteration + 1;
                row["XL"] = xl;
                row["XU"] = xu;
                row["XR"] = xr;
                row["F(XL)"] = f(xl);
                row["F(XU)"] = f(xu);
                row["F(XR)"] = f(xr);
                row["Error"] = error;
                dt.Rows.Add(row);
                if (iteration < 1)
                {
                    row["Error"] = "-";
                }

                if (f(xl) * f(xr) > 0)
                {

                    xl = xr;
                }
                else
                {
                    xu = xr;
                }


                if (error < eps)
                {
                    txtroot.Text = xr.ToString();

                    break;
                }

                iteration++;
            }

            data1.DataSource = dt;


        }

        private void clear_Click(object sender, EventArgs e)
        {
            txteps.Clear();
            txtxl.Clear();
            txtxu.Clear();
            txtEquation.Clear();
            txtroot.Clear();
            data1.Columns.Clear();

            if (data1.Rows.Count > 0)
            {
                data1.Rows.Clear();
            }
        }
    }
}
