class BreathingActivity : Activity
{
    protected override string GetName() => "Breathing";

    protected override string GetDescription() =>
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    protected override void PerformActivity()
    {
        int timeRemaining = GetDuration();
        while (timeRemaining > 0)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            timeRemaining -= 4;

            if (timeRemaining <= 0) break;

            Console.Write("Breathe out... ");
            ShowCountdown(6);
            timeRemaining -= 6;
        }
    }
}