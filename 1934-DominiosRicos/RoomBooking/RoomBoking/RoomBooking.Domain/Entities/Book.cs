using RoomBooking.Domain.Enums;
using SpaUserControl.Common.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Entities
{
    public class Book
    {
        public Book(Room room, DateTime startTime, DateTime endTime)
        {

            Id = Guid.NewGuid();
            Room = room;
            Status = EBookStatus.InProgress;
            StartTime = startTime;
            EndTime = endTime;
        }

        public Guid Id { get; set; }
        public Room Room { get; set; }
        public EBookStatus Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public void Confirm(IList<DateTime> holidays, IList<DateTime> booksForThisPeriod)
        {
            //AssertionConcern.Asser
            if (Status != EBookStatus.InProgress)
                throw new Exception("Error");

            Status = EBookStatus.Reserved;
        }

        public void MarkAsInProgress()
        {
            //Dizer se a sala está em uso
            Status = EBookStatus.InUse;
        }

        public void Cancel()
        {
            //só pode cancelar com duas horas de antecedencia
            if ((StartTime - DateTime.Now).Hours < 2)
            {
                throw new Exception("Error");
            }

            Status = EBookStatus.Canceled;
        }

        public void MarkAsCompleted()
        {
            Status = EBookStatus.Completed;
        }


    }
}
