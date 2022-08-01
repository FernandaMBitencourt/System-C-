using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Type it the student name\n");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Typet it the " + qtdNotas + " student grades " + nome + " \n");

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int a = 1; a <= qtdNotas; a++)
            {
                Console.WriteLine("Typet it the student grades " + a + "\n");
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / notas.Count();
            Console.WriteLine("The avarage of the student " + nome + " is: " + media + " \n");
            Console.WriteLine("Your grades are:\n");

            foreach (int nota in notas)
            {
                Console.WriteLine("Grade:" + nota + "\n");
            }
        }
    }
}
