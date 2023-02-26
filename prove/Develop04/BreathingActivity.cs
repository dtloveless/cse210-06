class BreathingActivity : Activity {
    public BreathingActivity(
            string title = "Breathing Activity", 
            string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        ) : base(title, description) {     
        }

    public void Breathe() {
        StartActivity();

        Console.Clear();
        int s = _duration;
        Random rand = new Random();
        int n;
        while (s > 0) {
            n = rand.Next(3, 7);
            Pause(n, "Breathe in...", countdown: true);
            s -= n;
            Console.Clear();
            if (rand.Next(0, 2) > 0) {
                Pause(n, "Hold it...", countdown: true);
                Console.Clear();
            }
            Pause(n, "Breathe out...", countdown: true);
            s -= n;
            Console.Clear();
        }

        EndActivity();
    }
}
