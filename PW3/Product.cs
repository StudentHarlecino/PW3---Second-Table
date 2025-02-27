using System;
using System.Collections.Generic;

namespace PW3;

public partial class Product
{
    public int Id { get; set; }

    public short IdTypeOfProduct { get; set; }

    public string NameOfProduct { get; set; } = null!;

    public string ArticleNumber { get; set; } = null!;

    public decimal MincCostForPartner { get; set; }

    public virtual TypesOfProduct IdTypeOfProductNavigation { get; set; } = null!;

    public virtual ICollection<PartnersPoduct> PartnersPoducts { get; set; } = new List<PartnersPoduct>();
}
