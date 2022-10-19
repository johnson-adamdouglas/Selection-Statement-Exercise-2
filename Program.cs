namespace SelectionStatementExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var faveSubject = Console.ReadLine().ToLower();

            switch (faveSubject)
            {
                case "math":
                    Console.WriteLine("I love math!");
                    break;
                case "english":
                    Console.WriteLine("english is awesome!");
                    break;
                case "science":
                    Console.WriteLine("science is great!");
                    break;
                case "history":
                    Console.WriteLine("ugh... history...");
                    break;
                case "music":
                    Console.WriteLine("music is my favorite too!");
                    break;
                default: Console.WriteLine("hmmm... I'm not sure about that one.");
                    break;
            }


        }
    }
}
