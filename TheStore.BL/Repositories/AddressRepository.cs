using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class AddressRepository
    {
        private List<Address> Addresses = new List<Address>();

        //Guardar una dirección
        public bool InsertAddress(Address newAddress)
        {
            Addresses.Insert(Addresses.Count, newAddress);
            return true;
        }

        //Obtener todas las direcciones de un cliente
        public List<Address> GetAddressesByCustomerId(int customerId)
        {
            Addresses = new List<Address>
            {
                new Address
                {
                    Id=1,
                    Line1="Av. de los palotes 15",
                    Line2="Portón azul de tu hermana 48",
                    City="Barcelona",
                    Country="Spain",
                    PostalCode="08017",
                    State="Cataluña"
                },
                new Address
                {
                    Id=2,
                    Line1="Av. del pozo 69",
                    Line2="Calle de mis pedidos 37",
                    City="Barcelona",
                    Country="Spain",
                    PostalCode="08024",
                    State="Cataluña"
                },                
                new Address
                {
                    Id=3,
                    Line1="Gran via 2, 786",
                    Line2="Calle Argentona 2",
                    City="Barcelona",
                    Country="Spain",
                    PostalCode="08020",
                    State="Cataluña"
                },
            };
            return Addresses;
        }
    }
}
