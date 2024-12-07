namespace Infostructure;
using Npgsql;
public class ConText
{
    private readonly string mainConnection = "Server=localhost;Port=5432;Database=DapperCrudDB;Username=postgres;Password=12345";

    public  NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(mainConnection);
    }
}
