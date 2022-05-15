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

namespace Coursework.EDairy
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainWindow : MaterialForm
    {
        private readonly CheckUser _user;
        WorkWithDatabase database = new WorkWithDatabase();
        int selectedRow;

        public MainWindow(CheckUser user)
        {
            _user = user;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("IDStudent", "ID");
            dataGridView1.Columns.Add("StudentGroup", "Group");
            dataGridView1.Columns.Add("FullName", "Name");
            dataGridView1.Columns.Add("Math", "Mathematics");
            dataGridView1.Columns.Add("Eng", "English");
            dataGridView1.Columns.Add("Inf", "Informatics");
            dataGridView1.Columns.Add("GPA", "GPA");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView3.Columns.Add("IDStudent", "ID");
            dataGridView3.Columns.Add("StudentGroup", "Group");
            dataGridView3.Columns.Add("FullName", "Name");
            dataGridView3.Columns.Add("Math", "Mathematics");
            dataGridView3.Columns.Add("Eng", "English");
            dataGridView3.Columns.Add("Inf", "Informatics");
            dataGridView3.Columns.Add("GPA", "GPA");
            dataGridView3.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            materialTextBoxID.Text = "";
            materialTextBoxGroup.Text = "";
            materialTextBoxName.Text = "";
            materialTextBoxMathematics.Text = "";
            materialTextBoxEnglish.Text = "";
            materialTextBoxInformatics.Text = "";
            materialTextBoxGPA.Text = "";
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetValue(3), record.GetValue(4), record.GetValue(5), record.GetValue(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string querystring = $"select * from MainGrid";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchString = $"select * from MainGrid where concat(IDStudent, StudentGroup, FullName, Math, Eng, Inf, GPA) like '%" + materialTextBoxSearch.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgv, read);
            }
            read.Close();
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;

        }

        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from MainGrid where IDStudent = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var group = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var math = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var eng = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var inf = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var changeQuery = $"update MainGrid set StudentGroup = '{group}', FullName = '{name}', Math = '{math}', Eng = '{eng}', Inf = '{inf}' where IDStudent = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void materialTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void materialButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = materialTextBoxID.Text;
            var group = materialTextBoxGroup.Text;
            var name = materialTextBoxName.Text;
            double math;
            double eng;
            double inf;


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (double.TryParse(materialTextBoxMathematics.Text, out math)
                    && double.TryParse(materialTextBoxEnglish.Text, out eng)
                    && double.TryParse(materialTextBoxInformatics.Text, out inf))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, group, name, math, eng, inf, ((math+eng+inf)/3));
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;

                }
                else
                {
                    MaterialMessageBox.Show("Estimates should have a numeric format!", "Error!");
                }
            }
        }

        private void materialButtonEdit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void pictureBoxErase_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            RegistrationAndAuthentication frm = new RegistrationAndAuthentication();
            frm.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            materialTextBoxStatus.Hint = $"{_user.Status}";
            materialTextBoxStatus.Text = $"{_user.Login}";
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid(dataGridView3);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                materialTextBoxID.Text = row.Cells[0].Value.ToString();
                materialTextBoxGroup.Text = row.Cells[1].Value.ToString();
                materialTextBoxName.Text = row.Cells[2].Value.ToString();
                materialTextBoxMathematics.Text = row.Cells[3].Value.ToString();
                materialTextBoxEnglish.Text = row.Cells[4].Value.ToString();
                materialTextBoxInformatics.Text = row.Cells[5].Value.ToString();
                materialTextBoxGPA.Text = row.Cells[6].Value.ToString();
            }
        }

        private void IsAdmin()
        {
            materialButtonNew.Enabled = _user.IsAdmin;
            materialButtonDelete.Enabled = _user.IsAdmin;
            materialButtonEdit.Enabled = _user.IsAdmin;
            materialButtonSave.Enabled = _user.IsAdmin;
            if (!_user.IsAdmin)
            {
                materialTabControl1.Controls.Remove(tabPageManagement);
            }
            else
            {
                CreateColumns_Management();
                RefreshDataGrid_Management();
            }
        }







        private void CreateColumns_Management()
        {
            dataGridView2.Columns.Add("IDUser", "ID");
            dataGridView2.Columns.Add("LoginUser", "Login");
            dataGridView2.Columns.Add("PasswordUser", "Password");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "IsAdmin";
            dataGridView2.Columns.Add(checkColumn);
        }

        private void ReadSingleRow_Management(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3));
        }

        private void RefreshDataGrid_Management()
        {
            dataGridView2.Rows.Clear();
            string queryString = $"select * from Register";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow_Management(dataGridView2, reader);
            }
            reader.Close();
            database.closeConnection();
        }

        private void materialButtonSaveManagement_Click(object sender, EventArgs e)
        {
            database.openConnection();
            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                var isadmin = dataGridView2.Rows[index].Cells[3].Value.ToString();
                var changeQuery = $"update Register set IsAdmin = '{isadmin}' where IDUser = '{id}'";
                var command = new SqlCommand(changeQuery, database.getConnection());
                command.ExecuteNonQuery();
            }
            database.closeConnection();
            RefreshDataGrid_Management();
        }

        private void materialButtonDelete_Management_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"delete from Register where IDUser = '{id}'";
            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
            RefreshDataGrid_Management();
        }

        private void SearchManagement(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchString = $"select * from Register where concat(IDUser, LoginUser) like '%" + materialTextBoxSearchManagement.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow_Management(dgv, read);
            }
            read.Close();
        }

        private void materialTextBoxSearchManagement_TextChanged(object sender, EventArgs e)
        {
            SearchManagement(dataGridView2);
        }

        private void materialButtonNew_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.Show();
        }

        private void materialTextBoxFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            string searchString = $"select * from MainGrid where GPA > '{materialTextBoxFind.Text}'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dataGridView3, read);
            }
            read.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
