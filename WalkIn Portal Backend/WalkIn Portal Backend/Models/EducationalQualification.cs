using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class EducationalQualification
{
    public int Id { get; set; }

    public decimal Percentage { get; set; }

    public short YearOfPassing { get; set; }

    public string Qualification { get; set; } = null!;

    public string StreamBranch { get; set; } = null!;

    public string College { get; set; } = null!;

    public string CollegeLocation { get; set; } = null!;

    public int UserDetailsUserId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    //public virtual UserDetail UserDetailsUser { get; set; } = null!;
}
