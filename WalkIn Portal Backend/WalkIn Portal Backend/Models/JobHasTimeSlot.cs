using System;
using System.Collections.Generic;

namespace WalkIn_Portal_Backend.Models;

public partial class JobHasTimeSlot
{
    public int JobId { get; set; }

    public int TimeSlotsId { get; set; }

    public DateTime? DtCreated { get; set; }

    public DateTime? DtModified { get; set; }

    public virtual Job Job { get; set; } = null!;

    public virtual TimeSlot TimeSlots { get; set; } = null!;
}
