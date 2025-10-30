using CalculatorPrivateAssembly;
namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();

            cbOperations.Items.Add("+");
            cbOperations.Items.Add("-");
            cbOperations.Items.Add("*");
            cbOperations.Items.Add("/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            a = float.Parse(Num1.Text);
            b = float.Parse(Num2.Text);

            int num = cbOperations.SelectedIndex;

            float result = 0;

            switch (num)
            {
                case 0:
                    result =  BasicComputation.Addition(a, b);
                    break;
                case 1:
                    result = BasicComputation.Subtraction(a, b);
                    break;
                case 2:
                    result = BasicComputation.Multiplication(a, b);
                    break;
                case 3:
                    result = BasicComputation.Division(a, b);
                    break;
            }

            label3.Text = result.ToString();

        }
       

private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
