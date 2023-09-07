using contabancaria.Model;

namespace contabancaria
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao;

            //Teste da conta
            Conta c1 = new Conta(1, 123, 1, "Adriana", 10000.00M);
            c1.Visualizar();
            c1.Sacar(12000.0M);
            c1.Visualizar();
            c1.Depositar(5000.0M);
            c1.Visualizar();

            //Teste da conta corrente
            ContaCorrente cc1 = new(2, 123, 1, "Mariana", 15000.0M,1000.0M);
            cc1.Visualizar();
            cc1.Sacar(12000.0M);
            cc1.Visualizar();
            cc1.Depositar(5000.0M);
            cc1.Visualizar();

            //Teste da conta poupança
            ContaPoupanca cp1 = new (3, 123, 2, "Victor", 100000.0M, 15);
            cp1.Visualizar();
            cp1.Sacar(1000.0M);
            cp1.Visualizar();
            cp1.Depositar(5000.0M);
            cp1.Visualizar();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("****************************************************");
                Console.WriteLine("                                                    ");
                Console.WriteLine("                     NUSS BANKO                     ");
                Console.WriteLine("                                                    ");
                Console.WriteLine("****************************************************");
                Console.WriteLine("                                                    ");
                Console.WriteLine("            1 - Criar Conta                         ");
                Console.WriteLine("            2 - Listar todas as Contas              ");
                Console.WriteLine("            3 - Buscar Conta por Número             ");
                Console.WriteLine("            4 - Atualizar Dados da Conta            ");
                Console.WriteLine("            5 - Apagar Conta                        ");
                Console.WriteLine("            6 - Sacar                               ");
                Console.WriteLine("            7 - Depositar                           ");
                Console.WriteLine("            8 - Transferir valores entre Contas     ");
                Console.WriteLine("            9 - Sair                                ");
                Console.WriteLine("                                                    ");
                Console.WriteLine("****************************************************");
                Console.WriteLine("Entre com a opção desejada:                         ");
                Console.WriteLine("                                                    ");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Criar Conta\n\n");
                        KeyPress();
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Listar todas as Contas\n\n");
                        KeyPress();
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                        KeyPress();
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        KeyPress();
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Apagar a Conta\n\n");
                        KeyPress();
                        break;
                    case 6:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Saque\n\n");
                        KeyPress();
                        break;
                    case 7:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Depósito\n\n");
                        KeyPress();
                        break;
                    case 8:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Transferência entre Contas\n\n");
                        KeyPress();
                        break;
                    default:
                        if (opcao == 9)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nNUSS BANKO - O nosso banco!");
                            DevAut();
                            Console.ResetColor();
                            System.Environment.Exit(0); //p sair do looping infinito do while(true)
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOPÇÃO INVÁLIDA!\n");
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            KeyPress();
                        }
                        break;
                }

            }
        }

        static void DevAut()
        {
            Console.WriteLine("\n****************************************************");
            Console.WriteLine("Projeto Desenvolvido por:");
            Console.WriteLine("Roniberto Rodrigues - ronirodrigues123@hotmail.com");
            Console.WriteLine("github.com/RoninZin");
            Console.WriteLine("****************************************************\n");

        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\n Press Enter to continue!");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

    }
}