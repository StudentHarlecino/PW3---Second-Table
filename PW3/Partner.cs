using System;
using System.Collections.Generic;

namespace PW3;

public partial class Partner
{
    public int Id { get; set; }

    public short IdTypeOfPartner { get; set; }

    public string NameOfPartner { get; set; } = null!;

    public string LegalAdress { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string FullNameOfDirector { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short Raiting { get; set; }

    public virtual TypesOfPartner IdTypeOfPartnerNavigation { get; set; } = null!;

    public virtual ICollection<PartnersPoduct> PartnersPoducts { get; set; } = new List<PartnersPoduct>();
}
