namespace Exercicio_SistemaCursos
{
    public class CursoSuperior : Curso
    {
        public override double CalcularPreco() => Horas * 40.0;
    }
}