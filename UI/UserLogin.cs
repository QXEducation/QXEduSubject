using System.Windows.Forms;
using BLLDAL;
namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, System.EventArgs e)
        {
            Ulog.Text = "账号：";
            UPWD.Text = "密码：";
            Login.Text = "登陆";
            Quit.Text = "退出";

        }

        private void Quit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            if (txtUID.Text == "")
            {
                MessageBox.Show("请输入用户名","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtUPWD.Text == "")
            {
                MessageBox.Show("请输入密码","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int iflogin = BLLDAL.UserLogin.ifLogin(txtUID.Text.ToString(), txtUPWD.Text.ToString());
                switch (iflogin)
                {
                    case 0: MessageBox.Show("密码错误！", "error", MessageBoxButtons.OK,MessageBoxIcon.Error); break;
                    case 1:new MainForm(txtUID.Text.ToString()).Show();this.Close();break;
                    case 2:MessageBox.Show("账号不存在！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);break;
                    case 3:MessageBox.Show("数据库不存在，请联系管理员", "Stop", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);break;
                }
            }
        }
    }
}
