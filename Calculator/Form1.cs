namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2, answer;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblSymbol.Text = "+";
            answer = 0;

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            answer = num1 + num2;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblSymbol.Text = "-";
            answer = 0;

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            answer = num1 - num2;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblSymbol.Text = "x";
            answer = 0;

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            answer = num1 * num2;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblSymbol.Text = "/";
            answer = 0;

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            answer = num1 / num2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lblAnswer.Text= Math.Round(answer, 2).ToString(); 
        }
    }
}
