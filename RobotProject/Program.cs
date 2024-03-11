namespace RobotProject
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //string file = @"D:\MyData\ASP.NETCORE\RobotProject\RobotProject\bin\Debug\net7.0\Robot.txt";
            //args = new string[] { file };
            // Automatically executes when application is started.
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please specify a .txt filepath.");
                return;
            }
            if (File.Exists(args[0]) && (Path.GetExtension(args[0]) == ".txt"))
            {
                string[] commands = File.ReadAllLines(args[0]);
                Program main = new Program();
                Console.WriteLine(main.Commander(commands));
            }
            else
            {
                Console.WriteLine("Not a .txt file. Please try again.");
                Console.Write(@"The correct command formats are as follows:PLACE X,Y,DIRECTION
                                                                           MOVE
                                                                           RIGHT
                                                                           LEFT
                                                                           REPORT
                                                                           -------------
                                                                           Please review your input file and try again.");
            }
        }

        public string Commander(string[] commands)
        {
            string message = "";
            Command obj = new Command();
            if (obj != null)
            {
                message = obj.Start(commands);
            }
            return message;
        }
    }
}
