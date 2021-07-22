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
            //README SAMPLE_CHECKED.PNG TEST
            MessageBox.Show("Title", "Test Content", ImageOptions.Checked);

            //README SAMPLE_ERROR.PNG TEST
            try
            {
                int.Parse("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Title", "An error occurred:", ex);
            }

            //README SAMPLE_INFO.PNG TEST
            MessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkCancel);

            //README SAMPLE_QUESTION.PNG TEST
            MessageBox.Show("Title", "Test Content", ImageOptions.Question, ButtonOptions.YesNoAuxiliary, "Test Aux");

            //OTHER TESTS
            MessageBox.Show("Title", "Test Content");
            MessageBox.Show("Title", "Test Content", ButtonOptions.Ok);
            MessageBox.Show("Title", "Test Content", ButtonOptions.OkAuxiliary, "Test Aux");
            MessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkAuxiliary, "Test Aux");

            try
            {
                int.Parse("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Title", ex);
            }
        }
    }
}
