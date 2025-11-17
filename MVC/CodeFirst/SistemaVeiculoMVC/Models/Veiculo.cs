using System.ComponentModel.DataAnnotations;

namespace SistemaVeiculoMVC.Models
{
    public abstract class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required] // Obriga a passar um nome
        public string Modelo { get; set; } = string.Empty;

        public string Ano { get; set; }

        public string Tipo { get; set; }

        public Veiculo() { }
        public Veiculo(string modeloConstrutor, string anoConstrutor, string tipoConstrutor)
        {
            Modelo = modeloConstrutor;
            Ano = anoConstrutor;
            Tipo = tipoConstrutor;
        }

        public abstract double CalcularRevisao();
    }
}