namespace SistemaAnimalMVC.Models
{
    public class Leao : Animal
    {
        public Leao (){}
        public Leao(string nomeConstrutor) : base(nomeConstrutor){}

        public override string TipoAlimentacao() => "Carnivoro";
      
        public override string EmitirSom() => "grrr";
   

    }
}