namespace Exercicio_Hotel
{
    public class  Quarto
    {
        public int numero{ get; set; }
        public string tipo{ get; set; }
        public double precoDiaria{ get; set; }
        public bool Disponivel{ get; set; }

        public Quarto(int numero, string tipo, double precoDiaria)
        {
            numero = numero;
            tipo = tipo;
            precoDiaria = precoDiaria;
            Disponivel = true;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Número do Quarto: {numero}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Preço da Diária: {precoDiaria}");
            if (Disponivel)
            {
                Console.WriteLine($"Disponível: {Disponivel}");
            }
            else
            {
                Console.WriteLine("Quarto Indisponível");
            }
        }

        public void Ocupar()
        {
            Disponivel = false;
        }
        
        public void Liberar()
        {
            Disponivel = true;
        }
    }
}