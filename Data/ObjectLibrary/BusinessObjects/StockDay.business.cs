

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class StockDay
    [Serializable]
    public partial class StockDay
    {

        #region Private Variables
        #endregion

        #region Constructor
        public StockDay()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public StockDay Clone()
            {
                // Create New Object
                StockDay newStockDay = (StockDay) this.MemberwiseClone();

                // Return Cloned Object
                return newStockDay;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
