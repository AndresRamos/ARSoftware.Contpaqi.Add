using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class Tunning_ErroLog
    {
        public Guid GuidProcess { get; set; }
        public Guid GuidCompany { get; set; }
        public string? DescriptionError { get; set; }
    }
}
