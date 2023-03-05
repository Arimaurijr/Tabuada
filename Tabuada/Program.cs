//tabuada
internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        do
        {
            Console.WriteLine("Digite um número entre 1 e 9, inclusive o 1 e o 9");
            numero = int.Parse(Console.ReadLine());

        } while (numero < 1 || numero > 9);

        Console.WriteLine();
        Console.WriteLine("TABUDA DO " + numero);
        for(int i = 0; i <= 10; i++) 
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            //Console.WriteLine("{0} x {1} = {2}", escolha, numero, resultado);
        }
    }
}