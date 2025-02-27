namespace PW3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            using (DbPartnersContext db = new DbPartnersContext())
            {
                var partners = db.Partners.ToList();
                var products = db.Products.ToList();
                var typesPartner = db.TypesOfPartners.ToList();
                var typesProduct = db.TypesOfProducts.ToList();
                var partnersProducts = db.PartnersPoducts.ToList();
                //Console.WriteLine("Список партнеров:");
                foreach (Partner u in partners)
                {
                    labelOut.Text += ($"{u.Id}.{u.IdTypeOfPartner} - {u.NameOfPartner} - {u.LegalAdress} - {u.Tin} - {u.FullNameOfDirector} - {u.Telephone} - {u.Email} - {u.Raiting} \n");
                }
            }
        }
    }
}
