using System;
using DevExpress.CodeRush.Core;

namespace CR_Fader
{
    partial class Options1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Options1()
        {
            /// <summary>
            /// Required for Windows.Forms Class Composition Designer support
            /// </summary>
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrefixes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrefixes
            // 
            this.txtPrefixes.Location = new System.Drawing.Point(137, 71);
            this.txtPrefixes.Multiline = true;
            this.txtPrefixes.Name = "txtPrefixes";
            this.txtPrefixes.Size = new System.Drawing.Size(200, 250);
            this.txtPrefixes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prefixes";
            // 
            // Options1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrefixes);
            this.Name = "Options1";
            this.CommitChanges += new DevExpress.CodeRush.Core.OptionsPage.CommitChangesEventHandler(this.Options1_CommitChanges);
            this.PreparePage += new DevExpress.CodeRush.Core.OptionsPage.PreparePageEventHandler(this.Options1_PreparePage);
            this.RestoreDefaults += new DevExpress.CodeRush.Core.OptionsPage.RestoreDefaultsEventHandler(this.Options1_RestoreDefaults);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        ///
        /// Gets a DecoupledStorage instance for this options page.
        ///
        public static DecoupledStorage Storage
        {
            get
            {
                return DevExpress.CodeRush.Core.CodeRush.Options.GetStorage(GetCategory(), GetPageName());
            }
        }
        ///
        /// Returns the category of this options page.
        ///
        public override string Category
        {
            get
            {
                return Options1.GetCategory();
            }
        }
        ///
        /// Returns the page name of this options page.
        ///
        public override string PageName
        {
            get
            {
                return Options1.GetPageName();
            }
        }
        ///
        /// Returns the full path (Category + PageName) of this options page.
        ///
        public static string FullPath
        {
            get
            {
                return GetCategory() + "\\" + GetPageName();
            }
        }

        ///
        /// Displays the DXCore options dialog and selects this page.
        ///
        public new static void Show()
        {
            DevExpress.CodeRush.Core.CodeRush.Command.Execute("Options", FullPath);
        }

        private System.Windows.Forms.TextBox txtPrefixes;
        private System.Windows.Forms.Label label1;
    }
}