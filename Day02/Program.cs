namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputReader inputReader = new InputReader();

            string[] input = inputReader.ReadLines("input.txt");
        }
    }

    internal class InputReader
    {
       public string[] ReadLines (string inputFile)
        { 
            return File.ReadAllLines(inputFile);
        }
    }

    internal class Solver
    {
        public int SolverTask01(string[] input)
        {





            return 0;
        }
    }
}
