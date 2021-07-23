using System.Windows;
using System.Windows.Input;

namespace Pretty.Views
{
    internal partial class ExceptionDetailsView : Window
    {
        internal ExceptionDetailsView(string stackTrace)
        {
            InitializeComponent();

            DetailsText.Text = stackTrace;
        }

        void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
    }
}
