/*
ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [accounts_Data], FILENAME = '$(DefaultDataPath)$(DatabaseName)_Data.mdf', FILEGROWTH = 10 %) TO FILEGROUP [PRIMARY];
*/
