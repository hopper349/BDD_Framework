
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFrameWork.COnfig
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path : "C:/Users/KRISHNA/source/repos/UnitTesting/AppSetting.json");


           IConfigurationRoot configurationRoot = builder.Build();


            Setting.AUT = configurationRoot.GetSection("testSettings").Get<TestSettings>().AUT;
            Setting.TestType = configurationRoot.GetSection("testSettings").Get<TestSettings>().TestType;
            Setting.IsLog = configurationRoot.GetSection("testSettings").Get<TestSettings>().IsLog;
            Setting.LogPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().LogPath;
            Setting.AppConnectionString = configurationRoot.GetSection("testSettings").Get<TestSettings>().AUTConnectionString;
            Setting.BrowserType = configurationRoot.GetSection("testSettings").Get<TestSettings>().Browser;

        }
    }
}
