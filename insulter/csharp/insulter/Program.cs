// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        //array named insults is created and initialized with a collection of insult phrases
        string[] insults = new string[]
        {
            "You look like what morning breath smells like.",
            "If you tried to give me cpr I would probably throw myself back under water",
            "I am not a fan of you",
            "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
            "I'd rather walk than be on the same plane as you",
            "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
            "Do you have to be so...like that?"
        };

        // This code ensures we don't end up with duplicate insults
        int[] indexes = new int[3];
        //This line declares an integer array named indexes that will store the randomly selected indexes from the insults array.
        Random random = new Random();
        int count = 0;
        while (count < 3)
        //used to select three unique random indexes from the insults array. It continues until count reaches 3
        {
            int candidate = getRandomInt(0, insults.Length - 1, random);
            //method is called to generate a random integer between 0 and the length of the insults array minus 1
            if (Array.IndexOf(indexes, candidate) == -1)
            {
                indexes[count] = candidate;
                count++;
            }
        }
        //The Array.IndexOf method is used to check if the candidate index already exists in the indexes array. If it doesn't, the candidate index is assigned to the next available position in the indexes array, and count is incremented

        for (int i = 0; i < indexes.Length; i++)
        {
            int index = indexes[i];
            Console.WriteLine(insults[index]);
        }
    }
    //used to iterate over each index in the indexes array. The corresponding insult phrase is retrieved from the insults array using the index, and it is printed to the console using Console.WriteLine

    static int getRandomInt(int min, int max, Random random)
    {
        return random.Next(min, max + 1);
    }
}
