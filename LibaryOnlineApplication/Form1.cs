

using LibaryOnlineApplication.Logging;
using LibaryOnlineApplication.Models;
using LibaryOnlineApplication.Queries;
using System.Data;
using System.Data.SqlClient;

namespace LibaryOnlineApplication
{
    public partial class FrmLogin : Form
    {
        SqlConnection conn;
        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            conn = Database.getConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                LoginUser loginUser = new LoginUser();
                LoginModel dataUser = loginUser.checkLogin(username, password);
                if (string.IsNullOrEmpty(dataUser.id) || string.IsNullOrEmpty(dataUser.email))
                {
                    MessageBox.Show("Account invalid");
                }
                else
                {
                    MessageBox.Show("Login success");
                    // luu thong tin cua nguoi dung de tien su dung sau nay
                    LoginInfo.UserId = dataUser.id;
                    LoginInfo.RoleId = dataUser.roleId;
                    LoginInfo.EmailUser = dataUser.email;
                    LoginInfo.FullNameUser = dataUser.fullName;

                    HomeForm home = new HomeForm();
                    home.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}