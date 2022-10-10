
namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing variable that the users be using
            // will be stored as a folat incase someone wants to say they are 18.5 for example
            float age;
            //"\x1B[4m" will start underlined text and "\x1B[0m" will stop highlighting
            // I have made this a variable instead of just staticly having it set in code
            // to make it easy to change the name and age of a different movie
            string movieName = "\u001b[4mVenom\u001b[0m";
            int ageRequirment = 15;


            Console.WriteLine("The film you want to see is " + movieName);
            Console.WriteLine("Enter your age: ");
            //if the program is unable to convert the string(console.readline) then the try catch statment will catch the error and display
            //an error message
            try
            {
                //reads the input user inputs and sets it to var age
                age = float.Parse(Console.ReadLine());
                //check if user has entered a negative number
                if (age < 0)
                {
                    Console.WriteLine("Your input is invalid(less tan 0)");
                }

                //check if user is under the age you need to be to watch movie
                else if (age < ageRequirment)
                {
                    Console.WriteLine("You are not old enough to watch " + movieName);
                }
                //all other input should be above and valid which means that the user s able to watch the movie
                else
                {
                    Console.WriteLine("You can watch " + movieName);
                }
            }// will cath the error that will be thrown by float.parse if the user input is not an intiger
            catch
            {
                Console.WriteLine("Your input is invalid (is not intiger)");
            }

        }
    }
}