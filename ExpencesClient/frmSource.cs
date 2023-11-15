using Example;
using Microsoft.EntityFrameworkCore;

namespace ExpencesClient
{
    public partial class frmSource : Form
    {
        private Source currentSource = null;
        private FinanceContext context;

        public frmSource()
        {
            InitializeComponent();
            context = new FinanceContext();
        }

        private void frmSource_Load(object sender, EventArgs e)
        {
            FillList();

        }

        private void FillList()
        {
            lstSource.Items.Clear();
            foreach (var s in context.Source)
                lstSource.Items.Add(s);
        }

        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSource = (Source)lstSource.SelectedItem;
            FillProperties();
        }

        private void FillProperties()
        {
            txtID.Text = currentSource.Id.ToString();
            txtName.Text = currentSource.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentSource == null)
                return;

            currentSource.Name = txtName.Text;

            if (context.Entry<Source>(currentSource).State == EntityState.Detached)
                context.Add(currentSource);

            context.SaveChanges();
            ClearData();
            FillList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentSource = new Source();
            FillProperties();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentSource == null) return;
            
            context.Source.Remove(currentSource);
            context.SaveChanges();
            ClearData();
            FillList();
        }

        private void ClearData()
        {
            currentSource = null;
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
        }
    }
}