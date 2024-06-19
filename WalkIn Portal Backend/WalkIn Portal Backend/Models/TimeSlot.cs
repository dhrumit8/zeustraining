using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class TimeSlot
{
    public int Id { get; set; }

    public string Slots { get; set; } = null!;

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual ICollection<JobHasTimeSlot> JobHasTimeSlots { get; } = new List<JobHasTimeSlot>();
}
