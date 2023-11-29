using Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpencesClient
{
    public partial class frmIncome : Form, IEditForm
    {
        private Income income;
        public frmIncome()
        {
            InitializeComponent();
        }


        public Income Income
        {
            get => this.income;
            set => this.income = value;
        }

        public IEntity Element
        {
            get => this.income;
            set
            {
                Income newIncome = value as Income;
                if (newIncome != null)
                    income = newIncome;
                else
                    income = null;
            }
        }

        bool IEditForm.Edit(IEntity element)
        {
            if (element is Income curIncome)
            {
                this.income = curIncome;
                FillData();
                var result = this.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void FillData()
        {
            txtId.Text = income.Id.ToString();
            txtName.Text = income.Name;
            txtDescription.Text = income.Description;
            nudSum.Value = income.Sum;
            dtpDate.Value = income.Date;
        }

        private void frmIncome_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(income.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            income.Name = txtName.Text;
            income.Description = txtDescription.Text;
            income.Sum = nudSum.Value;
            income.Date = dtpDate.Value;

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
