using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Contracts.Services
{
    public interface IBookService : IDisposable
    {
        void PlaceBook(DateTime startDate, DateTime endDate, Guid room);
    }
}
