using System;

namespace PrettyMessageBox.Test.Nuget
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MessageBox.Show("Teste", "Teste");
            MessageBox.Show("Teste", "Teste", ImageOptions.Checked);
            MessageBox.Show("Teste", "Teste", ButtonOptions.Ok);
            MessageBox.Show("Teste", "Teste", ButtonOptions.OkAuxiliary, "Teste");
            MessageBox.Show("Teste", "Teste", ImageOptions.Error, ButtonOptions.OkAuxiliary, "Teste");
            MessageBox.Show("Teste", "Teste", ImageOptions.Error, ButtonOptions.OkCancel);
            MessageBox.Show("Teste", "Teste", ImageOptions.Error, ButtonOptions.YesNoAuxiliary, "Teste");
        }
    }
}
