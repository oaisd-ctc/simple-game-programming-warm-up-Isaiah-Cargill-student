using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
        //there are 10 levels
        //in every level you roll a 6-sided dice
        //whoever rolls a higher number wins the round
        //whoever won the most rounds wins
        RoundNumber(1);
    }

    public static void RoundNumber(int roundNumber)
    {
        int userScore = 0;

        int rivalScore = 0;

        while (roundNumber < 11)
        {



            Random rivalRoll = new Random();

            int rival = rivalRoll.Next(1, 7);

            Random userRoll = new Random();

            int user = userRoll.Next(1, 7);

            Console.WriteLine("round " + roundNumber);

            Console.WriteLine("Rival rolled a " + rival);

            Console.WriteLine("press any key to roll the dice");

            Console.WriteLine("you rolled a " + user);



            if (rival > user)
            {
                Console.WriteLine("The Rival won this round.");
                rivalScore++;
            }
            else if (user > rival)
            {
                Console.WriteLine("you won this round");
                userScore++;
            }
            else
            {
                Console.WriteLine("This round is a draw!");
            }

            Console.WriteLine("the score is now - you: " + userScore + " Rival:" + rivalScore);





            roundNumber++;
        }

        if (userScore > rivalScore)
        {
             Console.WriteLine("Game over");

             Console.WriteLine("the score is now - you: " + userScore + " Rival:" + rivalScore);


            Console.WriteLine("You won!");
        }
        else if (rivalScore > userScore)
        {
           Console.WriteLine("Game over");

             Console.WriteLine("the score is now - you: " + userScore + " Rival:" + rivalScore);


            Console.WriteLine("You lost!");


        }

        else
        {
            Console.WriteLine("This game is a draw");
        }


    }
}
