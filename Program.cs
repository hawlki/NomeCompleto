using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Por favor, digite seu primeiro nome:");
            String nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Agora digite seu sobrenome:");
            String sobrenome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("toque em uma tecla para prosseguir");
            Console.ReadKey();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Nome completo:");
            Console.WriteLine($"{nome} {sobrenome}");
            Console.Write("Nome de catalogo:");
            Console.WriteLine($"{sobrenome.ToUpper()} {nome}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("clique em uma tecla para finalizar o programa");
            Console.ReadKey();
            Console.Clear();









            













            
        }
    }
}
