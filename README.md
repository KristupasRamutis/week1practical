# week1practical

    string name;
    int age;

    Console.WriteLine("please enter your name");
    name = (Console.ReadLine());
    Console.WriteLine("please enter your age");
    age = Convert.ToInt32(Console.ReadLine());

    int result = age + 5;
    Console.WriteLine("hello {0} you are going to be {1} in 5 years", name, result);
