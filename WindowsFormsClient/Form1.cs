using Messanger;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private static int MessageID = 0;
        private static string UserName;
        private static MessangerClientAPI API = new MessangerClientAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTB.Text;
            string Message = MessageTB.Text;
            if ((UserName.Length > 1) && (UserName.Length > 1))
            {
                Messanger.Message msg = new Messanger.Message(UserName, Message, DateTime.Now);
                API.SendMessage(msg);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var getMessage = new Func<Task>(async () =>
            {
                Messanger.Message msg = await API.GetMessageHTTPAsync(MessageID);
                while (msg != null)
                {
                    MessagesLB.Items.Add(msg);
                    MessageID++;
                    msg = await API.GetMessageHTTPAsync(MessageID);
                }
            });
            getMessage.Invoke();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MessagesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}