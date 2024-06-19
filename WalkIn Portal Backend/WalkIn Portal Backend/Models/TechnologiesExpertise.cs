using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class TechnologiesExpertise
{
    public int Id { get; set; }

    public string Technologies { get; set; } = null!;

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<ExperiencedHasTechnologiesExpertise> ExperiencedHasTechnologiesExpertises { get; } = new List<ExperiencedHasTechnologiesExpertise>();
}
