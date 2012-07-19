/*
ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [accounts_Log], FILENAME = '$(DefaultLogPath)$(DatabaseName)_Log.ldf', MAXSIZE = 2097152 MB, FILEGROWTH = 1024 KB);
*/
