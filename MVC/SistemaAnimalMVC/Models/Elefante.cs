namespace SistemaAnimalMVC.Models
{
    public class Elefante : Animal
    {
         public Elefante (){}
        public Elefante(string nomeConstrutor) : base(nomeConstrutor){}

        public override string TipoAlimentacao() => "Herbivoro";
      
        public override string EmitirSom() => "fuuuum uuuuh";
    }
}