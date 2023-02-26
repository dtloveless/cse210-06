class ReflectionActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;
    
    public ReflectionActivity(
        string title = "Reflection Activity",
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        ) : base(title, description) {
        _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }   
    
    public void Reflect() {
        StartActivity();

        Console.Clear();
        Random rand = new Random();
        int n = rand.Next(0, _prompts.Count);
        Console.Write(_prompts[n]);
        Pause(5);
        Console.Write("\n\n(When you've thought of something, press enter to continue.)");
        Console.Read();
        Console.Clear();

        int s = _duration;
        while (s > 0) {
            n = rand.Next(0, _questions.Count);
            Pause(10, _questions[n], spinner: true);
            _questions.RemoveAt(n);
            Console.Clear();
            s-= 10;
        }

        EndActivity();
    }
}