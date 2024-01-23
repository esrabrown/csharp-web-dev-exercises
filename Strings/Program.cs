//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");

string words = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";


//Use the Split method to divide the string at each space and store the individual words in an array. If you need to review the method syntax, look back at the string methods table.

string[] wordsArray = words.Split(' ');

foreach(string word in wordsArray)
{
    Console.WriteLine(word);
}

Console.WriteLine(string.Join(",", wordsArray));