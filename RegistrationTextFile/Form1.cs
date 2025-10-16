namespace RegistrationTextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                string studentNo = txtStudentNo.Text;
                string lastName = txtLastName.Text;
                string firstName = txtFirstName.Text;
                string middleInitial = txtMI.Text;
                string program = cbProgram.SelectedItem?.ToString();
                string gender = cbGender.SelectedItem?.ToString();
                string age = txtAge.Text;
                DateTime birthday = dtpBirthday.Value;
                string birthdayString = birthday.ToString("yyyy-MM-dd");

                string contactNo = txtContactNo.Text;

                string[] lines = {
                "Student No.: " + studentNo,
                "Full Name: " + lastName + ", " + firstName + ", " + middleInitial,
                "Program: " + program,
                "Gender: " + gender,
                "Age: " + age,
                "Birthday: " + birthdayString,
                "Contact No.: " + contactNo
            };

                string fileName = studentNo + ".txt";
                string filePath = Path.Combine(Application.StartupPath, fileName);

                try
                {
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("Registration data saved to " + filePath, "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing to file: " + ex.Message, "Error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbProgram.Items.Add("BSIT");
            cbProgram.Items.Add("BSCS");
            cbProgram.Items.Add("BSBA");

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Other");
        }
    }
}
