namespace DemoDotNet.Service
{
    public class AdvancedDataService : IDataService
    {
        public async Task<string> GetData()
        {
            await Task.Delay(5000);
            return ("Advanced data service return");
        }
    }
}
