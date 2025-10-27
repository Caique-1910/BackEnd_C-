namespace Atividade27_10
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        // {
        //     get
        //     {
        //         return AnoPublicacao;
        //     }

        //     set
        //     {
        //         if (value > 0)
        //         {
        //             AnoPublicacao = value;
        //         }
        //         else
        //         {
        //             Console.WriteLine("Ano de publicação inválido.");
        //         }
        //     }
        // }
        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; } = true;

        // Construtor
        // e um metodo especial, usado para inicializar o estado objeto
        public Livro( string tituloConstrutor, string autorConstrutor, int anoPublicacaoConstrutor, double precoConstrutor)
        {
            //this.titulo = tituloConstrutor;
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = anoPublicacaoConstrutor;
            Preco = precoConstrutor;

            //Definindo valor incial como true
            EstaDisponivel = true;
            
            Console.WriteLine($"Novo livro : {tituloConstrutor} criado e disponivel");
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("*****Detalhes do Livro*****");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
            Console.WriteLine($"Preço: R$ {Preco:F2}"); // Formatação para duas casas decimais :F2

            if (EstaDisponivel)
            {
                Console.WriteLine("Status: Disponível");
            }
            else
            {
                Console.WriteLine("Status: Indisponível");
            }
        }


        public void Emprestar()
        {
            if (EstaDisponivel)
            {
                EstaDisponivel = false;
                Console.WriteLine($"O livro {Titulo} foi emprestado");
            }
            else
            {
                Console.WriteLine($"O livro {Titulo} ja esta emprestado");
            }
        }
    }
}


