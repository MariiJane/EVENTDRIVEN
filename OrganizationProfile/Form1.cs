using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizationProfile
{
	public partial class Form1 : Form
	{
		private string _FullName;
		private int _Age;
		private long _ContactNo;
		private long _StudentNo;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] ListOfPrograms = new string[] {
				"BS Information Technology",
				"BS Computer Science",
				"BS Information Systems",
				"BS in Accountancy",
				"BS in Hospitality Management",
				"BS in Tourism Management"

			};
			for (int i = 0; i < 6; i++)
			{
				cbPrograms.Items.Add(ListOfPrograms[i].ToString());
			}
			string[] Gender = new string[] {
				"Male",
				"Female"
			};
			foreach (string g in Gender)
			{
				cbGender.Items.Add(g);
			}
		}
		public long StudentNumber(string studNum)
		{
			try
			{
				if (!Regex.IsMatch(studNum, @"0^[0-9]{10,11}$"))
				{
                    _StudentNo = long.Parse(studNum);

                }
                else
				{
                    throw new ArgumentNullException("Must be 11 digits only");
                }
			}
			catch (ArgumentNullException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Console.WriteLine("Student Number is valid.");
				_StudentNo = long.Parse(studNum);
			}
			return _StudentNo;
		}

		public long ContactNo(string Contact)
		{
            try
            {
                if (!Regex.IsMatch(Contact, @"0^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);

                }
                else
                {
                    throw new ArgumentNullException("Must be 11 digits only");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Console.WriteLine("Student Number is valid.");
                _ContactNo = long.Parse(Contact);
            }
            return _ContactNo;
        }
		

		public string FullName(string LastName, string FirstName, string MiddleInitial)
		{
			try
			{
				if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
				{
					_FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
				}
				else
				{
					throw new ArgumentNullException ("Must be letters only");
				}
			}
			catch (ArgumentNullException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Console.WriteLine("Name is Valid.");
			}
			return _FullName;
		}

		public int Age(string age)
		{
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

		private void btnRegister_Click(object sender, EventArgs e)
		{
			StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
			StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
			StudentInformationClass.SetProgram = cbPrograms.Text;
			StudentInformationClass.SetGender = cbGender.Text;
			StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
			StudentInformationClass.SetAge = Age(txtAge.Text);
			StudentInformationClass.SetBirthDay = datePickerBirthday.Value.ToString("yyyy-MM-dd");

			frmConfirmation frm = new frmConfirmation();
			frm.Show();
		}
	}
	public class StudentInformationClass
	{
		public static long SetStudentNo = 0;
		public static long SetContactNo = 0;
		public static string SetProgram = " ";
		public static string SetGender = " ";
		public static string SetBirthDay = " ";
		public static string SetFullName = " ";
		public static int SetAge = 0;

	}
}


