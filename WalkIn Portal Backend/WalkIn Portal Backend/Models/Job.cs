using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class Job
{
    public int Id { get; set; }

    public string JobTitle { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Location { get; set; } = null!;

    public string? SpecialOpportunity { get; set; }

    public int? Expires { get; set; }

    public int JobPreRequisitesId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }
    //public string? roles { get; set; }
    //public int? job_roles_id { get; set; }
    //public virtual ICollection<Role> roles { get; set; } = new List<Role>();
    //public string Roles { get; set; } = null!;

    public virtual ICollection<JobHasTimeSlot> JobHasTimeSlots { get; } = new List<JobHasTimeSlot>();

    public virtual JobPreRequisite JobPreRequisites { get; set; } = null!;

    public virtual ICollection<RolesAvailable> RolesAvailables { get; } = new List<RolesAvailable>();

    public virtual ICollection<UserAppliedForJob> UserAppliedForJobs { get; } = new List<UserAppliedForJob>();
}
