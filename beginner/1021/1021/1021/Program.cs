using System;
using System.Globalization;
namespace _1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorMonetario, restoDaDivisao;
            valorMonetario = Convert.ToDecimal(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            decimal[] valorNotasMoedas, valorParaImprimir;
            valorNotasMoedas = new decimal[] { 100M, 50M, 20M, 10M, 5M, 2M, 1M, 0.50M, 0.25M, 0.10M, 0.5M, 0.1M };
            valorParaImprimir = new decimal[12];
            restoDaDivisao = valorMonetario;
            for(int i = 0; i < valorNotasMoedas.Length; i++)
            {
                valorParaImprimir[i] = restoDaDivisao / valorNotasMoedas[i];
                if(restoDaDivisao == 0)
                    valorParaImprimir[i] = 0;
                else
                {
                    if(restoDaDivisao % valorNotasMoedas[i] != 0)
                    restoDaDivisao = restoDaDivisao % valorNotasMoedas[i];
                }



            }
            
            for(int i = 0; i < 7;i++) 
            {
                if (i == 0) 
                {
                    System.Console.WriteLine("NOTAS:"); 
                }                

                Console.WriteLine($"{Math.Floor(valorParaImprimir[i])} nota(s) de {valorNotasMoedas[i]}");

            }
                        
            for(int i = 7; i < 12;i++) 
            {
                if (i == 7) 
                {
                    System.Console.WriteLine("MOEDAS:"); 
                }

                Console.WriteLine($"{Math.Floor(valorParaImprimir[i])} moeda(s) de {valorNotasMoedas[i]}");

            }

            Console.ReadKey();
        }
    }
}