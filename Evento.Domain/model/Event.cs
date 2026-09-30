namespace Evento.Domain;

public class Event
{
    private int eventid;
    public int EventID
    {
        get {return eventid;}
        set {eventid = value;}
    }
    private int hostid;
    public int HostId
    {
        get{return hostid;}
        set{hostid = value;}
     }
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string category;
    public string Category
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


    private string location;
    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    private string eventImage;
    public string EventImagePath
    {
        get { return eventImage; }
        set { eventImage = value; }
    }

    private DateTime startingTime;
    public DateTime StartingTime
    {
        get { return startingTime; }
        set { startingTime = value; }
    }

    private DateTime endingTime;
    public DateTime EndingTime
    {
        get { return endingTime; }
        set { endingTime = value; }
    }

    private Status status;
    public Status Status
    {
        get { return status; }
        set { status = value; }
    }
    private decimal price;
    public decimal Price
    {
        get{return price;}
        set{price = value;}
    }
}