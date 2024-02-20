using System.ComponentModel;
using System.Windows.Input;

namespace SwipeItemInFlyout
{
    public class SimpleCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Application.Current.MainPage.DisplayAlert("This alert shows on Android, but not iOS.", "OK", "Cancel");
        }
    }

    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public SimpleCommand DoSomethingCommand => new SimpleCommand();
    }
}
