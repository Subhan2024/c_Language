// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Console.WriteLine("This is John\"s Pen");

int a;
a = 123;
string b = "Usama";
bool c = true;
double d = 2.2;
decimal e = 2;
float f = 3;
string g = "2f";
char h = '%';
long l = 324345344334;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(l);

var m = "hjfkjdskfjds";
Console.WriteLine(m);

const double pi = 3.14159265359;
Console.WriteLine(pi);

Console.WriteLine($"Hello {b} :-{{");
*/


/*
string name = "Usama";

Console.WriteLine($"Welcome back! {name} fhjhdsjhfjsd {name} jfkdsjkfjsd {name}");
*/

//Type Casting

//String a = "43453";

//int b = Convert.ToInt32(a);
//String a = "false";

//bool b = Convert.ToBoolean(a);

/*
int a = 345345;

string b = Convert.ToString(a);

Console.WriteLine($"Value: {b} Type: {b.GetType()}");
*/


/*double num1 = 34;

double num2 = 35;

Console.WriteLine(num1 + num2);
Console.WriteLine(num1 - num2);
Console.WriteLine(num1 * num2);
Console.WriteLine(num1 / num2);
Console.WriteLine(num1 % num2);

*/



//Math Class

/*
int a = -34;

//Console.WriteLine(Math.Sqrt(a));
//Console.WriteLine(Math.Pow(a,4));
//Console.WriteLine(Math.Abs(a));
Console.WriteLine(Math.Max(2,4));
Console.WriteLine(Math.Min(2,4));
Console.WriteLine(Math.Round(3.54));
Console.WriteLine(Math.Ceiling(3.1));
Console.WriteLine(Math.Floor(3.9));


*/


/*
Random random = new Random();


Console.WriteLine(random.Next(1,101));
Console.WriteLine(random.NextDouble());

*/




//string a = "Hello How are You";

//string b = a.ToUpper();
//string b = a.ToLower();
//string b = a.Replace("H","Tfsda");
//string b = a.Insert(5," John");
//string b = a.Substring(10,3);




//Console.WriteLine(a.Length);


//int age = 79;
/*
if(age >= 18)
{
    Console.WriteLine("You are below 18");
}
else
{
    Console.WriteLine("You are not suitable for our Website");
}

*/
/*
if (age == 0)
{
    Console.WriteLine("You are not born");
}
else if(age > 70)
{
    Console.WriteLine("You are going to die soon InshaAllah");
}
else if(age == 18)
{
    Console.WriteLine("Congratulation! You are 18");

}else if(age < 18)
{
    Console.WriteLine("You are below 18");

}
else if(age > 18)
{
   
    Console.WriteLine("You are above 18");
}
*/

/*

Console.WriteLine("Enter the number of your day: ");
string day = Console.ReadLine();

switch (day)
{
    case "1":
        Console.WriteLine("Today is Monday!");
        break;
    case "2":
        Console.WriteLine("Today is Tuesday");
        break;
    case "3":
        Console.WriteLine("Today is Wednesday");
        break;
    case "4":
        Console.WriteLine("Today is Thursday");
        break;
    case "5":
        Console.WriteLine("Today is Friday");
        break;
    case "6":
        Console.WriteLine("Today is Saturday");
        break;
    case "7":
        Console.WriteLine("Today is Sunday");
        break;
} 

*/


//Logical Operator

/*
int age = 87;

if(age > 18 || age < 70)
{
    Console.WriteLine("You are above 18");
}
else if(age < 18 && age > 0)
{
    Console.WriteLine("You are below 18");
}
else
{
    Console.WriteLine("You are not alive!");
}

*/

/*
Console.Write("Enter your Name : ");

string name = Console.ReadLine();


while (name == "")
{
    Console.Write("Enter your Name : ");

    name = Console.ReadLine();
}

Console.WriteLine($"Hello {name}!");
*/



//int a = 1;
/*
Console.WriteLine("Enter your max limit to print Numbers: ");
int b = Convert.ToInt32(Console.ReadLine());

while(a <= b)
{
    Console.WriteLine(a);
    a++;
}
*/

/*

for(;a<= 10; a++)
{
    Console.WriteLine(a);
}


*/


/*


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(j);
    }
}

*/

//string a = Console.ReadLine();

//string[] numbers = { "Arif","Ali","Zahid" };
//int[,] numbers = { { 2,4 },{5,6 },{7,8 } };



//Console.WriteLine(numbers);

/*
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine(numbers[i,j]);
    }
}
*/

/*
foreach (int number in numbers)
{
        Console.WriteLine(number);
}

*/



//int[,] numbers = 
//{
//    {1,3,5,7,8},
//    {2,4,6,9,13}
//};

//int[][] nums = new int[6][];

//nums[0] =  [ 1,3,5,6 ];
//nums[1] = [ 2,4,5,6 ];
//nums[2] = [ 4,5,6,7,9 ];
//nums[3] = [ 2,4,7,9,0 ];
//nums[4] = [ 10,90,87,65,89,97,56,45 ];
//nums[5] = [ 1,2,3,4,5,7,8,9,10,11];

//foreach (var number in nums)
//{
//    foreach (var item in number)
//    {
//        Console.WriteLine(item);
//    }
//    Console.WriteLine("--------------------------");
//}

/*
List<int> nums = new List<int>();

nums.Add(1);
nums.Add(2);
nums.Add(14);
nums.Add(6);
nums.Add(27);
nums.Add(8);
nums.Add(19);



Console.WriteLine("before sorting");


nums.Reverse();


foreach (int i in nums)
{
    Console.WriteLine(i);
}

//Console.WriteLine(nums[3]);

//nums.Remove(8);

//nums.IndexOf(8);
//Console.WriteLine("Index of 8: "+nums.IndexOf(8));

//nums.Insert(5, 2000);
//nums.Sort();

//Console.WriteLine($"Total Count of list is: {nums.Count}");
//Console.WriteLine($"Last Index: {nums.LastIndexOf(19)}");
//Console.WriteLine($"Contains: {nums.Contains(19)}");
//Console.WriteLine($"Sort: ");

/*
nums.Reverse();

Console.WriteLine("After sorting");
nums.Clear();
foreach (int i in nums)
{
    Console.WriteLine("nums list: " + i);
}


int[] numbers = nums.ToArray();

Console.WriteLine("numbers: "+numbers);
Console.WriteLine("list: "+nums);

foreach(int n in numbers)
{
    Console.WriteLine("numbers array: "+n);
}
*/

/*
game GTA = new game();
GTA.name = "GTA 7";
GTA.Company = "Rockstar";
GTA.releaseDate = "2027";
GTA.rating = 4.5;

Console.WriteLine(GTA.Company);


game superMario = new game();
superMario.name = "Super Mario Bros .Wonder";
superMario.Company = "Nintendo";
superMario.releaseDate = "2017";
superMario.rating = 4.8;

Console.WriteLine(superMario.Company);


game pubg = new game();
pubg.name = "PUBG";
pubg.Company = "GEO PUBG";
pubg.releaseDate = "2017";
pubg.rating = 5.0;


Console.WriteLine(pubg.name);



game Temple = new() {

    name = "Temple",
    Company = "TEM",
    releaseDate = "2015",
    rating = 3.5,
};

Console.WriteLine(Temple.name);

class game
{
    public string name;
    public string Company;
    private string releaseDate;
    public double rating;


    public void isgameavailible(string valuesdjg)
    {
        if (valuesdjg == "yes")
        {
            Console.WriteLine("the game is avalible");
        }
        else if (valuesdjg == "no")
        {
            Console.WriteLine("the game is not avalible");
        }
        else
        {
            Console.WriteLine("the valuesdjg is wrong");
        }
    }



    public static void websites(string valuesdjg)
    {
        if (valuesdjg == "yes")
        {
            Console.WriteLine("the website is avalible");
        }
        else if (valuesdjg == "no")
        {
            Console.WriteLine("the website is not avalible");
        }
        else
        {
            Console.WriteLine("the valuesdjg is wrong");
        }
    }
}
*/

/*ubisoft a = new()
{
    GameName = "Far Cry 3"
};

Console.WriteLine(a.gameDesc());

interface IGame
{
    public string gameDesc();
}

class ubisoft : IGame
{
    public string GameName;
    public string name;

    public string gameDesc()
    {
        return $"{this.GameName}";
    }
}*/


var input = WeekDays.Monday;


switch (input)
{
    case WeekDays.Monday:
        Console.WriteLine("Today is Monday!");
        break;
    case WeekDays.Tuesday:
        Console.WriteLine("Today is Tuesday!");
        break;
    case WeekDays.Wednesday:
        Console.WriteLine("Today is Wednesday!");
        break;
    case WeekDays.Thusrsday:
        Console.WriteLine("Today is Thusrsday!");
        break;

    default:
        Console.WriteLine("");
        break;
}


enum WeekDays
{
    Monday = 90,
    Tuesday = 10,
    Wednesday = 30,
    Thusrsday = 50
}




//timer.timer1();
//timer.timer2();
//timer.timer3();

//class timer
//{
//    public static void timer1()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"{i} Second of timer 1");
//            Thread.Sleep(1000);
//        }
//        Console.WriteLine("Timer 1 is completed");
//    }
//    public static void timer2()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine($"{i} Second of timer 2");
//            Thread.Sleep(2000);
//        }
//        Console.WriteLine("Timer 2 is completed");
//    }
//    public static void timer3()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine($"{i} Second of timer 3");
//            Thread.Sleep(3000);
//        }
//        Console.WriteLine("Timer 3 is completed");
//    }
//}








