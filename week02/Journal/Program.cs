using System;
class Program
{
    static void Main(string [] args)
    {
        int[] validNumbers = {1, 2, 3, 4, 5};
        int action = 0;
        Console.WriteLine("Welcome to the Journal Program!.");
        Journal journal = new Journal();
        PromptGenerator pg = new PromptGenerator();

        while (action = {validNumbers})
        {
        action = Choices();

        switch (action)
        {
            case 1:
            string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    Entry entry = new Entry();
                    entry._entryNumber = entryId;
                    entry._dateTime = dateInfo;
                    entry._PromptGenerator = prompt;

                    Console.WriteLine($"{prompt}");
                    Console.Write(">>> ");
                    string userEntry = Console.ReadLine();
                    entry._Entry = userEntry;

                    journal._journal.Add(entry);

                    break;
            case 2:
                    journal.Display();
                    break;
            case 3:
                    journal.LoadJournalFile();

                    break;
            case 4:
                    journal.CreateJournal.File();
                    break;
            case 5:
                    Console.WriteLine("Thanks for using the Journal Program!!");
                    break;
            default:
                    Console.WriteLine($"OOPs! the choice you entered is not valid.");
                    break;

        }

    }

}

static int Choices()
{
    string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

    Console.Write(choices);
    string userInput = Console.ReadLine();
    int action = 0;

    try
    {
        action = int.Parse(userInput);
    }
    catch (FormatException)
    {
        action = 0;
    }
    catch (Exception exception)
    {
     Console.WriteLine($"Unexpected error: {exception.Message}");   
    }
    return action;
}

static string GetDateTime()
{
    DateTime now = DateTime.Now;
    string currentDateTime = now.ToString("F");


    return currentDateTime;
}
static void AddJournalEntry()
{
    string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
}

static string GetEntryId()
{
    Guid entryuuid = Guid.NewGuid();
    string entryuuidAsString = entryuuid.ToString();
    return entryuuidAsString;
   }

}




