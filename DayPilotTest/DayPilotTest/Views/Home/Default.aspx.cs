using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DayPilotTest.Views.Home
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DayPilotCalendar1.StartDate = DayPilot.Utils.Week.FirstDayOfWeek(new DateTime(2009, 1, 1));
                DayPilotCalendar1.DataSource = dbGetEvents(DayPilotCalendar1.StartDate, DayPilotCalendar1.Days);
                DataBind();
            }
        }

        protected void DayPilotCalendar1_EventMove(object sender, DayPilot.Web.Ui.Events.EventMoveEventArgs e)
        {
            dbUpdateEvent(e.Value, e.NewStart, e.NewEnd);
            DayPilotCalendar1.DataSource = dbGetEvents(DayPilotCalendar1.StartDate, DayPilotCalendar1.Days);
            DayPilotCalendar1.DataBind();
            DayPilotCalendar1.Update();
        }

        private DataTable dbGetEvents(DateTime start, int days)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT [id], [name], [eventstart], [eventend] FROM [event] WHERE NOT (([eventend] <= @start) OR ([eventstart] >= @end))", ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            da.SelectCommand.Parameters.AddWithValue("start", start);
            da.SelectCommand.Parameters.AddWithValue("end", start.AddDays(days));
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void dbUpdateEvent(string id, DateTime start, DateTime end)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("UPDATE [event] SET [eventstart] = @start, [eventend] = @end WHERE [id] = @id", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("start", start);
                cmd.Parameters.AddWithValue("end", end);
                cmd.ExecuteNonQuery();
            }
        }
    }
}