namespace Exercicio_Hotel
{
    public class Hospede
    {
        public string nome;
        public string CPF;
        public string telefone;

        public Hospede(string nome, string CPF, string telefone)
        {
            nome = "";
            CPF = "";
            telefone = "";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"CPF: {CPF}" );
            Console.WriteLine($"Telefone: {telefone}" );
        }
    }
}