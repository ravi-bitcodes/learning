using System;
using System.Collections.Generic;

namespace AzureLearnWebApp.Models;

public partial class Author
{
    public Guid Id { get; set; }

    public string ACode { get; set; } = null!;

    public string AName { get; set; } = null!;

    public string? AEmail { get; set; }

    public bool IsActive { get; set; }

    public bool Deleted { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? ALastName { get; set; }
}
