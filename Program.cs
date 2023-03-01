//Random quote Generator 

using System;
using System.Net;

string pathToFile = @"https://raw.githubusercontent.com/MartinStyk/quotes-recommender/master/data/quotes_filtered_2.csv";

using (WebClient client = new WebClient()) // using webclient to access a csv file
{
    string csvContent = client.DownloadString(pathToFile);
    string[] csvLines = csvContent.Split('\n');

    foreach (string line in csvLines) // using a foreach loop to iteratate over the csv file and using the "string.Split" function for plitting the lines in the file. 
    {
        string[] values = line.Split(',');
        // Do something with the values
    }

    Random random = new Random(); // using the random class

    
int randomIndex = random.Next(csvLines.Length); // Generate a random index
string randomElement = csvLines[randomIndex]; // Access the element at the random index

Console.WriteLine("Your Quote of the day is: " + randomElement); // Print the random element
}





