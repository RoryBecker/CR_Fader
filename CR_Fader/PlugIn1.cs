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
    public partial class PlugIn1 : StandardPlugIn
    {
        private Settings _settings;
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            LoadSettings();
        }
        #endregion
        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {

            base.FinalizePlugIn();
        }
        #endregion

        private void PlugIn1_DecorateLanguageElement(object sender, DecorateLanguageElementEventArgs args)
        {
            if (args.LanguageElement == null)
                return;
            if (args.LanguageElement.Parent == null)
                return;
            LanguageElementType[] Types = { LanguageElementType.Class, LanguageElementType.Struct, LanguageElementType.Method, LanguageElementType.Property };
            if (!Types.Contains(args.LanguageElement.Parent.ElementType))
                return;
            if (LineStartsWith(args.LanguageElement.StartLine, _settings.Prefixes))
                args.AddAdornment(new FadeOutAdornmentFactory(args.LanguageElement.Range));
        }
        private bool LineStartsWith(int startLine, string[] prefixes)
        {
            var Code = CodeRush.Documents.ActiveTextDocument.GetCodeOnLine(startLine);
            return prefixes.Any(p => Code.Trim().StartsWith(p));
        }
        private void PlugIn1_OptionsChanged(OptionsChangedEventArgs ea)
        {
            LoadSettings();
        }
        private void LoadSettings()
        {
            _settings = Options1.LoadSettings(Options1.Storage);
            CodeRush.Adornments.RefreshAll();
        }
    }
}
