namespace Assignment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Input the size of the square matrix (less than 5): "); 
            int size = int.Parse(Console.ReadLine()); 
            if (size >= 5) 
            { 
                Console.WriteLine("Size must be less than 5."); 
                return; 
            }
			int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];
            int[,] sumMatrix = new int[size, size]; 
            // Input elements in the first matrix
            Console.WriteLine("Input elements in the first matrix:"); 
            for (int i = 0; i < size; i++) 
            { 
                for (int j = 0; j < size; j++) 
                { 
                    Console.Write($"element - [{i}],[{j}] : "); 
                    matrix1[i, j] = int.Parse(Console.ReadLine()); 
                } 
            } 
            // Input elements in the second matrix
            Console.WriteLine("Input elements in the second matrix:"); 
            for (int i = 0; i < size; i++) 
            { 
                for (int j = 0; j < size; j++) 
                { 
                    Console.Write($"element - [{i}],[{j}] : "); 
                    matrix2[i, j] = int.Parse(Console.ReadLine()); 
                } 
            } 
            // Adding the two matrices
            for (int i = 0; i < size; i++) 
            { 
                for (int j = 0; j < size; j++) 
                { 
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j]; 
                } 
            } 
            // Display the first matrix
            Console.WriteLine("\nThe First matrix is:"); 
            PrintMatrix(matrix1, size); 
            // Display the second matrix
            Console.WriteLine("\nThe Second matrix is:"); 
            PrintMatrix(matrix2, size); 
            // Display the sum of the two matrices
            Console.WriteLine("\nThe Addition of two matrix is:"); 
            PrintMatrix(sumMatrix, size); 
        } 
        static void PrintMatrix(int[,] matrix, int size) 
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
		}
    }
}
