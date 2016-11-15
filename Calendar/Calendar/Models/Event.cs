using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Calendar.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
    }

    public class EventDBContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}