using LibaryOnlineApplication.Queries;
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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // hien thi giao dien list view
            listViewCategories.View = View.Details;
            listViewCategories.GridLines = true;
            listViewCategories.FullRowSelect = true;

            // tao cot hien thi
            listViewCategories.Columns.Add("ID", 50);
            listViewCategories.Columns.Add("Name", 150);
            listViewCategories.Columns.Add("Description", 250);
            listViewCategories.Columns.Add("Status", 50);
            listViewCategories.Columns.Add("Created At", 150);
            listViewCategories.Columns.Add("Updated At", 150);
            CategoriesQuey queryData = new CategoriesQuey();
            queryData.GetAllDataCategories(listViewCategories);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameCategory = txtName.Text.Trim();
            string descriptionCategory = txtDescription.Text.Trim();
            string statusCategory = cboStatus.Text.Trim();
            if (string.IsNullOrEmpty(nameCategory))
            {
                MessageBox.Show("Name is not empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(statusCategory))
            {
                MessageBox.Show("Status is not empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // instert du lieu vao database
            CategoriesQuey query = new CategoriesQuey();
            int IdCate = query.InsertItemCategory(nameCategory, descriptionCategory, statusCategory);

            // do du lieu vao listView
            ListViewItem newItems = new ListViewItem(IdCate.ToString());
            // 100: test insert id
            newItems.SubItems.Add(nameCategory);
            newItems.SubItems.Add(descriptionCategory);
            newItems.SubItems.Add(statusCategory);
            newItems.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            listViewCategories.Items.Add(newItems);

            // xoa du lieu da nhap
            txtName.Clear();
            txtDescription.Clear();
            cboStatus.SelectedItem = null;

        }
    }
}
