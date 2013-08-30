using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_Fader
{
    [Export(typeof(IVsixPluginExtension))]
    public class CR_FaderExtension : IVsixPluginExtension { }
}