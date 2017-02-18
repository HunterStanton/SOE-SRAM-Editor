using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOE_SRAM_Editor
{
    /// <summary>
    /// The main window of the application.
    /// </summary>
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region File Menu stuff
        /// <summary>
        /// Used when the user selects the Exit option in the File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the app
            // We will need to change this later to account for a file being open, and offer to save if there are any changes
            Application.Exit();
        }

        /// <summary>
        /// Used when the user selects the Save option in the File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing right now
            return;
        }

        /// <summary>
        ///  Used when the user selects the Open option in the File menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing right now
            return;
        }

        #endregion

        #region Save Slot Menu stuff
        /// <summary>
        ///  Used when the user selects the Save Slot 1 option in the Save Slot menu.
        ///  Switches to save slot #1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSlot1MenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing right now.
            SaveSlotLabel.Text = "Save Slot 1";
            return;
        }

        /// <summary>
        ///  Used when the user selects the Save Slot 2 option in the Save Slot menu.
        ///  Switches to save slot #2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSlot2MenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing right now.
            SaveSlotLabel.Text = "Save Slot 2";
            return;
        }

        /// <summary>
        ///  Used when the user selects the Save Slot 3 option in the Save Slot menu.
        ///  Switches to save slot #3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSlot3MenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing right now.
            SaveSlotLabel.Text = "Save Slot 3";
            return;
        }

        /// <summary>
        ///  Used when the user selects the Save Slot 4 option in the Save Slot menu.
        ///  Switches to save slot #4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSlot4MenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing right now.
            SaveSlotLabel.Text = "Save Slot 4";
            return;
        }
        #endregion

        #region About stuff.
        /// <summary>
        ///  Used when the user clicks on the About menu option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Secret of Evermore SRAM Editor v0.0 Alpha\nCopyright 2017 Hunter Stanton", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Experimental Menu stuff.
        /// <summary>
        /// Used when the user clicks on the Enable Limits menu option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnableLimitsMenuItem_Click(object sender, EventArgs e)
        {
            LimitsLabel.Text = "Limits Enabled";
        }

        /// <summary>
        ///  Used when the user clicks on the Disable Limits menu option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisableLimitsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limits (such as alchemy ingredient limits) are now raised to their theoretical maximum where applicable.\nYou MAY experience bugs in-game when going above the limits.\nWould not advise using this on a save you care about!", "Important Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LimitsLabel.Text = "Limits Disabled";
        }
        #endregion
    }
}
