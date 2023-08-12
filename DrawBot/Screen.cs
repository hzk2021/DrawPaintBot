using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBot
{
    static class Screen
    {
        public static Tuple<int, int, int> GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            Color col = bmp.GetPixel(0, 0);
            return Tuple.Create(Convert.ToInt32(col.R), Convert.ToInt32(col.G), Convert.ToInt32(col.B));
        }
    }
}
