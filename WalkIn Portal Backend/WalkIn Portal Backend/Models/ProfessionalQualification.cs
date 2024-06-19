using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class ProfessionalQualification
{
    public int Id { get; set; }

    public sbyte? Fresher { get; set; }

    public sbyte? Experienced { get; set; }

    public int UserDetailsUserId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<ExperiencedQualification> ExperiencedQualifications { get; } = new List<ExperiencedQualification>();

    public virtual ICollection<FresherQualification> FresherQualifications { get; } = new List<FresherQualification>();

    public virtual UserDetail UserDetailsUser { get; set; } = null!;
}
