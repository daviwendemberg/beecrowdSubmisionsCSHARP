using System; 

class URI {

    static void Main(string[] args) {

        //https://www.beecrowd.com.br/judge/pt/problems/view/1072

        
        int valoresIn = 0, valoresOut = 0, n, x;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            x = Convert.ToInt32(Console.ReadLine());
            if(x >= 10 && x <= 20)
                valoresIn++;
            else{
                valoresOut++;
            }
        }

        System.Console.WriteLine($"{valoresIn} in \n"+
                                 $"{valoresOut} out");


    }

}