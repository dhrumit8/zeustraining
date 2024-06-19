using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class UserDetail
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Resume { get; set; }

    public string? ProfileImage { get; set; }

    public string? PortfolioUrl { get; set; }

    public string? Referal { get; set; }

    public bool? JobRelatedEmail { get; set; }

    //public DateTime? DtCreated { get; set; }

    //public DateTime? DtModified { get; set; }

    //public virtual ICollection<EducationalQualification> EducationalQualifications { get; } = new List<EducationalQualification>();

    //public virtual ICollection<Login> Logins { get; } = new List<Login>();

    //public virtual ICollection<ProfessionalQualification> ProfessionalQualifications { get; } = new List<ProfessionalQualification>();

    //public virtual ICollection<UserAppliedForJob> UserAppliedForJobs { get; } = new List<UserAppliedForJob>();

    //public virtual ICollection<UserHasJobRole> UserHasJobRoles { get; } = new List<UserHasJobRole>();
}
