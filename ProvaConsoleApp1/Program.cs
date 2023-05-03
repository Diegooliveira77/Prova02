using ProvaConsoleApp1.ModuloConta;
using ProvaConsoleApp1.ModuloGarcom;
using ProvaConsoleApp1.ModuloMesa;

namespace ProvaConsoleApp1;

internal class Program
{

    static void Main(string[] args)
    {
        RepositorioGarcom repositorioGarcom = new RepositorioGarcom();
        TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
        RepositorioMesa repositorioMesa = new RepositorioMesa();
        TelaMesa telaMesa = new TelaMesa(repositorioMesa);
        RepositorioConta repositorioConta = new RepositorioConta();
        
        bool continuar = true;
        while (continuar)

        {

            MostrarMenu();
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "s":
                    continuar = false;
                    break;
                case "1":
                    telaGarcom.Opcoes();
                    break;
                case "2":
                    telaMesa.Opcoes();
                
                    Console.ReadLine();
                    continue;
            }
        }
    }

    static void MostrarMenu()
    {
        string[] menu =
        {
            "Gerenciamento de Bar",
            "s-Sair",
            "1-Cadastrar Garçom",
            "2-Cadastrar Mesa",
            "3-Cadastrar Conta",
        };
        Console.Clear();
        foreach (string opcao in menu)
        {
            Console.WriteLine(opcao);
        }

       
    }
}
