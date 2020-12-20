using FluentValidator;
using Store.Domain.StoreContext.Enums;
using System;

namespace Store.Domain.StoreContext.Entities
{
    public class Delivery : Notifiable
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }
        public DateTime CreateDate {get; private set;}

        public DateTime EstimatedDeliveryDate { get; private set; }

        public EDeliveryStatus Status { get; private set; }

        //método criado para o pedidor ser enviado
        public void Ship()
        {
            //Se data estimada de entrega for no passado, não entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            //Se o status ja estiver entregue, não pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}