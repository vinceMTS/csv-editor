using Microsoft.UI.Xaml;

namespace CsvEditor.WinUI
{
    public partial class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Start(_ => new App());
        }
    }
}
