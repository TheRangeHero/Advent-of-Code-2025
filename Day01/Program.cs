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
            Console.WriteLine(solver.SolverTask1(input));
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
            int lowerDialLimit = 0;
            int upperDialLimit = 99;

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

                        if (startPosition < lowerDialLimit)
                        {
                            startPosition = startPosition % 100;
                            startPosition = 100 + startPosition;

                            if (startPosition == 100)
                            {
                                startPosition = 0;
                            }
                        }
                        break;
                    case 'R':
                        startPosition += dialNum;

                        if (startPosition > upperDialLimit)
                        {
                            startPosition = startPosition % 100;
                        }

                        break;
                    default:
                        break;
                }

                if (startPosition == 0)
                {
                    result++;
                }

            }

            return result;
        }
    }
}
