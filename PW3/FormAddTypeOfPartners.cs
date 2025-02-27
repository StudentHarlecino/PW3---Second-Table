using System.ComponentModel;

namespace PW3
{
    public partial class FormAddTypeOfPartners : Form
    {
        string msgError = "Поле не может быть пустым";
        public FormAddTypeOfPartners()
        {
            InitializeComponent();
        }

        private void FormAddTypeOfPartners_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
