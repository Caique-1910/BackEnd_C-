namespace Classe_Abstrata
{
    public abstract class Forma
    {
        public abstract double CalcularArea();

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica.");
        }
    }
}