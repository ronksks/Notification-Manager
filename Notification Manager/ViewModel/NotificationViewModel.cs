
using Notification_Manager.Model;
using Notification_Manager.Commands;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Notification_Manager.ViewModel
    {
    public class NotificationViewModel : ViewModelBase
        {
        ///*************** SQL CONNECTIONS*******************************************/

        //private SqlConnection _sqlConnection;
        //public SqlConnection Connection
        //{
        //    get { return _sqlConnection; }
        //    set { _sqlConnection = value; }

        //}


        //private string _connectionString = ConfigurationManager.ConnectionStrings["Notification_Manager.Properties.Settings.wpfdb1ConnectionString"].ConnectionString;
        //public string ConnectionString
        //{
        //    get { return _connectionString; }
        //}

        private ObservableCollection<Notification> _notifications;
        public ObservableCollection<Notification> Notifications
            {
            get { return _notifications; }
            set
                {
                _notifications = value;
                OnPropertyChanged(nameof(Notifications));
                }

            }


        public void AddAssigment()
            {
            Notifications.Add(new Notification(Name, Description, Alert_date, Min, Sec, 0));

            }
        public NotificationViewModel()
            {
            // command for buttons
            SubmitAlertCommand = new SubmitAlertCommand(this);

            DateTime time1 = new DateTime();
            //DateTime time2 = new DateTime();
            Notifications = new ObservableCollection<Notification>();
            Notifications.Add(new Notification("notification 1", "submit the assigment", time1, 22, 20, 0));
            Notifications.Add(new Notification("notification 2", "check the assigment", time1, 23, 10, 0));
            Notifications.Add(new Notification("notification 3", "verify the assigment", time1, 24, 15, 0));
            //checkNotification(Notifications);
            }

        private void checkNotification(ObservableCollection<Notification> notifications)
            {
            foreach (Notification item in Notifications)
                {
                DateTime notificationDate = new DateTime();
                notificationDate = item.Alert_date.Date;
                MessageBox.Show(notificationDate.ToString());
                // notification time

                }



            throw new NotImplementedException();
            }
        //public void InitTimer()
        //{
        //    // Checks every minute
        //DispatcherTimer timer = new DispatcherTimer();
        //DateTime myDeadLine = new DateTime();
        //    timer.Interval = new TimeSpan(0, 1, 0);
        //    timer.Tick += timer_Tick;
        //    timer.Start();

        //}

        //void timer_Tick(object sender, EventArgs e)
        //{
        //    if ((myDeadLine - DateTime.Now).TotalDays <= 5)
        //        MessageBox.Show("Your Alert Message");
        //}




        /*************** getters and seters for Properties*************/
        private string _name;
        public string Name
            {
            get { return _name; }
            set
                {
                _name = value;
                OnPropertyChanged(nameof(Name));
                }
            }
        private string _description;
        public string Description
            {
            get { return _description; }
            set
                {
                _description = value;
                OnPropertyChanged(nameof(Description));
                }
            }
        private DateTime _alert_date;
        public DateTime Alert_date
            {
            get { return _alert_date; }
            set
                {
                _alert_date = value;
                OnPropertyChanged(nameof(Alert_date));
                }
            }
        private DateTime _time;
        public DateTime Time
            {
            get { return _time; }
            set
                {
                _time = value;
                OnPropertyChanged(nameof(Time));
                }
            }

        private int _min;
        public int Min
            {
            get { return _min; }
            set
                {
                _min = value;
                OnPropertyChanged(nameof(Min));
                }
            }

        private int _sec;
        public int Sec
            {
            get { return _sec; }
            set
                {
                _sec = value;
                OnPropertyChanged(nameof(Sec));
                }
            }

        private int _notification_showed;
        public int Notification_showed
            {
            get { return _notification_showed; }
            set
                {
                _notification_showed = value;
                OnPropertyChanged(nameof(Notification_showed));
                }
            }



        /**********************TIMER****************/

        //DispatcherTimer timer = new DispatcherTimer();
        //DateTime myDeadLine = new DateTime();
        //public void InitTimer()
        //{
        //    // Checks every minute
        //    timer.Interval = new TimeSpan(0, 1, 0);
        //    timer.Tick += timer_Tick;
        //    timer.Start();
        //}

        //void timer_Tick(object sender, EventArgs e)
        //{
        //    if ((myDeadLine - DateTime.Now).TotalDays <= 5)
        //        MessageBox.Show("Your Alert Message");
        //}



        /*************** Buttons and handlers*************************************/
        public ICommand SubmitAlertCommand { get; }






        private Notification _notificationModel;

        public Notification SelectedNotification
            {
            get { return _notificationModel; }
            set
                {
                _notificationModel = value;
                OnPropertyChanged(nameof(SelectedNotification));
                //Id = value.Id.ToString();
                //FirstName = value.FirstName;
                //LastName = value.LastName;
                //Email = value.Email;
                //setDataFromRowToTextBoxs(_selectedEmployee);
                }
            }
        }
    }
