using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Client
    {
        public string Name;
        public string Phone;
        public string cpf;

        public void Record()
        {
            //Implementar
        }

        internal static void ReadClient()
        {
            throw new NotImplementedException();
        }

        public static List<Client> ReadClientes()
        {
            var clients = new List<Client>();

            return clients;
        }
    }
}
