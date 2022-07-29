

docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=P@ssword2710' -p 1433:1433 -v mssql-data:/var/opt/mssql/data --user=root  --name sqledge  -d mcr.microsoft.com/azure-sql-edge