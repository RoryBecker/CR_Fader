using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;

namespace CR_Fader
{
    [UserLevel(UserLevel.NewUser)]
    public partial class Options1 : OptionsPage
    {
        // DXCore-generated code...
        #region Initialize
        protected override void Initialize()
        {
            base.Initialize();
        }
        #endregion

        #region GetCategory
        public static string GetCategory()
        {
            return @"Editor\Painting";
        }
        #endregion
        #region GetPageName
        public static string GetPageName()
        {
            return @"Fader";
        }
        #endregion

        private void Options1_RestoreDefaults(object sender, OptionsPageEventArgs ea)
        {
            // Set Defaults
            txtPrefixes.Text = "Log";
        }

        private void Options1_PreparePage(object sender, OptionsPageStorageEventArgs ea)
        {
            // Load Options
            Settings Settings = LoadSettings(ea.Storage);
            txtPrefixes.Lines = Settings.Prefixes;
        }

        public static Settings LoadSettings(DecoupledStorage storage)
        {
            return new Settings()
            {
                Prefixes = storage.ReadStrings("Fader", "Prefixes")
            };
        }
        private void Options1_CommitChanges(object sender, CommitChangesEventArgs ea)
        {
            // Save Changes
            ea.Storage.WriteStrings("Fader", "Prefixes", txtPrefixes.Lines);
        }
    }
}