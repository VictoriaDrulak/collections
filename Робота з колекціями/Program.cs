//ЗАВДАННЯ 1
/*
class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }

    public Task(int taskId, string description)
    {
        TaskId = taskId;
        Description = description;
    }
}

class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
        Console.WriteLine($"Завдання з ID {task.TaskId} додано.");
    }

    public void RemoveTask(int taskId)
    {
        Task taskToRemove = tasks.Find(task => task.TaskId == taskId);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
            Console.WriteLine($"Завдання з ID {taskId} видалено.");
        }
        else
        {
            Console.WriteLine($"Завдання з ID {taskId} не знайдено.");
        }
    }

    public void DisplayTasks()
    {
        Console.WriteLine("Список завдань:");
        foreach (Task task in tasks)
        {
            Console.WriteLine($"ID: {task.TaskId}, Опис: {task.Description}");
        }
    }
}

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        taskManager.AddTask(new Task(1, "Завершити звіт"));
        taskManager.AddTask(new Task(2, "Зустріч з командою"));
        taskManager.AddTask(new Task(3, "Оновити документи"));

        taskManager.DisplayTasks();

        taskManager.RemoveTask(2);

        taskManager.DisplayTasks();
    }
}
*/

//ЗАВДАННЯ 2
/*
class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public User(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class UserManager
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
        Console.WriteLine($"Користувача з ID {user.Id} додано.");
    }

    public void RemoveUser(int id)
    {
        User userToRemove = users.Find(user => user.Id == id);
        if (userToRemove != null)
        {
            users.Remove(userToRemove);
            Console.WriteLine($"Користувача з ID {id} видалено.");
        }
        else
        {
            Console.WriteLine($"Користувача з ID {id} не знайдено.");
        }
    }

    public User GetUserById(int id)
    {
        return users.Find(user => user.Id == id);
    }

    public void DisplayUsers()
    {
        Console.WriteLine("Список користувачів:");
        foreach (User user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Ім'я: {user.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        UserManager userManager = new UserManager();

        userManager.AddUser(new User(1, "Андрій"));
        userManager.AddUser(new User(2, "Олена"));
        userManager.AddUser(new User(3, "Іван"));

        userManager.DisplayUsers();

        User foundUser = userManager.GetUserById(2);
        if (foundUser != null)
        {
            Console.WriteLine($"Знайдено користувача: ID: {foundUser.Id}, Ім'я: {foundUser.Name}");
        }
        else
        {
            Console.WriteLine("Користувача не знайдено.");
        }

        userManager.RemoveUser(3);

        userManager.DisplayUsers();
    }
}
*/