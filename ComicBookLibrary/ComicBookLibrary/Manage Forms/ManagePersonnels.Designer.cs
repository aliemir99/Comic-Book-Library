namespace ComicBookLibrary.Manage_Forms
{
    partial class frmManagePersonnels
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
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpPersonnel.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonnel
            // 
            this.grpPersonnel.BackgroundImage = global::ComicBookLibrary.Properties.Resources.comicGirl;
            this.grpPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpPersonnel.Controls.Add(this.dtpBirthDate);
            this.grpPersonnel.Controls.Add(this.txtLName);
            this.grpPersonnel.Controls.Add(this.txtFName);
            this.grpPersonnel.Controls.Add(this.lblBirthDay);
            this.grpPersonnel.Controls.Add(this.lblLName);
            this.grpPersonnel.Controls.Add(this.lblFName);
            this.grpPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grpPersonnel.Name = "grpPersonnel";
            this.grpPersonnel.Size = new System.Drawing.Size(431, 231);
            this.grpPersonnel.TabIndex = 0;
            this.grpPersonnel.TabStop = false;
            this.grpPersonnel.Text = "Personnel Information";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(165, 145);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(165, 88);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 20);
            this.txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(165, 36);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 20);
            this.txtFName.TabIndex = 3;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBirthDay.Location = new System.Drawing.Point(58, 151);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(59, 15);
            this.lblBirthDay.TabIndex = 2;
            this.lblBirthDay.Text = "Birth Date:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLName.Location = new System.Drawing.Point(55, 91);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(63, 15);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFName.Location = new System.Drawing.Point(55, 39);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(62, 15);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // grpControls
            // 
            this.grpControls.BackColor = System.Drawing.Color.Transparent;
            this.grpControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpControls.Controls.Add(this.btnCancel);
            this.grpControls.Controls.Add(this.btnLast);
            this.grpControls.Controls.Add(this.btnAdd);
            this.grpControls.Controls.Add(this.btnDelete);
            this.grpControls.Controls.Add(this.btnFirst);
            this.grpControls.Controls.Add(this.btnSave);
            this.grpControls.Controls.Add(this.btnPrevious);
            this.grpControls.Controls.Add(this.btnNext);
            this.grpControls.ForeColor = System.Drawing.Color.Transparent;
            this.grpControls.Location = new System.Drawing.Point(12, 267);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(431, 171);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::ComicBookLibrary.Properties.Resources.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(305, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 47);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackgroundImage = global::ComicBookLibrary.Properties.Resources.DarkBlue;
            this.btnLast.Location = new System.Drawing.Point(305, 37);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(81, 43);
            this.btnLast.TabIndex = 30;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ComicBookLibrary.Properties.Resources.Green;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(44, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 47);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ComicBookLibrary.Properties.Resources.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(131, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 47);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = global::ComicBookLibrary.Properties.Resources.DarkBlue;
            this.btnFirst.Location = new System.Drawing.Point(44, 37);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(81, 43);
            this.btnFirst.TabIndex = 29;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::ComicBookLibrary.Properties.Resources.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(218, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 47);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = global::ComicBookLibrary.Properties.Resources.LightBlue;
            this.btnPrevious.Location = new System.Drawing.Point(131, 37);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 43);
            this.btnPrevious.TabIndex = 28;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::ComicBookLibrary.Properties.Resources.LightBlue;
            this.btnNext.Location = new System.Drawing.Point(218, 37);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 43);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // frmManagePersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComicBookLibrary.Properties.Resources.backgroundAbout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpPersonnel);
            this.Name = "frmManagePersonnels";
            this.Text = "Manage Personnels";
            this.Load += new System.EventHandler(this.frmManagePersonnels_Load);
            this.grpPersonnel.ResumeLayout(false);
            this.grpPersonnel.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}