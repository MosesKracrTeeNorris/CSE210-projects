using System;

public class Resume
{
    public string _name;
    public List<Job1> _jobs = new List<Job1>();
    public List<Job2> _jobs = new List<Job2>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}