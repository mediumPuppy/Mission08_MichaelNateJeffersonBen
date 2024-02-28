using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission08_MichaelNateJeffersonBen.Models;

public partial class TaskData
{
    [Key]
    [Required]
    public int TaskID { get; set; }

  
    public string TaskName { get; set; }

    public string? DueDate { get; set; }

    public string Quadrant { get; set; } = null!;

    public string? Category { get; set; } = null!;

    public int? Completed { get; set; }
}
