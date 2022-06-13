using System;
using System.Windows.Forms;

namespace RegFuck
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (MessageBox.Show("This program was made to destroy the registry of your computer.\n" + 
                "Using it will likely make your computer unbootable or unusable.\n" +
                "You have been warned. Clicking Yes will start the program now.", "REGFuck - Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Run(new Form1());
        }
    }
}
