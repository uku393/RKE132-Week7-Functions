
Console.WriteLine("Are you coming or leaving? (in/out):");

string userchoice = Console.ReadLine();

if (userchoice == "in")
{
    PrintHello();   
}
else
{
    PrintGoodBye(); 
}



PrintHello();  
PrintGoodBye();


static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later!");
}
















