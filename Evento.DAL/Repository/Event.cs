using Microsoft.Data.SqlClient;
using Evento.Domain;

namespace Evento.DAL;

public class EventDal:IEventDal
{
    private readonly IDbconnection _dbconnection;
    public EventDal(IDbconnection dbconnection)
    {
        _dbconnection = dbconnection;
    }
    public Event GetEvent()
    {
        try
        {
             using(SqlConnection Connection = new SqlConnection(_dbconnection.ConnectionString()))
            {
                Connection.Open();
                string sql = "select* from  ";//sql statement thet would be done later
                using (SqlCommand Command = new SqlCommand(sql, Connection))
                {
                   using(SqlDataReader reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //model here 
                            Event Eventinfo = new Event();
                            

                        }
                    }  
                }

            }
        }
        catch (Exception ex)
        {
            throw;
        }  

    return null;
        
    }

   

}
