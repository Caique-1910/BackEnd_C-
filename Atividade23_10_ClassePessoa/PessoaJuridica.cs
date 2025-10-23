namespace Atividade23_10_ClassePessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public override void PagarImposto()
        {
            Console.WriteLine($"Pessosa Juridica: {RazaoSocial}, CNPJ: {CNPJ} - pagando imposto...");
        }
        
    }
}