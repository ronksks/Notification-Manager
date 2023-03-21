using Notification_Manager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notification_Manager.View
    {
    /// <summary>
    /// Interaction logic for NotificationManagerView.xaml
    /// </summary>
    public partial class NotificationManagerView : UserControl
        {
        private NotificationViewModel _notificationModelView = new NotificationViewModel();

        public NotificationManagerView()
            {
            InitializeComponent();
            DataContext = _notificationModelView;

            }
        private void TimeValidationTextBox(object sender, TextCompositionEventArgs e)
            {
            Regex regex = new Regex("[^0-9]+");
            TextBox t1 = (TextBox)sender;
            Regex regex2 = new Regex("^([0-5]?[0-9])$");
            if (t1.Text.Length == 1)
                {
                string time = string.Format("{0}{1}", t1.Text, e.Text);
                e.Handled = !regex2.IsMatch(time);
                return;
                }
            if (t1.Text.Length > 1)
                {
                e.Handled = true;
                return;
                }
            e.Handled = regex.IsMatch(e.Text);
            }
        }
    }
