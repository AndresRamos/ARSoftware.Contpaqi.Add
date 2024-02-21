using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class ProcessControl
{
    public Guid GuidControl { get; set; }

    public Guid? GuidCompany { get; set; }

    public int? Id_Process { get; set; }

    public string? ProcessDescription { get; set; }

    public int? Percentage { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? TotalExtracted { get; set; }

    public int? TotalProcessed { get; set; }

    public string? LogName { get; set; }

    public string? StatusProcess { get; set; }

    public string? JSONName { get; set; }

    public virtual Cat_Process? Id_ProcessNavigation { get; set; }
}
