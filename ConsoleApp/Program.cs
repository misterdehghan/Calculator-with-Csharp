// See https://aka.ms/new-console-template for more information
//به نام خدا اولین پروژه سی شارپ  گرفتن اطلاعات از کاربر
//Console.WriteLine("Hello, this is my first C # application on the console"); 
//Console.WriteLine("Please enter your name"); 
//var name = Console.ReadLine();

//Console.WriteLine("Please enter your last name");
//var lastName = Console.ReadLine();

//Console.WriteLine("Please enter your gender");
//Console.WriteLine("Choose option 1 if you are a woman and option 2 if you are a man");
//var gender = int.Parse(Console.ReadLine());

//if (gender == 1 )
//{
//    Console.WriteLine("miss" + " " + name + " " + lastName);
//    Console.WriteLine("If the information entered is correct at this stage, enter option 1, otherwise enter another option.");
//    int StepOneEvaluation = int.Parse(Console.ReadLine());

//    if (StepOneEvaluation == 1)
//    {

//        Console.WriteLine("Please enter your age");
//        int age = int.Parse(Console.ReadLine());

//        if (age >= 18)
//        {
//            Console.WriteLine("Your information was successfully registered in the system");
//            Console.ReadKey();

//        }
//        else
//        {
//            Console.WriteLine("You are not allowed to register information !!!!!!");
//            Console.ReadKey();
//        }


//    }
//    else
//    {
//        Console.WriteLine("Thanks again for the steps");
//        Console.ReadKey();
//    }


//}else if(gender == 2)
//{


//    Console.WriteLine("Mr" + " " + name + " " + lastName);
//    Console.WriteLine("If the information entered is correct at this stage, enter option 1, otherwise enter another option.");
//    int StepOneEvaluation = int.Parse(Console.ReadLine());

//    if (StepOneEvaluation == 1)
//    {

//        Console.WriteLine("Please enter your age");
//        int age = int.Parse(Console.ReadLine());

//        if (age >= 18)
//        {
//            Console.WriteLine("Your information was successfully registered in the system");
//            Console.ReadKey();

//        }
//        else
//        {
//            Console.WriteLine("You are not allowed to register information !!!!!!");
//            Console.ReadKey();
//        }


//    }
//    else
//    {
//        Console.WriteLine("Thanks again for the steps");
//        Console.ReadKey();
//    }




//دومین پروژه سی شارپ - ماشین حساب







//}
//else
//{

//    Console.WriteLine("Thanks");
//    Console.ReadKey();

//}


//Console.ReadKey();

bool isEnd = false;

while (isEnd == false)
{

    Console.WriteLine("Hello, welcome to my calculator");
    Console.WriteLine("Please enter a prime number");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter a second number");
    int num2 = int.Parse(Console.ReadLine());


    Console.WriteLine("Please select the desired operation from the options");
    Console.WriteLine("Addition operation a");
    Console.WriteLine("subtraction operation b");
    Console.WriteLine("multiplication operation c");
    Console.WriteLine("division operation d");
    string aperation = Console.ReadLine();


    switch (aperation)
    {
        case "a":
            Console.WriteLine($"Result {num1} + {num2} = " + (num1 + num2));
            break;

        case "b":
            Console.WriteLine($"Result {num1} - {num2} = " + (num1 - num2));
            break;

        case "c":
            Console.WriteLine($"Result {num1} * {num2} = " + (num1 * num2));
            break;

        case "d":
            Console.WriteLine($"Result {num1} / {num2} = " + (num1 / num2));
            break;

            Console.WriteLine("Enter 'exit' to exit");
      if (Console.ReadLine() == "exit")
      {
        isEnd = true;
      }
    }
}