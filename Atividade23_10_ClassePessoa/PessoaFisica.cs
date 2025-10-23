namespace Atividade23_10_ClassePessoa
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public override void PagarImposto()
        {
            Console.WriteLine($"Pessosa Fisica: {Nome}, Cpf: {CPF} - pagando imposto...");
        }
        

    }
}