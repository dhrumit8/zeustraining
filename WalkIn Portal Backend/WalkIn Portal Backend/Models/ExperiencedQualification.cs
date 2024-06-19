using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class ExperiencedQualification
{
    public int Id { get; set; }

    public int YearsOfExperience { get; set; }

    public int CurrentCtc { get; set; }

    public int ExpectedCtc { get; set; }

    public bool OnNoticePeriod { get; set; }

    public DateOnly? NoticePeriodEnd { get; set; }

    public int? NoticePeriodLength { get; set; }

    public bool ApperedForZeusTest { get; set; }

    public string? RoleApplied { get; set; }

    public string? OtherTechnologiesFamiliar { get; set; }

    public string? OtherTechnologiesExpertise { get; set; }

    public int ProfessionalQualificationId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<ExperiencedHasTechnologiesExpertise> ExperiencedHasTechnologiesExpertises { get; } = new List<ExperiencedHasTechnologiesExpertise>();

    public virtual ICollection<ExperiencedHasTechnologiesFamiliar> ExperiencedHasTechnologiesFamiliars { get; } = new List<ExperiencedHasTechnologiesFamiliar>();

    //public virtual ProfessionalQualification ProfessionalQualification { get; set; } = null!;
}
