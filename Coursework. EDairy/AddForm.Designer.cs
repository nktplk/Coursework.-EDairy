namespace Coursework.EDairy
{
    partial class AddForm
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxErase = new System.Windows.Forms.PictureBox();
            this.materialTextBoxInformatics = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxEnglish = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxMathematics = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxGroup = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBoxErase);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(8, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(783, 67);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(20, 23);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "New Record";
            // 
            // pictureBoxErase
            // 
            this.pictureBoxErase.Image = global::Coursework.EDairy.Properties.Resources.eraser;
            this.pictureBoxErase.Location = new System.Drawing.Point(724, 9);
            this.pictureBoxErase.Name = "pictureBoxErase";
            this.pictureBoxErase.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxErase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErase.TabIndex = 10;
            this.pictureBoxErase.TabStop = false;
            this.pictureBoxErase.Click += new System.EventHandler(this.pictureBoxErase_Click);
            // 
            // materialTextBoxInformatics
            // 
            this.materialTextBoxInformatics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxInformatics.Depth = 0;
            this.materialTextBoxInformatics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxInformatics.Hint = "Informatics";
            this.materialTextBoxInformatics.Location = new System.Drawing.Point(23, 250);
            this.materialTextBoxInformatics.MaxLength = 50;
            this.materialTextBoxInformatics.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxInformatics.Multiline = false;
            this.materialTextBoxInformatics.Name = "materialTextBoxInformatics";
            this.materialTextBoxInformatics.Size = new System.Drawing.Size(512, 50);
            this.materialTextBoxInformatics.TabIndex = 10;
            this.materialTextBoxInformatics.Text = "";
            // 
            // materialTextBoxEnglish
            // 
            this.materialTextBoxEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxEnglish.Depth = 0;
            this.materialTextBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxEnglish.Hint = "English";
            this.materialTextBoxEnglish.Location = new System.Drawing.Point(23, 194);
            this.materialTextBoxEnglish.MaxLength = 50;
            this.materialTextBoxEnglish.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxEnglish.Multiline = false;
            this.materialTextBoxEnglish.Name = "materialTextBoxEnglish";
            this.materialTextBoxEnglish.Size = new System.Drawing.Size(513, 50);
            this.materialTextBoxEnglish.TabIndex = 9;
            this.materialTextBoxEnglish.Text = "";
            // 
            // materialTextBoxMathematics
            // 
            this.materialTextBoxMathematics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxMathematics.Depth = 0;
            this.materialTextBoxMathematics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxMathematics.Hint = "Mathematics";
            this.materialTextBoxMathematics.Location = new System.Drawing.Point(23, 138);
            this.materialTextBoxMathematics.MaxLength = 50;
            this.materialTextBoxMathematics.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxMathematics.Multiline = false;
            this.materialTextBoxMathematics.Name = "materialTextBoxMathematics";
            this.materialTextBoxMathematics.Size = new System.Drawing.Size(513, 50);
            this.materialTextBoxMathematics.TabIndex = 8;
            this.materialTextBoxMathematics.Text = "";
            // 
            // materialTextBoxName
            // 
            this.materialTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxName.Depth = 0;
            this.materialTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxName.Hint = "Name";
            this.materialTextBoxName.Location = new System.Drawing.Point(23, 81);
            this.materialTextBoxName.MaxLength = 50;
            this.materialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxName.Multiline = false;
            this.materialTextBoxName.Name = "materialTextBoxName";
            this.materialTextBoxName.Size = new System.Drawing.Size(512, 50);
            this.materialTextBoxName.TabIndex = 7;
            this.materialTextBoxName.Text = "";
            // 
            // materialTextBoxGroup
            // 
            this.materialTextBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxGroup.Depth = 0;
            this.materialTextBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxGroup.Hint = "Group";
            this.materialTextBoxGroup.Location = new System.Drawing.Point(23, 25);
            this.materialTextBoxGroup.MaxLength = 50;
            this.materialTextBoxGroup.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxGroup.Multiline = false;
            this.materialTextBoxGroup.Name = "materialTextBoxGroup";
            this.materialTextBoxGroup.Size = new System.Drawing.Size(513, 50);
            this.materialTextBoxGroup.TabIndex = 6;
            this.materialTextBoxGroup.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialTextBoxInformatics);
            this.materialCard2.Controls.Add(this.materialTextBoxGroup);
            this.materialCard2.Controls.Add(this.materialTextBoxEnglish);
            this.materialCard2.Controls.Add(this.materialTextBoxName);
            this.materialCard2.Controls.Add(this.materialTextBoxMathematics);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(8, 148);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(560, 321);
            this.materialCard2.TabIndex = 11;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialButtonSave);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(577, 148);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(214, 321);
            this.materialCard3.TabIndex = 12;
            // 
            // materialButtonSave
            // 
            this.materialButtonSave.AutoSize = false;
            this.materialButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSave.Depth = 0;
            this.materialButtonSave.DrawShadows = true;
            this.materialButtonSave.HighEmphasis = true;
            this.materialButtonSave.Icon = null;
            this.materialButtonSave.Location = new System.Drawing.Point(30, 143);
            this.materialButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSave.Name = "materialButtonSave";
            this.materialButtonSave.Size = new System.Drawing.Size(158, 36);
            this.materialButtonSave.TabIndex = 0;
            this.materialButtonSave.Text = "Save";
            this.materialButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSave.UseAccentColor = false;
            this.materialButtonSave.UseVisualStyleBackColor = true;
            this.materialButtonSave.Click += new System.EventHandler(this.materialButtonSave_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "AddForm";
            this.Text = "EDairy";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxErase;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxInformatics;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxEnglish;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMathematics;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxGroup;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton materialButtonSave;
    }
}