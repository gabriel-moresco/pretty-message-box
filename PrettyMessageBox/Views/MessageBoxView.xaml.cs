using System;
using System.Media;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace PrettyMessageBox.Views
{
    internal partial class MessageBoxView : Window
    {
        ImageOptions _imageType;
        Exception _exception;

        internal MessageBoxResult Result { get; set; }

        internal MessageBoxView(string title, string message, ImageOptions image, ButtonOptions buttonOptions, string auxiliaryButtonText, Exception exception)
        {
            InitializeComponent();

            try
            {
                Owner = Application.Current.MainWindow;
            }
            catch (Exception) { }

            _exception = exception;
            _imageType = image;

            TitleTextBlock.Text = title;
            MessageTextBlock.Text = message;
            SeeMoreDetailsButton.Visibility = exception != null ? Visibility.Visible : Visibility.Hidden;

            SetResultButtonsConfig(buttonOptions, auxiliaryButtonText);
            SetImagesConfig();
        }

        void SetResultButtonsConfig(ButtonOptions buttonOptions, string auxiliary)
        {
            PositiveButton.Visibility = Visibility.Hidden;
            NegativeButton.Visibility = Visibility.Hidden;
            AuxiliaryButton.Visibility = Visibility.Hidden;

            string ok = "Ok";
            string cancel = "Cancel";
            string yes = "Yes";
            string no = "No";

            switch (buttonOptions)
            {
                case ButtonOptions.Ok:
                    PositiveButton.Visibility = Visibility.Visible;
                    PositiveButton.Content = ok;
                    PositiveButton.Margin = new Thickness(0, 0, 50, 0);
                    break;

                case ButtonOptions.OkCancel:
                    PositiveButton.Visibility = Visibility.Visible;
                    PositiveButton.Content = ok;
                    PositiveButton.Margin = new Thickness(0, 0, 150, 0);

                    NegativeButton.Visibility = Visibility.Visible;
                    NegativeButton.Content = cancel;
                    NegativeButton.Margin = new Thickness(0, 0, 50, 0);
                    break;

                case ButtonOptions.YesNo:
                    PositiveButton.Visibility = Visibility.Visible;
                    PositiveButton.Content = yes;
                    PositiveButton.Margin = new Thickness(0, 0, 150, 0);

                    NegativeButton.Visibility = Visibility.Visible;
                    NegativeButton.Content = no;
                    NegativeButton.Margin = new Thickness(0, 0, 50, 0);
                    break;

                case ButtonOptions.OkAuxiliary:
                    PositiveButton.Visibility = Visibility.Visible;
                    PositiveButton.Content = ok;
                    PositiveButton.Margin = new Thickness(0, 0, 150, 0);

                    AuxiliaryButton.Visibility = Visibility.Visible;
                    AuxiliaryButton.Content = auxiliary;
                    break;

                case ButtonOptions.OkCancelAuxiliary:
                    PositiveButton.Visibility = Visibility.Visible;
                    PositiveButton.Content = ok;

                    NegativeButton.Visibility = Visibility.Visible;
                    NegativeButton.Content = cancel;

                    AuxiliaryButton.Visibility = Visibility.Visible;
                    AuxiliaryButton.Content = auxiliary;
                    break;

                case ButtonOptions.YesNoAuxiliary:
                    PositiveButton.Visibility = Visibility.Visible;
                    PositiveButton.Content = yes;

                    NegativeButton.Visibility = Visibility.Visible;
                    NegativeButton.Content = no;

                    AuxiliaryButton.Visibility = Visibility.Visible;
                    AuxiliaryButton.Content = auxiliary;
                    break;
            }
        }

        void SetImagesConfig()
        {
            switch (_imageType)
            {
                case ImageOptions.None:
                    ImageColunm.Width = new GridLength(30);
                    break;

                case ImageOptions.Checked:
                    AlertImage.Source = new BitmapImage(new Uri(@"Images\checked.png", UriKind.Relative));
                    break;

                case ImageOptions.Error:
                    AlertImage.Source = new BitmapImage(new Uri(@"Images\error.png", UriKind.Relative));
                    break;

                case ImageOptions.Info:
                    AlertImage.Source = new BitmapImage(new Uri(@"Images\warning.png", UriKind.Relative));
                    break;

                case ImageOptions.Question:
                    AlertImage.Source = new BitmapImage(new Uri(@"Images\question.png", UriKind.Relative));
                    break;
            }
        }

        void OnPositiveButtonClick(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Positive;
            Close();
        }

        void OnNegativeButtonClick(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Negative;
            Close();
        }

        void OnAuxiliaryButtonClick(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Auxiliary;
            Close();
        }

        void ShowExceptionDetailsView(object sender, RoutedEventArgs e)
        {
            new ExceptionDetailsView(_exception.StackTrace).Show();
        }

        void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        void OnContentRendered(object sender, EventArgs e)
        {
            switch (_imageType)
            {
                case ImageOptions.Checked:
                    SystemSounds.Asterisk.Play();
                    break;

                case ImageOptions.Error:
                    SystemSounds.Hand.Play();
                    break;

                case ImageOptions.Info:
                case ImageOptions.Question:
                    SystemSounds.Exclamation.Play();
                    break;
            }
        }
    }
}
