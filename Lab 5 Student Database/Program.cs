using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab_5_Student_Database
{
    public class Program
    {
        
        //Ask usuer if they would like to go again. Would the user like to see the complete student list?
        //get index # from user input 1-5. To get index, subtract 1 from the number they entered. Or create if statements and plus in specific index.
        //if category does not exist.. add if else statement to prompt a correct answer. 

     
        public static void Main()
        {

            Console.WriteLine(" Student Database for: Culinary School of Issues: ");
            
            Console.WriteLine("Please enter a valid student ID number (1-5): ");

            int studentID = Int32.Parse(Console.ReadLine());

           

            if(studentID < 1 || studentID > 5 )
            {
                Console.WriteLine(" This is not a valid student ID entry. \n Please select from students 1-5. ");
                Console.WriteLine();
                Main();
                
            }
            
               //------------------------[0]----------------[1]-----------------[2]---------------[3]-------------[4]----------
            string[] students ={ " Jamie Oliver, ", " Anthony Bourdain, ", " Wolfgang Puck, ", " Gordon Ramsey, ", " Paula Deen, " };
            
            string[] homeTown = { "Clavering, Essex, ", "New York City, NY, ", "Sankt Veit an der Glan, Australia, ", "Johnstone, Scotland, ", "Albany, GA, " };

            string[] favFoods = { "Spaghetti to forget his regretti, ", "Pastrami SandWiches, ", "Macarons, ", "Roast Beef and fear, ", "Meatballs and BUTTER, " };

            //PrintCategory(students);// Gets method from below to print out array up top.

            if (studentID == 1 && NextChoice())
            {
                Console.WriteLine(students[0] + " was born and raised in " + homeTown[0]);
                GoAgain();
                
            }
            else if(studentID == 1)
            {
                Console.WriteLine(students[0] + " survives mainly on a diet of " + favFoods[0]);
                GoAgain();
            }

         
            if (studentID == 2 && NextChoice())
            {
                Console.WriteLine(students[1] + " was born and raised in " + homeTown[1]);
                GoAgain();
            }
            else if(studentID ==2)
            {
                Console.WriteLine(students[1] + " survives mainly on a diet of " + favFoods[1]);
                GoAgain();
            }

            if (studentID == 3 && NextChoice())
            {
                Console.WriteLine(students[2] + " was born and raised in " + homeTown[2]);
                GoAgain();
            }
            else if(studentID ==3)
            {
                Console.WriteLine(students[2] + " survives mainly on a diet of " + favFoods[2]);
                GoAgain();
            }

            if (studentID == 4 && NextChoice())
            {
                Console.WriteLine(students[3] + " was born and raised in " + homeTown[3]);
                GoAgain();
            }
            else if(studentID==4)
            {
                Console.WriteLine(students[3] + " survives mainly on a diet of " + favFoods[3]);
                GoAgain();
            }

            if (studentID == 5 && NextChoice())
            {
                Console.WriteLine(students[4] + " was born and raised in " + homeTown[4]);
                GoAgain();
            }
            else if(studentID ==5)
            {
                Console.WriteLine(students[4] + " survives mainly on a diet of " + favFoods[4]);
                GoAgain();
            }


            EntireArray();
            PrintCategory(students);
            PrintCategory(favFoods);
            PrintCategory(homeTown);

            // Console.WriteLine(students[0] + favFoods[0] + homeTown[0]); // gets a specific index[0].
            //in this case Jamie Oliver, Spaghetti, Clavering, Essex


        }
        public static bool NextChoice()
        {
            //student: Fav food OR hometown. If they don't answer "F" or "HT" prompt again.

            Console.WriteLine(" Favorite Food(F) or Home Town(HT)? : ");
            string nextChoices = Console.ReadLine().ToUpper();

            if (nextChoices == "HT")
            {
                return true;
            }
            else if(nextChoices == "F")
            {
                return false;
            }
            else
            {
                Console.WriteLine("This is not a valid branch.");
                NextChoice();
                return false;
            }
        }
        public static void PrintCategory(string[] names)
        {
            Console.WriteLine("Finding information for student: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i + names[i]);
            }
            Console.WriteLine();
        }

        

        public static bool GoAgain()
        
        {
            Console.WriteLine(" Would you like to search a different problematic legacy? Y/N? ");
            string again = Console.ReadLine().ToUpper();
            if (again == "Y")
            {
                Main();
                return true;
              
            }
            else if(again == "N")
            {
                Console.WriteLine(" Finished pulling data. ");
                return false;
            }
            else
            {
                Console.WriteLine(" Invalid Response: ");
                GoAgain();
                return false;
            }
        }
        public static bool EntireArray()
            
        {
            Console.WriteLine(" See entire Database? Y/N");
            string eArray = Console.ReadLine().ToUpper();
            if(eArray == "Y")
            {
                
                return true;
            }
            else if(eArray == "N")
            {
                Console.WriteLine(" Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("Unable to determine input. Please try again.");
                EntireArray();
                return false;
            }

        }
    }
}