namespace SubstituicaoLiskov_L
{
    public abstract class Ave
    {
        public abstract void Mover();
        public void Dormir() => Console.WriteLine("Dormindo...");
    }
}