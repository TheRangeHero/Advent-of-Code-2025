namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputReader inputReader = new InputReader();

            string input = inputReader.ReadLines("input.txt");
            Solver solver = new Solver();

            Console.WriteLine(solver.SolverTask01(input));
        }
    }

    internal class InputReader
    {
        public string ReadLines(string inputFile)
        {
            return File.ReadAllText(inputFile);
        }
    }

    internal class Solver
    {
        public int SolverTask01(string input)
        {

            int leftID;
            int rightID;

            string[] IDList = input.Split(",");

            foreach (string line in IDList)
            {
                string[] IDs = line.Split('-', 2);

                leftID = int.Parse(IDs[0]);
                rightID = int.Parse(IDs[1]);

                for (int i = leftID; i <= rightID; i++)
                {
                    string IDToCheck = i.ToString();
                    if (IDToCheck.Length % 2 != 0)
                    {
                        continue;
                    }

                    if (IDToCheck[0] == '0')
                    {
                        continue;
                    }


                }

            }


            return 0;
        }
    }
}
