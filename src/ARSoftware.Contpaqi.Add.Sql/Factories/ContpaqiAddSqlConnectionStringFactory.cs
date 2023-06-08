using ARSoftware.Contpaqi.Add.Sql.Models.Constants;
using Microsoft.Data.SqlClient;

namespace ARSoftware.Contpaqi.Add.Sql.Factories;

public static class ContpaqiAddSqlConnectionStringFactory
{
    public static string CreateContpaqiAddDbDirectoryConnectionString(string contpaqiConnectionString)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiAddConstants.ContpaqiAddDbDirectoryDatabaseName
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    public static string CreateContpaqiAddCatalogosConnectionString(string contpaqiConnectionString)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiAddConstants.ContpaqiAddCatalogosDatabaseName
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    public static string CreateContpaqiAddDocumentContentConnectionString(string contpaqiConnectionString, string empresaGuid)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiContabilidadAddDatabaseNameGenerator.CreateDocumentContentDabaseName(empresaGuid)
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    public static string CreateContpaqiAddDocumentMetadataConnectionString(string contpaqiConnectionString, string empresaGuid)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiContabilidadAddDatabaseNameGenerator.CreateDocumentMetadataDabaseName(empresaGuid)
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    public static string CreateContpaqiAddOtherContentConnectionString(string contpaqiConnectionString, string empresaGuid)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiContabilidadAddDatabaseNameGenerator.CreateOtherContentDabaseName(empresaGuid)
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    public static string CreateContpaqiAddOtherMetadataConnectionString(string contpaqiConnectionString, string empresaGuid)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiContabilidadAddDatabaseNameGenerator.CreateOtherMetadataDabaseName(empresaGuid)
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }
}
