using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar.View
{
    /// <summary>
    /// Логика взаимодействия для ChoiseOfAlcogolCalendarPage.xaml
    /// </summary>
    public partial class ChoiseOfAlcogolCalendarPage : Page
    {
        public ChoiseOfAlcogolCalendarPage()
        {
            InitializeComponent();

            ChoiseUSerControl first = new ChoiseUSerControl();
            ChoiseUSerControl second = new ChoiseUSerControl();

            second.NameOfDrink.Text = "Коньячокс";

            List<ChoiseUSerControl> Days = new List<ChoiseUSerControl>() { first, second };
            AlcogolListBox.ItemsSource = Days;

        }
    }
}
