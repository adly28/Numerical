namespace NumericalPRG
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bisection bisec=new bisection();
            bisec.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            False_Position false_Position = new False_Position();
            false_Position.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fixedpoint fixedpoint = new Fixedpoint();
            fixedpoint.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fixedpoint fixedpoint =new Fixedpoint();
            fixedpoint. Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Scant scant = new Scant();
            scant.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Newton newton = new Newton();
            newton.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gauss gauss = new Gauss();
            gauss.Show();
        }
    }
}