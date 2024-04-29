using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Calendar.View
{
    public partial class CalendarUserControl : UserControl
    {
        public event RoutedEventHandler ButtonClick;

        public CalendarUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }

        private void OpenDay_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }
    }
}
