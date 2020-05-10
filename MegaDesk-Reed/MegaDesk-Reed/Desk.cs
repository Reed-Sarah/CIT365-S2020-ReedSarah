using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Reed
{
    class Desk
    {
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MAXDRAWERS = 7;
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawer { get; set; }
        public DesktopMaterial Surface{get; set; }

        public Desk(int Width, int Depth, int Drawer) //, DesktopMaterial Surface
        {
            this.Width = Width;
            this.Depth = Depth;
            this.Drawer = Drawer;
            

        }
         public int SurfaceArea()
        {
            int area = this.Width * this.Depth;
            return area;
        }
    }
}


enum DesktopMaterial
{
    Oak,
    Laminate,
    Pine,
    Rosewood,
    Veneer
}