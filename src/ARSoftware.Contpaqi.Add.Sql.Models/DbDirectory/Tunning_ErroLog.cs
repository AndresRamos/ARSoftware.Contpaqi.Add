using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Tunning_ErroLog
    {
        public Guid GuidProcess { get; set; }
        public Guid GuidCompany { get; set; }
        [Unicode(false)]
        public string? DescriptionError { get; set; }
    }
}
