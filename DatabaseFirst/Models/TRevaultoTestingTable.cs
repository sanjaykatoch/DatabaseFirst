using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class TRevaultoTestingTable
{
    public Guid? UTestingId { get; set; }

    public string? VTestingName { get; set; }

    public string? VParameters { get; set; }

    public string? CIsDeleted { get; set; }

    public DateTime? DtCreatedOn { get; set; }

    public DateTime? DtModifiedOn { get; set; }

    public string? VTestNumber { get; set; }
}
