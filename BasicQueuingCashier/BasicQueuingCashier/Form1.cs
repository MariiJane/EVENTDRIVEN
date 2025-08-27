namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();
        
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm  obj= new CashierWindowQueueForm();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

    
        }
    }
    class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue = new Queue<string>();

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();

        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        
        }
    }
}
   
   

         
        
        
    

