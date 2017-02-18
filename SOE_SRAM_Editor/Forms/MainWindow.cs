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
            return;
        }
        #endregion
    }
}
