// See https://aka.ms/new-console-template for more information


class menu
{
    public static void Main(string[] args)
    {


        Console.WriteLine("what would you like to do (choose a number)");
        Console.WriteLine("1 : enter recipe");
        Console.WriteLine("2 : scale recipe");
        Console.WriteLine("3 : reset to original scale ");
        Console.WriteLine("4 : clear data");
        Console.WriteLine("5 : exit");
        
        int menu;
       menu =  Convert.ToInt32(Console.ReadLine());
         
        if(menu== 1)
        { }
        else if(menu== 2) 
        { }
        else if( menu== 3) 
        { }
        else if(menu == 4) 
        { }
        else if(menu == 5)
        { System.Environment.Exit(1); }
    }
}


