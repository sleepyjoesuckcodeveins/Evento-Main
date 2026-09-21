namespace Evento.Domain;

public class Event
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private List<string> category;
    public List<string> Category
    {
        get { return category; }
        set { category = value; }
    }

    private string description;
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    private DateTime date;
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    private string location;
    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    private string eventImage;
    public string EventImage
    {
        get { return eventImage; }
        set { eventImage = value; }
    }

    private TimeSpan startingTime;
    public TimeSpan StartingTime
    {
        get { return startingTime; }
        set { startingTime = value; }
    }

    private TimeSpan endingTime;
    public TimeSpan EndingTime
    {
        get { return endingTime; }
        set { endingTime = value; }
    }

    private string address;
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
}