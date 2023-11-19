public class Goal
{
    protected string _goalChoice;
    protected string _name;
    protected string _description;
    protected string _stringPoints;
    protected int _earnedPoints = 0;
    protected static int _totalPoints = 0;
    protected bool _isComplete = false;
    protected string _checkbox;
    protected List<Goal> goalsList = new List<Goal>();
    private string _fileName;

    public void SelectGoalType()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        _goalChoice = Console.ReadLine();
    }

    public string GetGoalChoice()
    {
        return _goalChoice;
    }

    public void SetGoalChoice(string choice)
    {
        _goalChoice = choice;
    }

    public virtual void CreateGoal()
    {
        Console.Write("\nWhat is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _stringPoints = Console.ReadLine();

        FormatGoal();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetStringPoints()
    {
        return _stringPoints;
    }

    public int GetPoints()
    {
        return _totalPoints += _earnedPoints;
    }

    public bool IsCompleted()
    {
        return _isComplete;
    }

    public virtual string FormatGoal()
    {
        _checkbox = CheckBox();
        return $"{_checkbox} {_name} ({_description})";
    }

    public virtual string CheckBox()
    {
        if (_isComplete == true)
        {
            _checkbox = "[X]";
            return _checkbox;
        }
        else
        {
            _checkbox = "[ ]";
            return _checkbox;
        }
    }

    public void PopulateList(Goal goal)
    {
        goalsList.Add(goal);
    }

    public void DisplayGoalsList()
    {
        Console.WriteLine();

        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalsList[i].FormatGoal()}");
        }
    }

    public void CreateFile()
    {
        Console.Write("Enter the file name: ");
        string userInput = Console.ReadLine();
        _fileName = userInput;

        if (File.Exists(_fileName))
        {
            Console.WriteLine("This file already exists.");
            UpdateFile(_fileName);
            Console.WriteLine("Goals have been saved.");
        }

        else
        {
            using (StreamWriter sw = File.CreateText(_fileName))
                Console.WriteLine($"Success! {_fileName} has been created.");
            SaveFile(_fileName);
            Console.WriteLine("Goals have been saved.");
        }
    }

    public virtual string Serialize()
    {
        return $"{_name},{_description},{_stringPoints}";
    }

    public virtual string SerializeForUpdate()
    {
        return $"{_name},{_description},{_stringPoints}";
    }

    public void SaveFile(string _fileName)
    {
        using (StreamWriter sw = new StreamWriter(_fileName))
        {
            sw.WriteLine($"{_totalPoints}");

            foreach (Goal goal in goalsList)
            {
                sw.WriteLine($"{goal.GetType().Name}:{goal.SerializeForUpdate()}");
            }
        }
    }

    public void UpdateFile(string _fileName)
    {
        using (StreamWriter sw = new StreamWriter(_fileName, append: true))
        {
            sw.WriteLine($"{_totalPoints}");

            foreach (Goal goal in goalsList)
            {
                sw.WriteLine($"{goal.GetType().Name}:{goal.SerializeForUpdate()}");
            }
        }
    }

    public void LoadFile()
    {
        Console.Write("Enter the file name: ");
        string userInput = Console.ReadLine();
        _fileName = userInput;

        if (File.Exists(_fileName))
        {
            string[] lines = File.ReadAllLines(_fileName);

            if (lines.Length > 0)
            {
                _totalPoints = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] typeAndGoalInfo = lines[i].Split(':');
                    string[] goalInfo = typeAndGoalInfo[1].Split(',');

                    string goalType = typeAndGoalInfo[0];
                    Goal loadedGoal = CreateGoalFromData(goalType, goalInfo);

                    Goal existingGoal = goalsList.Find(g => g.GetName() == loadedGoal.GetName());

                    if (existingGoal != null)
                    {
                        existingGoal.LoadGoalFromData(goalInfo);
                    }
                    else
                    {
                        goalsList.Add(loadedGoal);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("The file you are trying to load does not exist.");
        }
    }

    public virtual void LoadGoalFromData(string[] goalInfo)
    {
        _name = goalInfo[0];
        _description = goalInfo[1];
        _stringPoints = goalInfo[2];
    }

    private Goal CreateGoalFromData(string goalType, string[] goalInfo)
    {
        Goal loadedGoal;

        switch (goalType)
        {
            case "Simple":
                loadedGoal = new Simple("1");
                break;

            case "Eternal":
                loadedGoal = new Eternal("2");
                break;

            case "Checklist":
                loadedGoal = new Checklist("3");
                break;

            default:
                throw new NotSupportedException($"Unsupported goal type: {goalType}");
        }

        loadedGoal.LoadGoalFromData(goalInfo);
        return loadedGoal;
    }
}
