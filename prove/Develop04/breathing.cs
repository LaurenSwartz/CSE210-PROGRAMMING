
public class Breathing : Activity
{
    private string _breatheIn;
    private string _breatheOut;

    public Breathing(string activity, string description, string breatheIn, string breatheOut)
        : base(activity, description)
    {
        _breatheIn = breatheIn;
        _breatheOut = breatheOut;
    }

    public string GetBreatheIn()
    {
        return $"{_breatheIn}...";
    }
    public string GetBreatheOut()
    {
        return $"{_breatheOut}...";
    }
}