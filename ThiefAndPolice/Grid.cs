using ThiefAndPolice;

public class Grid
{
    public int X { get; set; }
    public int Y { get; set; }
    //public Person[,] Matrix { get; set; }

    //public Grid(int x, int y)
    //{
    //    X = x;
    //    Y = y;
    //}

    //public static int[,] CreateGrid(int SizeX, int SizeY, int[,] Matrix)
    //{
  
    //    Matrix = new int[SizeX, SizeY];

    //    return Matrix;
    //}

    public static void Print(int x, int y, Person[,]matrix)
    {

        for (int row = 0; row < x; row++) //loop x
        {
            for (int col = 0; col < y; col++) //loop y
            {
                if (matrix[row, col] == null)
                {
                    Console.Write(" ");
                }
                else if (matrix[row, col] is Thief)
                {
                    Console.Write("T");
                }
                else if (matrix[row, col] is Police)
                {
                    Console.Write("P");
                }
                else if (matrix[row, col] is Citizen)
                {
                    Console.Write("C");
                }

            }
            Console.WriteLine();
        }

    }

    public static void PrintPrison(int prisonX, int prisonY, Person[,] prisonMatrix)
    {

        for (int row = 0; row < prisonX; row++) //loop x
        {
            for (int col = 0; col < prisonY; col++) //loop y
            {
                if (prisonMatrix[row, col] == null)
                {
                    Console.Write(" ");
                }
                else if (prisonMatrix[row, col] is Thief)
                {
                    Console.Write("T");
                }
               

            }
            Console.WriteLine();
        }

    }

}