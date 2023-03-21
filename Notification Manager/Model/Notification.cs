
using System;

namespace Notification_Manager.Model
    {
    public class Notification
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Alert_date { get; set; }
        public int Min { get; set; }

        public int Sec { get; set; }

        //public DateTime Time { get; set; }
        public int Notification_showed { get; set; }

        public Notification()
            {

            }


        public Notification(int id, string name, string description, DateTime alert_date, int min, int sec, int notification_showed)
            {
            Id = id;
            Name = name;
            Description = description;
            Alert_date = alert_date;
            Min = Min;
            Sec = sec;
            Notification_showed = notification_showed;
            }
        public Notification(string name, string description, DateTime alert_date, int min, int sec, int notification_showed)
            {
            Name = name;
            Description = description;
            Alert_date = alert_date;
            Min = Min;
            Sec = sec;
            Notification_showed = notification_showed;
            }
        }
    }


