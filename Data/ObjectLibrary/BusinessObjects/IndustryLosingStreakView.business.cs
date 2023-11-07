

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class IndustryLosingStreakView
    [Serializable]
    public partial class IndustryLosingStreakView
    {

        #region Private Variables
        #endregion

        #region Constructor
        public IndustryLosingStreakView()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public IndustryLosingStreakView Clone()
            {
                // Create New Object
                IndustryLosingStreakView newIndustryLosingStreakView = (IndustryLosingStreakView) this.MemberwiseClone();

                // Return Cloned Object
                return newIndustryLosingStreakView;
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

                    if (Name.Length >= 16)
                    {
                        // return a shortName
                        name = Name.Substring(0, 16);
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
