public class TrainingSession
{
    public double Distance { get; set; }
    public double Time { get; set; }

    public TrainingSession(double distance, double time)
    {
        Distance = distance;
        Time = time;
    }
}