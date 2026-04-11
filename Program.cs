using System.IO.Pipelines;

List<string> toDoList = new List<string>();
//int maxTasks;

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
        Console.WriteLine("3. Complete a task");
        Console.WriteLine("Exit");

        //maxTasks = toDoList.Count;


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
                case "3":
                    CompleteTask();
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
            if (newTask != "")
            {
                newTask = newTask.ToLower();
                toDoList.Add(newTask);
            }
            else
            {
                Console.WriteLine("Invalid task name");
            }

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

    void CompleteTask()
    {
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"Task {i}: {toDoList[i]}\n");
        }
        Console.WriteLine("Please enter the number of the task you wish to complete");

        //int positiveValue;
        int j;
        string? userInput = Console.ReadLine();
        bool validInput = int.TryParse(userInput, out j); // --> out positiveValue);
        //int j = Math.Abs(positiveValue);


        //Console.WriteLine(validInput);
        //Console.WriteLine(j);
        
        if ((j < toDoList.Count) && (j >= 0))
        {
            Console.WriteLine($"The task {toDoList[j]} has been removed");
            toDoList.RemoveAt(j);
        }
        else if (j > toDoList.Count)
        {
            Console.WriteLine("Please select a valid task");
        }
        else
        {
            Console.WriteLine("Invalid selection");
        }


        /* for (int i = 0; i < toDoList.Count; i++)
        {
            switch (j)
            {
                case i:
                    break;
            }
        } */

    }

} while (readResult != "exit");
