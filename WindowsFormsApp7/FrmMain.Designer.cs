namespace WindowsFormsApp7
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.qRibbon1 = new Qios.DevSuite.Components.Ribbon.QRibbon();
            this.qRibbonPage1 = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPage2 = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).BeginInit();
            this.qRibbon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(638, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "施工日志";
            // 
            // qRibbon1
            // 
            this.qRibbon1.ActiveTabPage = this.qRibbonPage1;
            this.qRibbon1.Controls.Add(this.qRibbonPage1);
            this.qRibbon1.Controls.Add(this.qRibbonPage2);
            this.qRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.qRibbon1.Location = new System.Drawing.Point(0, 28);
            this.qRibbon1.Name = "qRibbon1";
            this.qRibbon1.PersistGuid = new System.Guid("b4933adf-86ab-4c40-937a-5c9582ff1f06");
            this.qRibbon1.Size = new System.Drawing.Size(638, 50);
            this.qRibbon1.TabIndex = 1;
            this.qRibbon1.TabStripConfiguration.HelpButtonVisible = false;
            this.qRibbon1.Text = "qRibbon1";
            this.qRibbon1.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbon1_ItemActivated_1);
            // 
            // qRibbonPage1
            // 
            this.qRibbonPage1.ButtonOrder = 0;
            this.qRibbonPage1.Location = new System.Drawing.Point(2, 30);
            this.qRibbonPage1.Name = "qRibbonPage1";
            this.qRibbonPage1.PersistGuid = new System.Guid("3a290911-3258-4b1a-869b-ef392b93f9c0");
            this.qRibbonPage1.Size = new System.Drawing.Size(632, 16);
            this.qRibbonPage1.Text = "工具";
            // 
            // qRibbonPage2
            // 
            this.qRibbonPage2.ButtonOrder = 1;
            this.qRibbonPage2.Location = new System.Drawing.Point(2, 30);
            this.qRibbonPage2.Name = "qRibbonPage2";
            this.qRibbonPage2.PersistGuid = new System.Guid("b5a6dc86-82ff-460b-a570-104442283cee");
            this.qRibbonPage2.Size = new System.Drawing.Size(632, 16);
            this.qRibbonPage2.Text = "设置";
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(638, 294);
            this.Controls.Add(this.qRibbon1);
            this.Controls.Add(this.qRibbonCaption1);
            this.Name = "FrmMain";
            this.Text = "施工日志";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).EndInit();
            this.qRibbon1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.Ribbon.QRibbon qRibbon1;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPage1;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPage2;
    }
}