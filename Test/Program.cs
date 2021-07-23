using Pretty;
using System;

namespace Test
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
            PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Checked);

            //README SAMPLE_ERROR.PNG TEST
            try
            {
                //...SOMETHING THAT THROWS AN EXCEPTION...
                int.Parse("");
            }
            catch (Exception ex)
            {
                PrettyMessageBox.Show("Title", "An error occurred:", ex);
            }

            //README SAMPLE_INFO.PNG TEST
            MessageBoxResults result1 = PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkCancel);

            //README SAMPLE_QUESTION.PNG TEST
            MessageBoxResults result2 = PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Question, ButtonOptions.YesNoAuxiliary, "Test Aux");

            //OTHER TESTS
            PrettyMessageBox.Show("Title", "Test Content");
            PrettyMessageBox.Show("Title", "Test Content", ButtonOptions.Ok);
            PrettyMessageBox.Show("Title", "Test Content", ButtonOptions.OkAuxiliary, "Test Aux");
            PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkAuxiliary, "Test Aux");

            try
            {
                int.Parse("");
            }
            catch (Exception ex)
            {
                PrettyMessageBox.Show("Title", ex);
            }
        }
    }
}
