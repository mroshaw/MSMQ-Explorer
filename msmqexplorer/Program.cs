#region

using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

#endregion

namespace MSMQExplorer
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += UiThreadException;
            // Set the unhandled exception mode to force all Windows Forms errors to go through 
            // our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMsmqExplorer());
        }

        // Handle the UI exceptions by showing a dialog box, and asking the user whether 
        // or not they wish to abort execution. 
        private static void UiThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowThreadExceptionDialog("Windows Forms Error", t.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show(Strings.Fatal_Windows_Forms_Error,
                        Strings.Fatal_Windows_Forms_Error, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort. 
            if (result == DialogResult.Abort)
                Application.Exit();
        }

        // Handle the UI exceptions by showing a dialog box, and asking the user whether 
        // or not they wish to abort execution. 
        // NOTE: This exception cannot be kept from terminating the application - it can only  
        // log the event, and inform the user about it.  
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception) e.ExceptionObject;
                const string errorMsg = "An application error occurred. Please contact the adminstrator " +
                                        "with the following information:\n\n";

                // Since we can't prevent the app from terminating, log this to the event log. 
                if (!EventLog.SourceExists("ThreadException"))
                {
                    EventLog.CreateEventSource("ThreadException", "Application");
                }

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog {Source = "ThreadException"};
                myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show(
                        Strings.Fatal_Non_UI_Error_Detail
                        + exc.Message, Strings.Fatal_Non_UI_Error, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        // Creates the error message and displays it. 
        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred. Please contact the adminstrator " +
                              "with the following information:\n\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }
    }
}