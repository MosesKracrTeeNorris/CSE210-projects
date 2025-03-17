using System;
public class Entry
{
   public string _entryNumber = "";
   public string _dateTime = "";
   public string _PromptGenerator = "";
   public string _Entry = "";
   public string _entryText = "";

   public Entry()
   {

   }

   public void Display()
   {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_PromptGenerator}");
        Console.WriteLine($"Entry: {_Entry}");
   }   
}