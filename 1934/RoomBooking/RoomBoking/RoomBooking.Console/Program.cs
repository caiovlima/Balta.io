using RoomBooking.Console.Repositories;
using RoomBooking.Console.Service;
using RoomBooking.Domain.Contracts.Repositories;
using RoomBooking.Domain.Contracts.Services;
using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using Unity;
using Unity.Lifetime;

namespace RoomBooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();

            //container.RegisterType<IBookRepository, BookRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IBookService, BookService>(new HierarchicalLifetimeManager());

            //var bookRepository = container.Resolve<IBookRepository>();
            //var bookService = container.Resolve<IBookService>();

            //var room = new Room(DateTime.Now, DateTime.Now.AddHours(8), "Sala 1");
            //bookService.PlaceBook(DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), room.Id);

            //criar uma sala
            var room = new Room(DateTime.Now.AddHours(1), DateTime.Now.AddHours(8), "Sala 1");
            System.Console.WriteLine("Criando uma sala: ");

            //inicial uma reserva
            var book = new Book(room, DateTime.Now.AddHours(4), DateTime.Now.AddHours(4));
            System.Console.WriteLine("Iniciando Reserva: "+ book.Status);

            //confirmar reserva
            book.Confirm(new List<DateTime>(), new List<DateTime>());
            System.Console.WriteLine("Status Reserva: "+ book.Status);

            //Marcar como em progresso
            book.MarkAsInProgress();
            System.Console.WriteLine("Status Reserva: "+ book.Status);

            //marcar como completa
            book.MarkAsCompleted();
            System.Console.WriteLine("Status Reserva: "+ book.Status);

            System.Console.ReadKey();
        }
    }
}
