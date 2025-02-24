public class User
{
    public string Email { get; set; }
    public string Password { get; set; }
    public List<TrainingSession> TrainingSessions { get; set; }

    public User(string email, string password)
    {
        Email = email;
        Password = password;
        TrainingSessions = new List<TrainingSession>();
    }

    public void AddTrainingSession(double distance, double time)
    {
        TrainingSessions.Add(new TrainingSession(distance, time));
    }

    public void ListTrainingSessions()
    {
        if (TrainingSessions.Count == 0)
        {
            Console.WriteLine("No hay entrenamientos registrados.");
            return;
        }

        foreach (TrainingSession trainingSession in TrainingSessions)
        {
            Console.WriteLine($"Entrenamiento: {trainingSession.Distance}km ({trainingSession.Time}min)");
        }
    }

    public void ClearTrainingSessions() {
        TrainingSessions.Clear();
        Console.WriteLine("Todos los entrenamientos han sido eliminados.");
    }
}