using System; 

class URI {

    static void Main(string[] args) {

        //https://www.beecrowd.com.br/judge/pt/problems/view/1070

        int valor = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 6; i++)
        {
            if(valor % 2 == 0)
            {
                valor++;
                System.Console.WriteLine(valor);
            }
            else{
                valor = valor + 2;
                System.Console.WriteLine(valor);
            }

            
        }

    }

}