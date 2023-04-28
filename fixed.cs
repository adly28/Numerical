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
    public partial class Fixedpoint : Form
    {
        private double f(double x)
        {
            string equationString = txtEquation.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = equation.Evaluate(variables).RealValue;
            return result;

        }
        public Fixedpoint()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(txtx0.Text);
            double eps = double.Parse(txteps.Text);
            double iteration = 0;
            double error = 0;
          double xi1 = 0;
            double xi = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Iteration");
            dt.Columns.Add("Xi");
          
            dt.Columns.Add("F(Xi)");
            dt.Columns.Add("ERROR");
            while (true)
            {
                xi = f(x0);
                xi1 = f(xi);
                error = Math.Abs((xi1 - xi) / xi1) * 100;
                DataRow row = dt.NewRow();
                row["Iteration"] = iteration + 1;
                row["Xi"] = xi;

                row["F(Xi)"] = f(xi);

                row["Error"] = error;
                dt.Rows.Add(row);
                if (iteration < 1)
                {
                    row["Error"] = "-";
                }

                if (error < eps)
                {
                    txtroot.Text = xi.ToString();

                    break;
                }
                else { 
                x0 = xi;


                }
                iteration++;







            }
            data1.DataSource = dt;







        }

        private void data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
