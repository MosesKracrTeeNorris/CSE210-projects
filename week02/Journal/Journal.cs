using System;
using System.Text.Json;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private string _userFileName;

    public Journal()
    public void AddEntry(Entry newEntry)
    {

    }
    public void DisplayAll()
    {
    Console.WriteLine("\n**************  Entries **************");
        foreach (Entry Entry in _journal)
    }
    public void SaveToFile(string file)
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n*** {_userFileName} has been created! ***\n");
            Console.Write("***  Your journal entries have been saved. ***\n");
            SaveJournalFile(_userFileName);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"\n*** {_userFileName} already exits. ***\n");
            Console.Write("***  Your journal entries have been added. ***\n");
            AppendJournalFile(_userFileName);  
        }
    }
    public void SaveJournalFile(string _userfileName)
    {
           using (StreamWriter outputFile = new StreamWriter(_userFileName))
           {
                foreach (Entry Entry in _journal)
                {
                    outputFile.WriteLine($"{Entry._entryNumber}; {Entry._dateTime}; {Entry._PromptGenerator}; {Entry._Entry}");
                }
           }
    }
    public void AppendJournalFile(string _userFileName)
    {
    using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
    {
        foreach (JournalEntry journalEntry in _journal)
        {
           outputFile.WriteLine($"{Entry._entryNumber}; {Entry._dateTime}; {Entry._PromptGenerator}; {Entry._Entry}"); 
        } 
    } 
}

public void LoadJournalFile()
{
    Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
          List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._PromptGenerator = entries[2];
                entry._Entry = entries[3];

                _journal.Add(entry);
            }
        }
}

public void CreateJSON(string userInput)
{
    string fileName = userInput + ".json";
    List<JsonItem> _data = new List<JsonItem>();

    foreach (Entry Entry in _journal)
    {
        _data.Add(new JsonItem());
    {
                ID = journalEntry._entryNumber
                Date = Entry._dateTime
                Prompt = Entry._PromptGenerator
                Entry = Entry._Entry
            }
            string json = JsonSerializer.Serialize(_data);
            File.WriteAllText(fileName, json);
    
    }
}