using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;
using DevExpress.DXCore.Adornments;
using DevExpress.DXCore.Platform.Drawing;

namespace CR_Fader
{
    public static class RectExt
    {
        public static Rect Extend(this Rect source, int X, int Y)
        {
            return new Rect(source.X, source.Y, source.Width + X, source.Height + Y);
        }
    }
}
