namespace Exercicio_SistemaCursos
{
    public class CursoTecnico : Curso
    {
        public override double CalcularPreco() => Horas * 20.0;

    }
}