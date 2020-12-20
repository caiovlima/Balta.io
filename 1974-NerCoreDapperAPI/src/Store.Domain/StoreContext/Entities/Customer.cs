using FluentValidator;
using Store.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Domain.StoreContext.Entities
{
    
    public class Customer : Notifiable
    {
        //vou utilizar essa propriedade para eu utilizar o método add no public void AddAddress
        private readonly IList<Address> _addresses;
        //OBS: Tudo que for private readonly, é ideal utilizar o underline para 
        //representar que tal propriedade é private readonly


        // aplicando SOLID - Open Close

        public Customer(Name name,
                        Document document, 
                        Email email, 
                        string phone)
    {
        Name = name;
        Document = document;
        Email = email;
        Phone = phone;
        _addresses = new List<Address>();
    }

        // qualquer um pode herdar dessa classe e extender ela, mas ela está fechada para modificações
        // detalhe para o private Set, ou seja, não pode setar nada, ela está privado
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            //validar endereço
            //adicionar o endereço

            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}