using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class FresherQualification
{
    public int Id { get; set; }

    public bool AppearedForZeusTest { get; set; }

    public string? RoleAppliedForZeusTest { get; set; }

    public string? OtherTechnologiesFamiliar { get; set; }

    public int ProfessionalQualificationId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<FresherHasTechnologiesFamiliar> FresherHasTechnologiesFamiliars { get; } = new List<FresherHasTechnologiesFamiliar>();

    //public virtual ProfessionalQualification ProfessionalQualification { get; set; } = null!;
}
