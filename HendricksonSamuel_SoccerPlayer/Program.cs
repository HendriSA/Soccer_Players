using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace HendricksonSamuel_SoccerPlayer
{
    //Name: Samuel Hendrickson
    //Date: 2/27/2020
    //Purpose: Soccer Player Object Class

    class Program
    {
        

        static void Main(string[] args)
        {
            int temp; //int variable for tryparse output

            SoccerPlayer soccerPlayer1 = new SoccerPlayer(); //instantiating a new SoccerPlayer object with the Default Constructor

            //Object initializer to assign values to the properties of the class at the time of instantiation
            SoccerPlayer soccerPlayer2 = new SoccerPlayer {PlayerName = "Katie Schuler", JerseyNumber = 1, GoalsScored = 24, AssistsMade = 19 };

            SoccerPlayer soccerPlayer3 = new SoccerPlayer(); //instantiating a new SoccerPlayer object

            //Assigning the values of each property individually for soccerPlayer3:
            soccerPlayer3.PlayerName = "Joe Johnson";
            soccerPlayer3.JerseyNumber = 14;
            soccerPlayer3.GoalsScored = 10;
            soccerPlayer3.AssistsMade = 32;

            SoccerPlayer soccerPlayer4 = new SoccerPlayer(); //instantiating a new (4th) SoccerPlayer object

            WriteLine("Enter the 4th soccer player's name: "); //Prompting user for soccer players name
            soccerPlayer4.PlayerName = ReadLine(); //assigning userinput to the PlayerName property for this object

            do // while the user fails to enter a proper format the loop body will execute (will always execute atleast once)
            {
                WriteLine("Enter the soccer player's jersey number: "); //Prompting user for soccer jersey number
                int.TryParse(ReadLine(), out temp); //Trying to parse, if it succeeds it continues, if it fails returns a 0 (false bool)


                if (temp != 0) //if parse is successful the if statement body executes
                {
                    soccerPlayer4.JerseyNumber = temp; //assigns the temp value to the JerseyNumber property for soccerPlayer4
                }
                else //if the parse fails than else statement body executes
                {
                    WriteLine("\n**Incorrect format, please try again - enter an integer**"); //Telling user to try again
                    WriteLine("");
                }
            } while (temp == 0);

            do // while the user fails to enter a proper format the loop body will execute (will always execute atleast once)
            {
                WriteLine("Enter the soccer player's number of goals scored: "); //Prompting user for number of goals scored
                int.TryParse(ReadLine(), out temp); //Trying to parse, if it succeeds it continues, if it fails returns a 0 (false bool)


                if (temp != 0) //if parse is successful the if statement body executes
                {
                    soccerPlayer4.GoalsScored = temp; // assigns the temp value to the JerseyNumber property for soccerPlayer4
                }
                else //if the parse fails than else statement body executes
                {
                    WriteLine("\n**Incorrect format, please try again - enter an integer**"); //Telling user to try again
                    WriteLine("");
                }
            } while (temp == 0);

            do // while the user fails to enter a proper format the loop body will execute (will always execute atleast once)
            {
                WriteLine("Enter the soccer player's number of assists made: "); //Prompting user for number of assists made
                int.TryParse(ReadLine(), out temp); //Trying to parse, if it succeeds it continues, if it fails returns a 0 (false bool)


                if (temp != 0) //if parse is successful the if statement body executes
                {
                    soccerPlayer4.AssistsMade = temp; // assigns the temp value to the JerseyNumber property for soccerPlayer4
                }
                else //if the parse fails than else statement body executes
                {
                    WriteLine("\n**Incorrect format, please try again - enter an integer**"); //Telling user to try again
                    WriteLine("");
                }
            } while (temp == 0);

            SoccerPlayer soccerPlayer5 = new SoccerPlayer ("Keisha Jones",8); //initialize new SoccerPlayer object and send arguments to the OVERLOADED constructor

            DisplayMotto(); //calling the DisplayMotto() Method
            DisplayPlayerInfo(soccerPlayer1); //calling the DisplayPlayerInfo() Method and passing soccerPlayer1 to it
            DisplayPlayerInfo(soccerPlayer2); //calling the DisplayPlayerInfo() Method and passing soccerPlayer2 to it
            DisplayPlayerInfo(soccerPlayer3); //calling the DisplayPlayerInfo() Method and passing soccerPlayer3 to it
            DisplayPlayerInfo(soccerPlayer4); //calling the DisplayPlayerInfo() Method and passing soccerPlayer4 to it
            DisplayPlayerInfo(soccerPlayer5); //calling the DisplayPlayerInfo() Method and passing soccerPlayer5 to it

            ReadKey(); //Keeps window open
        }

        private static void DisplayPlayerInfo(SoccerPlayer sp) //Method to display soccer player info
        {
            //Displaying each property of the SoccerPlayer:
            WriteLine("Name: {0}",sp.PlayerName);
            WriteLine("Jersey Number: {0}", sp.JerseyNumber);
            WriteLine("Goals Scored: {0}", sp.GoalsScored);
            WriteLine("Assists Made: {0}", sp.AssistsMade);
            WriteLine("Bonus: {0:C}", sp.BonusAmount);
            WriteLine(" ");
        }
        public static void DisplayMotto() //Method to display SoccerPlayer MOTTO 
        {
            WriteLine("");
            WriteLine("Alfred State Aardvarks: {0}\n", SoccerPlayer.MOTTO); //Displaying the motto string field from the SoccerPlayer class
        }
    }
    class SoccerPlayer //Class for defining SoccerPlayer Objects
    {
        public const string MOTTO = "Always do what you’re afraid to do!"; //Public constant string field to hold the MOTTO
        private const int MIN_GOALS = 20; //Private constant integer field to hold the number of goals that a player must exceed to recieve a bonus

        //Declaring private instance variables:
        private string playerName; 
        private int jerseyNumber;
        private int goalsScored;
        private int assistsMade;
        private double bonusAmount;
        


        public string PlayerName //Public Field property for player name: provides access to the playerName field, assigns the players name and returns the field value
        { get; set; } 
        public int JerseyNumber //Public Field property for jersey number: provides access to the jerseyNumber field, assigns the jersey number and returns the field value
        { get; set; } 
        public int GoalsScored //Public Field property for the number of goals scored: provides access to the goalsScored field and defines how the field will be set and retrieved
        {
          get //retrieving the stored values:
            {
                return goalsScored;
                
            }
              
          set //setting the value of the goalsScored field:
            {
                goalsScored = value; //assign the goalsScored field value to the value assigned in MAIN()
                
                if (GoalsScored > MIN_GOALS) //if the number of goals scored is greater than the value within the MIN_GOALS constant than the body of the IF statement runs
                {
                    bonusAmount = 1000; //assigns a value of 1000 to the bonus amount field
                }
                else //if the number of goals scored is NOT greater than the value within the MIN_GOALS constant than the body of the IF statement runs
                {
                    bonusAmount = 0; //Assigns a bonus of 0 to the bonusAmount field
                }
                
            }     
        }
        public int AssistsMade //Public Field property for number of assists: provides access to the assistsMafe field, assigns the number of assists and returns the field value
        { get; set; }

        public double BonusAmount //readonly 
        {
            get
            {
                return bonusAmount;
            } //returns the bonus amount
        }

        public SoccerPlayer() // default/parameterless constructor used to instantiate (create an instance of) objects
        {
            PlayerName = "Sam Hendrickson"; //default value is set
            JerseyNumber = 0; //default value is set
            GoalsScored = 0; //default value is set
            AssistsMade = 0; //default value is set
        }
        public SoccerPlayer(string playerName, int jerseyNumber) //OVERLOADED constructor to accept only the PlayerName and Jersey Number and set the other fields to ten
        {
            PlayerName = playerName; //assigns name: “Keisha Jones”, to the PlayerName Property
            JerseyNumber = jerseyNumber; //assigns jersey number: “8”, to the JerseyNumber Property
            GoalsScored = 10;
            AssistsMade = 10;
        }
    }
}
