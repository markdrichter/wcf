ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [ASPNETDB_TMP_log], FILENAME = '$(Path1)Aspnet_log.ldf', MAXSIZE = 2097152 MB, FILEGROWTH = 10 %);

