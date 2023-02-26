class ListingActivity : Activity {
    private List<string> _prompts;
    private int _items;

    public ListingActivity(
        string title = "Listing Activity",
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        ) : base(title, description) {
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void List() {
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Random rand = new Random();
        int n = rand.Next(0, _prompts.Count);

        Console.Clear();
        Console.WriteLine("List as many resopnses as you can to the following prompt:");
        Console.WriteLine(_prompts[n]);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime) {
            Console.Write("> ");
            Console.ReadLine();
            _items += 1;
            currentTime = DateTime.Now;
        }
        Pause(3, $"You listed {_items} items!", spinner: true);

        EndActivity();
    }
}