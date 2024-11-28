namespace Final_Fundamentals_Projects_Todo_Apss;

internal class Program
{

    private static List<string> _toDoList = new();
    
    private static void Main()
    {
        Console.WriteLine("Hello");
        Menu();
    }

    private static void Menu()
    {
        Console.WriteLine("What do you wanat to do?");
        Console.WriteLine("[S]ee all todo");
        Console.WriteLine("[A]dd a todo");
        Console.WriteLine("[R]emove a todo");
        Console.WriteLine("[E]xit");
        var userInput = Console.ReadLine()!.ToUpper();
        Secim(userInput);
    }

    private static void Secim (string userInput)
    {
        if (!string.IsNullOrWhiteSpace(userInput))
        {
            switch (userInput)
            {
                case "S":
                    ToDoList();
                    break;
                case "A":
                    ToDoAdd();
                    break;
                case "R":
                    RemoveSelectedList();
                    break;
                case "E":
                    Environment.Exit(-1); 
                    break;
                default:
                    Console.WriteLine("Invalod choıce.");
                    Menu();
                    break;
            
            }
        }
        else
        {
            Console.WriteLine("ERROR");
            Menu();
        }
        
    }


    public static void ToDoList ()
    {
        if (!(_toDoList.Equals(null)) && _toDoList.Count > 0)
        {
            for (var i = 0; i < _toDoList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_toDoList[i].Trim()}");
            }
            Menu();
        }
        else
        {
            Console.WriteLine("This my list empty");
            Menu();
        }
    }
    
    public static void ToDoAdd()
    {
        Console.WriteLine("Enter the TODO description: ");
        var add = Console.ReadLine()!;
        
        /* IsNullOrWhiteSpace Görevi: Bir string'in null, tamamen boş ("") veya yalnızca boşluk karakterlerinden oluşup
        oluşmadığını kontrol eder. */
        
        
        if (!string.IsNullOrWhiteSpace(add))
        {
            // Benzersizlik kontrolü
            for (var i = 0; i < _toDoList.Count; i++)
            {
                if (_toDoList[i].Equals(add))
                {
                    Console.WriteLine("The description must be unique.");
                    ToDoAdd();
                    return;
                }
            }
            _toDoList.Add(add);
            Menu();
        }
        else
        {
            Console.WriteLine("The description connat be empty.");
            ToDoAdd();
        }
    }

    public static void RemoveSelectedList()
    {
        if (!(_toDoList.Equals(null)) && _toDoList.Count > 0)
        {
            Console.WriteLine("Select the index of the TODO you want to remove");
            for (var i = 0; i < _toDoList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_toDoList[i].Trim()}");
            }

            var selectNumber = Convert.ToInt32(Console.ReadLine()!) - 1;
            var listLength = _toDoList.Count;
            if (selectNumber <= listLength && 0 <= selectNumber)
            {
                _toDoList.RemoveAt(selectNumber);
                Console.WriteLine("Item removed successfully.");
                Menu();
            }
            else 
            {
                Console.WriteLine("Invalid selection. Please try again." + "\n");
                RemoveSelectedList();
            }
        }
        else
        {
            Console.WriteLine("This my list empty");
            Menu();
        }
    }
}