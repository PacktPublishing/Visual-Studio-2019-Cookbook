using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Class to demonstrate code regions and outlining
    /// </summary>
    public class Class1
    {
        #region Properties
        /// <summary>
        /// Sample property
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Sample public method1
        /// </summary>
        public void PublicMethod1()
        {
            #region Conditional Check           
            if (true)
            {
                int i;
                int j=5;

                for (i = 0; i <= j; i++)
                {
                }
            }
            else
            {

            }
            #endregion
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Sample private method1
        /// </summary>
        public void PrivateMethod1()
        {
        }

        public void PrivateMethod2()
        {
        }
        #endregion

    }
}
