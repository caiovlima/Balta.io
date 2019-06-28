using RoomBooking.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Console.Service
{
    public class BookService : IBookService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void PlaceBook(DateTime startDate, DateTime endDate, Guid room)
        {
            
        }
    }
}
