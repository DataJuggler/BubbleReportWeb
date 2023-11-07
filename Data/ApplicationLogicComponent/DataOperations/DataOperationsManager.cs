

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class DataOperationsManager
    /// <summary>
    /// This class manages DataOperations for this project.
    /// </summary>
    public class DataOperationsManager
    {

        #region Private Variables
        private DataManager dataManager;
        private SystemMethods systemMethods;
        private AdminMethods adminMethods;
        private DailyPriceDataMethods dailypricedataMethods;
        private DailyPriceDataViewMethods dailypricedataviewMethods;
        private DoNotTrackMethods donottrackMethods;
        private IndustryMethods industryMethods;
        private IndustryLosingStreakViewMethods industrylosingstreakviewMethods;
        private IndustrySummaryMethods industrysummaryMethods;
        private IndustryWinningStreakViewMethods industrywinningstreakviewMethods;
        private MarketSummaryMethods marketsummaryMethods;
        private SectorSummaryMethods sectorsummaryMethods;
        private TopLosingStreakStocksMethods toplosingstreakstocksMethods;
        private TopStreakStocksMethods topstreakstocksMethods;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'DataOperationsManager' object.
        /// </summary>
        public DataOperationsManager(DataManager dataManagerArg)
        {
            // Save Arguments
            this.DataManager = dataManagerArg;

            // Create Child DataOperationMethods
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child DataOperationMethods
            /// </summary>
            private void Init()
            {
                // Create Child DataOperatonMethods
                this.SystemMethods = new SystemMethods();
                this.AdminMethods = new AdminMethods(this.DataManager);
                this.DailyPriceDataMethods = new DailyPriceDataMethods(this.DataManager);
                this.DailyPriceDataViewMethods = new DailyPriceDataViewMethods(this.DataManager);
                this.DoNotTrackMethods = new DoNotTrackMethods(this.DataManager);
                this.IndustryMethods = new IndustryMethods(this.DataManager);
                this.IndustryLosingStreakViewMethods = new IndustryLosingStreakViewMethods(this.DataManager);
                this.IndustrySummaryMethods = new IndustrySummaryMethods(this.DataManager);
                this.IndustryWinningStreakViewMethods = new IndustryWinningStreakViewMethods(this.DataManager);
                this.MarketSummaryMethods = new MarketSummaryMethods(this.DataManager);
                this.SectorSummaryMethods = new SectorSummaryMethods(this.DataManager);
                this.TopLosingStreakStocksMethods = new TopLosingStreakStocksMethods(this.DataManager);
                this.TopStreakStocksMethods = new TopStreakStocksMethods(this.DataManager);
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager
            public DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

            #region SystemMethods
            public SystemMethods SystemMethods
            {
                get { return systemMethods; }
                set { systemMethods = value; }
            }
            #endregion

            #region AdminMethods
            public AdminMethods AdminMethods
            {
                get { return adminMethods; }
                set { adminMethods = value; }
            }
            #endregion

            #region DailyPriceDataMethods
            public DailyPriceDataMethods DailyPriceDataMethods
            {
                get { return dailypricedataMethods; }
                set { dailypricedataMethods = value; }
            }
            #endregion

            #region DailyPriceDataViewMethods
            public DailyPriceDataViewMethods DailyPriceDataViewMethods
            {
                get { return dailypricedataviewMethods; }
                set { dailypricedataviewMethods = value; }
            }
            #endregion

            #region DoNotTrackMethods
            public DoNotTrackMethods DoNotTrackMethods
            {
                get { return donottrackMethods; }
                set { donottrackMethods = value; }
            }
            #endregion

            #region IndustryMethods
            public IndustryMethods IndustryMethods
            {
                get { return industryMethods; }
                set { industryMethods = value; }
            }
            #endregion

            #region IndustryLosingStreakViewMethods
            public IndustryLosingStreakViewMethods IndustryLosingStreakViewMethods
            {
                get { return industrylosingstreakviewMethods; }
                set { industrylosingstreakviewMethods = value; }
            }
            #endregion

            #region IndustrySummaryMethods
            public IndustrySummaryMethods IndustrySummaryMethods
            {
                get { return industrysummaryMethods; }
                set { industrysummaryMethods = value; }
            }
            #endregion

            #region IndustryWinningStreakViewMethods
            public IndustryWinningStreakViewMethods IndustryWinningStreakViewMethods
            {
                get { return industrywinningstreakviewMethods; }
                set { industrywinningstreakviewMethods = value; }
            }
            #endregion

            #region MarketSummaryMethods
            public MarketSummaryMethods MarketSummaryMethods
            {
                get { return marketsummaryMethods; }
                set { marketsummaryMethods = value; }
            }
            #endregion

            #region SectorSummaryMethods
            public SectorSummaryMethods SectorSummaryMethods
            {
                get { return sectorsummaryMethods; }
                set { sectorsummaryMethods = value; }
            }
            #endregion

            #region TopLosingStreakStocksMethods
            public TopLosingStreakStocksMethods TopLosingStreakStocksMethods
            {
                get { return toplosingstreakstocksMethods; }
                set { toplosingstreakstocksMethods = value; }
            }
            #endregion

            #region TopStreakStocksMethods
            public TopStreakStocksMethods TopStreakStocksMethods
            {
                get { return topstreakstocksMethods; }
                set { topstreakstocksMethods = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
