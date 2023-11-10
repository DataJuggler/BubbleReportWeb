

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class ControllerManager
    /// <summary>
    /// This class manages the child controllers for this application.
    /// </summary>
    public class ControllerManager
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        private AdminController adminController;
        private DailyPriceDataController dailypricedataController;
        private DailyPriceDataViewController dailypricedataviewController;
        private DoNotTrackController donottrackController;
        private IndustryController industryController;
        private IndustryLosingStreakViewController industrylosingstreakviewController;
        private IndustrySummaryController industrysummaryController;
        private IndustryWinningStreakViewController industrywinningstreakviewController;
        private MarketSummaryController marketsummaryController;
        private SectorController sectorController;
        private SectorSummaryController sectorsummaryController;
        private StockDayController stockdayController;
        private TopLosingStreakStocksController toplosingstreakstocksController;
        private TopStreakStocksController topstreakstocksController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ControllerManager' object.
        /// </summary>
        public ControllerManager(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;

            // Create Child Controllers
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child Controllers
            /// </summary>
            private void Init()
            {
                // Create Child Controllers
                this.AdminController = new AdminController(this.ErrorProcessor, this.AppController);
                this.DailyPriceDataController = new DailyPriceDataController(this.ErrorProcessor, this.AppController);
                this.DailyPriceDataViewController = new DailyPriceDataViewController(this.ErrorProcessor, this.AppController);
                this.DoNotTrackController = new DoNotTrackController(this.ErrorProcessor, this.AppController);
                this.IndustryController = new IndustryController(this.ErrorProcessor, this.AppController);
                this.IndustryLosingStreakViewController = new IndustryLosingStreakViewController(this.ErrorProcessor, this.AppController);
                this.IndustrySummaryController = new IndustrySummaryController(this.ErrorProcessor, this.AppController);
                this.IndustryWinningStreakViewController = new IndustryWinningStreakViewController(this.ErrorProcessor, this.AppController);
                this.MarketSummaryController = new MarketSummaryController(this.ErrorProcessor, this.AppController);
                this.SectorController = new SectorController(this.ErrorProcessor, this.AppController);
                this.SectorSummaryController = new SectorSummaryController(this.ErrorProcessor, this.AppController);
                this.StockDayController = new StockDayController(this.ErrorProcessor, this.AppController);
                this.TopLosingStreakStocksController = new TopLosingStreakStocksController(this.ErrorProcessor, this.AppController);
                this.TopStreakStocksController = new TopStreakStocksController(this.ErrorProcessor, this.AppController);
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

            #region AdminController
            public AdminController AdminController
            {
                get { return adminController; }
                set { adminController = value; }
            }
            #endregion

            #region DailyPriceDataController
            public DailyPriceDataController DailyPriceDataController
            {
                get { return dailypricedataController; }
                set { dailypricedataController = value; }
            }
            #endregion

            #region DailyPriceDataViewController
            public DailyPriceDataViewController DailyPriceDataViewController
            {
                get { return dailypricedataviewController; }
                set { dailypricedataviewController = value; }
            }
            #endregion

            #region DoNotTrackController
            public DoNotTrackController DoNotTrackController
            {
                get { return donottrackController; }
                set { donottrackController = value; }
            }
            #endregion

            #region IndustryController
            public IndustryController IndustryController
            {
                get { return industryController; }
                set { industryController = value; }
            }
            #endregion

            #region IndustryLosingStreakViewController
            public IndustryLosingStreakViewController IndustryLosingStreakViewController
            {
                get { return industrylosingstreakviewController; }
                set { industrylosingstreakviewController = value; }
            }
            #endregion

            #region IndustrySummaryController
            public IndustrySummaryController IndustrySummaryController
            {
                get { return industrysummaryController; }
                set { industrysummaryController = value; }
            }
            #endregion

            #region IndustryWinningStreakViewController
            public IndustryWinningStreakViewController IndustryWinningStreakViewController
            {
                get { return industrywinningstreakviewController; }
                set { industrywinningstreakviewController = value; }
            }
            #endregion

            #region MarketSummaryController
            public MarketSummaryController MarketSummaryController
            {
                get { return marketsummaryController; }
                set { marketsummaryController = value; }
            }
            #endregion

            #region SectorController
            public SectorController SectorController
            {
                get { return sectorController; }
                set { sectorController = value; }
            }
            #endregion

            #region SectorSummaryController
            public SectorSummaryController SectorSummaryController
            {
                get { return sectorsummaryController; }
                set { sectorsummaryController = value; }
            }
            #endregion

            #region StockDayController
            public StockDayController StockDayController
            {
                get { return stockdayController; }
                set { stockdayController = value; }
            }
            #endregion

            #region TopLosingStreakStocksController
            public TopLosingStreakStocksController TopLosingStreakStocksController
            {
                get { return toplosingstreakstocksController; }
                set { toplosingstreakstocksController = value; }
            }
            #endregion

            #region TopStreakStocksController
            public TopStreakStocksController TopStreakStocksController
            {
                get { return topstreakstocksController; }
                set { topstreakstocksController = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
