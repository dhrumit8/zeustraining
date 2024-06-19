using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class JobPreRequisite
{
    public int Id { get; set; }

    public string? GeneralInstructions { get; set; }

    public string? InstructionsForExam { get; set; }

    public string? MinSystemRequirements { get; set; }

    public string? Process { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<Job> Jobs { get; } = new List<Job>();
}
