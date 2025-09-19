using System.Threading;

namespace BasicThread
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(() => MyThreadClass.Thread1(listBox1));
            Thread ThreadB = new Thread(() => MyThreadClass.Thread1(listBox1));


            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";


            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();
            MessageBox.Show("End of Thread");
        }

        private void frmBasicThread_Load(object sender, EventArgs e)
        {

        }
        class MyThreadClass
        {
            public static void Thread1(ListBox listBox)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Thread thread = Thread.CurrentThread;
                   
                    listBox.Items.Add("Name of Thread: " + thread.Name + " = " + i);
                    Thread.Sleep(1500); 
                }
            }
        }
    }
}


