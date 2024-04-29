using System.Collections.Generic;
using System.Windows.Controls;

namespace Calendar.View
{
    public partial class CalendarPage : Page
    {
        public CalendarPage()
        {
            InitializeComponent();

            CalendarUserControl Example = new CalendarUserControl();

            List<CalendarUserControl> ExampleList = new List<CalendarUserControl>() { Example };
            DaysListBox.ItemsSource = ExampleList;

            Example.ButtonClick += (sender, e) =>
            {
                ChoiseOfAlcogolCalendarPage choisePage = new ChoiseOfAlcogolCalendarPage();
                NavigationService.Navigate(choisePage);
            };
        }
    }
}
