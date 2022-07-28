

namespace console_app2
{

    class Program
    {
        static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }
        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Hello Mundo");
        }
        public static void Tabuada(int numero)
        {
            Console.WriteLine("================== Calculo da Tabuada do " + numero + " ================================");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + "X" + i + " = " + (numero * i));
            }
            Console.WriteLine("========================================================================================");
        }

        private static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("===================" + arquivoComCaminho + " ================================");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }
        }
        private static void CalcularMediaAluno()
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
        private static void Menu()
        {  
        
            while (true)
            {

                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n Utilizando programacao funcional" +
                    "\n\n"+
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
                    LerArquivos(1);
                    Console.WriteLine("\n===================================================================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("==================== Opcao tabuada =====================================");
                    Console.WriteLine("Digite o numero que deseja na tabuada ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                    Console.WriteLine("\n=====================================================================\n");
                }
                else if ( valor == CALCULO_MEDIA)
                {
                    CalcularMediaAluno();
                    Console.WriteLine("\n=====================================================================\n");
                }
                    
                else
                {
                    Console.WriteLine("Opcões invalida digite novamente");
                }

            }
           

        }
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;


        static void Main(string[] args)
        {
            Menu();
        }
    }
}