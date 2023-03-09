using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];
        int somal1 = 0;
        int somal2 = 0;
        int somal3 = 0;
        int somal4 = 0;
        int somal5 = 0;
        int somac1 = 0;
        int somac2 = 0;
        int somac3 = 0;
        int somac4 = 0;
        int somac5 = 0;

        LerMatriz(mat);


        void LerMatriz(int[,] x)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($" Matriz[{i},{j}] : ");
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(x[i, j] + " ");
                    if (i == 0)
                    {
                        somal1 += x[i, j];
                    }
                    if (i == 1)
                    {
                        somal2 += x[i, j];
                    }
                    if (i == 2)
                    {
                        somal3 += x[i, j];
                    }
                    if (i == 3)
                    {
                        somal4 += x[i, j];
                    }
                    if (i == 4)
                    {
                        somal5 += x[i, j];
                    }
                    if (j == 0)
                    {
                        somac1 += x[i, j];
                    }
                    if (j == 1)
                    {
                        somac2 += x[i, j];
                    }
                    if (j == 2)
                    {
                        somac3 += x[i, j];
                    }
                    if (j == 3)
                    {
                        somac4 += x[i, j];
                    }
                    if (j == 4)
                    {
                        somac5 += x[i, j];
                    }
                }
                Console.WriteLine();

            }
            Console.Write("Diagonal pricipal: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        Console.Write(x[i, j]);
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Diagonal secundaria: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(x[i,4 - i] + "");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Soma 1 linha:" + somal1 + ", Soma 2 linha: " + somal2 +
            ", Soma 3 linha:" + somal3 + ", Soma 4 linha: " + somal4 + ", Soma 5 linha: " + somal5);
        Console.WriteLine("Soma 1 coluna:" + somac1 + ", Soma 2 coluna: " + somac2 +
            ", Soma 3 coluna:" + somac3 + ", Soma 4 coluna: " + somac4 + ", Soma 5 coluna: " + somac5);

    }
}