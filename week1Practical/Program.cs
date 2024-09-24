
    string name;
    int age;



Console.WriteLine("please enter your name");
    name = Console.ReadLine();
    Console.WriteLine("please enter your age");
    age = Convert.ToInt32(Console.ReadLine());

if (age > 19)
{
    int result = age + 5;
    Console.WriteLine("hello {0} you are going to be {1} in 5 years and you are a Adult", name, result);
}
else if (age <= 19 && age >= 13)
{
    int result = age + 5;
    Console.WriteLine("hello {0} you are going to be {1} in 5 years and you are a teenager", name, result);
}
else if (age < 13)
{
    int result = age + 5;
    Console.WriteLine("hello {0} you are going to be {1} in 5 years and you are a child", name, result);
}
else 
{
    Console.WriteLine("you did not enter a valid age");
}





   




