// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Maori Quiz!\n What\'s your name?");
string name = Console.ReadLine();

Console.WriteLine($"Okay {name}, This multiple choice quiz will contain 10 questions");
Console.WriteLine($"Make sure to read each question carefully,\nGoodluck {name.ToUpper()}!");
Console.WriteLine("Make sure you submit your answers in Upper case letters and letter ONLY.");

//the list of answers in arrays
string[] answer = { "A", "B", "C", "D" };

