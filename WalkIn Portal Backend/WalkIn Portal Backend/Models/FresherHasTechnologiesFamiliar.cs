using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class FresherHasTechnologiesFamiliar
{
    public int FresherQualificationId { get; set; }

    public int TechnologiesFamiliarId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual FresherQualification FresherQualification { get; set; } = null!;

    public virtual TechnologiesFamiliar TechnologiesFamiliar { get; set; } = null!;
}
