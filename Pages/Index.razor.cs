

#region using statements

using DataJuggler.Blazor.Components;
using DataJuggler.Blazor.Components.Interfaces;
using DataJuggler.Blazor.Components.Util;
using DataJuggler.Excelerate;
using ObjectLibrary.BusinessObjects;
using DataJuggler.UltimateHelper;
using ApplicationLogicComponent.Connection;
using DataGateway;
using DataJuggler.Cryptography;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using Row = DataJuggler.Excelerate.Row;
using Column = DataJuggler.Excelerate.Column;
using System.Linq.Expressions;

#endregion

namespace BubbleReportWeb.Pages
{

    #region class Index
    /// <summary>
    /// This class is the Main Page for this app
    /// </summary>
    public partial class Index : IBlazorComponentParent
    {
        
        #region Private Variables
        private Grid topLosingStreakGrid;
        private Grid topStreakGrid;
        private Grid marketSummaryGrid;
        private Grid topIndustryStreakGrid;
        private Grid losingIndustryGrid;        
        #endregion

        #region Events

            #region OnAfterRenderAsync(bool firstRender)
            /// <summary>
            /// This method is used to verify a user
            /// </summary>
            /// <param name="firstRender"></param>
            /// <returns></returns>
            protected async override Task OnAfterRenderAsync(bool firstRender)
            {
                // if the TopStreakGrid exists
                if (HasTopStreakGrid)
                {
                    // create the rows
                    List<Row> rows = CreateRowsForTopStreakStocks();

                    // Set the Row
                    TopStreakGrid.Rows = rows;

                    // Refresh the Grid
                    TopStreakGrid.Refresh();
                }

                // if the value for HasTopLosingStreakGrid is true
                if (HasTopLosingStreakGrid)
                {
                    // create the rows
                    List<Row> rows = CreateRowsForLosingStreakStocks();

                    // Set the Rows
                    TopLosingStreakGrid.Rows = rows;

                    // Refresh the Grid
                    TopLosingStreakGrid.Refresh();
                }

                // if the value for HasMarketSummaryGrid is true
                if (HasMarketSummaryGrid)
                {
                    // create the rows
                    List<Row> rows = CreateRowsForMarketSummary();

                    // Set the Rows
                    MarketSummaryGrid.Rows = rows;

                    // Refresh the Grid
                    MarketSummaryGrid.Refresh();
                }

                // if the value for HasTopIndustryStreakGrid is true
                if (HasTopIndustryStreakGrid)
                {
                    // create the rows
                    List<Row> rows = CreateRowsForTopIndustryStreak();

                    // Set the Rows
                    TopIndustryStreakGrid.Rows = rows;

                    // Refresh the Grid
                    TopIndustryStreakGrid.Refresh();
                }

                // if the value for HasLosingIndustryGrid is true
                if (HasLosingIndustryGrid)
                {
                    // create the rows
                    List<Row> rows = CreateRowsForIndustryLosers();

                    // Set the Rows
                    LosingIndustryGrid.Rows = rows;

                    // Refresh the Grid
                    LosingIndustryGrid.Refresh();
                }

                // call the base
                await base.OnAfterRenderAsync(firstRender);
            }
            #endregion

        #endregion
        
        #region Methods
            
            #region CreateRowsForIndustryLosers()
            /// <summary>
            /// returns a list of Rows For Industry Losers
            /// </summary>
            public List<Row> CreateRowsForIndustryLosers()
            {
                // initial value
                List<Row> rows = new List<Row>();
                
                // Load the Gateway
                Gateway gateway = new Gateway(Connection.Name);
                
                // Load the losingIndustries
                List<IndustryLosingStreakView> losingIndustries = gateway.LoadIndustryLosingStreakViews();

                // If the losingIndustries collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(losingIndustries))
                {
                    // Create Column and set properties
                    Column column = new Column();
                    column.Caption = "Name";
                    column.ColumnName = "Name";
                    column.Index = 0;
                    column.ColumnNumber = 1;                        
                    column.ColumnText = "Name";
                    column.Width = 100;
                    column.Height = 16;                    
                    column.ClassName = "displayinlineblock width100 colorwhite textalignleft down4 right16 fontsize12";  

                    // Add this column
                    LosingIndustryGrid.Columns.Add(column);

                    // Create Column and set properties
                    Column column2 = new Column();
                    column2.Caption = "Adv";
                    column2.ColumnName = "Adv";
                    column2.Index = 1;
                    column2.ColumnNumber = 2;                        
                    column2.ColumnText = column2.Caption;
                    column2.Width = 42;
                    column2.Height = 16;
                    column2.ClassName = "displayinlineblock width42 colorwhite textalignleft down4 right28 fontsize12";  

                    // Add Column 2 to the header row
                    LosingIndustryGrid.Columns.Add(column2);

                    // Create Column and set properties
                    Column column3 = new Column();
                    column3.Caption = "Dec";
                    column3.ColumnName = "Dec";
                    column3.Index = 2;
                    column3.ColumnNumber = 3;                        
                    column3.ColumnText = column3.Caption;
                    column3.Width =42;
                    column3.Height = 16;
                    column3.ClassName = "displayinlineblock width42 colorwhite textalignleft down4 right34 fontsize12";  

                    // Add this column
                    LosingIndustryGrid.Columns.Add(column3);

                    // Create Column and set properties
                    Column column4 = new Column();
                    column4.Caption = "Avg % Gain";
                    column4.ColumnName = "AveragePercentChange";
                    column4.Index = 3;
                    column4.ColumnNumber = 4;                        
                    column4.ColumnText = column4.Caption;
                    column4.Width = 74;
                    column4.Height = 16;
                    column4.ClassName = "displayinlineblock textdonotwrap width74 colorwhite textalignleft down4 right20 fontsize12";

                    // Add this column
                    LosingIndustryGrid.Columns.Add(column4);

                    // Create Column and set properties
                    Column column5 = new Column();
                    column5.Caption = "Streak";
                    column5.ColumnName = "Streak";
                    column5.Index = 3;
                    column5.ColumnNumber = 4;                        
                    column5.ColumnText = column5.Caption;
                    column5.Width = 48;
                    column5.Height = 16;
                    column5.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right16 fontsize12";

                    // Add this column
                    LosingIndustryGrid.Columns.Add(column5);

                    // Iterate the collection of IndustryLosingStreakView objects
                    foreach (IndustryLosingStreakView loser in losingIndustries)
                    {
                        // Create a row
                        Row row = new Row();
                        row.ClassName = "textdonotwrap width448 height16 marginbottom0 down8";

                        // Create Column and set properties
                        column = new Column();                        
                        column.ColumnName = "Name";
                        column.Index = 0;
                        column.ColumnNumber = 1;                        
                        column.ColumnText = loser.ShortName;
                        column.Width = 100;
                        column.Height = 16;                    
                        column.ClassName = "displayinlineblock width100 colorwhite textalignleft down4 right16 fontsize12";  

                        // Add this column
                        row.Columns.Add(column);

                        // Create Column and set properties
                        column2 = new Column();
                        column2.ColumnName = "Advancers";
                        column2.Index = 1;
                        column2.ColumnNumber = 2;                        
                        column2.ColumnText = loser.Advancers.ToString();
                        column2.Width = 42;
                        column2.Height = 16;
                        column2.ClassName = "displayinlineblock width42 colorwhite textaligncenter down4 right20 fontsize12";  

                        // Add Column 2 to the header row
                        row.Columns.Add(column2);

                        // Create Column and set properties
                        column3 = new Column();
                        column3.ColumnName = "Decliners";
                        column3.Index = 2;
                        column3.ColumnNumber = 3;                        
                        column3.ColumnText = loser.Decliners.ToString();
                        column3.Width =42;
                        column3.Height = 16;
                        column3.ClassName = "displayinlineblock width42 colorwhite textaligncenter down4 right26 fontsize12";  

                        // Add this column
                        row.Columns.Add(column3);

                        // Create Column and set properties
                        column4 = new Column();
                        column4.ColumnName = "AveragePercentChange";
                        column4.Index = 3;
                        column4.ColumnNumber = 4;                        
                        column4.ColumnText = loser.AveragePercentChange.ToString();
                        column4.Width = 74;
                        column4.Height = 16;
                        column4.ClassName = "displayinlineblock textdonotwrap width74 colorwhite textaligncenter down4 right16 fontsize12";

                        // Add this column
                        row.Columns.Add(column4);

                        // Create Column and set properties
                        column5 = new Column();
                        column5.ColumnName = "Streak";
                        column5.Index = 3;
                        column5.ColumnNumber = 4;                        
                        column5.ColumnText = loser.Streak.ToString();
                        column5.Width = 48;
                        column5.Height = 16;
                        column5.ClassName = "displayinlineblock width48 colorwhite textaligncenter down4 right12 fontsize12";

                        // Add this column
                        row.Columns.Add(column5);

                        // Add this row
                        rows.Add(row);
                    }
                }

                // return value
                return rows;
            }
            #endregion
            
            #region CreateRowsForLosingStreakStocks()
            /// <summary>
            /// returns a list of Rows For Top Streak Stocks
            /// </summary>
            public List<Row> CreateRowsForLosingStreakStocks()
            {
               // initial value
                List<Row> rows = new List<Row>();

                // Load the Gateway
                Gateway gateway = new Gateway(Connection.Name);
                
                // Load the topStocks
                List<TopLosingStreakStocks> topLosingStocks = gateway.LoadTopLosingStreakStocks();

                // If the topStocks collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(topLosingStocks))
                {
                    // Create Column and set properties
                    Column column = new Column();
                    column.Caption = "Symbol";
                    column.ColumnName = "Symbol";
                    column.Index = 0;
                    column.ColumnNumber = 1;                        
                    column.ColumnText = "Symbol";
                    column.Width = 48;
                    column.Height = 16;                    
                    column.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right16 fontsize12";  

                    // Add this column
                    TopLosingStreakGrid.Columns.Add(column);

                    // Create Column and set properties
                    Column column2 = new Column();
                    column2.Caption = "Name";
                    column2.ColumnName = "Name";
                    column2.Index = 1;
                    column2.ColumnNumber = 2;                        
                    column2.ColumnText = column2.Caption;
                    column2.Width = 140;
                    column2.Height = 16;
                    column2.ClassName = "displayinlineblock width140 colorwhite textalignleft down4 right16 fontsize12";  

                    // Add Column 2 to the header row
                    TopLosingStreakGrid.Columns.Add(column2);

                    // Create Column and set properties
                    Column column3 = new Column();
                    column3.Caption = "Last";
                    column3.ColumnName = "LastClose";
                    column3.Index = 2;
                    column3.ColumnNumber = 3;                        
                    column3.ColumnText = column3.Caption;
                    column3.Width = 48;
                    column3.Height = 16;
                    column3.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right30 fontsize12";  

                    // Add this column
                    TopLosingStreakGrid.Columns.Add(column3);

                    // Create Column and set properties
                    Column column4 = new Column();
                    column4.Caption = "Streak";
                    column4.ColumnName = "Streak";
                    column4.Index = 3;
                    column4.ColumnNumber = 4;                        
                    column4.ColumnText = column4.Caption;
                    column4.Width = 48;
                    column4.Height = 16;
                    column4.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right16 fontsize12";

                    // Add this column
                    TopLosingStreakGrid.Columns.Add(column4);

                    foreach (TopLosingStreakStocks topLosingStock in topLosingStocks)
                    {
                        // Create a row
                        Row row = new Row();
                        row.ClassName = "textdonotwrap width448 height16 marginbottom0 down8";

                        // Create Column and set properties
                        column = new Column();
                        column.Caption = "Symbol";
                        column.ColumnName = "Symbol";
                        column.Index = 0;
                        column.ColumnNumber = 1;                        
                        column.ColumnText = topLosingStock.Symbol;
                        column.Unit = "px";
                        column.Width = 48;
                        column.Height = 16;
                        column.ClassName = "displayinlineblock width48 colorwhite textalignleft right16 fontsize12";  

                        // Add this column
                        row.Columns.Add(column);

                        // Create Column and set properties
                        column2 = new Column();
                        column2.Caption = "Name";
                        column2.ColumnName = "Name";
                        column2.Index = 1;
                        column2.ColumnNumber = 2;                        
                        column2.ColumnText = topLosingStock.ShortName.ToString();
                        column2.Width = 140;
                        column2.Height = 16;
                        column2.ClassName = "displayinlineblock width140 colorwhite textalignleft right16 fontsize12";

                        // Add this column
                        row.Columns.Add(column2);

                        // Create Column and set properties
                        column3 = new Column();
                        column3.Caption = "Last Close";
                        column3.ColumnName = "LastPrice";
                        column3.Index = 2;
                        column3.ColumnNumber = 3;
                        column3.ColumnText = topLosingStock.LastClose.ToString("C");
                        column3.Width = 48;
                        column3.Height = 16;
                        column3.ClassName = "displayinlineblock width48 colorwhite textalignright right16 fontsize12";  
                        
                        // Add this column
                        row.Columns.Add(column3);

                        // Create Column and set properties
                        column4 = new Column();
                        column4.Caption = "Streak";
                        column4.ColumnName = "Streak";
                        column4.Index = 3;
                        column4.ColumnNumber = 4;
                        column4.ColumnValue = topLosingStock.Streak;
                        column4.ColumnText = topLosingStock.Streak.ToString();
                        column4.Width = 48;
                        column4.Height = 16;
                        column4.ClassName = "displayinlineblock width48 colorwhite textaligncenter right16 fontsize12";
                        
                        // Add this column
                        row.Columns.Add(column4);

                        // Add this row
                        rows.Add(row);
                    }
                }

                // return value
                return rows;
            }
            #endregion

            #region CreateRowsForMarketSummary()
            /// <summary>
            /// returns a list of Rows For Market Summary
            /// </summary>
            public List<Row> CreateRowsForMarketSummary()
            {
                // initial value
                List<Row> rows = new List<Row>();

                 // Load the Gateway
                Gateway gateway = new Gateway(Connection.Name);
                
                // Load the topStocks
                MarketSummary marketSummary = gateway.LoadMarketSummarys().FirstOrDefault();

                // If the marketSummary object exists
                if (NullHelper.Exists(marketSummary))
                {
                    // Create Column and set properties
                    Column column = new Column();
                    column.Caption = "Advancers";
                    column.ColumnName = "Advancers";
                    column.Index = 0;
                    column.ColumnNumber = 1;                        
                    column.ColumnText = "Advancers";
                    column.Width = 64;
                    column.Height = 16;                    
                    column.ClassName = "displayinlineblock width64 colorwhite textaligncenter textdonotwrap right4 fontsize12";  

                    // Add this column
                    MarketSummaryGrid.Columns.Add(column);

                    // Create Column and set properties
                    Column column2 = new Column();
                    column2.Caption = "Decliners";
                    column2.ColumnName = "Decliners";
                    column2.Index = 1;
                    column2.ColumnNumber = 1;                        
                    column2.ColumnText = "Decliners";
                    column2.Width = 64;
                    column2.Height = 16;                    
                    column2.ClassName = "displayinlineblock width64 colorwhite textaligncenter textdonotwrap right8 fontsize12";  

                    // Add this column
                    MarketSummaryGrid.Columns.Add(column2);

                    // Create a row
                    Row row = new DataJuggler.Excelerate.Row();                        
                    row.ClassName = "textdonotwrap width96 height16 marginbottom0 up4";

                    // Create Column and set properties
                    column = new Column();                    
                    column.ColumnName = "Advancers";
                    column.Index = 0;
                    column.ColumnNumber = 2;                        
                    column.ColumnText = marketSummary.Advancers.ToString("#,##0");
                    column.Width = 64;
                    column.Height = 16;                    
                    column.ClassName = "displayinlineblock width64 colorwhite textaligncenter textdonotwrap right4 fontsize12";  

                    // Add this column
                    row.Columns.Add(column);

                    // Create Column and set properties
                    column2 = new Column();                    
                    column2.ColumnName = "Decliners";
                    column2.Index = 1;
                    column2.ColumnNumber = 2;                        
                    column2.ColumnText = marketSummary.Decliners.ToString("#,##0");
                    column2.Width = 64;
                    column2.Height = 16;                    
                    column2.ClassName = "displayinlineblock width64 colorwhite textaligncenter textdonotwrap right8 fontsize12";

                    // Add this column
                    row.Columns.Add(column2);

                    // Add this row (the only row)
                    rows.Add(row);
                }
                
                // return value
                return rows;
            }
            #endregion
            
            #region CreateRowsForTopIndustryStreak()
            /// <summary>
            /// returns a list of Rows For Top Industry Streak
            /// </summary>
            public List<Row> CreateRowsForTopIndustryStreak()
            {
                // initial value
                List<Row> rows = new List<Row>();

                // Load the Gateway
                Gateway gateway = new Gateway(Connection.Name);
                
                // Load the topStocks
                List<IndustryWinningStreakView> topIndustries = gateway.LoadIndustryWinningStreakViews();

                // If the topIndustries collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(topIndustries))
                {
                    // Create Column and set properties
                    Column column = new Column();
                    column.Caption = "Name";
                    column.ColumnName = "Name";
                    column.Index = 0;
                    column.ColumnNumber = 1;                        
                    column.ColumnText = "Name";
                    column.Width = 100;
                    column.Height = 16;                    
                    column.ClassName = "displayinlineblock width100 colorwhite textalignleft down4 right16 fontsize12";  

                    // Add this column
                    TopIndustryStreakGrid.Columns.Add(column);

                    // Create Column and set properties
                    Column column2 = new Column();
                    column2.Caption = "Adv";
                    column2.ColumnName = "Adv";
                    column2.Index = 1;
                    column2.ColumnNumber = 2;                        
                    column2.ColumnText = column2.Caption;
                    column2.Width = 42;
                    column2.Height = 16;
                    column2.ClassName = "displayinlineblock width42 colorwhite textalignleft down4 right28 fontsize12";  

                    // Add Column 2 to the header row
                    TopIndustryStreakGrid.Columns.Add(column2);

                    // Create Column and set properties
                    Column column3 = new Column();
                    column3.Caption = "Dec";
                    column3.ColumnName = "Dec";
                    column3.Index = 2;
                    column3.ColumnNumber = 3;                        
                    column3.ColumnText = column3.Caption;
                    column3.Width =42;
                    column3.Height = 16;
                    column3.ClassName = "displayinlineblock width42 colorwhite textalignleft down4 right34 fontsize12";  

                    // Add this column
                    TopIndustryStreakGrid.Columns.Add(column3);

                    // Create Column and set properties
                    Column column4 = new Column();
                    column4.Caption = "Avg % Gain";
                    column4.ColumnName = "AveragePercentChange";
                    column4.Index = 3;
                    column4.ColumnNumber = 4;                        
                    column4.ColumnText = column4.Caption;
                    column4.Width = 74;
                    column4.Height = 16;
                    column4.ClassName = "displayinlineblock textdonotwrap width74 colorwhite textalignleft down4 right20 fontsize12";

                    // Add this column
                    TopIndustryStreakGrid.Columns.Add(column4);

                    // Create Column and set properties
                    Column column5 = new Column();
                    column5.Caption = "Streak";
                    column5.ColumnName = "Streak";
                    column5.Index = 3;
                    column5.ColumnNumber = 4;                        
                    column5.ColumnText = column5.Caption;
                    column5.Width = 48;
                    column5.Height = 16;
                    column5.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right16 fontsize12";

                    // Add this column
                    TopIndustryStreakGrid.Columns.Add(column5);

                    // Iterate the collection of IndustryWinningStreakView objects
                    foreach (IndustryWinningStreakView topIndustry in topIndustries)
                    {
                        // Create a row
                        Row row = new Row();
                        row.ClassName = "textdonotwrap width448 height16 marginbottom0 down8";

                        // Create Column and set properties
                        column = new Column();                        
                        column.ColumnName = "Name";
                        column.Index = 0;
                        column.ColumnNumber = 1;                        
                        column.ColumnText = topIndustry.ShortName;
                        column.Width = 100;
                        column.Height = 16;                    
                        column.ClassName = "displayinlineblock width100 colorwhite textalignleft down4 right16 fontsize12";  

                        // Add this column
                        row.Columns.Add(column);

                        // Create Column and set properties
                        column2 = new Column();
                        column2.ColumnName = "Advancers";
                        column2.Index = 1;
                        column2.ColumnNumber = 2;                        
                        column2.ColumnText = topIndustry.Advancers.ToString();
                        column2.Width = 42;
                        column2.Height = 16;
                        column2.ClassName = "displayinlineblock width42 colorwhite textaligncenter down4 right20 fontsize12";  

                        // Add Column 2 to the header row
                        row.Columns.Add(column2);

                        // Create Column and set properties
                        column3 = new Column();
                        column3.ColumnName = "Decliners";
                        column3.Index = 2;
                        column3.ColumnNumber = 3;                        
                        column3.ColumnText = topIndustry.Decliners.ToString();
                        column3.Width =42;
                        column3.Height = 16;
                        column3.ClassName = "displayinlineblock width42 colorwhite textaligncenter down4 right26 fontsize12";  

                        // Add this column
                        row.Columns.Add(column3);

                        // Create Column and set properties
                        column4 = new Column();
                        column4.ColumnName = "AveragePercentChange";
                        column4.Index = 3;
                        column4.ColumnNumber = 4;                        
                        column4.ColumnText = topIndustry.AveragePercentChange.ToString();
                        column4.Width = 74;
                        column4.Height = 16;
                        column4.ClassName = "displayinlineblock textdonotwrap width74 colorwhite textaligncenter down4 right16 fontsize12";

                        // Add this column
                        row.Columns.Add(column4);

                        // Create Column and set properties
                        column5 = new Column();
                        column5.ColumnName = "Streak";
                        column5.Index = 3;
                        column5.ColumnNumber = 4;                        
                        column5.ColumnText = topIndustry.Streak.ToString();
                        column5.Width = 48;
                        column5.Height = 16;
                        column5.ClassName = "displayinlineblock width48 colorwhite textaligncenter down4 right12 fontsize12";

                        // Add this column
                        row.Columns.Add(column5);

                        // Add thsi row
                        rows.Add(row);
                    }
                }
                
                // return value
                return rows;
            }
            #endregion
            
            #region CreateRowsForTopStreakStocks()
            /// <summary>
            /// returns a list of Rows For Top Streak Stocks
            /// </summary>
            public List<Row> CreateRowsForTopStreakStocks()
            {
                // initial value
                List<Row> rows = new List<Row>();

                // Load the Gateway
                Gateway gateway = new Gateway(Connection.Name);
                
                // Load the topStocks
                List<TopStreakStocks> topStocks = gateway.LoadTopStreakStocks();

                // If the topStocks collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(topStocks))
                {
                    // Create Column and set properties
                    Column column = new Column();
                    column.Caption = "Symbol";
                    column.ColumnName = "Symbol";
                    column.Index = 0;
                    column.ColumnNumber = 1;                        
                    column.ColumnText = "Symbol";
                    column.Width = 48;
                    column.Height = 16;                    
                    column.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right16 fontsize12";  

                    // Add this column
                    TopStreakGrid.Columns.Add(column);

                    // Create Column and set properties
                    Column column2 = new Column();
                    column2.Caption = "Name";
                    column2.ColumnName = "Name";
                    column2.Index = 1;
                    column2.ColumnNumber = 2;                        
                    column2.ColumnText = column2.Caption;
                    column2.Width = 140;
                    column2.Height = 16;
                    column2.ClassName = "displayinlineblock width140 colorwhite textalignleft down4 right16 fontsize12";  

                    // Add Column 2 to the header row
                    TopStreakGrid.Columns.Add(column2);

                    // Create Column and set properties
                    Column column3 = new Column();
                    column3.Caption = "Last";
                    column3.ColumnName = "LastClose";
                    column3.Index = 2;
                    column3.ColumnNumber = 3;                        
                    column3.ColumnText = column3.Caption;
                    column3.Width = 48;
                    column3.Height = 16;
                    column3.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right30 fontsize12";  

                    // Add this column
                    TopStreakGrid.Columns.Add(column3);

                    // Create Column and set properties
                    Column column4 = new Column();
                    column4.Caption = "Streak";
                    column4.ColumnName = "Streak";
                    column4.Index = 3;
                    column4.ColumnNumber = 4;                        
                    column4.ColumnText = column4.Caption;
                    column4.Width = 48;
                    column4.Height = 16;
                    column4.ClassName = "displayinlineblock width48 colorwhite textalignleft down4 right16 fontsize12";

                    // Add this column
                    TopStreakGrid.Columns.Add(column4);

                    foreach (TopStreakStocks topStock in topStocks)
                    {
                        // Create a row
                        DataJuggler.Excelerate.Row row = new DataJuggler.Excelerate.Row();                        
                        row.ClassName = "textdonotwrap width448 height16 marginbottom0 down8";

                        // Create Column and set properties
                        column = new Column();
                        column.Caption = "Symbol";
                        column.ColumnName = "Symbol";
                        column.Index = 0;
                        column.ColumnNumber = 1;                        
                        column.ColumnText = topStock.Symbol;
                        column.Unit = "px";
                        column.Width = 48;
                        column.Height = 16;
                        column.ClassName = "displayinlineblock width48 colorwhite textalignleft right16 fontsize12";  

                        // Add this column
                        row.Columns.Add(column);

                        // Create Column and set properties
                        column2 = new Column();
                        column2.Caption = "Name";
                        column2.ColumnName = "Name";
                        column2.Index = 1;
                        column2.ColumnNumber = 2;                        
                        column2.ColumnText = topStock.ShortName.ToString();
                        column2.Width = 140;
                        column2.Height = 16;
                        column2.ClassName = "displayinlineblock width140 colorwhite textalignleft right16 fontsize12";

                        // Add this column
                        row.Columns.Add(column2);

                        // Create Column and set properties
                        column3 = new Column();
                        column3.Caption = "Last Close";
                        column3.ColumnName = "LastPrice";
                        column3.Index = 2;
                        column3.ColumnNumber = 3;
                        column3.ColumnText = topStock.LastClose.ToString("C");
                        column3.Width = 48;
                        column3.Height = 16;
                        column3.ClassName = "displayinlineblock width48 colorwhite textalignright right8 fontsize12";  
                        
                        // Add this column
                        row.Columns.Add(column3);

                        // Create Column and set properties
                        column4 = new Column();
                        column4.Caption = "Streak";
                        column4.ColumnName = "Streak";
                        column4.Index = 3;
                        column4.ColumnNumber = 4;
                        column4.ColumnValue = topStock.Streak;
                        column4.ColumnText = topStock.Streak.ToString();
                        column4.Width = 48;
                        column4.Height = 16;
                        column4.ClassName = "displayinlineblock width48 colorwhite textaligncenter right16 fontsize12";
                        
                        // Add this column
                        row.Columns.Add(column4);

                        // Add this row
                        rows.Add(row);
                    }
                }

                // return value
                return rows;
            }
            #endregion
            
            #region FindChildByName(string name)
            /// <summary>
            /// method Find Child By Name
            /// </summary>
            public IBlazorComponent FindChildByName(string name)
            {
                // return using Helper class
                return ComponentHelper.FindChildByName(Children, name);
            }
            #endregion
            
            #region ReceiveData(Message message)
            /// <summary>
            /// method Receive Data
            /// </summary>
            public void ReceiveData(Message message)
            {
                
            }
            #endregion
            
            #region Refresh()
            /// <summary>
            /// method Refresh
            /// </summary>
            public void Refresh()
            {
                // Update the UI
                InvokeAsync(() =>
                {
                    // Refresh the UI
                    StateHasChanged();
                });
            }
            #endregion
            
            #region Register(IBlazorComponent component)
            /// <summary>
            /// method Register
            /// </summary>
            public void Register(IBlazorComponent component)
            {
                // If the component object exists
                if (NullHelper.Exists(component))
                {      
                    // TopStreakGrid = component as Grid;                    
                    if (TextHelper.IsEqual(component.Name, "TopStreaksStockGrid"))
                    {
                        // Store the Grid
                        TopStreakGrid = component as Grid;                        
                    }                
                    // TopStreakGrid = component as Grid;                    
                    else if (TextHelper.IsEqual(component.Name, "TopLosingStreakStockGrid"))
                    {
                        // Store the Grid
                        TopLosingStreakGrid = component as Grid;
                    }
                    else if (TextHelper.IsEqual(component.Name, "MarketSummaryGrid"))
                    {
                        // Store the Grid
                        MarketSummaryGrid = component as Grid;
                    }
                    else if (TextHelper.IsEqual(component.Name, "TopIndustryGrid"))
                    {
                        // store the grid
                        TopIndustryStreakGrid = component as Grid;
                    }
                    else if(TextHelper.IsEqual(component.Name, "LosingIndustryGrid"))
                    {
                        // store the grid
                        LosingIndustryGrid = component as Grid;
                    }                    
                }
            }
            #endregion
            
        #endregion
        
        #region Properties
            
            #region Children
            /// <summary>
            /// This property gets or sets the value for Children.
            /// </summary>
            public List<IBlazorComponent> Children { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            #endregion
            
            #region HasLosingIndustryGrid
            /// <summary>
            /// This property returns true if this object has a 'LosingIndustryGrid'.
            /// </summary>
            public bool HasLosingIndustryGrid
            {
                get
                {
                    // initial value
                    bool hasLosingIndustryGrid = (this.LosingIndustryGrid != null);
                    
                    // return value
                    return hasLosingIndustryGrid;
                }
            }
            #endregion
            
            #region HasMarketSummaryGrid
            /// <summary>
            /// This property returns true if this object has a 'MarketSummaryGrid'.
            /// </summary>
            public bool HasMarketSummaryGrid
            {
                get
                {
                    // initial value
                    bool hasMarketSummaryGrid = (this.MarketSummaryGrid != null);
                    
                    // return value
                    return hasMarketSummaryGrid;
                }
            }
            #endregion
            
            #region HasTopIndustryStreakGrid
            /// <summary>
            /// This property returns true if this object has a 'TopIndustryStreakGrid'.
            /// </summary>
            public bool HasTopIndustryStreakGrid
            {
                get
                {
                    // initial value
                    bool hasTopIndustryStreakGrid = (this.TopIndustryStreakGrid != null);
                    
                    // return value
                    return hasTopIndustryStreakGrid;
                }
            }
            #endregion
            
            #region HasTopLosingStreakGrid
            /// <summary>
            /// This property returns true if this object has a 'TopLosingStreakGrid'.
            /// </summary>
            public bool HasTopLosingStreakGrid
            {
                get
                {
                    // initial value
                    bool hasTopLosingStreakGrid = (this.TopLosingStreakGrid != null);
                    
                    // return value
                    return hasTopLosingStreakGrid;
                }
            }
            #endregion
            
            #region HasTopStreakGrid
            /// <summary>
            /// This property returns true if this object has a 'TopStreakGrid'.
            /// </summary>
            public bool HasTopStreakGrid
            {
                get
                {
                    // initial value
                    bool hasTopStreakGrid = (this.TopStreakGrid != null);
                    
                    // return value
                    return hasTopStreakGrid;
                }
            }
            #endregion
            
            #region LosingIndustryGrid
            /// <summary>
            /// This property gets or sets the value for 'LosingIndustryGrid'.
            /// </summary>
            public Grid LosingIndustryGrid
            {
                get { return losingIndustryGrid; }
                set { losingIndustryGrid = value; }
            }
            #endregion
            
            #region MarketSummaryGrid
            /// <summary>
            /// This property gets or sets the value for 'MarketSummaryGrid'.
            /// </summary>
            public Grid MarketSummaryGrid
            {
                get { return marketSummaryGrid; }
                set { marketSummaryGrid = value; }
            }
            #endregion
            
            #region TopIndustryStreakGrid
            /// <summary>
            /// This property gets or sets the value for 'TopIndustryStreakGrid'.
            /// </summary>
            public Grid TopIndustryStreakGrid
            {
                get { return topIndustryStreakGrid; }
                set { topIndustryStreakGrid = value; }
            }
            #endregion
            
            #region TopLosingStreakGrid
            /// <summary>
            /// This property gets or sets the value for 'TopLosingStreakGrid'.
            /// </summary>
            public Grid TopLosingStreakGrid
            {
                get { return topLosingStreakGrid; }
                set { topLosingStreakGrid = value; }
            }
            #endregion
            
            #region TopStreakGrid
            /// <summary>
            /// This property gets or sets the value for 'TopStreakGrid'.
            /// </summary>
            public Grid TopStreakGrid
            {
                get { return topStreakGrid; }
                set { topStreakGrid = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
