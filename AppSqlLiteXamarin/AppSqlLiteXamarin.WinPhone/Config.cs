using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;
using System.IO;
using Xamarin.Forms;
using Windows.Storage;

[assembly: Dependency(typeof(AppSqlLiteXamarin.WinPhone.App))]

namespace AppSqlLiteXamarin
{
    public class Config : IConfig
    {
        private string directorioDB;
        private ISQLitePlatform plataforma;
        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    
                    directorioDB = ApplicationData.Current.LocalFolder.Path;
                }

                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
                }

                return plataforma;
            }
        }
    }
}
