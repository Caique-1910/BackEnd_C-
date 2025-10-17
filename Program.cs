namespace BackEnd_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao sistema.");

        //Entrada de dados
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOlá, {nome}! Você tem {idade} anos.");

        if (idade < 18)
        {
            Console.WriteLine("Você ainda é menor de idade.");
        }
        else
        {
            Console.WriteLine("Você ja é maior de idade.");
        }

        //Menu
        Console.WriteLine("\nEscolha uma opção: ");
        Console.WriteLine("1 - Ver a tabuada de um numero");
        Console.WriteLine("2 - Contar ate um numero");
        Console.WriteLine("3 - Fazer a sequência de Fibonacci");
        Console.WriteLine("4 - Sair");
        Console.WriteLine("Digite a opção: ");

        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            //Menu de opcoes

            // Opcao 1: Tabuada: Utilizei uma estrutura de repeticao "for" para contar de 1 a 10 e fazer a multiplicacao do numero colocado pelo usuario
            case 1: 
                Console.WriteLine("Digite um numero para ver a tabuada:");
                int numero = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
                break;

            // Opcao 2: Contar ate um numero: Utilizei uma estrutura de repeticao "for" para contar de 1 ate o numero colocado pelo usuario
            case 2:
                Console.WriteLine("Digite um numero para contar ate ele:");
                int contarAte = int.Parse(Console.ReadLine());
                for (int i = 1; i <= contarAte; i++)
                {
                    Console.WriteLine(i);
                }
                break;

            // Opcao 3: Sequencia de Fibonacci: Utilizei uma estrutura de repeticao "for" para gerar a sequencia de Fibonacci ate o numero de termos colocado pelo usuario
            case 3:
                Console.WriteLine("Digite quantos termos da sequência de Fibonacci você quer ver:");
                int termos = int.Parse(Console.ReadLine());
                int a = 0;
                int b = 1;
                Console.WriteLine("Sequência de Fibonacci:");
                for (int i = 0; i < termos; i++)
                {
                    Console.WriteLine(a);
                    int proximo = a + b;
                    a = b;
                    b = proximo;
                }
                break;

            // Opcao 4: Simplesmente encerra o programa
            case 4:
                Console.WriteLine("Ate logo");
                break;

            // Caso o querido do usuario nao coloque um numero valido, o programa avisa e encerra
            default:
                Console.WriteLine("Opcao Invalida");
                break;
        }

    }
}