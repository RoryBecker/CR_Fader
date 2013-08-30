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

    public class FadeOutAdornment : VisualObjectAdornment
    {
        public static DevExpress.DXCore.Platform.Drawing.Color BackgroundColor;
        public static double Opacity = 0.6;
        public FadeOutAdornment(string feature, IElementFrame frame) : base(feature, frame) { }
        public override void Render(IDrawingSurface context, ElementFrameGeometry geometry)
        {
            BackgroundColor = DevExpress.DXCore.Platform.Drawing.Color.ConvertFrom(CodeRush.VSSettings.BackgroundColor);
            context.DrawRectangle(BackgroundColor, Opacity,
                                  BackgroundColor, Opacity, 1,
                                  geometry.Bounds.Extend(5, 0));
        }
    }
    public class FadeOutAdornmentFactory : TextDocumentAdornment
    {
        public FadeOutAdornmentFactory(SourceRange range) : base(range) { }
        protected override TextViewAdornment NewAdornment(string feature, IElementFrame frame)
        {
            return new FadeOutAdornment(feature, frame);
        }
    }
}
