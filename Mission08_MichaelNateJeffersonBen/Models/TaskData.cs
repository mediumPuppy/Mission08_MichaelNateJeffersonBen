using System;
using System.Collections.Generic;

namespace Mission08_MichaelNateJeffersonBen.Models;

public partial class TaskData
{
    public int TaskId { get; set; }

    public decimal TaskName { get; set; }

    public string DueDate { get; set; } = null!;

    public string Quadrant { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int Completed { get; set; }
}
