using System;
public class PromptGenerator
{
   public List<string> _prompts;

   public static string[] _Prompt = {
        "What would you buy today if money were no object?",
            "How did you procrastinate on important tasks today?",
            "What scripture just popped into your head right now?",
            "What is something that made you laugh today?",
            "Who made your day better today?",
            "What is one thing you want to remember from today?",
            "What steps did you take today towards a goal you are working on?",
            "How can you make tomorrow (even) better than today?",
            "What went well today?",
            "What is a simple pleasure in your life that you are thankful for?",
            "How did you show love to someone today?",
            "How would you describe your spirituality today?",
            "What was your magic power today?",
            "Identify three times that you felt challenged today.",
            "What do I need to let go of today?",
            "What do you need the most right now?",
            "If you could only accomplish three things tomorrow, what would they be?",
            "What was the most peaceful moment during the day?",
            "Would you change any of the decisions you made today?",
            "What frightened you today?",
            "Who do you wish you had talked to today? What would you say?",
            "If you had another hour during the day, how would you have spent it?",
            "Reflect on how your body feels. Sore, Stressed, Tired, Energized",
            "Did you read a book today? If so what?",
            "Did you watch a movie today? If so what?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "List the places I have been to today.",
            "What was the best idea you had today?",
            "List the 3 things you are grateful for today and why.",
            "What was the most outrageous thing you did today?",
            "What was the best meal of the day today and what was it?",
            "Who made you feel good today?",
            "What did you learn today?",
            "What is the funniest thing that happened today?",
            "If you could become an expert in any subject or activity, what would it be?"
   };
   public List<string> _PromptGenerator = new List<string>(_prompt);

    public PromptGenerator()
    {

    }
    public void Display()
   {
        var random = new Random();
        int index = random.Next(_PromptGenerator.Count);
        string PromptGenerator = _PromptGenerator[index];
        Console.WriteLine($"\n{_PromptGenerator}");
   }
   public string GetPrompt()
    {
    var random = new Random();
        int index = random.Next(_PromptGenerator.Count);
        string PromptGenerator = _PromptGenerator[index];

    return PromptGenerator;
   } 
}