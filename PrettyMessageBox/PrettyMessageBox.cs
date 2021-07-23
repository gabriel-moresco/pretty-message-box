using Pretty.Views;
using System;

namespace Pretty
{
    /// <summary>
    /// Class to show the PrettyMessageBox
    /// </summary>
    public class PrettyMessageBox
    {
        /// <summary>
        /// Without image, with <see cref="ButtonOptions.Ok"/> button available
        /// </summary>
        /// <param name="title"><see cref="PrettyMessageBox"/> Title</param>
        /// <param name="message"><see cref="PrettyMessageBox"/> Content</param>
        public static void Show(string title, string message)
        {
            MessageBoxView messageBox = new MessageBoxView(title, message, ImageOptions.None, ButtonOptions.Ok, "", null);
            messageBox.ShowDialog();
        }

        /// <summary>
        /// Image by choice, and with <see cref="ButtonOptions.Ok"/> button available
        /// </summary>
        /// <param name="title"><see cref="PrettyMessageBox"/> Title</param>
        /// <param name="message"><see cref="PrettyMessageBox"/> Content</param>
        /// <param name="image">Image to show next to content</param>
        public static void Show(string title, string message, ImageOptions image)
        {
            MessageBoxView messageBox = new MessageBoxView(title, message, image, ButtonOptions.Ok, "", null);
            messageBox.ShowDialog();
        }

        /// <summary>
        /// Shows the <see cref="Exception.Message"/> in the content, and a Exception Details View with the <see cref="Exception.StackTrace"/>, only with <see cref="ButtonOptions.Ok"/> button available
        /// </summary>
        /// <param name="title"><see cref="PrettyMessageBox"/> Title</param>
        /// <param name="exception"><see cref="Exception"/> to show the <see cref="Exception.Message"/> in the content and <see cref="Exception.StackTrace"/> in the exception details view</param>
        public static void Show(string title, Exception exception)
        {
            MessageBoxView messageBox = new MessageBoxView(title, exception.Message, ImageOptions.Error, ButtonOptions.Ok, "", exception);
            messageBox.ShowDialog();
        }

        /// <summary>
        /// Shows the <paramref name="preExceptionMessage"/> and the <see cref="Exception.Message"/> in the content, and a Exception Details View with the <see cref="Exception.StackTrace"/>, only with <see cref="ButtonOptions.Ok"/> button available
        /// </summary>
        /// <param name="title"><see cref="PrettyMessageBox"/> Title</param>
        /// <param name="preExceptionMessage">Message to show in the content before the exception.Message</param>
        /// <param name="exception"><see cref="Exception"/> to show the <see cref="Exception.Message"/> in the content and <see cref="Exception.StackTrace"/> in the exception details view</param>
        public static void Show(string title, string preExceptionMessage, Exception exception)
        {
            string message = string.IsNullOrEmpty(preExceptionMessage) ? exception.Message : $"{preExceptionMessage}\n{exception.Message}";

            MessageBoxView messageBox = new MessageBoxView(title, message, ImageOptions.Error, ButtonOptions.Ok, "", exception);
            messageBox.ShowDialog();
        }

        /// <summary>
        /// Without <see cref="ImageOptions"/>, and <see cref="ButtonOptions"/> by user choice
        /// </summary>
        /// <param name="title"><see cref="PrettyMessageBox"/> Title</param>
        /// <param name="message"><see cref="PrettyMessageBox"/> Content</param>
        /// <param name="buttonOptions">Button configuration to show under the content</param>
        /// <param name="auxiliaryButtonContent">Text to show in the auxiliary button, if chosen in the <paramref name="buttonOptions"/></param>
        /// <returns>Returns <see cref="MessageBoxResults.Positive"/> if user click in "Ok" or "Yes", <see cref="MessageBoxResults.Negative"/> if user click in "Cancel" or "No", and <see cref="MessageBoxResults.Auxiliary"/> if user click in the Auxiliary Button</returns>
        public static MessageBoxResults Show(string title, string message, ButtonOptions buttonOptions, string auxiliaryButtonContent = "")
        {
            MessageBoxView messageBox = new MessageBoxView(title, message, ImageOptions.None, buttonOptions, auxiliaryButtonContent, null);
            messageBox.ShowDialog();

            return messageBox.Result;
        }

        /// <summary>
        /// <see cref="ImageOptions"/> and <see cref="ButtonOptions"/> by user choice
        /// </summary>
        /// <param name="title"><see cref="PrettyMessageBox"/> Title</param>
        /// <param name="message"><see cref="PrettyMessageBox"/> Content</param>
        /// <param name="image">Image to show next to content</param>
        /// <param name="buttonOptions">Button configuration to show under the content</param>
        /// <param name="auxiliaryButtonContent">Text to show in the auxiliary button, if chosen in the <paramref name="buttonOptions"/></param>
        /// <returns>Returns <see cref="MessageBoxResults.Positive"/> if user click in "Ok" or "Yes", <see cref="MessageBoxResults.Negative"/> if user click in "Cancel" or "No", and <see cref="MessageBoxResults.Auxiliary"/> if user click in the Auxiliary Button</returns>
        public static MessageBoxResults Show(string title, string message, ImageOptions image, ButtonOptions buttonOptions, string auxiliaryButtonContent = "")
        {
            MessageBoxView messageBox = new MessageBoxView(title, message, image, buttonOptions, auxiliaryButtonContent, null);
            messageBox.ShowDialog();

            return messageBox.Result;
        }
    }
}
