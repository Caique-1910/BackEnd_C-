namespace Exercicio_SistemaCursos;

class Program
{
    static void Main(string[] args)
    {
        Curso cursoTec = new CursoTecnico { Nome = "Desenvolvimento de Sistemas", Horas = 1200 };
        Curso cursoSup = new CursoSuperior { Nome = "Engenharia de Softwares", Horas = 3200 };

        Console.WriteLine(cursoTec.ExibirResumo());
        Console.WriteLine("\n" + cursoSup.ExibirResumo());
    }
}
