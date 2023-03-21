
using Notification_Manager.ViewModel;


namespace Notification_Manager.Commands
    {
    public class SubmitAlertCommand : CommandBase
        {
        // Create an instance of EmployeeModelView so we could use methods that are implemented there.
        private readonly NotificationViewModel _notificationViewModel;

        public SubmitAlertCommand(NotificationViewModel notificationViewModel)
            {
            _notificationViewModel = notificationViewModel;
            }
        public override void Execute(object parameter)
            {
            _notificationViewModel.AddAssigment();
            }
        }
    }