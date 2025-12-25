namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputReader inputReader = new InputReader();

            string input = inputReader.ReadLines("input.txt");
        }
    }

    internal class InputReader
    {
       public string ReadLines (string inputFile)
        { 
            return File.ReadAllText(inputFile);
        }
    }

    internal class Solver
    {
        public int SolverTask01(string input)
        {
            string[] IDList = input.Split(", ");




            return 0;
        }
    }
}
