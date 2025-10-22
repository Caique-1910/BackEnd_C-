
namespace Atividade1_Classe_Normal
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        // Virtual - vamos utilizar o metodo em outras classes, podendo ser sobrescrito
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome} e tenho {Idade} anos.");
        }

    }
}