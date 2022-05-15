using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.EDairy;

namespace Coursework.EDairy
{
    public partial class RegistrationAndAuthentication : MaterialForm
    {
        WorkWithDatabase database = new WorkWithDatabase();

        public RegistrationAndAuthentication()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationAndAuthentication_Load(object sender, EventArgs e)
        {
            //Вкладка по умолчанию
            materialTabControl1.SelectedTab = tabPageAuthentication;

            //TextBox в качестве формы для пароля
            materialTextBoxPassword_Authentication.Password = true;
            materialTextBoxPassword_Registration.Password = true;

            //Убрать картинки с формы
            pictureBoxHidePassword_Authentication.Visible = false;
            pictureBoxHidePassword_Registration.Visible = false;

            //Ограничение по вводу символов
            materialTextBoxLogin_Authentication.MaxLength = 50;
            materialTextBoxPassword_Authentication.MaxLength = 50;
            materialTextBoxLogin_Registration.MaxLength = 50;
            materialTextBoxPassword_Registration.MaxLength = 50;
        }

        private void materialButtonLogin_Authentication_Click(object sender, EventArgs e)
        {
            var loginUser = materialTextBoxLogin_Authentication.Text;
            var passUser = EncryptionMD5.hashPassword(materialTextBoxPassword_Authentication.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select IDUser, LoginUser, PasswordUser, IsAdmin from Register where LoginUser = '{loginUser}' and PasswordUser = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new CheckUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MaterialMessageBox.Show("You have successfully logged in!", "Successfully!");
                MainWindow frm1 = new MainWindow(user);
                this.Hide();
                frm1.ShowDialog();
            }
            else
            {
                MaterialMessageBox.Show("There is no such account!", "The account does not exist!");
            }
        }

        private void pictureBoxHidePassword_Authentication_Click(object sender, EventArgs e)
        {
            materialTextBoxPassword_Authentication.Password = true;
            pictureBoxHidePassword_Authentication.Visible = false;
            pictureBoxShowPassword_Authentication.Visible = true;
        }

        private void pictureBoxShowPassword_Authentication_Click(object sender, EventArgs e)
        {
            materialTextBoxPassword_Authentication.Password = false;
            pictureBoxHidePassword_Authentication.Visible = true;
            pictureBoxShowPassword_Authentication.Visible = false;
        }

        private void materialTextBoxPassword_Authentication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialButtonLogin_Authentication_Click(sender, e);
            }
        }

        private Boolean CheckUser()
        {
            var loginUser = materialTextBoxLogin_Registration.Text;
            var passUser = EncryptionMD5.hashPassword(materialTextBoxPassword_Registration.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select IDUser, LoginUser, PasswordUser, IsAdmin from Register where LoginUser = '{loginUser}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MaterialMessageBox.Show("The user already exists!", "Sorry!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void materialButtonCreate_Registration_Click(object sender, EventArgs e)
        {
            var login = materialTextBoxLogin_Registration.Text;
            var password = EncryptionMD5.hashPassword(materialTextBoxPassword_Registration.Text);

            if(CheckUser())
            {
                return;
            }

            string querystring = $"insert into register(LoginUser, PasswordUser, IsAdmin) values('{login}', '{password}', 0)";


            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MaterialMessageBox.Show("Account successfully created!", "Success!");
                materialTabControl1.SelectedTab = tabPageAuthentication;
            }
            else
            {
                MaterialMessageBox.Show("Account not created!", "Sorry!");
            }
            database.closeConnection();
        }

        private void materialTextBoxPassword_Registration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialButtonCreate_Registration_Click(sender, e);
            }
        }

        private void pictureBoxShowPassword_Registration_Click(object sender, EventArgs e)
        {
            materialTextBoxPassword_Registration.Password = false;
            pictureBoxHidePassword_Registration.Visible = true;
            pictureBoxShowPassword_Registration.Visible = false;
        }

        private void pictureBoxHidePassword_Registration_Click(object sender, EventArgs e)
        {
            materialTextBoxPassword_Registration.Password = true;
            pictureBoxHidePassword_Registration.Visible = false;
            pictureBoxShowPassword_Registration.Visible = true;
        }

        private void RegistrationAndAuthentication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
