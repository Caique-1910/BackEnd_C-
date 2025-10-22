namespace Atividade2_Classe_Abstrata
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        public override double CalcularArea() => Largura * Altura;
    }
}