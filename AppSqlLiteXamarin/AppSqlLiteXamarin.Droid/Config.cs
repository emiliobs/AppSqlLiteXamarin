using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppSqlLiteXamarin.Droid.Resource))]

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
                    var directorio = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    directorioDB = Path.Combine(directorio, ".." ,"Library");
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
                    plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }

                return plataforma;
            }
        }
    }
}
