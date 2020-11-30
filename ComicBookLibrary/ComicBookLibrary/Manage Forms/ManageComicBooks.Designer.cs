namespace ComicBookLibrary.Manage_Forms
{
    partial class frmManageComicBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageComicBooks));
            this.grpComicBook = new System.Windows.Forms.GroupBox();
            this.cmbRatings = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCollaborator = new System.Windows.Forms.GroupBox();
            this.cmbDesigner = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.lblDesigner = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.grpPublisher = new System.Windows.Forms.GroupBox();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpComicBook.SuspendLayout();
            this.grpCollaborator.SuspendLayout();
            this.grpPublisher.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpComicBook
            // 
            this.grpComicBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpComicBook.BackgroundImage")));
            this.grpComicBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpComicBook.Controls.Add(this.cmbRatings);
            this.grpComicBook.Controls.Add(this.lblRating);
            this.grpComicBook.Controls.Add(this.cmbGenres);
            this.grpComicBook.Controls.Add(this.lblGenre);
            this.grpComicBook.Controls.Add(this.dtpPublishDate);
            this.grpComicBook.Controls.Add(this.lblPublishDate);
            this.grpComicBook.Controls.Add(this.txtDescription);
            this.grpComicBook.Controls.Add(this.txtName);
            this.grpComicBook.Controls.Add(this.lblDescription);
            this.grpComicBook.Controls.Add(this.lblName);
            this.grpComicBook.Location = new System.Drawing.Point(12, 27);
            this.grpComicBook.Name = "grpComicBook";
            this.grpComicBook.Size = new System.Drawing.Size(363, 309);
            this.grpComicBook.TabIndex = 1;
            this.grpComicBook.TabStop = false;
            this.grpComicBook.Text = "Comic Book";
            // 
            // cmbRatings
            // 
            this.cmbRatings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRatings.FormattingEnabled = true;
            this.cmbRatings.Location = new System.Drawing.Point(137, 269);
            this.cmbRatings.Name = "cmbRatings";
            this.cmbRatings.Size = new System.Drawing.Size(200, 21);
            this.cmbRatings.TabIndex = 8;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(33, 272);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(41, 13);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Rating:";
            // 
            // cmbGenres
            // 
            this.cmbGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(137, 231);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(200, 21);
            this.cmbGenres.TabIndex = 2;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(33, 234);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre:";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(137, 185);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPublishDate.TabIndex = 5;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(30, 191);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(70, 13);
            this.lblPublishDate.TabIndex = 4;
            this.lblPublishDate.Text = "Publish Date:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(33, 98);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(310, 68);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(33, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Book Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Comic Name:";
            // 
            // grpCollaborator
            // 
            this.grpCollaborator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpCollaborator.BackgroundImage")));
            this.grpCollaborator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpCollaborator.Controls.Add(this.cmbDesigner);
            this.grpCollaborator.Controls.Add(this.cmbAuthor);
            this.grpCollaborator.Controls.Add(this.lblDesigner);
            this.grpCollaborator.Controls.Add(this.lblAuthor);
            this.grpCollaborator.Location = new System.Drawing.Point(401, 23);
            this.grpCollaborator.Name = "grpCollaborator";
            this.grpCollaborator.Size = new System.Drawing.Size(324, 170);
            this.grpCollaborator.TabIndex = 2;
            this.grpCollaborator.TabStop = false;
            this.grpCollaborator.Text = "Collaborators";
            // 
            // cmbDesigner
            // 
            this.cmbDesigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesigner.FormattingEnabled = true;
            this.cmbDesigner.Location = new System.Drawing.Point(173, 90);
            this.cmbDesigner.Name = "cmbDesigner";
            this.cmbDesigner.Size = new System.Drawing.Size(121, 21);
            this.cmbDesigner.TabIndex = 3;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(173, 35);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(121, 21);
            this.cmbAuthor.TabIndex = 2;
            // 
            // lblDesigner
            // 
            this.lblDesigner.AutoSize = true;
            this.lblDesigner.Location = new System.Drawing.Point(22, 98);
            this.lblDesigner.Name = "lblDesigner";
            this.lblDesigner.Size = new System.Drawing.Size(68, 13);
            this.lblDesigner.TabIndex = 1;
            this.lblDesigner.Text = "Art Designer:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(19, 37);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // grpPublisher
            // 
            this.grpPublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPublisher.BackgroundImage")));
            this.grpPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpPublisher.Controls.Add(this.cmbPublisher);
            this.grpPublisher.Location = new System.Drawing.Point(401, 218);
            this.grpPublisher.Name = "grpPublisher";
            this.grpPublisher.Size = new System.Drawing.Size(324, 118);
            this.grpPublisher.TabIndex = 3;
            this.grpPublisher.TabStop = false;
            this.grpPublisher.Text = "Publisher";
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(48, 52);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(246, 21);
            this.cmbPublisher.TabIndex = 0;
            // 
            // grpControls
            // 
            this.grpControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpControls.BackgroundImage")));
            this.grpControls.Controls.Add(this.btnCancel);
            this.grpControls.Controls.Add(this.btnLast);
            this.grpControls.Controls.Add(this.btnAdd);
            this.grpControls.Controls.Add(this.btnDelete);
            this.grpControls.Controls.Add(this.btnFirst);
            this.grpControls.Controls.Add(this.btnSave);
            this.grpControls.Controls.Add(this.btnPrevious);
            this.grpControls.Controls.Add(this.btnNext);
            this.grpControls.Location = new System.Drawing.Point(149, 354);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(426, 124);
            this.grpControls.TabIndex = 4;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(308, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 47);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.Location = new System.Drawing.Point(308, 19);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(81, 43);
            this.btnLast.TabIndex = 30;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(47, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 47);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(134, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 47);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirst.Location = new System.Drawing.Point(47, 19);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(81, 43);
            this.btnFirst.TabIndex = 29;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(221, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 47);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.Location = new System.Drawing.Point(134, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 43);
            this.btnPrevious.TabIndex = 28;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.Location = new System.Drawing.Point(221, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 43);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // frmManageComicBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 490);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpPublisher);
            this.Controls.Add(this.grpCollaborator);
            this.Controls.Add(this.grpComicBook);
            this.Name = "frmManageComicBooks";
            this.Text = "Manage Comic Books";
            this.Load += new System.EventHandler(this.ManageComicBooks_Load);
            this.grpComicBook.ResumeLayout(false);
            this.grpComicBook.PerformLayout();
            this.grpCollaborator.ResumeLayout(false);
            this.grpCollaborator.PerformLayout();
            this.grpPublisher.ResumeLayout(false);
            this.grpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpComicBook;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbRatings;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.GroupBox grpCollaborator;
        private System.Windows.Forms.GroupBox grpPublisher;
        private System.Windows.Forms.ComboBox cmbDesigner;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Label lblDesigner;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbPublisher;
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