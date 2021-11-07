namespace S11_MONGODB_DPA.API.Models
{
    public interface ICustomerDatabaseSetting
    {
        string ConnectionString { get; set; }
        string CustomerCollectionName { get; set; }
        string DatabaseName { get; set; }
    }
}