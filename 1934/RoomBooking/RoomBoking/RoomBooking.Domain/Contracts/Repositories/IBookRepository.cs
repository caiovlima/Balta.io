using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Contracts.Repositories
{
    public interface IBookRepository : IDisposable
    {
        IList<Book> GetBooksByDateRange(DateTime startDate, DateTime endDate);
    }
}
