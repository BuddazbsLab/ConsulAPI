
using Newtonsoft.Json.Linq;

namespace ConsulAPI.Queries
{
    public class ConsulAppsettings
    {
        private readonly string _appsettingsPath;
        public string AppsettingsPath => _appsettingsPath;

        public ConsulAppsettings()
        {
            _appsettingsPath = "appsettings.json";
        }

        public JObject GetSettings()
        {

            using var fs = new StreamReader(AppsettingsPath);
            string json = fs.ReadToEnd();
            var jsoon = JObject.Parse(json);

            return jsoon;
        }
    }
}
