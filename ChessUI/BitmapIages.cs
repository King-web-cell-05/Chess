using System.Security.Policy;
using System.Windows.Media;

namespace ChessUI
{
    internal class BitmapIages : ImageSource
    {
        private Url url;
        private Url url1;

        public BitmapIages(Url url)
        {
            this.url = url;
        }

        public BitmapIages(Url url1)
        {
            this.url1 = url1;
        }
    }
}