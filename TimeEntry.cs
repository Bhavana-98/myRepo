using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntry
{
    public class TimeEntry
    {
        public long ?Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Data { get; set; }
        public int Hours { get; set; }

        public TimeEntry(long id,long projectId,long userId,DateTime date,int hours)
        {
            Id = id;
            ProjectId = projectId;
            UserId = userId;
            Data = Data;
            Hours = hours;
        }
        public TimeEntry( long projectId, long userId, DateTime date, int hours)
        {
            Id = null;
            ProjectId = projectId;
            UserId = userId;
            Data = Data;
            Hours = hours;
        }

    }
}
