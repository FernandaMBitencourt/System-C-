
using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace console_app2
{

    class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();

            var clients = Client.ReadClientes();

            Client.Test = "ssss";

            var client = new Client();
            client.Name = "Danilo";
            client.Phone = "55646456456";
            client.CPF = "554545454564";
            client.Record();

            Client c = new Client();

            var l = new List<String>();

            /*
            var client2 = new Client();
            client2.Name = "Fernanda";
            client2.Phone = "4564564564";
            client2.CPF = "5245646464";
            */
        
        }
    }
}