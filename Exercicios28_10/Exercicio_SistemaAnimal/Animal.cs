namespace Exercicio_SistemaAnimal
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string EmitirSom();
        public abstract string TipoAlimentacao();
    }
}