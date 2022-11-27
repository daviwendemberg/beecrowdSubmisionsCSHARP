using System; 

class URI {

    static void Main(string[] args) {

        //https://www.beecrowd.com.br/judge/pt/problems/view/1066

        int valores, valoresPares = 0, valoresImpares = 0, valoresPositivos = 0, valoresNegativos = 0;

        for (int i = 0; i < 5; i++)
        {
            valores = Convert.ToInt32(Console.ReadLine());

            if(valores % 2 == 0)
                valoresPares++;
            if(valores % 2 == 1 || valores % 2 == -1)
                valoresImpares++;
            if(valores >= 1)
                valoresPositivos++;
            if(valores < 0)
                valoresNegativos++;
            
        }

        System.Console.WriteLine(	
                                $"{valoresPares} valor(es) par(es)\n" +
                                $"{valoresImpares} valor(es) impar(es)\n"+
                                $"{valoresPositivos} valor(es) positivo(s)\n"+
                                $"{valoresNegativos} valor(es) negativo(s)");
    }

}