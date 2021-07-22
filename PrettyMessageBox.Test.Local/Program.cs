using System;

namespace PrettyMessageBox.Test.Local
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            TestMessageBox();
        }

        static void TestMessageBox()
        {
            MessageBox.Show("Title", "Test Content");
            MessageBox.Show("Title", "Test Content", ImageOptions.Checked);
            MessageBox.Show("Title", "Test Content", ButtonOptions.Ok);
            MessageBox.Show("Title", "Test Content", ButtonOptions.OkAuxiliary, "Test Aux");
            MessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkAuxiliary, "Test Aux");
            MessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkCancel);
            MessageBox.Show("Title", "Test Content", ImageOptions.Question, ButtonOptions.YesNoAuxiliary, "Test Aux");

            try
            {
                int.Parse("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Title", ex);
                MessageBox.Show("Title", "An error occurred:", ex);
            }
        }
    }
}
