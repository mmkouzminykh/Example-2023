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
    public partial class frmEntityList : Form
    {
        int curPosition = 0;
        bool haveMore = false;

        private IEditForm _editForm;
        private IQueryable<IEntity> _entities;
        //private SaveEntityDelegate _saveFunc;
        private Action<IEntity> _saveFunc;

        public frmEntityList(IQueryable<IEntity> entities, IEditForm editForm, Action<IEntity> saveFunc)
        {
            InitializeComponent();

            _editForm = editForm;
            _entities = entities;
            _saveFunc = saveFunc;
        }

        private void frmEntityList_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            int shown = 0;
            lstEntities.Items.Clear();
            foreach (var entity in _entities.Skip(curPosition).Take(5))
            {
                lstEntities.Items.Add(entity);
                shown++;
            }
            if (shown == 5)
                haveMore = true;
            else
                haveMore = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (haveMore)
            {
                curPosition += 5;
                FillList();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (curPosition > 5)
            {
                curPosition -= 5;
            }
            else
            {
                curPosition = 0;
            }
            FillList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lstEntities.Items.Clear();
            foreach (var entity in _entities.Where(e => e.Name.Contains(txtNameFilter.Text)))
            {
                lstEntities.Items.Add(entity);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEntities.SelectedItem == null)
                return;

            var item = (IEntity)lstEntities.SelectedItem;

            if (_editForm.Edit(item))
            {                
                _saveFunc(item);                
            }
            else
            {
                MessageBox.Show("No need to save element");
            }
        }
    }
}
