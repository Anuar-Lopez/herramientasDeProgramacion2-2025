namespace ClinicaApp.Infraestructure.Config
{
    public static class Config
    {
        // Ajusta esta cadena a tu instancia de SQL Server
        public static string ConnectionString =>
            @"Server=DESKTOP-68JDOQ8\SQLEXPRESS;Database=ClinicaDB;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
