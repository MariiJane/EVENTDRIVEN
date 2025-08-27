using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
    
        public CustomerView()
        {
      InitializeComponent();
            UpdateNextNumberLabel("No number in the queue");
           
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }
        public void UpdateNextNumberLabel(string nextNumber)
        {
           
            label2.Text = nextNumber;       
        }
   
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
