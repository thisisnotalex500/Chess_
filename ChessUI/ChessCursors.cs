using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessLogic;

namespace ChessUI
{
    public static class ChessCursors 
    {
        public static readonly Cursor WhiteCursor = LoadCursor("Assests/CursorW.cur");
        public static readonly Cursor BlackCursor = LoadCursor("Assests/CursorB.cur");
        private static Cursor LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
