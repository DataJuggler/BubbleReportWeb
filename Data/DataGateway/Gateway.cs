
#region using statements

using ApplicationLogicComponent.Controllers;
using ApplicationLogicComponent.DataOperations;
using DataAccessComponent.DataManager;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

#endregion

namespace DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods
        
            #region DeleteAdmin(int id, Admin tempAdmin = null)
            /// <summary>
            /// This method is used to delete Admin objects.
            /// </summary>
            /// <param name="id">Delete the Admin with this id</param>
            /// <param name="tempAdmin">Pass in a tempAdmin to perform a custom delete.</param>
            public bool DeleteAdmin(int id, Admin tempAdmin = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdmin does not exist
                    if (tempAdmin == null)
                    {
                        // create a temp Admin
                        tempAdmin = new Admin();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAdmin.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.AdminController.Delete(tempAdmin);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteDailyPriceData(int id, DailyPriceData tempDailyPriceData = null)
            /// <summary>
            /// This method is used to delete DailyPriceData objects.
            /// </summary>
            /// <param name="id">Delete the DailyPriceData with this id</param>
            /// <param name="tempDailyPriceData">Pass in a tempDailyPriceData to perform a custom delete.</param>
            public bool DeleteDailyPriceData(int id, DailyPriceData tempDailyPriceData = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDailyPriceData does not exist
                    if (tempDailyPriceData == null)
                    {
                        // create a temp DailyPriceData
                        tempDailyPriceData = new DailyPriceData();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempDailyPriceData.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.DailyPriceDataController.Delete(tempDailyPriceData);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteDoNotTrack(int id, DoNotTrack tempDoNotTrack = null)
            /// <summary>
            /// This method is used to delete DoNotTrack objects.
            /// </summary>
            /// <param name="id">Delete the DoNotTrack with this id</param>
            /// <param name="tempDoNotTrack">Pass in a tempDoNotTrack to perform a custom delete.</param>
            public bool DeleteDoNotTrack(int id, DoNotTrack tempDoNotTrack = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDoNotTrack does not exist
                    if (tempDoNotTrack == null)
                    {
                        // create a temp DoNotTrack
                        tempDoNotTrack = new DoNotTrack();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempDoNotTrack.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.DoNotTrackController.Delete(tempDoNotTrack);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteIndustry(int id, Industry tempIndustry = null)
            /// <summary>
            /// This method is used to delete Industry objects.
            /// </summary>
            /// <param name="id">Delete the Industry with this id</param>
            /// <param name="tempIndustry">Pass in a tempIndustry to perform a custom delete.</param>
            public bool DeleteIndustry(int id, Industry tempIndustry = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempIndustry does not exist
                    if (tempIndustry == null)
                    {
                        // create a temp Industry
                        tempIndustry = new Industry();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempIndustry.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.IndustryController.Delete(tempIndustry);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteSector(int id, Sector tempSector = null)
            /// <summary>
            /// This method is used to delete Sector objects.
            /// </summary>
            /// <param name="id">Delete the Sector with this id</param>
            /// <param name="tempSector">Pass in a tempSector to perform a custom delete.</param>
            public bool DeleteSector(int id, Sector tempSector = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempSector does not exist
                    if (tempSector == null)
                    {
                        // create a temp Sector
                        tempSector = new Sector();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempSector.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.SectorController.Delete(tempSector);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            /// <summary>
            /// This method Executes a Non Query StoredProcedure
            /// </summary>
            public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            {
                // initial value
                PolymorphicObject returnValue = new PolymorphicObject();

                // locals
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // create the parameters
                PolymorphicObject procedureNameParameter = new PolymorphicObject();
                PolymorphicObject sqlParametersParameter = new PolymorphicObject();

                // if the procedureName exists
                if (!String.IsNullOrEmpty(procedureName))
                {
                    // Create an instance of the SystemMethods object
                    SystemMethods systemMethods = new SystemMethods();

                    // setup procedureNameParameter
                    procedureNameParameter.Name = "ProcedureName";
                    procedureNameParameter.Text = procedureName;

                    // setup sqlParametersParameter
                    sqlParametersParameter.Name = "SqlParameters";
                    sqlParametersParameter.ObjectValue = sqlParameters;

                    // Add these parameters to the parameters
                    parameters.Add(procedureNameParameter);
                    parameters.Add(sqlParametersParameter);

                    // get the dataConnector
                    DataAccessComponent.DataManager.DataConnector dataConnector = GetDataConnector();

                    // Execute the query
                    returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
                }

                // return value
                return returnValue;
            }
            #endregion

            #region FindAdmin(int id, Admin tempAdmin = null)
            /// <summary>
            /// This method is used to find 'Admin' objects.
            /// </summary>
            /// <param name="id">Find the Admin with this id</param>
            /// <param name="tempAdmin">Pass in a tempAdmin to perform a custom find.</param>
            public Admin FindAdmin(int id, Admin tempAdmin = null)
            {
                // initial value
                Admin admin = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdmin does not exist
                    if (tempAdmin == null)
                    {
                        // create a temp Admin
                        tempAdmin = new Admin();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAdmin.UpdateIdentity(id);
                    }

                    // perform the find
                    admin = this.AppController.ControllerManager.AdminController.Find(tempAdmin);
                }

                // return value
                return admin;
            }
            #endregion

            #region FindDailyPriceData(int id, DailyPriceData tempDailyPriceData = null)
            /// <summary>
            /// This method is used to find 'DailyPriceData' objects.
            /// </summary>
            /// <param name="id">Find the DailyPriceData with this id</param>
            /// <param name="tempDailyPriceData">Pass in a tempDailyPriceData to perform a custom find.</param>
            public DailyPriceData FindDailyPriceData(int id, DailyPriceData tempDailyPriceData = null)
            {
                // initial value
                DailyPriceData dailyPriceData = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDailyPriceData does not exist
                    if (tempDailyPriceData == null)
                    {
                        // create a temp DailyPriceData
                        tempDailyPriceData = new DailyPriceData();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempDailyPriceData.UpdateIdentity(id);
                    }

                    // perform the find
                    dailyPriceData = this.AppController.ControllerManager.DailyPriceDataController.Find(tempDailyPriceData);
                }

                // return value
                return dailyPriceData;
            }
            #endregion

            #region FindDoNotTrack(int id, DoNotTrack tempDoNotTrack = null)
            /// <summary>
            /// This method is used to find 'DoNotTrack' objects.
            /// </summary>
            /// <param name="id">Find the DoNotTrack with this id</param>
            /// <param name="tempDoNotTrack">Pass in a tempDoNotTrack to perform a custom find.</param>
            public DoNotTrack FindDoNotTrack(int id, DoNotTrack tempDoNotTrack = null)
            {
                // initial value
                DoNotTrack doNotTrack = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDoNotTrack does not exist
                    if (tempDoNotTrack == null)
                    {
                        // create a temp DoNotTrack
                        tempDoNotTrack = new DoNotTrack();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempDoNotTrack.UpdateIdentity(id);
                    }

                    // perform the find
                    doNotTrack = this.AppController.ControllerManager.DoNotTrackController.Find(tempDoNotTrack);
                }

                // return value
                return doNotTrack;
            }
            #endregion

            #region FindIndustry(int id, Industry tempIndustry = null)
            /// <summary>
            /// This method is used to find 'Industry' objects.
            /// </summary>
            /// <param name="id">Find the Industry with this id</param>
            /// <param name="tempIndustry">Pass in a tempIndustry to perform a custom find.</param>
            public Industry FindIndustry(int id, Industry tempIndustry = null)
            {
                // initial value
                Industry industry = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempIndustry does not exist
                    if (tempIndustry == null)
                    {
                        // create a temp Industry
                        tempIndustry = new Industry();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempIndustry.UpdateIdentity(id);
                    }

                    // perform the find
                    industry = this.AppController.ControllerManager.IndustryController.Find(tempIndustry);
                }

                // return value
                return industry;
            }
            #endregion

            #region FindSector(int id, Sector tempSector = null)
            /// <summary>
            /// This method is used to find 'Sector' objects.
            /// </summary>
            /// <param name="id">Find the Sector with this id</param>
            /// <param name="tempSector">Pass in a tempSector to perform a custom find.</param>
            public Sector FindSector(int id, Sector tempSector = null)
            {
                // initial value
                Sector sector = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempSector does not exist
                    if (tempSector == null)
                    {
                        // create a temp Sector
                        tempSector = new Sector();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempSector.UpdateIdentity(id);
                    }

                    // perform the find
                    sector = this.AppController.ControllerManager.SectorController.Find(tempSector);
                }

                // return value
                return sector;
            }
            #endregion

            #region GetDataConnector()
            /// <summary>
            /// This method (safely) returns the Data Connector from the
            /// AppController.DataBridget.DataManager.DataConnector
            /// </summary>
            private DataConnector GetDataConnector()
            {
                // initial value
                DataConnector dataConnector = null;

                // if the AppController exists
                if (this.AppController != null)
                {
                    // return the DataConnector from the AppController
                    dataConnector = this.AppController.GetDataConnector();
                }

                // return value
                return dataConnector;
            }
            #endregion

            #region GetLastException()
            /// <summary>
            /// This method returns the last Exception from the AppController if one exists.
            /// Always test for null before refeferencing the Exception returned as it will be null 
            /// if no errors were encountered.
            /// </summary>
            /// <returns></returns>
            public Exception GetLastException()
            {
                // initial value
                Exception exception = null;

                // If the AppController object exists
                if (this.HasAppController)
                {
                    // return the Exception from the AppController
                    exception = this.AppController.Exception;

                    // Set to null after the exception is retrieved so it does not return again
                    this.AppController.Exception = null;
                }

                // return value
                return exception;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perform Initializations for this object.
            /// </summary>
            private void Init()
            {
                // Create Application Controller
                this.AppController = new ApplicationController(ConnectionName);
            }
            #endregion

            #region LoadAdmins(Admin tempAdmin = null)
            /// <summary>
            /// This method loads a collection of 'Admin' objects.
            /// </summary>
            public List<Admin> LoadAdmins(Admin tempAdmin = null)
            {
                // initial value
                List<Admin> admins = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    admins = this.AppController.ControllerManager.AdminController.FetchAll(tempAdmin);
                }

                // return value
                return admins;
            }
            #endregion

            #region LoadDailyPriceDatas(DailyPriceData tempDailyPriceData = null)
            /// <summary>
            /// This method loads a collection of 'DailyPriceData' objects.
            /// </summary>
            public List<DailyPriceData> LoadDailyPriceDatas(DailyPriceData tempDailyPriceData = null)
            {
                // initial value
                List<DailyPriceData> dailyPriceDatas = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    dailyPriceDatas = this.AppController.ControllerManager.DailyPriceDataController.FetchAll(tempDailyPriceData);
                }

                // return value
                return dailyPriceDatas;
            }
            #endregion

            #region LoadDailyPriceDataViews(DailyPriceDataView tempDailyPriceDataView = null)
            /// <summary>
            /// This method loads a collection of 'DailyPriceDataView' objects.
            /// </summary>
            public List<DailyPriceDataView> LoadDailyPriceDataViews(DailyPriceDataView tempDailyPriceDataView = null)
            {
                // initial value
                List<DailyPriceDataView> dailyPriceDataViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    dailyPriceDataViews = this.AppController.ControllerManager.DailyPriceDataViewController.FetchAll(tempDailyPriceDataView);
                }

                // return value
                return dailyPriceDataViews;
            }
            #endregion

            #region LoadDoNotTracks(DoNotTrack tempDoNotTrack = null)
            /// <summary>
            /// This method loads a collection of 'DoNotTrack' objects.
            /// </summary>
            public List<DoNotTrack> LoadDoNotTracks(DoNotTrack tempDoNotTrack = null)
            {
                // initial value
                List<DoNotTrack> doNotTracks = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    doNotTracks = this.AppController.ControllerManager.DoNotTrackController.FetchAll(tempDoNotTrack);
                }

                // return value
                return doNotTracks;
            }
            #endregion

            #region LoadIndustryLosingStreakViews(IndustryLosingStreakView tempIndustryLosingStreakView = null)
            /// <summary>
            /// This method loads a collection of 'IndustryLosingStreakView' objects.
            /// </summary>
            public List<IndustryLosingStreakView> LoadIndustryLosingStreakViews(IndustryLosingStreakView tempIndustryLosingStreakView = null)
            {
                // initial value
                List<IndustryLosingStreakView> industryLosingStreakViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    industryLosingStreakViews = this.AppController.ControllerManager.IndustryLosingStreakViewController.FetchAll(tempIndustryLosingStreakView);
                }

                // return value
                return industryLosingStreakViews;
            }
            #endregion

            #region LoadIndustrys(Industry tempIndustry = null)
            /// <summary>
            /// This method loads a collection of 'Industry' objects.
            /// </summary>
            public List<Industry> LoadIndustrys(Industry tempIndustry = null)
            {
                // initial value
                List<Industry> industrys = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    industrys = this.AppController.ControllerManager.IndustryController.FetchAll(tempIndustry);
                }

                // return value
                return industrys;
            }
            #endregion

            #region LoadIndustrySummarys(IndustrySummary tempIndustrySummary = null)
            /// <summary>
            /// This method loads a collection of 'IndustrySummary' objects.
            /// </summary>
            public List<IndustrySummary> LoadIndustrySummarys(IndustrySummary tempIndustrySummary = null)
            {
                // initial value
                List<IndustrySummary> industrySummarys = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    industrySummarys = this.AppController.ControllerManager.IndustrySummaryController.FetchAll(tempIndustrySummary);
                }

                // return value
                return industrySummarys;
            }
            #endregion

            #region LoadIndustryWinningStreakViews(IndustryWinningStreakView tempIndustryWinningStreakView = null)
            /// <summary>
            /// This method loads a collection of 'IndustryWinningStreakView' objects.
            /// </summary>
            public List<IndustryWinningStreakView> LoadIndustryWinningStreakViews(IndustryWinningStreakView tempIndustryWinningStreakView = null)
            {
                // initial value
                List<IndustryWinningStreakView> industryWinningStreakViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    industryWinningStreakViews = this.AppController.ControllerManager.IndustryWinningStreakViewController.FetchAll(tempIndustryWinningStreakView);
                }

                // return value
                return industryWinningStreakViews;
            }
            #endregion

            #region LoadMarketSummarys(MarketSummary tempMarketSummary = null)
            /// <summary>
            /// This method loads a collection of 'MarketSummary' objects.
            /// </summary>
            public List<MarketSummary> LoadMarketSummarys(MarketSummary tempMarketSummary = null)
            {
                // initial value
                List<MarketSummary> marketSummarys = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    marketSummarys = this.AppController.ControllerManager.MarketSummaryController.FetchAll(tempMarketSummary);
                }

                // return value
                return marketSummarys;
            }
            #endregion

            #region LoadSectors(Sector tempSector = null)
            /// <summary>
            /// This method loads a collection of 'Sector' objects.
            /// </summary>
            public List<Sector> LoadSectors(Sector tempSector = null)
            {
                // initial value
                List<Sector> sectors = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    sectors = this.AppController.ControllerManager.SectorController.FetchAll(tempSector);
                }

                // return value
                return sectors;
            }
            #endregion

            #region LoadSectorSummarys(SectorSummary tempSectorSummary = null)
            /// <summary>
            /// This method loads a collection of 'SectorSummary' objects.
            /// </summary>
            public List<SectorSummary> LoadSectorSummarys(SectorSummary tempSectorSummary = null)
            {
                // initial value
                List<SectorSummary> sectorSummarys = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    sectorSummarys = this.AppController.ControllerManager.SectorSummaryController.FetchAll(tempSectorSummary);
                }

                // return value
                return sectorSummarys;
            }
            #endregion

            #region LoadTopLosingStreakStocks(TopLosingStreakStocks tempTopLosingStreakStocks = null)
            /// <summary>
            /// This method loads a collection of 'TopLosingStreakStocks' objects.
            /// </summary>
            public List<TopLosingStreakStocks> LoadTopLosingStreakStocks(TopLosingStreakStocks tempTopLosingStreakStocks = null)
            {
                // initial value
                List<TopLosingStreakStocks> topLosingStreakStocks = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    topLosingStreakStocks = this.AppController.ControllerManager.TopLosingStreakStocksController.FetchAll(tempTopLosingStreakStocks);
                }

                // return value
                return topLosingStreakStocks;
            }
            #endregion

            #region LoadTopStreakStocks(TopStreakStocks tempTopStreakStocks = null)
            /// <summary>
            /// This method loads a collection of 'TopStreakStocks' objects.
            /// </summary>
            public List<TopStreakStocks> LoadTopStreakStocks(TopStreakStocks tempTopStreakStocks = null)
            {
                // initial value
                List<TopStreakStocks> topStreakStocks = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    topStreakStocks = this.AppController.ControllerManager.TopStreakStocksController.FetchAll(tempTopStreakStocks);
                }

                // return value
                return topStreakStocks;
            }
            #endregion

            #region SaveAdmin(ref Admin admin)
            /// <summary>
            /// This method is used to save 'Admin' objects.
            /// </summary>
            /// <param name="admin">The Admin to save.</param>
            public bool SaveAdmin(ref Admin admin)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.AdminController.Save(ref admin);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveDailyPriceData(ref DailyPriceData dailyPriceData)
            /// <summary>
            /// This method is used to save 'DailyPriceData' objects.
            /// </summary>
            /// <param name="dailyPriceData">The DailyPriceData to save.</param>
            public bool SaveDailyPriceData(ref DailyPriceData dailyPriceData)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.DailyPriceDataController.Save(ref dailyPriceData);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveDoNotTrack(ref DoNotTrack doNotTrack)
            /// <summary>
            /// This method is used to save 'DoNotTrack' objects.
            /// </summary>
            /// <param name="doNotTrack">The DoNotTrack to save.</param>
            public bool SaveDoNotTrack(ref DoNotTrack doNotTrack)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.DoNotTrackController.Save(ref doNotTrack);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveIndustry(ref Industry industry)
            /// <summary>
            /// This method is used to save 'Industry' objects.
            /// </summary>
            /// <param name="industry">The Industry to save.</param>
            public bool SaveIndustry(ref Industry industry)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.IndustryController.Save(ref industry);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveSector(ref Sector sector)
            /// <summary>
            /// This method is used to save 'Sector' objects.
            /// </summary>
            /// <param name="sector">The Sector to save.</param>
            public bool SaveSector(ref Sector sector)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.SectorController.Save(ref sector);
                }

                // return value
                return saved;
            }
            #endregion

            #region TestDatabaseConnection()
            /// <summary>
            /// method returns the Database Connection
            /// </summary>
            public bool TestDatabaseConnection()
            {
                Exception error = null;
                
                // Test the database connection
                return this.AppController.TestDatabaseConnection(ref error);
            }
            #endregion
            
        #endregion

        #region Properties

            #region AppController
            /// <summary>
            /// This property gets or sets the value for 'AppController'.
            /// </summary>
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ConnectionName
            /// <summary>
            /// This property gets or sets the value for 'ConnectionName'.
            /// </summary>
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion
            
            #region HasAppController
            /// <summary>
            /// This property returns true if this object has an 'AppController'.
            /// </summary>
            public bool HasAppController
            {
                get
                {
                    // initial value
                    bool hasAppController = (this.AppController != null);

                    // return value
                    return hasAppController;
                }
            }
            #endregion

            #region HasConnectionName
            /// <summary>
            /// This property returns true if the 'ConnectionName' exists.
            /// </summary>
            public bool HasConnectionName
            {
                get
                {
                    // initial value
                    bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));
                    
                    // return value
                    return hasConnectionName;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}

