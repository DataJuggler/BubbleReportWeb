

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class TopLosingStreakStocks
    [Serializable]
    public partial class TopLosingStreakStocks
    {

        #region Private Variables
        #endregion

        #region Constructor
        public TopLosingStreakStocks()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public TopLosingStreakStocks Clone()
            {
                // Create New Object
                TopLosingStreakStocks newTopLosingStreakStocks = (TopLosingStreakStocks) this.MemberwiseClone();

                // Return Cloned Object
                return newTopLosingStreakStocks;
            }
            #endregion

        #endregion

        #region Properties

            #region ShortName
            /// <summary>
            /// This read only property returns the value of ShortName from the object Name.
            /// </summary>
            public string ShortName
            {
                
                get
                {
                    // initial value
                    string shortName = "";
                    
                    // if Name exists
                    if (Name != null)
                    {
                        if (Name.Length >= 22)
                        {
                            // set the return value
                            shortName = Name.Substring(0, 22);
                        }
                        else
                        {
                            // Use the full name
                            shortName = Name;
                        }
                    }
                    
                    // return value
                    return shortName;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
