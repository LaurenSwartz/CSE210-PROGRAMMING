
public class EternalGoal : Goal
{
     public EternalGoal()
    {
        

    }

     public override string SaveFile()
    {
         
        return $" Eternal Goal - {_name} - ({_description}) - {_points} ";
    
    }

    public override void PrintGoal()
    {
          {
           if (_check == false)
        {
            Console.Write("[]");
        }
        else
        {
            Console.Write("[]");
            
        }
        Console.WriteLine ($"{_check } {_name} ({_description}) ");

    }
    }

    public override void RecordEvent()
    {
         _answer = int.Parse(Console.ReadLine());
        if (_answer == 2)
        {   
            _check = false;
            _totalPoints += _points;
            Console.WriteLine($"You earned {_points} points");
            

        }
    }
}