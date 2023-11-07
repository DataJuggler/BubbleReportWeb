# BubbleReportWeb
This project is used as part of a 3D Animated Show I am building called The Bubble Report. The plan is to create a daily morning video with a recap of the
stock market from the previous market day.

I will publish this site on my server soon. 

This project uses DataJuggler.Blazor.Components and is a demo for the Grid. DataJuggler.Blazor.Components has passed 100,000 installs on NuGet.
https://github.com/DataJuggler/DataJuggler.Blazor.Components

This project is used in conjunction with another project of mine called StockData, where I download the latest End of Day stock prices from https://eoddata.com

Stock Data
https://github.com/DataJuggler/StockData

# Setup Instructions
To run this project will you need to follow these instructions

1. Create a SQL Server dataqbase named StockData
2. Download the SQL Script from Stock Data here: https://datajuggler.com/Downloads/StockDataDatabaseWithData.zip
3. Extract the Zip file and execute the StockDataDatabaseWithData.sql. This will create the tables, fields and views, plus insert all the rows.
   I update the database about once a week.
4. Create a connection string for StockData database. Tip: DataTier.Net comes with a Connection Builder program located in the Tools folder
   https://github.com/DataJuggler/DataTier.Net
5. Create a System Environment variable called BubbleReportConnString and paste in the connection string created in Step 4.
6. Run the project and you should see 5 or 6 grids.

I am making a video now for this project.




