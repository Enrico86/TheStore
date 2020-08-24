using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class AddressRepository
    {
        //Guardar una dirección
        public bool Save(Address address)
        {
            return true;
        }

        //Obtener todas las direcciones
        public List<Address> GetAddresses()
        {
            return new List<Address>();
        }

        //Obtener una dirección por su id
        public Address GetAddress(int id)
        {
            return new Address();

        }

        //Eliminar una dirección por su id
        public bool DeleteAddress(int id)
        {
            return true;
        }
    }
}
