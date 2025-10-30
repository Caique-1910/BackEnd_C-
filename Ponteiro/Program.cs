/*------PONTEIROS------*/
namespace Ponteiro;

class Program
{
    static unsafe void Main()
    {
        int VariavelA = 10;
        Console.WriteLine($"Variavel: {VariavelA}");

        //ponteiro = &endereco da variavel
        int* ponteiro = &VariavelA;
        Console.WriteLine($"Endereco da memoria {(ulong)ponteiro}");

        *ponteiro = 75;
        Console.WriteLine($"Variavel: {VariavelA}");


        int[] numeros = { 10, 20, 30, 40 };

        fixed (int* pArray = numeros)
        {
            Console.WriteLine($"Endereco do array {(ulong)pArray}");
            Console.WriteLine($"array[0] {*(pArray)}");
            Console.WriteLine($"array[1] {*(pArray+1)}");
            Console.WriteLine($"array[2] {*(pArray+2)}");
            Console.WriteLine($"array[3] {*(pArray+3)}");
            Console.WriteLine($"array[4] {*(pArray + 4)}");
        }


    }
}
