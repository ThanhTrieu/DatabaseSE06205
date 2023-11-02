using LibaryOnlineApplication.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryOnlineApplication
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            labUsername.Text = LoginInfo.FullNameUser;
        }

        private void labUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoriesForm category = new CategoriesForm();
            category.Show();
            this.Hide();
        }
    }
}
