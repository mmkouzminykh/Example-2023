namespace ExpencesClient
{
    partial class frmIncome
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
            lblId = new Label();
            lblName = new Label();
            lblDescription = new Label();
            lblSum = new Label();
            lblDate = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            nudSum = new NumericUpDown();
            dtpDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSum).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(53, 61);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 32);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(181, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Наименование";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(53, 215);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(124, 32);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(53, 292);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(87, 32);
            lblSum.TabIndex = 3;
            lblSum.Text = "Сумма";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(53, 371);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(65, 32);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата";
            // 
            // txtId
            // 
            txtId.Location = new Point(248, 58);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(447, 39);
            txtId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(248, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(801, 39);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(248, 212);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(801, 39);
            txtDescription.TabIndex = 7;
            // 
            // nudSum
            // 
            nudSum.DecimalPlaces = 2;
            nudSum.Location = new Point(248, 290);
            nudSum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSum.Name = "nudSum";
            nudSum.Size = new Size(228, 39);
            nudSum.TabIndex = 8;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(248, 366);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(306, 39);
            dtpDate.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(710, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(884, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmIncome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 561);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpDate);
            Controls.Add(nudSum);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblDate);
            Controls.Add(lblSum);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmIncome";
            Text = "Поступление средств";
            Load += frmIncome_Load;
            ((System.ComponentModel.ISupportInitialize)nudSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblDescription;
        private Label lblSum;
        private Label lblDate;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;
        private NumericUpDown nudSum;
        private DateTimePicker dtpDate;
        private Button btnSave;
        private Button btnCancel;
    }
}