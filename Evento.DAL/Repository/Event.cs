using Microsoft.Data.SqlClient;
using Evento.Domain;
using System.Collections.Generic;
using System.Collections;



namespace Evento.DAL;

public class EventDal:IEventDal
{
    private readonly IDbconnection _dbconnection;
    public EventDal(IDbconnection dbconnection)
    {
        _dbconnection = dbconnection;
    }
    public List<Event> GetEvent()
    {
        var ListEvent = new List<Event>();
        try
        {
             using(SqlConnection Connection = new SqlConnection(_dbconnection.ConnectionString()))
            {
                Connection.Open();
                string sql = @" SELECT e.EventID, e.EventName, e.CategoryID, c.CategoryName,
                e.ApprovalStatus, e.StartTime, e.EndTime,
                e.Location, e.EventImage, e.Price
                 FROM dbo.Events e
                 JOIN dbo.Categories c ON c.CategoryID = e.CategoryID";//sql statement thet would be done later

                using (SqlCommand Command = new SqlCommand(sql, Connection))
                {
                   using(SqlDataReader reader = Command.ExecuteReader())
                    {
                            int idOrd       = reader.GetOrdinal("EventID");
                            int nameOrd     = reader.GetOrdinal("EventName");
                            int locOrd      = reader.GetOrdinal("Location");
                            int imgOrd      = reader.GetOrdinal("EventImage");
                            int startOrd    = reader.GetOrdinal("StartTime");
                            int endOrd      = reader.GetOrdinal("EndTime");
                            int statusOrd   = reader.GetOrdinal("ApprovalStatus");
                            int priceOrd    = reader.GetOrdinal("Price");
                            int categoryOrd = reader.GetOrdinal("CategoryName");

                        while (reader.Read())
                        {
                            //model here 
                            var Eveninfo = new Event
                            {
                                EventID      = reader.GetInt32(idOrd),
                                Name         = reader.GetString(nameOrd),
                                Location     = reader.GetString(locOrd),
                                EventImagePath   = reader.IsDBNull(imgOrd) ? null : reader.GetString(imgOrd),
                                StartingTime = reader.GetDateTime(startOrd),
                                EndingTime   = reader.GetDateTime(endOrd),
                                Status       = (Status)reader.GetInt32(statusOrd),
                                Price        = reader.GetDecimal(priceOrd),
                                Category     = reader.GetString(categoryOrd)
                                
                            };
                      
                            ListEvent.Add(Eveninfo);

                        }
                    }  
                }

            }
        }
        catch (Exception ex)
        {
            throw;
        }  

    return ListEvent;
        
    }

    public bool AddEvent()
    {
        return true;
    }

   

}
