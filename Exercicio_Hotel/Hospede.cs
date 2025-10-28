namespace Exercicio_Hotel
{
    public class Hospede
    {
        public string nome { get; set; }
        public string CPF { get; set; }
        public string telefone { get; set; }
        public Hospede(string nome, string CPF, string telefone)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.telefone = telefone;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Telefone: {telefone}");
        }
    }
}