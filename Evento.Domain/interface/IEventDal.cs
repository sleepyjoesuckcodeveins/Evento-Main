
namespace Evento.Domain;
public interface IEventDal
{
    public List<Event> GetEvent();
    public bool AddEvent();

}