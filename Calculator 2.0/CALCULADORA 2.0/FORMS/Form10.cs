﻿

namespace CALCULADORA_2._0
{
    public partial class Form10 : Form
    {
        public Form10()
        {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "You did not enter a server name. Cancel this operation?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }
        }
    }

}

