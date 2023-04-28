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

namespace NumericalPRG
{
    public partial class Scant : Form
    {
        private double f(double x)
        {
            string equationString = txtEquation.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = equation.Evaluate(variables).RealValue;
            return result;

        }
        public Scant()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double xi = double.Parse(txtxl.Text);
            double xi0 = double.Parse(txtxi0.Text);
            double eps = double.Parse(txteps.Text);
       
            double error = 0;
            int iteration = 0;
            double xi1 = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Iteration");
            dt.Columns.Add("Xi");
            dt.Columns.Add("Xi-1");
           
            dt.Columns.Add("F(Xi)");
            dt.Columns.Add("F(Xi-1)");
           
            dt.Columns.Add("ERROR");
            while (true)
            {
                xi1 = xi - (f(xi) * (xi0 - xi) / (f(xi0) - f(xi)));
                error = Math.Abs((xi1 - xi) / xi1) * 100;
                xi0 = xi;
                xi = xi1;
                DataRow row = dt.NewRow();
                row["Iteration"] = iteration + 1;
                row["Xi"] = xi;
                row["Xi-1"] = xi0;
                row["F(Xi)"] = f(xi);
                row["F(Xi-1)"] = f(xi0);
                if (xi != 0)
                {
                    row["Error"] = error;
                }
                else
                {
                    row["Error"] = "-";
                }
                dt.Rows.Add(row);
                iteration++;
                if (error <= eps)
                {
                    txtroot.Text=xi.ToString();


                    break;
                }
            }
            data1.DataSource = dt;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txteps.Clear();
            txtxi0.Clear();
            txtxl.Clear();
            txtEquation.Clear();
            txtroot.Clear();
            data1.Columns.Clear();

            if (data1.Rows.Count > 0)
            {
                data1.Rows.Clear();
            }
        }

        private void txtroot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
