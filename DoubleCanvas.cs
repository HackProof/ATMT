using System;
using System.Windows.Forms;

namespace ATMT
{
    public class DoubleCanvas : Panel
    {
	    public DoubleCanvas()
	    {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
        }
    }
}
