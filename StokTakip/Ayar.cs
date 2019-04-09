using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace StokTakip
{
    enum Languages
    {
        en,
        tr
    }
    static class Ayar
    {    
       static  JavaScriptSerializer  jss = new JavaScriptSerializer();
        public static void ChangeLanguge(Languages lang)
        {
            CultureInfo.CurrentCulture = new CultureInfo(lang.ToString());
            CultureInfo.CurrentUICulture = new CultureInfo(lang.ToString());
            
            string json = jss.Serialize(lang);
            File.WriteAllText("settings.json", json);
        }

        public static void GetLatestLanguage()
        {
            Languages lang = Languages.tr;
            if (File.Exists("settings.json"))
            {
                var  settingContent = File.ReadAllText("settings.json");
                 lang = jss.Deserialize<Languages>(settingContent);
            }
            CultureInfo.CurrentCulture = new CultureInfo(lang.ToString());
            CultureInfo.CurrentUICulture = new CultureInfo(lang.ToString());
        }
    }
}
