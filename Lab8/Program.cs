using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;

namespace Lab8
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string[] students = new string[20]
            {
                "Jason",
                "Dylan",
                "Kim",
                "Albert",
                "Mike",
                "Danny",
                "Theresa",
                "Darshan",
                "Candace",
                "Sam",
                "Michael",
                "Adryenne",
                "Blake",
                "Joe",
                "James",
                "Thomas",
                "Ivan",
                "Anna",
                "Hannah",
                "Ciarra"
            };
            bool moreInfo = true;

            do
            {
                var studentName = IsStudentInClass(students);
                Console.WriteLine($"What Would you like to know about {studentName}? (Enter 'Hometown' or 'Favorite Food' or 'Favorite Baseball Team')");
                string firstUserDetail = Console.ReadLine();
                if (firstUserDetail.Equals("Hometown", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{studentName}'s hometown is {GetStudentHometown(studentName)}.");
                    moreInfo = DoesUserWantMore();
                }
                else if (firstUserDetail.Equals("Favorite Food", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{studentName}'s favorite food is {GetStudentFavoriteFood(studentName)}\n");
                    moreInfo = DoesUserWantMore();

                }
                else if (firstUserDetail.Equals("Favorite Baseball Team", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{studentName}'s favorite Baseball Team is {GetStudentFavoriteBaseballTeam(studentName)}\n");
                    moreInfo = DoesUserWantMore();
                }
                else
                {
                    Console.WriteLine("That data does not exist. Plese Try Again.\n");
                }
            } while (moreInfo);                     

        }

        public static string GetStudentFavoriteBaseballTeam(string studentName)
        {
            Dictionary<string, string> studentsFavortieBaseballTeam = new Dictionary<string, string>();
            studentsFavortieBaseballTeam["Jason"] = "Detroit Tigers";
            studentsFavortieBaseballTeam["Dylan"] = "Chicago Cubs";
            studentsFavortieBaseballTeam["Kim"] = "Milwaukee Brewers";
            studentsFavortieBaseballTeam["Albert"] = "Cleveland Indians";
            studentsFavortieBaseballTeam["Mike"] = "Pittsburgh Pirates";
            studentsFavortieBaseballTeam["Danny"] = "Boston Red Sox";
            studentsFavortieBaseballTeam["Theresa"] = "New York Yankees";
            studentsFavortieBaseballTeam["Darshan"] = "Chicago White Sox";
            studentsFavortieBaseballTeam["Candace"] = "Minnesota Twins";
            studentsFavortieBaseballTeam["Sam"] = "St Louis Cardinals";
            studentsFavortieBaseballTeam["Michael"] = "Tampa Bay Rays";
            studentsFavortieBaseballTeam["Adryenne"] = "Los Angeles Dodgers";
            studentsFavortieBaseballTeam["Blake"] = "Los Angeles Angels of Anaheim";
            studentsFavortieBaseballTeam["Joe"] = "Miami Marlins";
            studentsFavortieBaseballTeam["James"] = "Atlant Braves";
            studentsFavortieBaseballTeam["Thomas"] = "Arizona Diamondbacks";
            studentsFavortieBaseballTeam["Ivan"] = "Colorado Rockies";
            studentsFavortieBaseballTeam["Anna"] = "Baltimore Orioles";
            studentsFavortieBaseballTeam["Hannah"] = "San Diego Padres";
            studentsFavortieBaseballTeam["Ciarra"] = "New York Mets";

            return studentsFavortieBaseballTeam[studentName];
        }

        public static string GetStudentHometown(string studentName)
        {
            Dictionary<string, string> studentsHometown = new Dictionary<string, string>();
            studentsHometown["Jason"] = "Detroit";
            studentsHometown["Dylan"] = "Sterling Heights";
            studentsHometown["Kim"] = "Auburn Hills";
            studentsHometown["Albert"] = "Warren";
            studentsHometown["Mike"] = "Royal Oak";
            studentsHometown["Danny"] = "Detroit";
            studentsHometown["Theresa"] = "Southfield";
            studentsHometown["Darshan"] = "Livonia";
            studentsHometown["Candace"] = "Dearborn";
            studentsHometown["Sam"] = "Hamtramck";
            studentsHometown["Michael"] = "Flint";
            studentsHometown["Adryenne"] = "Macomb";
            studentsHometown["Blake"] = "Troy";
            studentsHometown["Joe"] = "Rochester";
            studentsHometown["James"] = "Northville";
            studentsHometown["Thomas"] = "Chesterfield";
            studentsHometown["Ivan"] = "St Clair Shores";
            studentsHometown["Anna"] = "Clinton Twp";
            studentsHometown["Hannah"] = "Utica";
            studentsHometown["Ciarra"] = "Armada";

            return studentsHometown[studentName];
        }

        public static bool DoesUserWantMore()
        {
            bool moreInfo = true;
            bool invalidInput = true;
            do
            {
                Console.WriteLine("Would you Like to Know About a Different Student? ('Yes' or 'No')");
                string userKeepGoing = Console.ReadLine();
                if (userKeepGoing.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    moreInfo = true;
                    invalidInput = false;
                }
                else if (userKeepGoing.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thank You!");
                    moreInfo = false;
                    invalidInput = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid selection\n");
                    invalidInput = true;
                }

                
            } while (invalidInput);
            return moreInfo;

        }

        public static string GetStudentFavoriteFood(string studentName)
        {
            Dictionary<string, string> studentsFavoriteFoods = new Dictionary<string, string>();
            studentsFavoriteFoods["Jason"] = "Hot Dog";
            studentsFavoriteFoods["Dylan"] = "Poutine";
            studentsFavoriteFoods["Kim"] = "Spaghetti";
            studentsFavoriteFoods["Albert"] = "Scrambled Eggs";
            studentsFavoriteFoods["Mike"] = "Pizza";
            studentsFavoriteFoods["Danny"] = "Chicken Wings";
            studentsFavoriteFoods["Theresa"] = "Tacos";
            studentsFavoriteFoods["Darshan"] = "Salmon";
            studentsFavoriteFoods["Candace"] = "Shwarma";
            studentsFavoriteFoods["Sam"] = "Sushi";
            studentsFavoriteFoods["Michael"] = "Cereal";
            studentsFavoriteFoods["Adryenne"] = "Hamburger";
            studentsFavoriteFoods["Blake"] = "Lamb";
            studentsFavoriteFoods["Joe"] = "Ice Cream";
            studentsFavoriteFoods["James"] = "Chicken Sandwich";
            studentsFavoriteFoods["Thomas"] = "Coney Dog";
            studentsFavoriteFoods["Ivan"] = "Pancakes";
            studentsFavoriteFoods["Anna"] = "Waffles";
            studentsFavoriteFoods["Hannah"] = "Steak";
            studentsFavoriteFoods["Ciarra"] = "Popcorn";

            return studentsFavoriteFoods[studentName];


        }



        static string IsStudentInClass(string[] students)
        {
            int formattedSelection = 0;
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-20)\n");
                int.TryParse(Console.ReadLine(), out int userSelection);
                formattedSelection = userSelection - 1;

                try
                {
                    Console.WriteLine($"Student {userSelection} is {students[formattedSelection]}");
                }
                catch (IndexOutOfRangeException x)
                {

                    Console.WriteLine($"That Student Does Not Exist. Please Try Again.\n {x.Message}");
                    continue;
                }  
                    

                keepLooping = false;              

            } 

            return students[formattedSelection];







        }
    }
}
