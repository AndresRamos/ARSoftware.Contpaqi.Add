namespace ARSoftware.Contpaqi.Add.Sql.Models.Constants;

public static class ContpaqiContabilidadAddDatabaseNameGenerator
{
    public static string CreateDocumentContentDabaseName(string guid)
    {
        return $"document_{guid}_content";
    }

    public static string CreateDocumentMetadataDabaseName(string guid)
    {
        return $"document_{guid}_metadata";
    }

    public static string CreateOtherContentDabaseName(string guid)
    {
        return $"other_{guid}_content";
    }

    public static string CreateOtherMetadataDabaseName(string guid)
    {
        return $"other_{guid}_metadata";
    }
}
