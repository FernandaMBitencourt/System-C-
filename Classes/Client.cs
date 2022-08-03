using System;
using System.Configuration;
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
        public string CPF;

        public void Record()
        {
            //Implementar
        }

        
        private static string caminhoBaseClient() => ConfigurationManager.AppSettings["BaseOfClients"];

        public static List<Client> ReadClientes()
        {
            var clients = new List<Client>();
            if (File.Exists(caminhoBaseClient()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClient()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if(i == 0) continue;
                        var clientFile = linha.Split(';');

                        var client = new Client();
                        client.Name = clientFile[0];
                        client.Phone = clientFile[1];
                        client.CPF = clientFile[2];

                        clients.Add(client);

                    }
                }
            }

            return clients;
        }
    }
}      
   
