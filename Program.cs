// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace POEPART1
{

    class Menu2 
    {
          public static void Main(String[]args) 
          {
            Menu1 m = new Menu1();
            m.Run();
           

        }
    }
}


class Menu1
{
    public void Run()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Creation c = new Creation(); // creating a constructor for creation class to use its methods 

        // creating a  menu for the user to enter software
        Console.WriteLine("what would you like to do (choose a number)");
        Console.WriteLine("1 : enter recipe");
        Console.WriteLine("2 : display");
        Console.WriteLine("3 : scale recipe");
        Console.WriteLine("4 : reset to original scale ");
        Console.WriteLine("5 : clear data");
        Console.WriteLine("6 : exit");
     
        // error handling with exeption handling

            int menu = Convert.ToInt32(Console.ReadLine());//taking user input
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


class Creation
{
    Menu1 m = new Menu1();

    String recipeN; // recipe name 
    int nIngredients; // number of ingrediants 
    int numS; // number of steps 

    int c = 0; // count to start positioning in the first loop 
    int s = 0; // count for the second loop

    // count keeping users from being confused 
    int count = 1;
    int index = 1;

    //intislising of arrays 
    string[] listOfI;// list of ingredients
    int[] iQuantity;  // ingredient quantity 
    string[] ingredientM;// ingredient measurment 
    String[] steps; // steps of the recipe 



    public void Recipe()

    {
       
        Console.WriteLine("what is the name of the recipe");
        recipeN = Console.ReadLine();


        Console.WriteLine("enter the number of ingredients needed for the recipe");
        nIngredients = Convert.ToInt32(Console.ReadLine());
        
       // decleration of arrays along with their size using input number of ingredients.
        string[] listOfI = new string[nIngredients]; 
        int[] iQuantity = new int[nIngredients];
        string[] ingredientM= new string[nIngredients];

        while (c < nIngredients) 
        {
            Console.WriteLine("name of the ingredient"+""+ count ); // eg flour
            listOfI[c] = Console.ReadLine();

            Console.WriteLine("what is the quantity of the ingrediant" + "" + count + ""); // eg 2  or 0.2 (which would make it 2 flour or 0.2 flour)
            iQuantity[c] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("examples for unit of measurment g(gram) , mg(milligram) and kg(kilogram) ");

            Console.WriteLine("enter measurement value of ingrediant"+""+count);
            ingredientM[c] = Console.ReadLine();

            count++;
            c++;
            // note to self do not add break when creating such a loop

        } 
        
        Console.WriteLine("how many steps does it take to make the recipe ");
        numS = Convert.ToInt32(Console.ReadLine());

        // adding a size to array according to the amount of steps user input
        String[] steps = new String[numS];

        while (s < numS)
        {
            Console.WriteLine("please enter step"+index+" in detail on what should be done in recipe");
            steps[s] = Console.ReadLine();

            index++;
            s++;

        }

        Display();
    }
    public void Display()
    {
        Console.WriteLine("recipe name:\n"+recipeN);
        Console.WriteLine("number of ingredient:\n"+ nIngredients);
        Console.WriteLine("list of ingredients in recipe");
        for (int a = 0; a < listOfI.Length; a++)
        {
            Console.WriteLine($"- \n{listOfI[a]}-");
        }
        Console.WriteLine("list of quantity of ingredients recipe");
        for(int b = 0; b< iQuantity.Length; b++)
        {
            Console.WriteLine($"==>\n{iQuantity[b]}-");
        }
        Console.WriteLine("number of steps in recipe:\n"+ numS);
        Console.WriteLine("steps of recipes");
      
        for(int i = 0; i < steps.Length; i++) 
        {
            Console.WriteLine($"-\n{steps[i]}-");
        }
    }
    public void Scale()
    {
        Console.WriteLine("tsek");
    }
    public void Reset()
    {
        Console.WriteLine("tsek");
    }
    public void Clear()
    {
        String[] listOfI = new string[0];
        int[] iQuantity = new int[0];
        string[] ingredientM = new string[0];
        int[] steps = new int[0];

        Console.WriteLine("recipe has been cleared");
        Console.WriteLine("would you like to make another recipe "+"yes"+"or no");
        String q = Console.ReadLine(); // taking input of user 

        if (q.ToLower() == "yes" )
        {
            m.Run();
        }
        else
        {
            Console.WriteLine("thank you for using the application");
            System.Environment.Exit(1);
        }

    }

    
}



