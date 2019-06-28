using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Enums
{
    public enum EBookStatus
    {
        InProgress = 1,
        Reserved = 2,
        InUse = 3,
        Canceled = 4,
        Completed = 5
    }
}
