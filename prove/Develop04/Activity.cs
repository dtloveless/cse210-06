class Activity{
    protected string _title;
    protected string _description;
    protected int _duration;

    public Activity(string title, string description) {
        _title = title;
        _description = description;
    }

    public void Pause(int s, string message="", bool spinner=false, bool countdown=false, bool loadingDots=false) {
        if (spinner) {
            List<string> spinnerStrings = new List<string>();
            spinnerStrings.Add("|");
            spinnerStrings.Add("/");
            spinnerStrings.Add("-");
            spinnerStrings.Add("\\");
            spinnerStrings.Add("|");
            spinnerStrings.Add("/");
            spinnerStrings.Add("-");
            spinnerStrings.Add("\\");
            
            Console.Write(message + ' ');
            for (int i = s; i > 0; i--) {
                foreach (string spinnerString in spinnerStrings) {
                    Console.Write(spinnerString);
                    Thread.Sleep(125);
                    Console.Write("\b \b");
                }
            }
        } else if (countdown) {
            Console.Write(message + ' ');
            string count = "";
            for (int i = s; i > 0; i--) {
                Console.Write(new string('\b', count.Length) + new string(' ', count.Length) + new string('\b', count.Length));
                count = i.ToString();
                Console.Write(count);
                Thread.Sleep(1000);
            }
        } else if (loadingDots) {
            Console.Write(message);
            int j = s;
            string dots = "";
            while (j > 0) {
                int numDots = 0;
                for (int i = 4; i > 0 && j > 0; i--, j--, numDots++) {
                    dots = new string('.', numDots);
                    if (dots.Length < 3) {
                        dots += new string(' ', 3 - numDots);
                    }
                    Console.Write(dots);
                    Thread.Sleep(1000);
                    Console.Write("\b\b\b");
                }
            }
        } else {
            Console.Write(message);
            Thread.Sleep(s * 1000);
        }
    }

    public void StartActivity() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title}.\n"); // Display title
        Console.WriteLine(_description + "\n");           // Display description
        while(true){                                      // Get duration from user
            Console.Write("How long would you like this session to last? (seconds): ");
            string userInput = Console.ReadLine();
            if(int.TryParse(userInput, out _duration)){
                break;
            } else {
                Console.WriteLine("Invalid input. Please enter a positive whole number of seconds.");
            }
        }
        Console.Clear();
        Pause(4, message: "Get ready", loadingDots: true);
    }

    public void EndActivity() {
        Console.Clear();
        Pause(1, "Well done! ", spinner: true);
        Console.WriteLine();
        Pause(3, $"You have completed another {_duration} seconds of the {_title}. ", spinner: true);
        Console.WriteLine('\n');
    }
}
