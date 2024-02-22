home:
Console.Clear();
System.Console.WriteLine("\t -= Welcome to my Project! =- ");
System.Console.WriteLine("1. Triangle");
System.Console.WriteLine("2. Square");
System.Console.WriteLine("3. Pentagon");
System.Console.Write("Choose >>> ");
int choose = Convert.ToInt32(Console.ReadLine());
string Triangle = @"   
                       *
                     *   *
                   *       *
                 *           *
               *               * 
             * * * * * * * * * * *";
string Square = @"
                  * * * * * * * *
                  *             *
                  *             *
                  *             *
                  *             *
                  *             *
                  * * * * * * * *";
string Pentagon = @"   
                       *
                    *     *
                 *           *
              *                 *
               *               *
                *             *
                 *           *
                  * * * * * * ";
switch (choose)
{
    case 1:
        System.Console.WriteLine(Triangle);
        break;
    case 2:
        System.Console.WriteLine(Square);
        break;
    case 3:
        System.Console.WriteLine(Pentagon);
        break;
    default:
        System.Console.WriteLine("You entered incorrectly!");
        break;
}
System.Console.WriteLine("Do you want to continue? [Yes(y)/No(n)] >>> ");
string goHome = System.Console.ReadLine();
if (goHome == "y" | goHome == "Y")
    goto home;
else
    Console.Clear();
    System.Console.WriteLine("Thanks, bye!");