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

            ChoiseUSerControl Vine = new ChoiseUSerControl();
            ChoiseUSerControl Cognac = new ChoiseUSerControl();
            ChoiseUSerControl Martini = new ChoiseUSerControl();
            ChoiseUSerControl GayLagune = new ChoiseUSerControl();
            ChoiseUSerControl SexOnTheBeach = new ChoiseUSerControl();
            ChoiseUSerControl Vodka = new ChoiseUSerControl();
            ChoiseUSerControl Champagne = new ChoiseUSerControl();
            ChoiseUSerControl Abcent = new ChoiseUSerControl();

            Vine.NameOfDrink.Text = "Винишко";
            Vine.PhotoOfDrink.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("C:\\Users\\Public\\Documents\\Calendar\\Calendar\\Images\\wine.png")),
                Stretch = Stretch.Uniform
            };

            Cognac.NameOfDrink.Text = "Коньячокс";

            Martini.NameOfDrink.Text = "Мартини";
            Martini.PhotoOfDrink.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("C:\\Users\\Public\\Documents\\Calendar\\Calendar\\Images\\martini.png")),
                Stretch = Stretch.Uniform
            };

            GayLagune.NameOfDrink.Text = "Голубая лагуна";
            GayLagune.PhotoOfDrink.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("C:\\Users\\Public\\Documents\\Calendar\\Calendar\\Images\\bluelagune.png")),
                Stretch = Stretch.Uniform
            };

            SexOnTheBeach.NameOfDrink.Text = "Секс на пляже";
            SexOnTheBeach.PhotoOfDrink.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("C:\\Users\\Public\\Documents\\Calendar\\Calendar\\Images\\sexbeach.png")),
                Stretch = Stretch.Uniform
            };

            Vodka.NameOfDrink.Text = "Водочка";
            Vodka.PhotoOfDrink.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("C:\\Users\\Public\\Documents\\Calendar\\Calendar\\Images\\bottle.png")),
                Stretch = Stretch.Uniform
            };

            Champagne.NameOfDrink.Text = "Шампусик";
            Champagne.PhotoOfDrink.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("C:\\Users\\Public\\Documents\\Calendar\\Calendar\\Images\\champagne.png")),
                Stretch = Stretch.Uniform
            };

            Abcent.NameOfDrink.Text = "Абсент";
            Abcent.PhotoOfDrink.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri("C:\\Users\\Public\\Documents\\Calendar\\Calendar\\Images\\Abcent.png")),
                Stretch = Stretch.Uniform
            };

            List<ChoiseUSerControl> Days = new List<ChoiseUSerControl>() { Vine, Cognac, Martini, GayLagune, SexOnTheBeach, Vodka, Champagne, Abcent };
            AlcogolListBox.ItemsSource = Days;
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            CalendarPage calendarpage = new CalendarPage();
            NavigationService.Navigate(calendarpage);
        }

        private void SaveAndExit_Click(object sender, RoutedEventArgs e)
        {
            // Код сохранения тут или в ViewModel
            CalendarPage calendarpage = new CalendarPage();
            NavigationService.Navigate(calendarpage);
        }
    }
}