

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class TopStreakStocks
    [Serializable]
    public partial class TopStreakStocks
    {

        #region Private Variables
        #endregion

        #region Constructor
        public TopStreakStocks()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public TopStreakStocks Clone()
            {
                // Create New Object
                TopStreakStocks newTopStreakStocks = (TopStreakStocks) this.MemberwiseClone();

                // Return Cloned Object
                return newTopStreakStocks;
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
