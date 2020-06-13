using System;

namespace algorithm_v2.Graph
{
    public class Graphs
    {

        public int[,] CreateGraph()
        {
            int[,] adjMatrix = new int[3, 3];

            for (int i = 0; i < adjMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < adjMatrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        adjMatrix[i, j] = 0;
                    }
                    else
                    {
                        adjMatrix[i, j] = 1;
                    }
                }
            }

            return adjMatrix;
        }

        public void TraverseGraph(int[,] adjMatrix)
        {
            for (int i = 0; i < adjMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < adjMatrix.GetLength(1); j++)
                {
                    Console.Write(adjMatrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        public void ShowNieghbours(int v, int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = v; col < v + 1; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        sum++;
                    }
                }
            }

            Console.WriteLine("Vertices = {0} , Neigh = {1}", v, sum);
        }
    }
}