using Evento.Domain;
using Evento.DAL;

namespace Evento.BLL;
public class EventService
{
    private readonly IEventDal Eventmanagement;
    public EventService( IEventDal _Eventmanagement)
    {
        _Eventmanagement = Eventmanagement;
    }

    public List<Event> GetEvents()
    {
        return Eventmanagement.GetEvent();
    }
    public bool AddEvent()
    {
        return Eventmanagement.AddEvent();
    }

}
