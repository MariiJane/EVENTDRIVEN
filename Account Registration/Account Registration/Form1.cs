using System.Net.Sockets;

namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("BSIT");
            comboBox1.Items.Add("BMMA");
            comboBox1.Items.Add("BSTM");
            comboBox1.Items.Add("BMHM");
            comboBox1.Items.Add("BSCRIM");
            comboBox1.Items.Add("BSCS");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = (string)this.textBox3.Text;
            StudentInfoClass.LastName = (string)this.textBox2.Text;
            StudentInfoClass.MiddleName = (string)this.textBox4.Text;
            StudentInfoClass.Address = (string)this.textBox7.Text;
            StudentInfoClass.Program = (string)this.comboBox1.Text;
            StudentInfoClass.Age = long.Parse(this.textBox5.Text);
            StudentInfoClass.ContactNo = long.Parse(this.textBox6.Text);
            StudentInfoClass.StudentNo = long.Parse(this.textBox1.Text);

            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK) 
            {
            }
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        
        }
    public class StudentInfoClass()
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public  static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string FirstName)
{
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }
        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
