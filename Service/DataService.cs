using DemoDotNet.Service;

namespace DemoDotNet.Service
{
    public class DataService : IDataService
    {
        public async Task<string> GetData()
        {
            await Task.Delay(10000);
            return ("Data service return");
        }
    }
}
