namespace ExpencesClient
{
    partial class frmSource
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstSource = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            lblID = new Label();
            lblName = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lstSource
            // 
            lstSource.FormattingEnabled = true;
            lstSource.ItemHeight = 32;
            lstSource.Location = new Point(45, 61);
            lstSource.Name = "lstSource";
            lstSource.Size = new Size(534, 772);
            lstSource.TabIndex = 0;
            lstSource.SelectedIndexChanged += lstSource_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 863);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(227, 863);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(749, 92);
            lblID.Name = "lblID";
            lblID.Size = new Size(37, 32);
            lblID.TabIndex = 3;
            lblID.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(619, 171);
            lblName.Name = "lblName";
            lblName.Size = new Size(181, 32);
            lblName.TabIndex = 4;
            lblName.Text = "Наименование";
            // 
            // txtID
            // 
            txtID.Location = new Point(820, 89);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(200, 39);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(820, 164);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 39);
            txtName.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(650, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmSource
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 1009);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstSource);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmSource";
            Text = " Источники средств";
            Load += frmSource_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSource;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblID;
        private Label lblName;
        private TextBox txtID;
        private TextBox txtName;
        private Button btnSave;
    }
}