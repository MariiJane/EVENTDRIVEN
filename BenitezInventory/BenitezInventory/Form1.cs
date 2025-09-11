using System.Drawing.Text;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace BenitezInventory
{
    public partial class frmAddProduct : Form
    {
        private BindingSource showProductList;

        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        public IEnumerable<string> ListOfProductCategory { get; private set; }
        class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }
        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }
        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                    throw new StringFormatException("Invalid String Format.");
            }
            catch (StringFormatException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine(ProductName);
            }
            return name;
        }

        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                    throw new NumberFormatException("Invalid Numerical Values.");
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                Console.WriteLine(Quantity);
            }
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                    throw new CurrencyFormatException("Invalid Currency Format.");
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                Console.WriteLine(SellingPrice);
            }
            return Convert.ToDouble(price);
        }

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory =
             {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"

            };
            foreach (string ListOfProduct in ListOfProductCategory)
            {
                cbCategory.Items.Add(ListOfProduct);
            }

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richtxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }

        }
    }
}
        

    


