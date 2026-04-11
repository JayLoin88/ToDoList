using System.IO.Pipelines;

List<string> toDoList = new List<string>();

bool validEntry = false;
string? readResult;

do
{
    do
    {
        Console.WriteLine("Simple To-Do-List application");
        Console.WriteLine("Please select a menu item\n");

        Console.WriteLine("1. Enter new task");
        Console.WriteLine("2. Check current tasks");
        Console.WriteLine("Exit");


        readResult = Console.ReadLine();
        if (readResult != null)
        {
            readResult = readResult.ToLower();

            switch (readResult)
            {
                case "1":
                    NewTask();
                    validEntry = true;
                    break;

                case "2":
                    CurrentTasks();
                    validEntry = true;
                    break;
                case "exit":
                    validEntry = true;
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    Console.WriteLine("Press enter to return to the menu options");
                    Console.ReadLine();
                    validEntry = false;
                    break;
            }
        }
    } while (validEntry == false);


    void NewTask()
    {
        Console.WriteLine("Please enter new task");
        string? newTask = Console.ReadLine();

        if (newTask != null)
        {
            newTask = newTask.ToLower();
            toDoList.Add(newTask);
        }

        Console.WriteLine("Press enter to return to the menu");
        Console.ReadLine();
    }

    void CurrentTasks()
    {
        Console.WriteLine("Here is the current list of tasks");
        foreach (var task in toDoList)
        {
            Console.WriteLine(task);
        }


        Console.WriteLine("Press enter to return to the menu");
        Console.ReadLine();
    }


} while (readResult != "exit");
