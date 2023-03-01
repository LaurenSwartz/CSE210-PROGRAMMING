
public class Activity
{
    private string _activity;
    private string _description;

    public Activity(string activity, string description)
    {
        _description = description;
        _activity = activity;
    }

    public string GetWelcome()
    {
        return _activity;
    }

    public string GetDescription()
    {
        return _description;
    }

    }
    
  