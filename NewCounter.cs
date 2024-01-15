using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class NewCounter
    {
        // Private count variable.
        private int _count = 0;

        // Public Count variable with getters and setters.
        // get will return the conents of the private variable
        // set will set the new value to private variable.
        // update: set will check if new value is > 10, and send error
        public int Count {

            get 
            {
                return _count;
            }
            set 
            { 
                if (value > 10)
                {
                    // We can't send errors to UI from the model
                    // so we throw the exception backwards.
                    throw new Exception("Number too High");
                }
                _count = value;
            
            }
        }

        /// <summary>
        /// Method that increments the count variable.
        /// </summary>
        public void Inc()
        {
            Count++;
        }

    }
}
