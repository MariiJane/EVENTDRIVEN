using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {

        public CashierWindowQueueForm()
        {
            InitializeComponent();
            CustomerView.Show();
        }
        CustomerView CustomerView = new CustomerView();
        private void btnRefresh_Click(object sender, EventArgs e)

        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        private CustomerView GetCustomerView()
        {
            return CustomerView;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.View = View.List;
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            CustomerView.Show();
            try
            {
                CustomerView.UpdateNextNumberLabel(CashierClass.CashierQueue.Peek());
            }
            catch
            {

            }

            if (CashierClass.CashierQueue.Count <= 0)
            {
                MessageBox.Show("Empty Queue", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }

        }
    }
}
    

