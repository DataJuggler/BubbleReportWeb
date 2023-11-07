

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class DoNotTrack
    [Serializable]
    public partial class DoNotTrack
    {

        #region Private Variables
        #endregion

        #region Constructor
        public DoNotTrack()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public DoNotTrack Clone()
            {
                // Create New Object
                DoNotTrack newDoNotTrack = (DoNotTrack) this.MemberwiseClone();

                // Return Cloned Object
                return newDoNotTrack;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
