namespace Atividade27_10;

class Program
{
    static void Main(string[] args)
    {
        // // Sem construtor
        // Livro novolivro = new Livro(); //sem parametros

        // Console.WriteLine($"Titulo: {novolivro.Titulo}");
        // Console.WriteLine($"Ano : {novolivro.AnoPublicacao}");
        // Console.WriteLine($"Disponivel: {novolivro.EstaDisponivel}");

        // // Colocando valores manualmente
        // novolivro.Titulo = "O Poder do Construtor";
        // novolivro.Autor = "Parceiro de Programação";
        // novolivro.AnoPublicacao = 2025;
        // novolivro.Preco = 59.90;
        // novolivro.EstaDisponivel = true;

        // Console.WriteLine("Exibindo detalhes do livro:");
        // novolivro.ExibirDetalhes();

        // Com construtor
        Console.WriteLine(">>> Sistem de controle de biblioteca <<<");

        //Criando obejto novo com construtor
        Livro livro1 = new Livro("A Arte da guerra", "Sun Izu", 1950, 45.90);
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899, 30.50);

        //Interacao com os Livros - emprestar / Ver detalhes
        Console.WriteLine("Interagindo com o livro 1");
        livro1.ExibirDetalhes();
        livro1.Emprestar();
        livro1.ExibirDetalhes();
        livro1.Emprestar();

        Console.WriteLine("\nInteragindo com o livro 2");
        livro2.ExibirDetalhes();
        livro2.Preco = 32.99; // Atualizando preco
        Console.WriteLine($"Atualizacacao de preco {livro2.Titulo} para R$ {livro2.Preco:F2}");
        livro2.ExibirDetalhes();
    }
}
