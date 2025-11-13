using System.ComponentModel.DataAnnotations;


namespace SistemaAnimalMVC.Models
{
    public abstract class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required] // Obriga a passar um nome
        public string Nome{ get; set; } = string.Empty;

        public Animal() { }
        public Animal(string nomeConstrutor)
        {
            Nome = nomeConstrutor;
        }

        public abstract string EmitirSom();
        public abstract string TipoAlimentacao();
    }
}