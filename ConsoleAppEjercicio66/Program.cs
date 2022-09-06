using System;

namespace ConsoleAppEjercicio66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertir de Decimal a Binario");
            var seguir = true;
            int nroIngresado;
            do
            {
                Console.Write("Ingrese un nro positivo:");
                if (!int.TryParse(Console.ReadLine(), out nroIngresado))
                {
                    Console.WriteLine("Nro mal ingresado");
                }else if (nroIngresado<=0)
                {
                    Console.WriteLine("El nro debe se positivo");
                }
                else
                {
                    seguir = false;
                }
            } while (seguir);

            var nroBinario = ConvertirABinario(nroIngresado);
            Console.WriteLine($"{nroIngresado} equivale a {nroBinario} en binario");
            Console.ReadLine();
        }

        private static string ConvertirABinario(int nro)
        {
            var binario = "";
            while (nro>0)
            {
                binario=string.Concat(Convert.ToString(nro % 2), binario);
                nro =(int) Math.Truncate((double)nro / 2);
            }

            return binario;
        }
    }
}
