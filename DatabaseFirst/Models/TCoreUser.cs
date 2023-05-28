using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class TCoreUser
{
    public int? Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
}
