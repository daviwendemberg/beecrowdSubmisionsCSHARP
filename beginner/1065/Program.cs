using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) {

        int valoresPares = 0, valor;
        for (int i = 0; i < 5; i++)
        {
            valor = Convert.ToInt32(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            if(valor % 2 == 0)
            {
                valoresPares++;
            }
        }

        System.Console.WriteLine($"{valoresPares} valores pares");


    }

}