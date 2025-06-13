using System;
using System.Collections.Generic;

namespace AzureLearnWebApp.Models;

public partial class Course
{
    public Guid Id { get; set; }

    public string CCode { get; set; } = null!;

    public string CName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool Deleted { get; set; }

    public DateTime CreatedAt { get; set; }
}
