using System.Runtime.CompilerServices;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputReader reader = new InputReader();

            var input = reader.ReadLines("input.txt");
            var solver = new Solver();
            int task1 = solver.SolverTask1(input);

        }
    }


    internal class InputReader
    {
        public string[] ReadLines(string fileName)
        {
            return File.ReadAllLines(fileName);
        }
    }

    internal class Solver
    {
        public int SolverTask1(string[] input)
        {
            int result = 0;
            int startPosition = 50;

            char direction;
            int dialNum;

            foreach (string line in input)
            {
                direction = (line[0]);
                dialNum = int.Parse(line.Substring(1));

                switch (direction)
                {
                    case 'L':
                        startPosition -= dialNum;
                        break;
                    case 'R':
                        startPosition += dialNum;
                        break;
                    default:
                        break;
                }


            }

            return 0;
        }
    }
}
