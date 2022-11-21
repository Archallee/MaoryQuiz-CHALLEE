// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Maori Quiz!\n What\'s your name?");
string name = Console.ReadLine();

Console.WriteLine($"Okay {name}, This multiple choice quiz will contain 10 questions");
Console.WriteLine($"Make sure to read each question carefully,\nGoodluck {name.ToUpper()}!");
Console.WriteLine("Make sure you submit your answers in Upper case letters and letter ONLY.");

//the list of answers in arrays
string[] answer = { "A", "B", "C", "D" };

//this will serve as answer variables for each question
string answer1;
string answer2;
string answer3;
string answer4;
string answer5;
string answer6;
string answer7;
string answer8;
string answer9;
string answer10;

//this will be the point system of the whole quiz
int point = 0;

Console.WriteLine("1. On sunny days we need to wear a pōtae on our heads. What is a pōtae? \nA. GLASSES\nB. HAT\nC. SCARF\nD. WIG");
Console.WriteLine("Answer: ");
answer1 = Console.ReadLine();
while (answer1 != answer[0] && answer1 != answer[1] && answer1 != answer[2] && answer1 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices");
    answer1 = Console.ReadLine();
}
Console.Clear();

if (answer1 == answer[1])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point -= 1;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("2. E tū and e noho are...\nA. JUMP AND DANCE\nB. RUN AND WALK\nC. CLAP AND LAUGH\nD. STAND UP AND SIT DOWN");
Console.WriteLine("Answer: ");
answer2 = Console.ReadLine();
while (answer1 != answer[0] && answer1 != answer[1] && answer1 != answer[2] && answer1 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices");
    answer1 = Console.ReadLine();
}
Console.Clear();

if (answer2 == answer[3])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point -= 1;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("3. Tamariki are like a map of their own parents. What is Tamariki?\nA. ADULTS\nB. CHILDREN\nC. TREES\nD. LAKES");
Console.WriteLine("Answer: ");
answer3 = Console.ReadLine();