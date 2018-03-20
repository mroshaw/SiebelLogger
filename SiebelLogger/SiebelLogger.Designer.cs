namespace SiebelLogger
{
    partial class SiebelLogForm
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
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioSQL = new System.Windows.Forms.RadioButton();
            this.radioAlloc = new System.Windows.Forms.RadioButton();
            this.selectGroupBox = new System.Windows.Forms.GroupBox();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioOLE = new System.Windows.Forms.RadioButton();
            this.radioScript = new System.Windows.Forms.RadioButton();
            this.groupTrace = new System.Windows.Forms.GroupBox();
            this.textTrace = new System.Windows.Forms.TextBox();
            this.btnTraceTxt = new System.Windows.Forms.Button();
            this.btnTraceOff = new System.Windows.Forms.Button();
            this.btnTraceOn = new System.Windows.Forms.Button();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.buttonOpenLog = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.profGroupBox = new System.Windows.Forms.GroupBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtProfVal = new System.Windows.Forms.TextBox();
            this.txtProfName = new System.Windows.Forms.TextBox();
            this.automaticUpdaterMain = new wyDay.Controls.AutomaticUpdater();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeGroupBox.SuspendLayout();
            this.selectGroupBox.SuspendLayout();
            this.groupTrace.SuspendLayout();
            this.groupControl.SuspendLayout();
            this.profGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdaterMain)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.radioSQL);
            this.typeGroupBox.Controls.Add(this.radioAlloc);
            this.typeGroupBox.Location = new System.Drawing.Point(12, 127);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(96, 82);
            this.typeGroupBox.TabIndex = 0;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type";
            // 
            // radioSQL
            // 
            this.radioSQL.AutoSize = true;
            this.radioSQL.Checked = true;
            this.radioSQL.Location = new System.Drawing.Point(7, 44);
            this.radioSQL.Name = "radioSQL";
            this.radioSQL.Size = new System.Drawing.Size(46, 17);
            this.radioSQL.TabIndex = 4;
            this.radioSQL.TabStop = true;
            this.radioSQL.Text = "SQL";
            this.radioSQL.UseVisualStyleBackColor = true;
            this.radioSQL.CheckedChanged += new System.EventHandler(this.radioSQL_CheckedChanged);
            // 
            // radioAlloc
            // 
            this.radioAlloc.AutoSize = true;
            this.radioAlloc.Location = new System.Drawing.Point(7, 20);
            this.radioAlloc.Name = "radioAlloc";
            this.radioAlloc.Size = new System.Drawing.Size(71, 17);
            this.radioAlloc.TabIndex = 3;
            this.radioAlloc.Text = "Allocation";
            this.radioAlloc.UseVisualStyleBackColor = true;
            this.radioAlloc.CheckedChanged += new System.EventHandler(this.radioAlloc_CheckedChanged);
            // 
            // selectGroupBox
            // 
            this.selectGroupBox.Controls.Add(this.radioAll);
            this.selectGroupBox.Controls.Add(this.radioOLE);
            this.selectGroupBox.Controls.Add(this.radioScript);
            this.selectGroupBox.Location = new System.Drawing.Point(12, 27);
            this.selectGroupBox.Name = "selectGroupBox";
            this.selectGroupBox.Size = new System.Drawing.Size(96, 94);
            this.selectGroupBox.TabIndex = 1;
            this.selectGroupBox.TabStop = false;
            this.selectGroupBox.Text = "Selection";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Enabled = false;
            this.radioAll.Location = new System.Drawing.Point(7, 68);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(36, 17);
            this.radioAll.TabIndex = 2;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioOLE
            // 
            this.radioOLE.AutoSize = true;
            this.radioOLE.Enabled = false;
            this.radioOLE.Location = new System.Drawing.Point(7, 44);
            this.radioOLE.Name = "radioOLE";
            this.radioOLE.Size = new System.Drawing.Size(46, 17);
            this.radioOLE.TabIndex = 1;
            this.radioOLE.Text = "OLE";
            this.radioOLE.UseVisualStyleBackColor = true;
            // 
            // radioScript
            // 
            this.radioScript.AutoSize = true;
            this.radioScript.Enabled = false;
            this.radioScript.Location = new System.Drawing.Point(7, 20);
            this.radioScript.Name = "radioScript";
            this.radioScript.Size = new System.Drawing.Size(52, 17);
            this.radioScript.TabIndex = 0;
            this.radioScript.Text = "Script";
            this.radioScript.UseVisualStyleBackColor = true;
            // 
            // groupTrace
            // 
            this.groupTrace.Controls.Add(this.textTrace);
            this.groupTrace.Controls.Add(this.btnTraceTxt);
            this.groupTrace.Controls.Add(this.btnTraceOff);
            this.groupTrace.Controls.Add(this.btnTraceOn);
            this.groupTrace.Location = new System.Drawing.Point(120, 127);
            this.groupTrace.Name = "groupTrace";
            this.groupTrace.Size = new System.Drawing.Size(223, 82);
            this.groupTrace.TabIndex = 9;
            this.groupTrace.TabStop = false;
            this.groupTrace.Text = "Trace";
            // 
            // textTrace
            // 
            this.textTrace.Location = new System.Drawing.Point(87, 49);
            this.textTrace.Multiline = true;
            this.textTrace.Name = "textTrace";
            this.textTrace.Size = new System.Drawing.Size(130, 22);
            this.textTrace.TabIndex = 12;
            // 
            // btnTraceTxt
            // 
            this.btnTraceTxt.Enabled = false;
            this.btnTraceTxt.Location = new System.Drawing.Point(6, 48);
            this.btnTraceTxt.Name = "btnTraceTxt";
            this.btnTraceTxt.Size = new System.Drawing.Size(75, 23);
            this.btnTraceTxt.TabIndex = 11;
            this.btnTraceTxt.Text = "Comment >>";
            this.btnTraceTxt.UseVisualStyleBackColor = true;
            this.btnTraceTxt.Click += new System.EventHandler(this.btnTraceTxt_Click);
            // 
            // btnTraceOff
            // 
            this.btnTraceOff.Enabled = false;
            this.btnTraceOff.Location = new System.Drawing.Point(87, 20);
            this.btnTraceOff.Name = "btnTraceOff";
            this.btnTraceOff.Size = new System.Drawing.Size(75, 23);
            this.btnTraceOff.TabIndex = 10;
            this.btnTraceOff.Text = "Trace Off";
            this.btnTraceOff.UseVisualStyleBackColor = true;
            this.btnTraceOff.Click += new System.EventHandler(this.btnTraceOff_Click);
            // 
            // btnTraceOn
            // 
            this.btnTraceOn.Enabled = false;
            this.btnTraceOn.Location = new System.Drawing.Point(6, 19);
            this.btnTraceOn.Name = "btnTraceOn";
            this.btnTraceOn.Size = new System.Drawing.Size(75, 23);
            this.btnTraceOn.TabIndex = 9;
            this.btnTraceOn.Text = "Trace On";
            this.btnTraceOn.UseVisualStyleBackColor = true;
            this.btnTraceOn.Click += new System.EventHandler(this.btnTraceOn_Click);
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.buttonOpenLog);
            this.groupControl.Controls.Add(this.btnClose);
            this.groupControl.Controls.Add(this.btnConnect);
            this.groupControl.Controls.Add(this.textLog);
            this.groupControl.Controls.Add(this.lblLogFile);
            this.groupControl.Location = new System.Drawing.Point(120, 27);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(223, 94);
            this.groupControl.TabIndex = 11;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "Control";
            // 
            // buttonOpenLog
            // 
            this.buttonOpenLog.Image = global::SiebelLogger.Properties.Resources.SIEBLOG_document_text_edit_16;
            this.buttonOpenLog.Location = new System.Drawing.Point(185, 51);
            this.buttonOpenLog.Name = "buttonOpenLog";
            this.buttonOpenLog.Size = new System.Drawing.Size(32, 23);
            this.buttonOpenLog.TabIndex = 8;
            this.buttonOpenLog.UseVisualStyleBackColor = true;
            this.buttonOpenLog.Click += new System.EventHandler(this.buttonOpenLog_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(88, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(31, 52);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(148, 20);
            this.textLog.TabIndex = 7;
            this.textLog.Text = "C:\\Siebel\\SiebelLog.txt";
            // 
            // lblLogFile
            // 
            this.lblLogFile.AutoSize = true;
            this.lblLogFile.Location = new System.Drawing.Point(7, 55);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(25, 13);
            this.lblLogFile.TabIndex = 11;
            this.lblLogFile.Text = "Log";
            // 
            // profGroupBox
            // 
            this.profGroupBox.Controls.Add(this.btnGet);
            this.profGroupBox.Controls.Add(this.txtProfVal);
            this.profGroupBox.Controls.Add(this.txtProfName);
            this.profGroupBox.Location = new System.Drawing.Point(12, 216);
            this.profGroupBox.Name = "profGroupBox";
            this.profGroupBox.Size = new System.Drawing.Size(331, 48);
            this.profGroupBox.TabIndex = 13;
            this.profGroupBox.TabStop = false;
            this.profGroupBox.Text = "Profile Attribute Lookup";
            // 
            // btnGet
            // 
            this.btnGet.Image = global::SiebelLogger.Properties.Resources.SIEBLOG_find_16;
            this.btnGet.Location = new System.Drawing.Point(293, 18);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(32, 23);
            this.btnGet.TabIndex = 15;
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtProfVal
            // 
            this.txtProfVal.Location = new System.Drawing.Point(151, 20);
            this.txtProfVal.Name = "txtProfVal";
            this.txtProfVal.ReadOnly = true;
            this.txtProfVal.Size = new System.Drawing.Size(138, 20);
            this.txtProfVal.TabIndex = 14;
            // 
            // txtProfName
            // 
            this.txtProfName.Location = new System.Drawing.Point(7, 20);
            this.txtProfName.Name = "txtProfName";
            this.txtProfName.Size = new System.Drawing.Size(138, 20);
            this.txtProfName.TabIndex = 13;
            // 
            // automaticUpdaterMain
            // 
            this.automaticUpdaterMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.automaticUpdaterMain.ContainerForm = this;
            this.automaticUpdaterMain.Location = new System.Drawing.Point(327, 5);
            this.automaticUpdaterMain.Name = "automaticUpdaterMain";
            this.automaticUpdaterMain.Size = new System.Drawing.Size(16, 16);
            this.automaticUpdaterMain.TabIndex = 14;
            this.automaticUpdaterMain.ToolStripItem = this.updateToolStripMenuItem1;
            this.automaticUpdaterMain.wyUpdateCommandline = null;
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Image = global::SiebelLogger.Properties.Resources.SIEBLOG_nternet_update_16;
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.updateToolStripMenuItem1.Text = "Update...";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(355, 24);
            this.menuStripMain.TabIndex = 15;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SiebelLogger.Properties.Resources.SIEBLOG_close_window;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Image = global::SiebelLogger.Properties.Resources.SIEBLOG_window_panel_top_16;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SiebelLogger.Properties.Resources.SIEBLOG_info_16;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SiebelLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 272);
            this.Controls.Add(this.automaticUpdaterMain);
            this.Controls.Add(this.profGroupBox);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.groupTrace);
            this.Controls.Add(this.selectGroupBox);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SiebelLogForm";
            this.Text = "Siebel Logger";
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.selectGroupBox.ResumeLayout(false);
            this.selectGroupBox.PerformLayout();
            this.groupTrace.ResumeLayout(false);
            this.groupTrace.PerformLayout();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            this.profGroupBox.ResumeLayout(false);
            this.profGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdaterMain)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton radioSQL;
        private System.Windows.Forms.RadioButton radioAlloc;
        private System.Windows.Forms.GroupBox selectGroupBox;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioOLE;
        private System.Windows.Forms.RadioButton radioScript;
        private System.Windows.Forms.GroupBox groupTrace;
        private System.Windows.Forms.TextBox textTrace;
        private System.Windows.Forms.Button btnTraceTxt;
        private System.Windows.Forms.Button btnTraceOff;
        private System.Windows.Forms.Button btnTraceOn;
        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.GroupBox profGroupBox;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtProfVal;
        private System.Windows.Forms.TextBox txtProfName;
        private System.Windows.Forms.Button buttonOpenLog;
        private wyDay.Controls.AutomaticUpdater automaticUpdaterMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

