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

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing right now
            return;
        }
        #endregion
    }
}
