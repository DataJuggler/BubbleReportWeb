

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Sector
    [Serializable]
    public partial class Sector
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Sector()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Sector Clone()
            {
                // Create New Object
                Sector newSector = (Sector) this.MemberwiseClone();

                // Return Cloned Object
                return newSector;
            }
            #endregion

        #endregion

        #region Properties

            #region ShortName
            /// <summary>
            /// This read only property returns a ShortName for this Industry
            /// </summary>
            public string ShortName
            {
                get
                {
                    // initial value
                    string name = Name;

                    if (Name.Length >= 17)
                    {
                        // return a shortName
                        name = Name.Substring(0, 17);
                    }

                    // return the name
                    return name;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
