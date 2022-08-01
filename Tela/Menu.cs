using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;
using Diretorio;
using Funcoes;

namespace Tela
{
    internal class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar()
        {

            while (true)
            {

                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n Utilizando programacao funcional" +
                    "\n\n" +
                    "\n   Digite uma das opcoes abaixo:" +
                    "\n     0 - Sair do Programa" +
                    "\n     1 - Para Ler Arquivo" +
                    "\n     2 - Para executar a tabuada" +
                    "\n     3 - Calcular media de alunos";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("=================== Opcao ler arquivos ================================");
                    Arquivo.Ler(1);
                    Console.WriteLine("\n===================================================================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("==================== Opcao tabuada =====================================");
                    Console.WriteLine("Digite o numero que deseja na tabuada ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calculo(numero);
                    Console.WriteLine("\n=====================================================================\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n=====================================================================\n");
                }

                else
                {
                    Console.WriteLine("Opcões invalida digite novamente");
                }

            }


        }
    }
}
