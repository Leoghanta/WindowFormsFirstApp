using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Instance of NewCounter object.
        NewCounter counter = new NewCounter();

        /// <summary>
        /// Build in method to initialise the form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ClickMeButton has been clicked. handle this event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Attempt to update the count. and display in label 
                counter.Inc();
                label1.Text = counter.Count.ToString();
            }
            catch (Exception ex)
            {
                //Handle exceptions by placing error in label.
                label1.Text = ex.Message;
            }
        }
    }
}
