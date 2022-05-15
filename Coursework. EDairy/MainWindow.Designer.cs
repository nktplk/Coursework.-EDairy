﻿namespace Coursework.EDairy
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageGrid = new System.Windows.Forms.TabPage();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxStatus = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonNew = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxGPA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxInformatics = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxEnglish = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxMathematics = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxGroup = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxID = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageManagement = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonDelete_Management = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSaveManagement = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxSearchManagement = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxErase = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPageGrid.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.tabPageManagement.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageGrid);
            this.materialTabControl1.Controls.Add(this.tabPageManagement);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(900, 985);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.Controls.Add(this.materialCard8);
            this.tabPageGrid.Controls.Add(this.materialCard4);
            this.tabPageGrid.Controls.Add(this.materialCard3);
            this.tabPageGrid.Controls.Add(this.materialCard2);
            this.tabPageGrid.Controls.Add(this.materialCard1);
            this.tabPageGrid.ImageKey = "grid.png";
            this.tabPageGrid.Location = new System.Drawing.Point(4, 39);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrid.Size = new System.Drawing.Size(892, 942);
            this.tabPageGrid.TabIndex = 0;
            this.tabPageGrid.Text = "Grid";
            this.tabPageGrid.UseVisualStyleBackColor = true;
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.materialTextBoxStatus);
            this.materialCard8.Controls.Add(this.pictureBox4);
            this.materialCard8.Controls.Add(this.materialLabel5);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(574, 746);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(251, 158);
            this.materialCard8.TabIndex = 4;
            // 
            // materialTextBoxStatus
            // 
            this.materialTextBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxStatus.Depth = 0;
            this.materialTextBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxStatus.Hint = "Status";
            this.materialTextBoxStatus.Location = new System.Drawing.Point(17, 91);
            this.materialTextBoxStatus.MaxLength = 50;
            this.materialTextBoxStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxStatus.Multiline = false;
            this.materialTextBoxStatus.Name = "materialTextBoxStatus";
            this.materialTextBoxStatus.Size = new System.Drawing.Size(220, 50);
            this.materialTextBoxStatus.TabIndex = 7;
            this.materialTextBoxStatus.Text = "";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(81, 31);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(47, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Status";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialButtonSave);
            this.materialCard4.Controls.Add(this.materialButtonEdit);
            this.materialCard4.Controls.Add(this.materialButtonDelete);
            this.materialCard4.Controls.Add(this.materialButtonNew);
            this.materialCard4.Controls.Add(this.pictureBox1);
            this.materialCard4.Controls.Add(this.materialLabel1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(574, 416);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(252, 320);
            this.materialCard4.TabIndex = 3;
            // 
            // materialButtonSave
            // 
            this.materialButtonSave.AutoSize = false;
            this.materialButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSave.Depth = 0;
            this.materialButtonSave.DrawShadows = true;
            this.materialButtonSave.HighEmphasis = true;
            this.materialButtonSave.Icon = null;
            this.materialButtonSave.Location = new System.Drawing.Point(51, 260);
            this.materialButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSave.Name = "materialButtonSave";
            this.materialButtonSave.Size = new System.Drawing.Size(158, 36);
            this.materialButtonSave.TabIndex = 7;
            this.materialButtonSave.Text = "Save Changes";
            this.materialButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSave.UseAccentColor = false;
            this.materialButtonSave.UseVisualStyleBackColor = true;
            this.materialButtonSave.Click += new System.EventHandler(this.materialButtonSave_Click);
            // 
            // materialButtonEdit
            // 
            this.materialButtonEdit.AutoSize = false;
            this.materialButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonEdit.Depth = 0;
            this.materialButtonEdit.DrawShadows = true;
            this.materialButtonEdit.HighEmphasis = true;
            this.materialButtonEdit.Icon = null;
            this.materialButtonEdit.Location = new System.Drawing.Point(51, 203);
            this.materialButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonEdit.Name = "materialButtonEdit";
            this.materialButtonEdit.Size = new System.Drawing.Size(158, 36);
            this.materialButtonEdit.TabIndex = 6;
            this.materialButtonEdit.Text = "Edit Record";
            this.materialButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonEdit.UseAccentColor = false;
            this.materialButtonEdit.UseVisualStyleBackColor = true;
            this.materialButtonEdit.Click += new System.EventHandler(this.materialButtonEdit_Click);
            // 
            // materialButtonDelete
            // 
            this.materialButtonDelete.AutoSize = false;
            this.materialButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete.Depth = 0;
            this.materialButtonDelete.DrawShadows = true;
            this.materialButtonDelete.HighEmphasis = true;
            this.materialButtonDelete.Icon = null;
            this.materialButtonDelete.Location = new System.Drawing.Point(51, 147);
            this.materialButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete.Name = "materialButtonDelete";
            this.materialButtonDelete.Size = new System.Drawing.Size(158, 36);
            this.materialButtonDelete.TabIndex = 5;
            this.materialButtonDelete.Text = "Delete Record";
            this.materialButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete.UseAccentColor = false;
            this.materialButtonDelete.UseVisualStyleBackColor = true;
            this.materialButtonDelete.Click += new System.EventHandler(this.materialButtonDelete_Click);
            // 
            // materialButtonNew
            // 
            this.materialButtonNew.AutoSize = false;
            this.materialButtonNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonNew.Depth = 0;
            this.materialButtonNew.DrawShadows = true;
            this.materialButtonNew.HighEmphasis = true;
            this.materialButtonNew.Icon = null;
            this.materialButtonNew.Location = new System.Drawing.Point(51, 90);
            this.materialButtonNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonNew.Name = "materialButtonNew";
            this.materialButtonNew.Size = new System.Drawing.Size(158, 36);
            this.materialButtonNew.TabIndex = 1;
            this.materialButtonNew.Text = "New Record";
            this.materialButtonNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonNew.UseAccentColor = false;
            this.materialButtonNew.UseVisualStyleBackColor = true;
            this.materialButtonNew.Click += new System.EventHandler(this.materialButtonNew_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(81, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(156, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Records Management";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.pictureBox2);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.materialTextBoxGPA);
            this.materialCard3.Controls.Add(this.materialTextBoxInformatics);
            this.materialCard3.Controls.Add(this.materialTextBoxEnglish);
            this.materialCard3.Controls.Add(this.materialTextBoxMathematics);
            this.materialCard3.Controls.Add(this.materialTextBoxName);
            this.materialCard3.Controls.Add(this.materialTextBoxGroup);
            this.materialCard3.Controls.Add(this.materialTextBoxID);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 415);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(546, 489);
            this.materialCard3.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(80, 31);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Record";
            // 
            // materialTextBoxGPA
            // 
            this.materialTextBoxGPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxGPA.Depth = 0;
            this.materialTextBoxGPA.Enabled = false;
            this.materialTextBoxGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxGPA.Hint = "GPA";
            this.materialTextBoxGPA.Location = new System.Drawing.Point(16, 425);
            this.materialTextBoxGPA.MaxLength = 50;
            this.materialTextBoxGPA.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxGPA.Multiline = false;
            this.materialTextBoxGPA.Name = "materialTextBoxGPA";
            this.materialTextBoxGPA.Size = new System.Drawing.Size(513, 50);
            this.materialTextBoxGPA.TabIndex = 6;
            this.materialTextBoxGPA.Text = "";
            // 
            // materialTextBoxInformatics
            // 
            this.materialTextBoxInformatics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxInformatics.Depth = 0;
            this.materialTextBoxInformatics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxInformatics.Hint = "Informatics";
            this.materialTextBoxInformatics.Location = new System.Drawing.Point(16, 368);
            this.materialTextBoxInformatics.MaxLength = 50;
            this.materialTextBoxInformatics.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxInformatics.Multiline = false;
            this.materialTextBoxInformatics.Name = "materialTextBoxInformatics";
            this.materialTextBoxInformatics.Size = new System.Drawing.Size(512, 50);
            this.materialTextBoxInformatics.TabIndex = 5;
            this.materialTextBoxInformatics.Text = "";
            // 
            // materialTextBoxEnglish
            // 
            this.materialTextBoxEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxEnglish.Depth = 0;
            this.materialTextBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxEnglish.Hint = "English";
            this.materialTextBoxEnglish.Location = new System.Drawing.Point(16, 312);
            this.materialTextBoxEnglish.MaxLength = 50;
            this.materialTextBoxEnglish.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxEnglish.Multiline = false;
            this.materialTextBoxEnglish.Name = "materialTextBoxEnglish";
            this.materialTextBoxEnglish.Size = new System.Drawing.Size(513, 50);
            this.materialTextBoxEnglish.TabIndex = 4;
            this.materialTextBoxEnglish.Text = "";
            // 
            // materialTextBoxMathematics
            // 
            this.materialTextBoxMathematics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxMathematics.Depth = 0;
            this.materialTextBoxMathematics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxMathematics.Hint = "Mathematics";
            this.materialTextBoxMathematics.Location = new System.Drawing.Point(16, 256);
            this.materialTextBoxMathematics.MaxLength = 50;
            this.materialTextBoxMathematics.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxMathematics.Multiline = false;
            this.materialTextBoxMathematics.Name = "materialTextBoxMathematics";
            this.materialTextBoxMathematics.Size = new System.Drawing.Size(513, 50);
            this.materialTextBoxMathematics.TabIndex = 3;
            this.materialTextBoxMathematics.Text = "";
            // 
            // materialTextBoxName
            // 
            this.materialTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxName.Depth = 0;
            this.materialTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxName.Hint = "Name";
            this.materialTextBoxName.Location = new System.Drawing.Point(16, 199);
            this.materialTextBoxName.MaxLength = 50;
            this.materialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxName.Multiline = false;
            this.materialTextBoxName.Name = "materialTextBoxName";
            this.materialTextBoxName.Size = new System.Drawing.Size(512, 50);
            this.materialTextBoxName.TabIndex = 2;
            this.materialTextBoxName.Text = "";
            // 
            // materialTextBoxGroup
            // 
            this.materialTextBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxGroup.Depth = 0;
            this.materialTextBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxGroup.Hint = "Group";
            this.materialTextBoxGroup.Location = new System.Drawing.Point(16, 143);
            this.materialTextBoxGroup.MaxLength = 50;
            this.materialTextBoxGroup.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxGroup.Multiline = false;
            this.materialTextBoxGroup.Name = "materialTextBoxGroup";
            this.materialTextBoxGroup.Size = new System.Drawing.Size(513, 50);
            this.materialTextBoxGroup.TabIndex = 1;
            this.materialTextBoxGroup.Text = "";
            // 
            // materialTextBoxID
            // 
            this.materialTextBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxID.Depth = 0;
            this.materialTextBoxID.Enabled = false;
            this.materialTextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxID.Hint = "ID";
            this.materialTextBoxID.Location = new System.Drawing.Point(16, 86);
            this.materialTextBoxID.MaxLength = 50;
            this.materialTextBoxID.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxID.Multiline = false;
            this.materialTextBoxID.Name = "materialTextBoxID";
            this.materialTextBoxID.Size = new System.Drawing.Size(512, 50);
            this.materialTextBoxID.TabIndex = 0;
            this.materialTextBoxID.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dataGridView12);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 90);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(811, 311);
            this.materialCard2.TabIndex = 1;
            // 
            // dataGridView12
            // 
            this.dataGridView12.AllowUserToAddRows = false;
            this.dataGridView12.AllowUserToDeleteRows = false;
            this.dataGridView12.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView12.Location = new System.Drawing.Point(16, 17);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.ReadOnly = true;
            this.dataGridView12.Size = new System.Drawing.Size(781, 277);
            this.dataGridView12.TabIndex = 3;
            this.dataGridView12.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBoxErase);
            this.materialCard1.Controls.Add(this.pictureBoxRefresh);
            this.materialCard1.Controls.Add(this.pictureBox3);
            this.materialCard1.Controls.Add(this.materialTextBoxSearch);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(811, 67);
            this.materialCard1.TabIndex = 0;
            // 
            // materialTextBoxSearch
            // 
            this.materialTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxSearch.Depth = 0;
            this.materialTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxSearch.Hint = "Search";
            this.materialTextBoxSearch.Location = new System.Drawing.Point(577, 9);
            this.materialTextBoxSearch.MaxLength = 50;
            this.materialTextBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSearch.Multiline = false;
            this.materialTextBoxSearch.Name = "materialTextBoxSearch";
            this.materialTextBoxSearch.Size = new System.Drawing.Size(220, 50);
            this.materialTextBoxSearch.TabIndex = 2;
            this.materialTextBoxSearch.Text = "";
            this.materialTextBoxSearch.TextChanged += new System.EventHandler(this.materialTextBoxSearch_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(20, 23);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(30, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Grid";
            // 
            // tabPageManagement
            // 
            this.tabPageManagement.Controls.Add(this.materialCard6);
            this.tabPageManagement.Controls.Add(this.materialCard5);
            this.tabPageManagement.Controls.Add(this.materialCard7);
            this.tabPageManagement.ImageKey = "settings.png";
            this.tabPageManagement.Location = new System.Drawing.Point(4, 39);
            this.tabPageManagement.Name = "tabPageManagement";
            this.tabPageManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagement.Size = new System.Drawing.Size(892, 942);
            this.tabPageManagement.TabIndex = 1;
            this.tabPageManagement.Text = "Management";
            this.tabPageManagement.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialButtonDelete_Management);
            this.materialCard6.Controls.Add(this.materialButtonSaveManagement);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 708);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(811, 196);
            this.materialCard6.TabIndex = 5;
            // 
            // materialButtonDelete_Management
            // 
            this.materialButtonDelete_Management.AutoSize = false;
            this.materialButtonDelete_Management.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete_Management.Depth = 0;
            this.materialButtonDelete_Management.DrawShadows = true;
            this.materialButtonDelete_Management.HighEmphasis = true;
            this.materialButtonDelete_Management.Icon = null;
            this.materialButtonDelete_Management.Location = new System.Drawing.Point(413, 79);
            this.materialButtonDelete_Management.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDelete_Management.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete_Management.Name = "materialButtonDelete_Management";
            this.materialButtonDelete_Management.Size = new System.Drawing.Size(158, 36);
            this.materialButtonDelete_Management.TabIndex = 4;
            this.materialButtonDelete_Management.Text = "Delete";
            this.materialButtonDelete_Management.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete_Management.UseAccentColor = false;
            this.materialButtonDelete_Management.UseVisualStyleBackColor = true;
            this.materialButtonDelete_Management.Click += new System.EventHandler(this.materialButtonDelete_Management_Click);
            // 
            // materialButtonSaveManagement
            // 
            this.materialButtonSaveManagement.AutoSize = false;
            this.materialButtonSaveManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSaveManagement.Depth = 0;
            this.materialButtonSaveManagement.DrawShadows = true;
            this.materialButtonSaveManagement.HighEmphasis = true;
            this.materialButtonSaveManagement.Icon = null;
            this.materialButtonSaveManagement.Location = new System.Drawing.Point(247, 79);
            this.materialButtonSaveManagement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSaveManagement.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSaveManagement.Name = "materialButtonSaveManagement";
            this.materialButtonSaveManagement.Size = new System.Drawing.Size(158, 36);
            this.materialButtonSaveManagement.TabIndex = 3;
            this.materialButtonSaveManagement.Text = "Save";
            this.materialButtonSaveManagement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSaveManagement.UseAccentColor = false;
            this.materialButtonSaveManagement.UseVisualStyleBackColor = true;
            this.materialButtonSaveManagement.Click += new System.EventHandler(this.materialButtonSaveManagement_Click);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.pictureBox6);
            this.materialCard5.Controls.Add(this.materialTextBoxSearchManagement);
            this.materialCard5.Controls.Add(this.materialLabel4);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(811, 67);
            this.materialCard5.TabIndex = 1;
            // 
            // materialTextBoxSearchManagement
            // 
            this.materialTextBoxSearchManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxSearchManagement.Depth = 0;
            this.materialTextBoxSearchManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxSearchManagement.Hint = "Search";
            this.materialTextBoxSearchManagement.Location = new System.Drawing.Point(577, 9);
            this.materialTextBoxSearchManagement.MaxLength = 50;
            this.materialTextBoxSearchManagement.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSearchManagement.Multiline = false;
            this.materialTextBoxSearchManagement.Name = "materialTextBoxSearchManagement";
            this.materialTextBoxSearchManagement.Size = new System.Drawing.Size(220, 50);
            this.materialTextBoxSearchManagement.TabIndex = 2;
            this.materialTextBoxSearchManagement.Text = "";
            this.materialTextBoxSearchManagement.TextChanged += new System.EventHandler(this.materialTextBoxSearchManagement_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(20, 23);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(157, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Account Management";
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.dataGridView2);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(14, 90);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(811, 606);
            this.materialCard7.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(781, 572);
            this.dataGridView2.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "grid.png");
            this.imageList1.Images.SetKeyName(1, "settings.png");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Coursework.EDairy.Properties.Resources.growth;
            this.pictureBox4.Location = new System.Drawing.Point(17, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.EDairy.Properties.Resources.notes;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Coursework.EDairy.Properties.Resources.notebook;
            this.pictureBox2.Location = new System.Drawing.Point(16, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxErase
            // 
            this.pictureBoxErase.Image = global::Coursework.EDairy.Properties.Resources.eraser;
            this.pictureBoxErase.Location = new System.Drawing.Point(332, 9);
            this.pictureBoxErase.Name = "pictureBoxErase";
            this.pictureBoxErase.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxErase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErase.TabIndex = 10;
            this.pictureBoxErase.TabStop = false;
            this.pictureBoxErase.Click += new System.EventHandler(this.pictureBoxErase_Click);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Image = global::Coursework.EDairy.Properties.Resources.refresh;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(399, 9);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefresh.TabIndex = 9;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Coursework.EDairy.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(521, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Coursework.EDairy.Properties.Resources.search;
            this.pictureBox6.Location = new System.Drawing.Point(521, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 985);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainWindow";
            this.Text = "EDairy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageGrid.ResumeLayout(false);
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPageManagement.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageManagement;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSearchManagement;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveManagement;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete_Management;
        private System.Windows.Forms.TabPage tabPageGrid;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxStatus;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton materialButtonSave;
        private MaterialSkin.Controls.MaterialButton materialButtonEdit;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete;
        private MaterialSkin.Controls.MaterialButton materialButtonNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxGPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxInformatics;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxEnglish;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMathematics;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxGroup;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxID;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView dataGridView12;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBoxErase;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}