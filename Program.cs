
class Program
{
    static List<User> users = new List<User>();
    static User currentUser = null;
    static void Main(string[] args)
    {
        while (true)
        {
            if (currentUser == null)
            {
                Console.WriteLine("1. Registrarse");
                Console.WriteLine("2. Iniciar sesion");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Seleccione una opcion: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Login();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } else {
                Console.WriteLine("1. Registrar entrenamiento");
                Console.WriteLine("2. Listar entrenamientos");
                Console.WriteLine("3. Vaciar entrenamientos");
                Console.WriteLine("4. Cerrar sesion");
                Console.WriteLine("Seleccione una opcion: ");

                string option = Console.ReadLine();

                switch (option) {
                    case "1":
                        Console.WriteLine("Introduce la distancia del entrenamiento (km):");
                        double distance = double.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce el tiempo del entrenamiento (min):");
                        double time = double.Parse(Console.ReadLine());

                        currentUser.AddTrainingSession(distance, time);
                        break;
                    case "2":
                        currentUser.ListTrainingSessions();
                        break; 
                    case "3":
                        currentUser.ClearTrainingSessions();
                        break;
                    case "4":
                        currentUser = null;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }

    static void Login()
    {
        Console.WriteLine("Introduce tu correo:");
        string email = Console.ReadLine();

        Console.WriteLine("Introduce tu constraseña:");
        string password = Console.ReadLine();

        User runUser = users.Find(user => user.Email == email && user.Password == password);

        if (runUser != null)
        {
            currentUser = runUser;
        }
        else
        {
            Console.WriteLine("Correo o contraseña incorrectos");
        }
    }

    static void Register() {
        Console.WriteLine("Introduce tu correo:");
        string email = Console.ReadLine();

        Console.WriteLine("Introduce tu constraseña:");
        string password = Console.ReadLine();

        if (users.Exists(user => user.Email == email)) {
            Console.WriteLine("El correo ya esta registrado");
            return;
        }

        users.Add(new User(email, password));
        Console.WriteLine("Usuario registrado correctamente");
    }
}