class Program
{

    /// <summary>
    /// Clase Principal por la cual se inicializa la aplicacion
    /// <author>DMN 17/01/2024</author>
    /// </summary>
    /// <param name="args"></param>

    static void Main(String[] args)
    {

        /// <summary>
        /// Metodo por el cual la aplicacion se inicializa
        /// <author>DMN 17/01/2024</author>
        /// </summary>
        /// <param name="args"></param>


        int[] arrayEnteros = { 10, 45, 60, 6, 7, 3, 2, 10 };

        Console.WriteLine("Tamaño del arrya");
        Console.WriteLine(arrayEnteros.Length);

        Console.WriteLine("Valor de la primera posicion");
        Console.WriteLine(arrayEnteros[0]);

        Console.WriteLine("Valor de la primera ultima posicion");
        Console.WriteLine(arrayEnteros[6]);

        Console.WriteLine("Valor de la primera ultima posicion");
        Console.WriteLine(arrayEnteros[7]);

        Console.WriteLine("Ordenar los valores de un array");
        Array.Sort(arrayEnteros);
    
        Console.WriteLine("Modificacion de la ultima posicion por el valor 100");
        arrayEnteros[7] = 100;

        Console.WriteLine("Ordenar de forma descendente el Array");
        Array.Reverse(arrayEnteros);


        int[] arrayEnteros02 = { 45, 56, 2, -1, 98, 34 };

        Console.WriteLine("Longitud de Array");
        Console.WriteLine(arrayEnteros.Length);

        Console.WriteLine("Valor de la Primera Posicion");
        Console.WriteLine(arrayEnteros02[0]);

        Console.WriteLine("Valor de la Penultima Posicion");
        Console.WriteLine(arrayEnteros02[4]);

        Console.WriteLine("Valor de la Ultima Posicion");
        Console.WriteLine(arrayEnteros02[5]);


    }


}