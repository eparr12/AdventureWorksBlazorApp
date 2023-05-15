namespace AdventureWorksBlazorClassLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "AdventureWorks2014");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "AdventureWorks2014");
    }
}