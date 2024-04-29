using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Calendar.View
{
    public partial class CalendarWindow : Window
    {    
        public CalendarWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new CalendarPage());

        }

        #region Логика для углового ресайза, можешь не лезть сюда
        private void ResizeThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            Thumb thumb = sender as Thumb;
            if (thumb == null) return;

            Window window = Window.GetWindow(thumb);
            if (window == null) return;

            double deltaX = e.HorizontalChange;
            double deltaY = e.VerticalChange;

            if (thumb == TopLeftResizeThumb)
            {
                window.Width -= deltaX;
                window.Height -= deltaY;
                window.Left += deltaX;
                window.Top += deltaY;
            }
        }
        #endregion

        #region Логика для управления пользовательским интерфейсом (скрыть/закрыть)
        private void MinimiseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }
        #endregion
    }
}
