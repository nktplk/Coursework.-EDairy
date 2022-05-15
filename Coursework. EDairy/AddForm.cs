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
    public partial class AddForm : MaterialForm
    {
        WorkWithDatabase database = new WorkWithDatabase();
        
        public AddForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            database.openConnection();



            var group = materialTextBoxGroup.Text;
            var name = materialTextBoxName.Text;
            double math;
            double eng;
            double inf;

            if (double.TryParse(materialTextBoxMathematics.Text, out math)
                    && double.TryParse(materialTextBoxEnglish.Text, out eng)
                    && double.TryParse(materialTextBoxInformatics.Text, out inf))
            {
                var addQuery = $"insert into MainGrid (StudentGroup, FullName, Math, Eng, Inf) values ('{group}', '{name}', '{math}', '{eng}', '{inf}')";
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MaterialMessageBox.Show("The record was created successfully!", "Successfully!");

            }
            else
            {
                MaterialMessageBox.Show("Estimates should have a numeric format!", "Error!");
            }

            database.closeConnection();
        }

        private void pictureBoxErase_Click(object sender, EventArgs e)
        {
            materialTextBoxGroup.Text = "";
            materialTextBoxName.Text = "";
            materialTextBoxMathematics.Text = "";
            materialTextBoxEnglish.Text = "";
            materialTextBoxInformatics.Text = "";
        }
    }
}
