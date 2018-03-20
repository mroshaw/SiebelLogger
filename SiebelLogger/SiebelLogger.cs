using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Media;
using System.Diagnostics;

namespace SiebelLogger
{
    public partial class SiebelLogForm : Form
    {

        private TWSiebelLib.SiebelWebApplication SiebelApp;

        public SiebelLogForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.SIEBLOG_database_find_32;
        }

        /// <summary>
        /// Handle enabling tracing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraceOn_Click(object sender, EventArgs e)
        {
            string cat = "";
            string src ="";

            if (radioAll.Checked) src = "All";
            else if (radioOLE.Checked) src = "OLE";
            else if (radioScript.Checked) src = "Script";

            if (radioAlloc.Checked) cat = "Allocation";
            else if (radioSQL.Checked)
            {
                cat = "SQL";
                src = "";
            }

            // Enable tracing
            try
            {
                // Switch tracing on
                SiebelApp.TraceOn(textLog.Text, cat, src);

                // Toggle trace controls
                traceToggleControls(true);
            }
            catch(Exception onE)
            {
                 showError("An error occurred enabling tracing", "This is probably due to the fact that the Siebel instance has been killed.",onE.ToString());
            }
        }

        /// <summary>
        /// Handle disabling tracing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraceOff_Click(object sender, EventArgs e)
        {
            // Disable tracing
            try
            {
                // Switch tracing off
                SiebelApp.TraceOff();
            }
            catch (Exception offE)
            {
                showError("An error occurred disabling tracing", "The Siebel instance may have been closed or killed.", offE.ToString());
            }
            // Toggle trace controls
            traceToggleControls(false);
        }

        /// <summary>
        /// Connect to the running Siebel instance
        /// </summary>
        private Boolean connectToSiebel()
        {
            // Create new connection to Siebel instace
            try
            {
                SiebelApp = new TWSiebelLib.SiebelWebApplication();
                return true;
            }
            catch (Exception conE)
            {
                showError("An error occurred connecting to Siebel", "Please ensure the Siebel Dedicated Web Client is running and that this application has been run 'As Administrator'.", 
                    conE.ToString());
                return false;
            }
        }

        /// <summary>
        /// Close the connection to the Siebel Client
        /// </summary>
        /// <returns></returns>
        private Boolean closeSiebel()
        {
            try
            {
                SiebelApp = null;
                return true;
            }

            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Toggle the state of the controls based on Trace status
        /// </summary>
        private void traceToggleControls(Boolean state)
        {
            btnTraceOff.Enabled = state;
            btnTraceOn.Enabled = !state;
            btnTraceTxt.Enabled = state;
            
            radioAll.Enabled = !state;
            radioAlloc.Enabled = !state;
            radioOLE.Enabled = !state;
            radioScript.Enabled = !state;
            radioSQL.Enabled = !state;

        }

        /// <summary>
        /// Toggle the state based on the Connection status
        /// </summary>
        private void connectToggleControls(Boolean state)
        {
            // Toggle all controls
            btnConnect.Enabled = !state;
            btnClose.Enabled = state;
            btnTraceOn.Enabled = state;
            btnTraceOff.Enabled = btnTraceOff.Enabled && state;
            btnTraceTxt.Enabled = btnTraceTxt.Enabled && state;
            btnGet.Enabled = state;
        }

        /// <summary>
        /// Handling Write to Trace Log button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraceTxt_Click(object sender, EventArgs e)
        {
            try
            {

                if (textTrace.Text != "")
                {
                    // Write the field contents to the trace log
                    SiebelApp.Trace(textTrace.Text);
                }
            }
            catch (Exception trcE)
            {
                showError("An error occurred writing to the trace file", "This is probably due to the fact that the Siebel instance has been killed.", trcE.ToString());
            }
        }

        /// <summary>
        /// Handle the Connect button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Try to connect to Siebel
            if (connectToSiebel())
            {
                connectToggleControls(true);
            }
        }

        // Handle the Disconnect / Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (closeSiebel())
            {
                connectToggleControls(false);
            }
        }

        /// <summary>
        /// Handle the 'Always on Top' menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
            this.TopMost = !this.TopMost;
        }

        /// <summary>
        /// Handle the Exit menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the connection
            if (SiebelApp != null)
                closeSiebel();

            // Close the application
            this.Close();
        }

        /// <summary>
        /// Handle About menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// Display error dialog via the TaskDialog control
        /// </summary>
        /// <param name="errText"></param>
        private void showError(string instrText, string errText, string exceptionText)
        {
            TaskDialog dialog = new TaskDialog();
            dialog.Caption = "Error!";
            dialog.InstructionText = instrText;
            dialog.Icon = TaskDialogStandardIcon.Error;
            dialog.Cancelable = false;
            dialog.Text = errText;
            dialog.DetailsCollapsedLabel = "Show Error Details";
            dialog.DetailsExpandedLabel = "Hide Error Details";
            dialog.DetailsExpandedText = exceptionText;
            System.Media.SystemSounds.Exclamation.Play();
            dialog.Show();
        }

        /// <summary>
        /// When SQL is selected, allocation is not permitted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioSQL_CheckedChanged(object sender, EventArgs e)
        {
            sqlToggleControl(true);
        }

        private void sqlToggleControl(Boolean state)
        {
            radioScript.Enabled = !state;
            radioOLE.Enabled = !state;
            radioAll.Enabled = !state;
        }

        /// <summary>
        /// Allow all alloc when SQL not selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioAlloc_CheckedChanged(object sender, EventArgs e)
        {
            sqlToggleControl(false);
        }
        /// <summary>
        /// Handle get and display of profile attribute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGet_Click(object sender, EventArgs e)
        {
            string profName = txtProfName.Text;

            try
            {
                if (profName != "")
                {
                    txtProfVal.Text = SiebelApp.GetProfileAttr(profName);
                }
            }
            catch (Exception getE)
            {
                showError("An error occurred getting the profile attribute value", "This is probably due to the fact that the Siebel instance has been killed.", getE.ToString());
            }
        }

        private void buttonOpenLog_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(textLog.Text);
            }
            catch (Exception e2)
            {

            }
        }
    }
}
