using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class Owners
{
    public Guid GuidOwner { get; set; }

    public Guid GuidCompany { get; set; }

    public string? ApplicationType { get; set; }

    public string? MemberType { get; set; }

    public byte? Read { get; set; }

    public byte? Write { get; set; }

    public virtual DatabaseDirectory GuidCompanyNavigation { get; set; } = null!;
}
