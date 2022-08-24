using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    [Index("GuidOwner", Name = "IXFK_Owners")]
    public partial class Owners
    {
        public Guid GuidOwner { get; set; }
        public Guid GuidCompany { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ApplicationType { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string? MemberType { get; set; }
        public byte? Read { get; set; }
        public byte? Write { get; set; }

        [ForeignKey("GuidCompany")]
        public virtual DatabaseDirectory GuidCompanyNavigation { get; set; } = null!;
    }
}
