using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var name = new Name("Caio", "Vinicius");
            var document = new Document("123456789");
            var email = new Email("test@test.com");
            
            var c = new Customer(name, document, email, "19924567");

            var mouse = new Product("Mouse", "Rato", "Image.png", 59.90M, 10);
            var teclado = new Product("Teclado", "Tec", "Image.png", 359.90M, 10);
            var fone = new Product("Fone", "Headset", "Image.png", 159.90M, 10);
            var monitor = new Product("Monitor", "Monitor", "Image.png", 459.90M, 10);

            var order = new Order(c);
            //order.AddItem(new OrderItem(mouse, 5));
            //order.AddItem(new OrderItem(teclado, 5));
            //order.AddItem(new OrderItem(fone, 5));
            //order.AddItem(new OrderItem(monitor, 5));

            //realizei o pedido
            order.Place();

            //verificar se tudo é válido
            var valid = order.IsValid;

            //simular pagamento
            order.Pay();

            //simular envio
            order.Ship();

            //simula cancelamento
            order.Cancel();
        }
    }
}
