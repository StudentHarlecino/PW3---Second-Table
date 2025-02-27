using System;
using System.Collections.Generic;

namespace PW3;

public partial class PartnersPoduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Amount { get; set; }

    public DateOnly DateOfSale { get; set; }

    public virtual Partner IdPartnerNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
