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
    public partial class Newton : Form
    {



        private double f(double x)
        {
            string equationString = txtEquation.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = equation.Evaluate(variables).RealValue;
            return result;

        }




        private double df(double x)
        {
            string equationString = txtEquation.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            SymbolicExpression derivative = equation.Differentiate("x");
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = derivative.Evaluate(variables).RealValue;
            return result;
        }
        public Newton()
        {
            InitializeComponent();
        }

        private void txteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void Newton_Load(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            double x0 =double.Parse(txtxl.Text);
            double eps =double.Parse(txteps.Text);

            double xi = 0;
            double xiold =0;
            double error = 0;
            double iteration = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Iteration");
            dt.Columns.Add("Xi");
            

            dt.Columns.Add("F(Xi)");
            dt.Columns.Add("F(Xi)dash");

            dt.Columns.Add("ERROR");


           data1.ColumnCount = 6;
           data1.Columns[0].Name = "Iteration";
           data1.Columns[1].Name = "xr";
           data1.Columns[2].Name = "f(xr)";
           data1.Columns[3].Name = "f'(xr)";
           data1.Columns[4].Name = "x0";
           data1.Columns[5].Name = "error%";
            // Clear the iteration data grid view
           data1.Rows.Clear();
           data1.Refresh();



            while (true)
            {
                // Evaluate the function and its derivative at xr
                double x = f(xi);
                double y = df(xi);

                xiold = xi;
                xi = xi - (x / y);
                error = Math.Abs((xi - xiold) / xi) * 100;

                // Add the iteration information to the data grid view
                data1.Rows.Add(iteration, xi, f(x), df(y), x0, error);

                iteration++;

                if (error < eps)
                {
                    txtroot.Text = xi.ToString();
                    break;
                }
                x0 = xi;

            }



        }

        private void clear_Click(object sender, EventArgs e)
        {
            txteps.Clear();
            
            txtxl.Clear();
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
