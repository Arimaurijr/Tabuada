internal class Program
{
    private static void Main(string[] args)
    {
        int numero, indice = 0;

        void Entrada()
        {
            bool flag = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("NÚMERO INVÁLIDO !!!");
                    Console.WriteLine("DIGITE NOVAMENTE !!!");
                }

                Console.WriteLine("DIGITE UM NÚMERO ENTRE 1 E 9, INCLUSIVE 1 E 9");
                numero = int.Parse(Console.ReadLine());
                flag = true;

            } while (numero < 1 || numero > 9);
        }

        void Exibicao()
        {
            Console.WriteLine(numero + " X " + indice + " = " + (numero * indice));
            indice++;
        }

        void Iteracao()
        {
            for (int i = 0; i <= 10; i++)
            {
                Exibicao();
            }
        }

        Entrada();
        Iteracao();
    }
}