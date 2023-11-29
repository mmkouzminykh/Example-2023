namespace ExpencesClient
{
    partial class frmEntityList
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
            lstEntities = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSelect = new Button();
            btnClose = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            txtNameFilter = new TextBox();
            lblNameFilter = new Label();
            btnFilter = new Button();
            SuspendLayout();
            // 
            // lstEntities
            // 
            lstEntities.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstEntities.FormattingEnabled = true;
            lstEntities.ItemHeight = 32;
            lstEntities.Location = new Point(28, 120);
            lstEntities.Name = "lstEntities";
            lstEntities.Size = new Size(984, 612);
            lstEntities.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(28, 757);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(184, 757);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(340, 757);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelect.Location = new Point(862, 757);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 46);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "Выбрать";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(862, 854);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 46);
            btnClose.TabIndex = 5;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(119, 68);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(88, 46);
            btnNext.TabIndex = 6;
            btnNext.Text = "->";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(25, 68);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(88, 46);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "<-";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // txtNameFilter
            // 
            txtNameFilter.Location = new Point(584, 68);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new Size(200, 39);
            txtNameFilter.TabIndex = 8;
            // 
            // lblNameFilter
            // 
            lblNameFilter.AutoSize = true;
            lblNameFilter.Location = new Point(397, 71);
            lblNameFilter.Name = "lblNameFilter";
            lblNameFilter.Size = new Size(181, 32);
            lblNameFilter.TabIndex = 9;
            lblNameFilter.Text = "Наименование";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(790, 64);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(137, 46);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Найти";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // frmEntityList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 912);
            Controls.Add(btnFilter);
            Controls.Add(lblNameFilter);
            Controls.Add(txtNameFilter);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnClose);
            Controls.Add(btnSelect);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lstEntities);
            Name = "frmEntityList";
            Text = "frmEntityList";
            Load += frmEntityList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEntities;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSelect;
        private Button btnClose;
        private Button btnNext;
        private Button btnPrevious;
        private TextBox txtNameFilter;
        private Label lblNameFilter;
        private Button btnFilter;
    }
}