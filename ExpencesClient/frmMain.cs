using Example;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        private FinanceContext context = new FinanceContext();

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //return;
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Окно " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnuItemSource_Click(object sender, EventArgs e)
        {
            frmSource? frm = this.MdiChildren.FirstOrDefault(f => f.GetType() == typeof(frmSource)) as frmSource;
            if (frm == null)
            {
                frm = new frmSource();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }

        }

        private void menuItemIncomes_Click(object sender, EventArgs e)
        {
/*
            var incomeInfo = (from income in context.Incomes
                             join account in context.Accounts on income.DestinationAccount.Id equals account.Id
                             select new { Name = income.Name, Account = account.Name, Date = income.Date }).ToList();
            foreach(var income in incomeInfo)
            {
                MessageBox.Show($"Поступление {income.Name} на счет {income.Account} от {income.Date.ToShortDateString()}");
            }
            return;
*/
            frmEntityList ? frm = this.MdiChildren.FirstOrDefault(f => f.GetType() == typeof(frmEntityList)) as frmEntityList;
            if (frm == null)
            {                
                var incomes = context.Incomes
                    .Include("DestinationAccount")
                    .OrderByDescending(i => i.Date);

                //SaveEntityDelegate saveFunc = new SaveEntityDelegate(SaveEntity);                
                var action = new Action<IEntity>(SaveEntity);
                    
                var anotherAction = delegate (IEntity entity)
                {                    
                    this.SaveEntity(entity);
                };

                Action<IEntity> yetAnotherAction = e => this.SaveEntity(e); 

                frmIncome frmIncome = new frmIncome();
                frm = new frmEntityList(incomes, frmIncome, action);
                //frm = new frmEntityList(incomes, frmIncome, e => this.SaveEntity(e));
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                frm.BringToFront();
            }
        }

        private void SaveEntity(IEntity entity)
        {
            var contextElement = context.Entry(entity);
            if (contextElement.State == EntityState.Detached)
                context.Add(entity);
            context.SaveChanges();
        }
    }
}
