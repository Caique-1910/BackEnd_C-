namespace AtividadePOO
{
    public class Aluno : Pessoa
    {
        public string Curso;
        public override void Apresentar()
        {
            Console.WriteLine($"Sou aluno a {Nome}, tenho {Idade} anos e estudo {Curso}.");
        }

    }
}