using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission08_MichaelNateJeffersonBen.Models;

public partial class CategoryData
{
    [Key]
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<TaskData> TaskData { get; set; } = new List<TaskData>();
}
