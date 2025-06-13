using System;
using System.Collections.Generic;

namespace AzureLearnWebApp.Models;

public partial class CourseAuthor
{
    public int Id { get; set; }

    public Guid CourceId { get; set; }

    public Guid AuthorId { get; set; }

    public DateTime CreatedAt { get; set; }
}
