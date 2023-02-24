using System;
using static System.Console;
public class Reflecting : Activity
{
    private Spinner _spinner = new Spinner();

    private CountDown _countDown = new CountDown(5);

    private string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?:",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string[] _reflectingPrompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public Reflecting() 
    : base()
    {
        base.SetName("Reflecting Activity");
        base.SetDescription("This activity will help you reflect on times in your life when you have demonstrated strength and resilience. This activity will help you recognize the power you have and how you can use it in other aspects of your life.");
        base.SetDuration("How long, in sceonds, would you like for your session? ");
        base.SetMessage1("\nWell done!!");
    }

    public void GetReflectingPrompt()
    {
        Random randomPrompt = new Random();
        int i = randomPrompt.Next(this._reflectingPrompts.Length);
        string prompt = this._reflectingPrompts[i];
        WriteLine("\nConsider the following prompt:");
        WriteLine($"\n--- {prompt} ---\n");

        WriteLine("When you have something in mind, press enter to continue... ");
    }

    public void GetPreQuestion()
    {
        WriteLine("\nNow ponder on each of the following questions as they are related to this experience.");
        Write("You may begin in: ");
        this._countDown.GetCounter();
    }

    public void GetQuestions()
    {
        Random randomQuestion = new Random();
        int i = randomQuestion.Next(this._questions.Length);
        int j = randomQuestion.Next(this._questions.Length);

        string question = _questions[i];
        string question1 = _questions[j];

        Write($"> {question} ");
        var _spinner1 = new Spinner();
        _spinner1.GetSpinner();
        Write(" ");

        WriteLine();
        Write($"> {question1} ");
        var _spinner2 = new Spinner();
        _spinner2.GetSpinner();
        Write(" ");
    }

    public void ShowReflectingActivity()
    {
        string actName = base.GetName();
        string description = base.GetDescription();
        string duration = base.GetDuration();
        string msg1 = base.GetMessage1();

        Clear();
        WriteLine($"Welcome to the {actName}\n");
        WriteLine($"{description}\n");
        Write(duration);
        int seconds = int.Parse(ReadLine());
        Clear();
        WriteLine("Get ready...");

        this._spinner.GetSpinner();
        Write(" ");

        this.GetReflectingPrompt();
        ReadLine();

        this.GetPreQuestion();
        Clear();

        this.GetQuestions();
        WriteLine($"\n{msg1}");

        this._spinner.GetSpinner();
        Write(" ");

        base.SetMessage2($"\nYou have completed another {seconds} seconds of the {base.GetName()}");
        string msg2 = base.GetMessage2();
        WriteLine($"{msg2}");
        this._spinner.GetSpinner();
        Clear();
    }
}