namespace WindowsFormsApp7
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.krylblUsr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krytxtUsr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.krytxtPwd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.krybtnEnter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krybtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krybtnSetting = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonSpecAnyPwd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAnyUsr = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.qGlobalColorSchemeManager1 = new Qios.DevSuite.Components.QGlobalColorSchemeManager(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(591, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "施工日志";
            // 
            // krylblUsr
            // 
            this.krylblUsr.Location = new System.Drawing.Point(12, 185);
            this.krylblUsr.Name = "krylblUsr";
            this.krylblUsr.Size = new System.Drawing.Size(49, 20);
            this.krylblUsr.TabIndex = 1;
            this.krylblUsr.Values.Text = "用户名";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(191, 185);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "密 码";
            // 
            // krytxtUsr
            // 
            this.krytxtUsr.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyUsr});
            this.krytxtUsr.Location = new System.Drawing.Point(67, 185);
            this.krytxtUsr.Name = "krytxtUsr";
            this.krytxtUsr.Size = new System.Drawing.Size(100, 22);
            this.krytxtUsr.StateActive.Content.Padding = new System.Windows.Forms.Padding(2);
            this.krytxtUsr.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.krytxtUsr.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krytxtUsr.TabIndex = 3;
            // 
            // krytxtPwd
            // 
            this.krytxtPwd.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAnyPwd});
            this.krytxtPwd.Location = new System.Drawing.Point(250, 185);
            this.krytxtPwd.Name = "krytxtPwd";
            this.krytxtPwd.PasswordChar = '*';
            this.krytxtPwd.Size = new System.Drawing.Size(100, 24);
            this.krytxtPwd.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.krytxtPwd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krytxtPwd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.krytxtPwd.TabIndex = 4;
            this.krytxtPwd.UseMnemonic = false;
            // 
            // krybtnEnter
            // 
            this.krybtnEnter.Location = new System.Drawing.Point(384, 185);
            this.krybtnEnter.Name = "krybtnEnter";
            this.krybtnEnter.Size = new System.Drawing.Size(55, 24);
            this.krybtnEnter.TabIndex = 5;
            this.krybtnEnter.Values.Text = "登 录";
            // 
            // krybtnCancel
            // 
            this.krybtnCancel.Location = new System.Drawing.Point(445, 185);
            this.krybtnCancel.Name = "krybtnCancel";
            this.krybtnCancel.Size = new System.Drawing.Size(55, 24);
            this.krybtnCancel.TabIndex = 6;
            this.krybtnCancel.Values.Text = "取消";
            // 
            // krybtnSetting
            // 
            this.krybtnSetting.Location = new System.Drawing.Point(506, 185);
            this.krybtnSetting.Name = "krybtnSetting";
            this.krybtnSetting.Size = new System.Drawing.Size(55, 24);
            this.krybtnSetting.TabIndex = 7;
            this.krybtnSetting.Values.Text = "设置";
            this.krybtnSetting.Click += new System.EventHandler(this.krybtnSetting_Click);
            // 
            // buttonSpecAnyPwd
            // 
            this.buttonSpecAnyPwd.Image = global::WindowsFormsApp7.Properties.Resources.edit_clear;
            this.buttonSpecAnyPwd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyPwd.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyPwd.UniqueName = "88B1A0605BC94049888FE68A5045B4AD";
            this.buttonSpecAnyPwd.Click += new System.EventHandler(this.buttonSpecAnyPwd_Click);
            // 
            // buttonSpecAnyUsr
            // 
            this.buttonSpecAnyUsr.Image = global::WindowsFormsApp7.Properties.Resources.edit_clear;
            this.buttonSpecAnyUsr.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.buttonSpecAnyUsr.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            this.buttonSpecAnyUsr.UniqueName = "DD718EE1C9024E8CF3A711F5F29DA209";
            this.buttonSpecAnyUsr.Click += new System.EventHandler(this.buttonSpecAnyUsr_Click);
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(591, 240);
            this.Controls.Add(this.krybtnSetting);
            this.Controls.Add(this.krybtnCancel);
            this.Controls.Add(this.krybtnEnter);
            this.Controls.Add(this.krytxtPwd);
            this.Controls.Add(this.krytxtUsr);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.krylblUsr);
            this.Controls.Add(this.qRibbonCaption1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 246);
            this.MinimumSize = new System.Drawing.Size(597, 246);
            this.Name = "FrmLogin";
            this.Text = "施工日志";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel krylblUsr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox krytxtUsr;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyUsr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox krytxtPwd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAnyPwd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krybtnEnter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krybtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krybtnSetting;
        private Qios.DevSuite.Components.QGlobalColorSchemeManager qGlobalColorSchemeManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}