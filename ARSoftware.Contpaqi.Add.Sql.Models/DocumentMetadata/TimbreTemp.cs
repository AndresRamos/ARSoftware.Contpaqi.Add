using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class TimbreTemp
    {
        [Key]
        public Guid UUID { get; set; }
        public Guid GuidDocument { get; set; }
    }
}
