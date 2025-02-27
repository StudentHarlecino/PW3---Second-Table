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

namespace PW3
{
    public partial class FormTypeOfPartners : Form
    {
        private DbPartnersContext db;
        public FormTypeOfPartners()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new DbPartnersContext();
            this.db.TypesOfProduct.Load();
            this.dataGridViewType.DataSource = this.db.TypesOfProduct.Local.OrderBy(o => o.TypeOfProduct).ToList();
            dataGridViewType.Columns["Id"].Visible = false;

            dataGridViewType.Columns["TypeOfPartner"].HeaderText = "Тип партнера";
            dataGridViewType.Columns["Partners"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }
        private void FormTypeOfPartners_Load(object sender, EventArgs e)
        {

        }

        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            FormAddTypeOfPartners formAddType = new FormAddTypeOfPartners();
            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            TypesOfPartner typeOfPartner = new TypesOfPartner();
            typeOfPartner.TypeOfProduct = formAddType.textBoxTypeName.Text;

            db.TypesOfProduct.Add(typeOfPartner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewType.DataSource = this.db.TypesOfProduct.Local.OrderBy(O => O.TypeOfProduct).ToList();
        }

        private void buttonTypeEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewType.SelectedRows.Count == 0)
            {
                return;
            }

            int index = dataGridViewType.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewType[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }
            TypesOfPartner partnerType = db.TypesOfProduct.Find(id);

            FormAddTypeOfPartners formTypeAdd = new();

            formTypeAdd.textBoxTypeName.Text = partnerType.TypeOfProduct;

            DialogResult result = formTypeAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            partnerType.TypeOfProduct = formTypeAdd.textBoxTypeName.Text;
            db.SaveChanges();

            MessageBox.Show("Объект обновлен");

            this.dataGridViewType.DataSource = this.db.TypesOfProduct.Local
                .OrderBy(O => O.TypeOfProduct).ToList();

        }

        private void buttonTypeDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewType.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                return;
            }



            int index = dataGridViewType.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewType[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }
            TypesOfPartner partnerType = db.TypesOfProduct.Find(id);

            db.TypesOfProduct.Remove(partnerType);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewType.DataSource = this.db.TypesOfProduct.Local
                .OrderBy(O => O.TypeOfProduct).ToList();
        }
    }
}
