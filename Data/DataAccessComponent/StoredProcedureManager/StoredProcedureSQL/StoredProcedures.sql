Use [StockData]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Insert a new Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Insert >>>'

    End

GO

Create PROCEDURE Admin_Insert

    -- Add the parameters for the stored procedure here
    @DocumentsFolder nvarchar(256),
    @MinVolume int,
    @ProcessedFolder nvarchar(256)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Admin]
    ([DocumentsFolder],[MinVolume],[ProcessedFolder])

    -- Begin Values List
    Values(@DocumentsFolder, @MinVolume, @ProcessedFolder)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Update an existing Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Update >>>'

    End

GO

Create PROCEDURE Admin_Update

    -- Add the parameters for the stored procedure here
    @DocumentsFolder nvarchar(256),
    @Id int,
    @MinVolume int,
    @ProcessedFolder nvarchar(256)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Admin]

    -- Update Each field
    Set [DocumentsFolder] = @DocumentsFolder,
    [MinVolume] = @MinVolume,
    [ProcessedFolder] = @ProcessedFolder

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Find an existing Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Find >>>'

    End

GO

Create PROCEDURE Admin_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DocumentsFolder],[Id],[MinVolume],[ProcessedFolder]

    -- From tableName
    From [Admin]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Delete an existing Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Delete >>>'

    End

GO

Create PROCEDURE Admin_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Admin]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all Admin objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_FetchAll >>>'

    End

GO

Create PROCEDURE Admin_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DocumentsFolder],[Id],[MinVolume],[ProcessedFolder]

    -- From tableName
    From [Admin]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DailyPriceData_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Insert a new DailyPriceData
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DailyPriceData_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DailyPriceData_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DailyPriceData_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DailyPriceData_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DailyPriceData_Insert >>>'

    End

GO

Create PROCEDURE DailyPriceData_Insert

    -- Add the parameters for the stored procedure here
    @ClosePrice float,
    @CloseScore float,
    @HighPrice float,
    @LowPrice float,
    @MostRecent bit,
    @OpenPrice float,
    @PercentChange float,
    @PriceUnchanged bit,
    @Spread float,
    @SpreadScore float,
    @StockDate datetime,
    @Streak int,
    @Symbol nvarchar(10),
    @Volume int,
    @VolumeScore float

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [DailyPriceData]
    ([ClosePrice],[CloseScore],[HighPrice],[LowPrice],[MostRecent],[OpenPrice],[PercentChange],[PriceUnchanged],[Spread],[SpreadScore],[StockDate],[Streak],[Symbol],[Volume],[VolumeScore])

    -- Begin Values List
    Values(@ClosePrice, @CloseScore, @HighPrice, @LowPrice, @MostRecent, @OpenPrice, @PercentChange, @PriceUnchanged, @Spread, @SpreadScore, @StockDate, @Streak, @Symbol, @Volume, @VolumeScore)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DailyPriceData_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Update an existing DailyPriceData
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DailyPriceData_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DailyPriceData_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DailyPriceData_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DailyPriceData_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DailyPriceData_Update >>>'

    End

GO

Create PROCEDURE DailyPriceData_Update

    -- Add the parameters for the stored procedure here
    @ClosePrice float,
    @CloseScore float,
    @HighPrice float,
    @Id int,
    @LowPrice float,
    @MostRecent bit,
    @OpenPrice float,
    @PercentChange float,
    @PriceUnchanged bit,
    @Spread float,
    @SpreadScore float,
    @StockDate datetime,
    @Streak int,
    @Symbol nvarchar(10),
    @Volume int,
    @VolumeScore float

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [DailyPriceData]

    -- Update Each field
    Set [ClosePrice] = @ClosePrice,
    [CloseScore] = @CloseScore,
    [HighPrice] = @HighPrice,
    [LowPrice] = @LowPrice,
    [MostRecent] = @MostRecent,
    [OpenPrice] = @OpenPrice,
    [PercentChange] = @PercentChange,
    [PriceUnchanged] = @PriceUnchanged,
    [Spread] = @Spread,
    [SpreadScore] = @SpreadScore,
    [StockDate] = @StockDate,
    [Streak] = @Streak,
    [Symbol] = @Symbol,
    [Volume] = @Volume,
    [VolumeScore] = @VolumeScore

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DailyPriceData_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Find an existing DailyPriceData
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DailyPriceData_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DailyPriceData_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DailyPriceData_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DailyPriceData_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DailyPriceData_Find >>>'

    End

GO

Create PROCEDURE DailyPriceData_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ClosePrice],[CloseScore],[HighPrice],[Id],[LowPrice],[MostRecent],[OpenPrice],[PercentChange],[PriceUnchanged],[Spread],[SpreadScore],[StockDate],[Streak],[Symbol],[Volume],[VolumeScore]

    -- From tableName
    From [DailyPriceData]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DailyPriceData_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Delete an existing DailyPriceData
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DailyPriceData_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DailyPriceData_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DailyPriceData_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DailyPriceData_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DailyPriceData_Delete >>>'

    End

GO

Create PROCEDURE DailyPriceData_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [DailyPriceData]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DailyPriceData_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all DailyPriceData objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DailyPriceData_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DailyPriceData_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DailyPriceData_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DailyPriceData_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DailyPriceData_FetchAll >>>'

    End

GO

Create PROCEDURE DailyPriceData_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ClosePrice],[CloseScore],[HighPrice],[Id],[LowPrice],[MostRecent],[OpenPrice],[PercentChange],[PriceUnchanged],[Spread],[SpreadScore],[StockDate],[Streak],[Symbol],[Volume],[VolumeScore]

    -- From tableName
    From [DailyPriceData]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DailyPriceDataView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all DailyPriceDataView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DailyPriceDataView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DailyPriceDataView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DailyPriceDataView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DailyPriceDataView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DailyPriceDataView_FetchAll >>>'

    End

GO

Create PROCEDURE DailyPriceDataView_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ClosePrice],[CloseScore],[HighPrice],[Id],[LowPrice],[Name],[OpenPrice],[Spread],[SpreadScore],[StockDate],[StockId],[Streak],[Symbol],[Volume],[VolumeScore]

    -- From tableName
    From [DailyPriceDataView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DoNotTrack_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Insert a new DoNotTrack
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DoNotTrack_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DoNotTrack_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DoNotTrack_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DoNotTrack_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DoNotTrack_Insert >>>'

    End

GO

Create PROCEDURE DoNotTrack_Insert

    -- Add the parameters for the stored procedure here
    @Symbol nvarchar(10)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [DoNotTrack]
    ([Symbol])

    -- Begin Values List
    Values(@Symbol)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DoNotTrack_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Update an existing DoNotTrack
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DoNotTrack_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DoNotTrack_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DoNotTrack_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DoNotTrack_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DoNotTrack_Update >>>'

    End

GO

Create PROCEDURE DoNotTrack_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Symbol nvarchar(10)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [DoNotTrack]

    -- Update Each field
    Set [Symbol] = @Symbol

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DoNotTrack_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Find an existing DoNotTrack
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DoNotTrack_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DoNotTrack_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DoNotTrack_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DoNotTrack_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DoNotTrack_Find >>>'

    End

GO

Create PROCEDURE DoNotTrack_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Symbol]

    -- From tableName
    From [DoNotTrack]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DoNotTrack_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Delete an existing DoNotTrack
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DoNotTrack_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DoNotTrack_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DoNotTrack_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DoNotTrack_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DoNotTrack_Delete >>>'

    End

GO

Create PROCEDURE DoNotTrack_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [DoNotTrack]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DoNotTrack_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all DoNotTrack objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DoNotTrack_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DoNotTrack_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DoNotTrack_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DoNotTrack_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DoNotTrack_FetchAll >>>'

    End

GO

Create PROCEDURE DoNotTrack_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Symbol]

    -- From tableName
    From [DoNotTrack]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Industry_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Insert a new Industry
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Industry_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Industry_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Industry_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Industry_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Industry_Insert >>>'

    End

GO

Create PROCEDURE Industry_Insert

    -- Add the parameters for the stored procedure here
    @Advancers int,
    @AveragePercentChange float,
    @Decliners int,
    @LastUpdated datetime,
    @Name nvarchar(128),
    @NumberStocks int,
    @Score float,
    @Streak int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Industry]
    ([Advancers],[AveragePercentChange],[Decliners],[LastUpdated],[Name],[NumberStocks],[Score],[Streak])

    -- Begin Values List
    Values(@Advancers, @AveragePercentChange, @Decliners, @LastUpdated, @Name, @NumberStocks, @Score, @Streak)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Industry_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Update an existing Industry
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Industry_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Industry_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Industry_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Industry_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Industry_Update >>>'

    End

GO

Create PROCEDURE Industry_Update

    -- Add the parameters for the stored procedure here
    @Advancers int,
    @AveragePercentChange float,
    @Decliners int,
    @Id int,
    @LastUpdated datetime,
    @Name nvarchar(128),
    @NumberStocks int,
    @Score float,
    @Streak int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Industry]

    -- Update Each field
    Set [Advancers] = @Advancers,
    [AveragePercentChange] = @AveragePercentChange,
    [Decliners] = @Decliners,
    [LastUpdated] = @LastUpdated,
    [Name] = @Name,
    [NumberStocks] = @NumberStocks,
    [Score] = @Score,
    [Streak] = @Streak

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Industry_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Find an existing Industry
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Industry_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Industry_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Industry_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Industry_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Industry_Find >>>'

    End

GO

Create PROCEDURE Industry_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Advancers],[AveragePercentChange],[Decliners],[Id],[LastUpdated],[Name],[NumberStocks],[Score],[Streak]

    -- From tableName
    From [Industry]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Industry_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Delete an existing Industry
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Industry_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Industry_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Industry_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Industry_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Industry_Delete >>>'

    End

GO

Create PROCEDURE Industry_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Industry]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Industry_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all Industry objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Industry_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Industry_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Industry_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Industry_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Industry_FetchAll >>>'

    End

GO

Create PROCEDURE Industry_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Advancers],[AveragePercentChange],[Decliners],[Id],[LastUpdated],[Name],[NumberStocks],[Score],[Streak]

    -- From tableName
    From [Industry]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: IndustryLosingStreakView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all IndustryLosingStreakView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('IndustryLosingStreakView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure IndustryLosingStreakView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.IndustryLosingStreakView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure IndustryLosingStreakView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure IndustryLosingStreakView_FetchAll >>>'

    End

GO

Create PROCEDURE IndustryLosingStreakView_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Advancers],[AveragePercentChange],[Decliners],[Name],[Streak]

    -- From tableName
    From [IndustryLosingStreakView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: IndustrySummary_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all IndustrySummary objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('IndustrySummary_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure IndustrySummary_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.IndustrySummary_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure IndustrySummary_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure IndustrySummary_FetchAll >>>'

    End

GO

Create PROCEDURE IndustrySummary_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [IndustryAdvancers],[IndustryDecliners]

    -- From tableName
    From [IndustrySummary]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: IndustryWinningStreakView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all IndustryWinningStreakView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('IndustryWinningStreakView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure IndustryWinningStreakView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.IndustryWinningStreakView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure IndustryWinningStreakView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure IndustryWinningStreakView_FetchAll >>>'

    End

GO

Create PROCEDURE IndustryWinningStreakView_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Advancers],[AveragePercentChange],[Decliners],[Name],[Streak]

    -- From tableName
    From [IndustryWinningStreakView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: MarketSummary_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all MarketSummary objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('MarketSummary_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure MarketSummary_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.MarketSummary_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure MarketSummary_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure MarketSummary_FetchAll >>>'

    End

GO

Create PROCEDURE MarketSummary_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Advancers],[Decliners],[NumberStocks],[StockDate]

    -- From tableName
    From [MarketSummary]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Sector_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Insert a new Sector
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Sector_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Sector_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Sector_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Sector_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Sector_Insert >>>'

    End

GO

Create PROCEDURE Sector_Insert

    -- Add the parameters for the stored procedure here
    @Advancers int,
    @AveragePercentChange float,
    @Decliners int,
    @LastUpdated datetime,
    @Name nvarchar(50),
    @NumberStocks int,
    @Score float,
    @Streak int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Sector]
    ([Advancers],[AveragePercentChange],[Decliners],[LastUpdated],[Name],[NumberStocks],[Score],[Streak])

    -- Begin Values List
    Values(@Advancers, @AveragePercentChange, @Decliners, @LastUpdated, @Name, @NumberStocks, @Score, @Streak)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Sector_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Update an existing Sector
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Sector_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Sector_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Sector_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Sector_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Sector_Update >>>'

    End

GO

Create PROCEDURE Sector_Update

    -- Add the parameters for the stored procedure here
    @Advancers int,
    @AveragePercentChange float,
    @Decliners int,
    @Id int,
    @LastUpdated datetime,
    @Name nvarchar(50),
    @NumberStocks int,
    @Score float,
    @Streak int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Sector]

    -- Update Each field
    Set [Advancers] = @Advancers,
    [AveragePercentChange] = @AveragePercentChange,
    [Decliners] = @Decliners,
    [LastUpdated] = @LastUpdated,
    [Name] = @Name,
    [NumberStocks] = @NumberStocks,
    [Score] = @Score,
    [Streak] = @Streak

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Sector_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Find an existing Sector
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Sector_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Sector_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Sector_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Sector_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Sector_Find >>>'

    End

GO

Create PROCEDURE Sector_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Advancers],[AveragePercentChange],[Decliners],[Id],[LastUpdated],[Name],[NumberStocks],[Score],[Streak]

    -- From tableName
    From [Sector]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Sector_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Delete an existing Sector
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Sector_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Sector_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Sector_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Sector_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Sector_Delete >>>'

    End

GO

Create PROCEDURE Sector_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Sector]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Sector_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all Sector objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Sector_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Sector_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Sector_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Sector_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Sector_FetchAll >>>'

    End

GO

Create PROCEDURE Sector_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Advancers],[AveragePercentChange],[Decliners],[Id],[LastUpdated],[Name],[NumberStocks],[Score],[Streak]

    -- From tableName
    From [Sector]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: SectorSummary_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all SectorSummary objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('SectorSummary_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure SectorSummary_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.SectorSummary_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure SectorSummary_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure SectorSummary_FetchAll >>>'

    End

GO

Create PROCEDURE SectorSummary_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [SectorAdvancers],[SectorDecliners]

    -- From tableName
    From [SectorSummary]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StockDay_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Insert a new StockDay
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StockDay_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StockDay_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StockDay_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StockDay_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StockDay_Insert >>>'

    End

GO

Create PROCEDURE StockDay_Insert

    -- Add the parameters for the stored procedure here
    @Date datetime,
    @IndustryProcessed bit,
    @SectorProcessed bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [StockDay]
    ([Date],[IndustryProcessed],[SectorProcessed])

    -- Begin Values List
    Values(@Date, @IndustryProcessed, @SectorProcessed)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StockDay_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Update an existing StockDay
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StockDay_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StockDay_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StockDay_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StockDay_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StockDay_Update >>>'

    End

GO

Create PROCEDURE StockDay_Update

    -- Add the parameters for the stored procedure here
    @Date datetime,
    @Id int,
    @IndustryProcessed bit,
    @SectorProcessed bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [StockDay]

    -- Update Each field
    Set [Date] = @Date,
    [IndustryProcessed] = @IndustryProcessed,
    [SectorProcessed] = @SectorProcessed

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StockDay_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Find an existing StockDay
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StockDay_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StockDay_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StockDay_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StockDay_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StockDay_Find >>>'

    End

GO

Create PROCEDURE StockDay_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Date],[Id],[IndustryProcessed],[SectorProcessed]

    -- From tableName
    From [StockDay]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StockDay_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Delete an existing StockDay
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StockDay_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StockDay_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StockDay_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StockDay_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StockDay_Delete >>>'

    End

GO

Create PROCEDURE StockDay_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [StockDay]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: StockDay_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all StockDay objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('StockDay_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure StockDay_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.StockDay_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure StockDay_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure StockDay_FetchAll >>>'

    End

GO

Create PROCEDURE StockDay_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Date],[Id],[IndustryProcessed],[SectorProcessed]

    -- From tableName
    From [StockDay]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: TopLosingStreakStocks_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all TopLosingStreakStocks objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('TopLosingStreakStocks_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure TopLosingStreakStocks_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.TopLosingStreakStocks_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure TopLosingStreakStocks_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure TopLosingStreakStocks_FetchAll >>>'

    End

GO

Create PROCEDURE TopLosingStreakStocks_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[LastClose],[Name],[Streak],[Symbol]

    -- From tableName
    From [TopLosingStreakStocks]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: TopStreakStocks_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   11/10/2023
-- Description:    Returns all TopStreakStocks objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('TopStreakStocks_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure TopStreakStocks_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.TopStreakStocks_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure TopStreakStocks_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure TopStreakStocks_FetchAll >>>'

    End

GO

Create PROCEDURE TopStreakStocks_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[LastClose],[Name],[Streak],[Symbol]

    -- From tableName
    From [TopStreakStocks]

END

-- Thank you for using DataTier.Net.

