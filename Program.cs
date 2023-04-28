using POEPART1;
using System;
using System.Net.Mail;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace POEPART1
{

    class Menu2
    {
        public static void Main(String[] args)
        {
            Creation c = new Creation();

            Console.BackgroundColor = ConsoleColor.Magenta;
            c.Recipe();
            c.Display();
            c.Scale();
            c.Reset();
            c.Clear();
         

        }
    }





    class Creation
    {


        String recipeN; // recipe name 
        int nIngredients; // number of ingrediants 
        int numS; // number of steps 
        int scale; // to scale 

        int c = 0; // count to start positioning in the first loop 
        int s = 0; // count for the second loop

        // count keeping users from being confused 
        int count = 1;
        int index = 1;
        
        //questions answers from user input for scales and clearance 
        String q1;
        String q2;
        String q3;

        //intislising of arrays 
        private string[] listOfI;
        private int[] iQuantity;
        private  string[] ingredientM ;
        private string[] steps;



        public void Recipe()

        {
            Menu2 m = new Menu2();

            Console.WriteLine("what is the name of the recipe");
            recipeN = Console.ReadLine();


            Console.WriteLine("enter the number of ingredients needed for the recipe");
            nIngredients = Convert.ToInt32(Console.ReadLine());

            // decleration of arrays along with their size using input number of ingredients.
            listOfI = new string[nIngredients];
            iQuantity = new int[nIngredients];
            ingredientM = new string[nIngredients];

            while (c < nIngredients)
            {
                Console.WriteLine("name of the ingredient" + "" + count); // eg flour
                listOfI[c] = Console.ReadLine();

                Console.WriteLine("what is the quantity of the ingrediant" + "" + count + ""); // eg (which would make it 2 flour or 0.2 flour)
                iQuantity[c] = Convert.ToInt32(Console.ReadLine());

                bool flag = false;

                while (flag)
                {
                    Console.WriteLine("Units of measurment: \n1. cup  \n2. tablespoon \n3. teaspoon ");                    
                    ingredientM[c] = Console.ReadLine();

                    switch (ingredientM[c])
                    {

                        case "1":
                            ingredientM[c] = "cup";
                            break;

                        case "2":
                            ingredientM[c] = "tablespoon";
                            break;

                        case "3":
                            ingredientM[c] = "teaspoon";
                            break;
                        default:
                            Console.WriteLine("Please enter the number of the value you want to enter");
                            break;

                    }

                }
               

                count++;
                c++;
                // note to self do not add break when creating such a loop

            }


            Console.WriteLine("how many steps does it take to make the recipe ");
            numS = Convert.ToInt32(Console.ReadLine());

            // adding a size to array according to the amount of steps user input
            steps = new String[numS];
         

            while (s < numS)
            {
                Console.WriteLine("please enter step" + index + " in detail on what should be done in recipe");
                steps[s] = Console.ReadLine();

                index++;
                s++;

            }

            Console.WriteLine("");

        }

        public void Display()
        {
            
            Console.WriteLine("name of the recipe:" +" "+ recipeN);
            Console.WriteLine("");
            Console.WriteLine("list of ingredients:");

            for(int a = 0; a < listOfI.Length; a++) // forloop searching in the array 
            {
                
               
                Console.WriteLine(listOfI[a]); // display of Ingredients

                
            }
            Console.WriteLine("");
            Console.WriteLine("the steps needed to be taken for recipe:");

            for(int b = 0; b< steps.Length; b++) 
            {
                
                Console.WriteLine(steps[b]);

                
            }


        }
        public void Scale()
        { 
            // recieveing user input if they want to scale
            Console.WriteLine("");
            Console.WriteLine("would you like to Scale your recipe yes or no");
             q1 =Console.ReadLine();

            if (q1.ToLower() == "yes")
            {
                Console.WriteLine(" scale quantity of recipe by 0.5(half) , 2 (double) 0r 3(triple)");
                Console.WriteLine("choose from the 3 above options");
                Convert.ToDouble(scale);
                scale = Convert.ToInt32(Console.ReadLine()); 
              


                for (int i = 0; i < iQuantity.Length; i++)
                {

                    Console.WriteLine(listOfI[i]);
                    Console.WriteLine(iQuantity[i] *=  scale);

                }
            }else if (q1.ToLower() == "no")
            {
                Clear();
            }

        }
        public void Reset()
      
        public void Clear()
        {
             listOfI = new string[0];
             iQuantity = new int[0];
             ingredientM = new string[0];
            steps = new string[0];

            Console.WriteLine("recipe has been cleared");
            Console.WriteLine("");
            Console.WriteLine("would you like to make another recipe yes or no");
            q3 = Console.ReadLine(); // taking input of user 

            if (q3.ToLower() == "yes")
            {
                Menu2 m = new Menu2();
            }
            else if(q3.ToLower() == "no")
            {
                Console.WriteLine("thank you for using the application");
                System.Environment.Exit(1);
            }

        }

    }
}