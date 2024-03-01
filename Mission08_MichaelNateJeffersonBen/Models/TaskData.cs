using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_MichaelNateJeffersonBen.Models;

public partial class TaskData
{
    [Key]
    [Required]
    public int TaskId { get; set; }

    public string TaskName { get; set; }

    public string? DueDate { get; set; }

    public string Quadrant { get; set; } = null!;

    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }

    public int? Completed { get; set; }

    public virtual CategoryData? Category { get; set; }
}
