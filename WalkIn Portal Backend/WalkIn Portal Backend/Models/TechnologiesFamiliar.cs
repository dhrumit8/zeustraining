using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class TechnologiesFamiliar
{
    public int Id { get; set; }

    public string Technologies { get; set; } = null!;

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<ExperiencedHasTechnologiesFamiliar> ExperiencedHasTechnologiesFamiliars { get; } = new List<ExperiencedHasTechnologiesFamiliar>();

    public virtual ICollection<FresherHasTechnologiesFamiliar> FresherHasTechnologiesFamiliars { get; } = new List<FresherHasTechnologiesFamiliar>();
}
