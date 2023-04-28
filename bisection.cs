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
    public partial class bisection : Form
    {
        private double f(double x)
        {
            string equationString = txtEquation.Text;
            SymbolicExpression equation = SymbolicExpression.Parse(equationString);
            Dictionary<string, FloatingPoint> variables = new Dictionary<string, FloatingPoint> { { "x", x } };
            double result = equation.Evaluate(variables).RealValue;
            return result;

        }
        public bisection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xl=double.Parse(txtxl.Text);
            double xu=double.Parse(txtxu.Text);
            double eps=double.Parse(txteps.Text);
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
              

            while(true)
            {
                xrold = xr;
                xr = (xl + xu) / 2;
                error =Math.Abs((xr - xrold) / xr) * 100;
                DataRow row= dt.NewRow();
                row["Iteration"]= iteration + 1;
                row["XL"]= xl;
                row["XU"]= xu;
                row["XR"]= xr;
                row["F(XL)"]= f(xl);
                row["F(XU)"]= f(xu);
                row["F(XR)"]=f(xr);
                row["Error"]= error;
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




    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txteps.Clear();
            txtxl.Clear();
            txtxu.Clear();
            txtEquation.Clear();
            txtroot.Clear();
            data1.Columns.Clear();

            if(data1.Rows.Count > 0)
            {
                data1.Rows.Clear();
            }
           

        }

        private void data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bisection_Load(object sender, EventArgs e)
        {

        }
    }
}
