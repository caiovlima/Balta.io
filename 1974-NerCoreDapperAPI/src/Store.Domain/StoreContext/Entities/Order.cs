using FluentValidator;
using Store.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Store.Domain.StoreContext.Entities
{
    public class Order : Notifiable
    {

        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;
        public Order(Customer customer)
        {
            Customer = customer;
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();
        }

        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }

        //IReadOnlyCollection pode dar problemas quando se utilizar ORM's (EF)
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public void AddItem(OrderItem item)
        {
            //valida item
            //adiciona pedido
            _items.Add(item);
        }

        
        //criar um pedido
        public void Place(){
            //gera o numero do pedido
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            //validar
            if(_items.Count == 0)
            {
                AddNotification("Order", "Este pedido não possui itens");
            }
        }

        //pagar o pedido
        public void Pay()
        {
            Status = EOrderStatus.Paid;
            
        }

        //enviar o pedido
        public void Ship()
        {
            // A cada 5 produtos é uma entrega
            var deliveries = new List<Delivery>();
            deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            var count = 1;

            //quebra as entregas
            foreach(var item in _items)
            {
                if(count == 5)
                {
                    count = 1;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                }
                count++;
            }

            //envia todas as entregas
            deliveries.ForEach(x => x.Ship());
            //adiciona as entregas ao pedido
            deliveries.ForEach(x => _deliveries.Add(x));

          
        }

        //cancelar o pedido
        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
            //também devo criar um método no delivery para cancelar
            _deliveries.ToList().ForEach(x => x.Cancel());
        }



    }
}