namespace Atividade2_Classe_Abstrata
{
    public abstract class Forma
    {
        // metodo abstrato obriga a classe filha a implementar esse metodo
        // e sobrescreve-lo  (override)
        public abstract double CalcularArea();

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica.");
        }
    }
}