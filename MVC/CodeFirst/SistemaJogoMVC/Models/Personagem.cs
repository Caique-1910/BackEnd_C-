using System.ComponentModel.DataAnnotations;

namespace SistemaJogoMVC.Models
{
    public abstract class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public int Nivel{ get; set; }

        public string Tipo{ get; set; }

        public Personagem() { }
        public Personagem(string nomeConstrutor, int nivelConstrutor, string tipoConstrutor)
        {
            Nome = nomeConstrutor;
            Nivel = nivelConstrutor;
            Tipo = tipoConstrutor;
        }

        public abstract int CalcularPoder();

        public string ExibirStatus()=> $"{Nome} tem {Nivel} no jogo";
    }
}