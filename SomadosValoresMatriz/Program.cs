using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];

        Random sorteio = new Random();

        //Carregar valores na matriz
        for (int c = 0; c < mat.GetLength(1); c++)
        {
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                mat[l, c] = sorteio.Next(1000);
            }
        }
        //Calculo da soma das linhas
        Console.WriteLine("Soma das linhas...");
        for (int l = 0; l < mat.GetLength(0); l++)
        {
            Console.Write("Linha [" + l + "]= ");
            int somalinha = 0;
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                somalinha += mat[l, c];
            }
            Console.WriteLine(somalinha);
        }

        //Calculo da soma das colunas
        Console.WriteLine("Soma das Colunas...");
        for (int c = 0; c < mat.GetLength(1); c++)
        {
            Console.Write("Soma da coluna [" + c + "]= ");
            int somacoluna = 0;
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                somacoluna += mat[l, c];
            }
            Console.WriteLine(somacoluna);
        }

        //Soma diagonal principal
        Console.WriteLine("Soma da Diagonal principal...");
        int diagonal = 0;
        for (int c = 0; c < mat.GetLength(1); c++)
        {
            diagonal += mat[c, c];
        }
        Console.WriteLine(diagonal);

        //Soma diagonal secundária
        Console.WriteLine("Soma da Diagonal principal...");
        diagonal = 0;
        for (int c = 0; c < mat.GetLength(1); c++)
        {
            diagonal += mat[c, mat.GetLength(1)-c-1];
        }
        Console.WriteLine(diagonal);

        //Impressao da matriz
        Console.WriteLine("Os valores da matriz são: ");
        for (int l = 0; l < mat.GetLength(0); l++)
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(" \tmat[" + l + "][" + c + "] =" + mat[l, c].ToString("d3"));
            }
            Console.WriteLine();
        }
    }
}
