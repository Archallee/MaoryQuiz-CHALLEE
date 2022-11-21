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
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
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
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("2. E tū and e noho are...\nA. JUMP AND DANCE\nB. RUN AND WALK\nC. CLAP AND LAUGH\nD. STAND UP AND SIT DOWN");
Console.WriteLine("Answer: ");
answer2 = Console.ReadLine();
while (answer2 != answer[0] && answer2 != answer[1] && answer2 != answer[2] && answer2 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer2 = Console.ReadLine();
}
Console.Clear();

if (answer2 == answer[3])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("3. Tamariki are like a map of their own parents. What is Tamariki?\nA. ADULTS\nB. CHILDREN\nC. TREES\nD. LAKES");
Console.WriteLine("Answer: ");
answer3 = Console.ReadLine();
while (answer3 != answer[0] && answer3 != answer[1] && answer3 != answer[2] && answer3 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer3 = Console.ReadLine();
}
Console.Clear();

if (answer3 == answer[1])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("4. The colour of the bag is as kākāriki as a plant. What is kākāriki?\nA. PINK\nB. YELLOW\nC. GREEN\nD. BLUE");
Console.WriteLine("Answer: ");
answer4 = Console.ReadLine();
while (answer4 != answer[0] && answer4 != answer[1] && answer4 != answer[2] && answer4 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer4 = Console.ReadLine();
}
Console.Clear();

if (answer4 == answer[2])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("5. What animal is a Hoiho?\nA. GOAT\nB. HORSE\nC. PIGEON\nD. CAT");
Console.WriteLine("Answer: ");
answer5 = Console.ReadLine();
while (answer5 != answer[0] && answer5 != answer[1] && answer5 != answer[2] && answer5 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer5 = Console.ReadLine();
}
Console.Clear();

if (answer5 == answer[1])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("6. Moana greets Mōrena to her neighbours everyday at 7am. What is Mōrena?\nA. GOODBYE\nB. MORE PLEASE\nC. STAY THERE\nD. GOOD MORNING");
Console.WriteLine("Answer: ");
answer6 = Console.ReadLine();
while (answer6 != answer[0] && answer6 != answer[1] && answer6 != answer[2] && answer6 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer6 = Console.ReadLine();
}
Console.Clear();

if (answer6 == answer[3])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("7. I'm hungry. can we get some kai? What is kai?\nA. CLOTHES\nB. FOOD\nC. TOYS\nD. SLEEP");
Console.WriteLine("Answer: ");
answer7 = Console.ReadLine();
while (answer7 != answer[0] && answer7 != answer[1] && answer7 != answer[2] && answer7 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer7 = Console.ReadLine();
}
Console.Clear();

if (answer7 == answer[1])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("8. The color of the flamingo is māwhero. What is māwhero?\nA. RED\nB. GREEN\nC. PINK\nD. YELLOW");
Console.WriteLine("Answer: ");
answer8 = Console.ReadLine();
while (answer8 != answer[0] && answer8 != answer[1] && answer8 != answer[2] && answer8 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer8 = Console.ReadLine();
}
Console.Clear();

if (answer8 == answer[2])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("9. What animal is a poaka?\nA. DUCK\nB. MOUSE\nC. TIGER\nD. PIG");
Console.WriteLine("Answer: ");
answer9 = Console.ReadLine();
while (answer9 != answer[0] && answer9 != answer[1] && answer9 != answer[2] && answer9 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer9 = Console.ReadLine();
}
Console.Clear();

if (answer9 == answer[3])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
Console.WriteLine("10. The color of her hair is like wood, it's Parauri. What is Parauri?\nA. BLACK\nB. GREY\nC. BROWN\nD. GREEN");
Console.WriteLine("Answer: ");
answer10 = Console.ReadLine();
while (answer10 != answer[0] && answer10 != answer[1] && answer10 != answer[2] && answer10 != answer[3])
{
    Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
    answer10 = Console.ReadLine();
}
Console.Clear();

if (answer10 == answer[2])
{
    point += 1;
    Console.WriteLine("Correct");
}
else
{
    point += 0;
    Console.WriteLine("Incorrect");
}
