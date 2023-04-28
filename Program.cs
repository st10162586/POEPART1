﻿using POEPART1;
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
           

            Console.BackgroundColor = ConsoleColor.Magenta;
            Menu1 m = new Menu1();
            m.Run();


        }
    }

    class Menu1
    {
        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Creation c = new Creation(); // creating a constructor for creation class to use its methods 

            // creating a  menu for the user to enter software
            int menu;

            Console.WriteLine("what would you like to do (choose a number)");
            Console.WriteLine("1 : enter recipe");
            Console.WriteLine("2 : Display recipe");
            Console.WriteLine("2 : scale recipe");
            Console.WriteLine("3 : reset to original scale ");
            Console.WriteLine("4 : clear data");
            Console.WriteLine("5 : exit");

            
            // error handling with exeption handling

            menu = Convert.ToInt32(Console.ReadLine());//taking user input
            if (menu <= 6)
            {
                if (menu == 1)
                { c.Recipe(); } // recipeE is in the Creation class
                else if (menu == 2)
                { c.Display(); } // Display is in the Creation class
                else if (menu == 3)
                { c.Scale(); }  //  Scale is in the Creation class
                else if (menu == 4)
                { c.Reset(); }  // Reset is in the Creation class
                else if (menu == 5)
                { c.Clear(); }  // Clear is in the Creation class
                else if (menu == 6)
                { System.Environment.Exit(1); } // feaature to exist the program 
            }
            else if (menu > 6)
            {
                Console.WriteLine("please only enter numbers given and no letters ");
                Run();
            }
            else if (menu < 1)
            {
                Console.WriteLine("please only enter numbers given and no letters ");
                Run();
            }
        }

    }
    }

        class Creation
        {

             
            Menu1 m1 = new Menu1();
            String recipeN; // recipe name 
            int nIngredients; // number of ingrediants 
            int numS; // number of steps 
            int scale; // to scale 
            int menu3; // for the menu to move around the code

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
            private string[] ingredientM;
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

                    bool flag = true;

                  
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

                Console.WriteLine("what would you like to do (choose a number)");
                Console.WriteLine("1 : enter recipe");
                Console.WriteLine("2 : Display recipe");
                Console.WriteLine("2 : scale recipe");
                Console.WriteLine("3 : reset to original scale ");
                Console.WriteLine("4 : clear data");
                Console.WriteLine("5 : exit");

                    menu3 = Convert.ToInt32(Console.ReadLine());//taking user input
            if (menu3<= 6)
            {
                if (menu3 == 1)
                { Recipe(); } // recipeE is in the Creation class
                else if (menu3 == 2)
                { Display(); } // Display is in the Creation class
                else if (menu3== 3)
                { Scale(); }  //  Scale is in the Creation class
                else if (menu3 == 4)
                { Reset(); }  // Reset is in the Creation class
                else if (menu3== 5)
                { Clear(); }  // Clear is in the Creation class
                else if (menu3 == 6)
                { System.Environment.Exit(1); } // feaature to exist the program 
            }
            else if (menu3 > 6)
            {
                Console.WriteLine("please only enter numbers given and no letters ");
                m1.Run();
            }
            else if (menu3 < 1)
            {
                Console.WriteLine("please only enter numbers given and no letters ");
                m1.Run();
            }

            }

            public void Display()
            {

                Console.WriteLine("name of the recipe:" + " " + recipeN);
                Console.WriteLine("");
                Console.WriteLine("list of ingredients:");

                for (int a = 0; a < listOfI.Length; a++) // forloop searching in the array 
                {


                    Console.WriteLine(listOfI[a]); // display of Ingredients


                }
                Console.WriteLine("");
                Console.WriteLine("the steps needed to be taken for recipe:");

                for (int b = 0; b < steps.Length; b++)
                {

                    Console.WriteLine(steps[b]);


                }


            }
            public void Scale()
            {
                // recieveing user input if they want to scale
                Console.WriteLine("");
                Console.WriteLine("would you like to Scale your recipe yes or no");
                q1 = Console.ReadLine();

                if (q1.ToLower() == "yes")
                {
                    Console.WriteLine(" scale quantity of recipe by 0.5(half) , 2 (double) 0r 3(triple)");
                    Console.WriteLine("choose from the 3 above options");
                    Convert.ToDouble(scale);
                    scale = Convert.ToInt32(Console.ReadLine());



                    for (int i = 0; i < iQuantity.Length; i++)
                    {

                        Console.WriteLine(listOfI[i]);
                        Console.WriteLine(iQuantity[i] *= scale);

                    }
                }
                else if (q1.ToLower() == "no")
                {
                    Clear();
                }

            }
            public void Reset()
            {
                Console.WriteLine("would you like to Scale back to your original  recipe yes or no");
                q2 = Console.ReadLine();

                if (q2.ToLower() == "yes")
                {
                    for (int i = 0; i < iQuantity.Length; i++)
                    {
                        Console.WriteLine(listOfI[i]);
                        Console.WriteLine(iQuantity[i] /= scale);
                    }
                }
                else if (q2.ToLower() == "no")
                {
                    Clear();
                }
            }
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
                else if (q3.ToLower() == "no")
                {
                    Console.WriteLine("thank you for using the application");
                    System.Environment.Exit(1);
                }

            }

        }


