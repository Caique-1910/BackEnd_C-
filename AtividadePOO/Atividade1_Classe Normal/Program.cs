namespace Atividade1_Classe_Normal
{

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa
            {
                Nome = "Joao",
                Idade = 25
            };

            Aluno a = new Aluno
            {
                Nome = "Maria",
                Idade = 20,
                Curso = "Engenharia"
            };

            p.Apresentar();
            a.Apresentar();
        }
    }
}
