namespace taboada;

public class Program
{
    static void Main(string[] args)
    {
        //Ler um numero inteiro N, dai mostrar na tela a tabuada de N para 1 a 10, conforme exemplo

        int N, mult;
        
        Console.WriteLine("Seja bem vindo ao seu programa de tabuadas!");
        Console.WriteLine("Deseja a tabuada para qual valor ?");
        Console.Write("Tabuada do = ");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for(int i = 1; i <= 10; i++ )
        {
            mult = N * i;
            
            Console.WriteLine(N + " X " + i + " = " + mult);
        }

    }
}