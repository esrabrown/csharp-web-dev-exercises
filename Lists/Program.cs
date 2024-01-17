//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");


//Write a static method to find the sum of all the even numbers in a List.

static int sumNums(List<int> arry)
{
    int total=0;
    foreach(int integar in arry)
    {
        if(integar % 2 == 0)
        {
            total += integar;
        }
    }
    return total;
}


//Create a list with at least 10 integers and call your method on the list.

List <int> numbs = new List<int>();

//Write a static method to print out each word in a list that has exactly 5 letters.

static void printLetters(List<string> wordList)
{
    foreach(string word in wordList)
    {
        if(word.Length == 5)
        {
            Console.WriteLine(word);
        }
    }
}

//Modify your code to prompt the user to enter the word length for the search.

Console.WriteLine("Enter a word length: ");
string number = Console.ReadLine();
int numChars = int.Parse(input);

printLettersWords(wordList, numChars);

static void printLettersWords(List<string> wordList, int length)
{
    foreach(string word in wordList)
    {
        if(word.Length == length)
        {
            Console.WriteLine(word);
        }
    }
}