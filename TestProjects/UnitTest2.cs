using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace DevOpsProject
{
    public class UnitTest2
    {
        public  string getAppSettingJsonData(string apiURL)
        {
            string URL = string.Empty;
            string filePath = getDir() + "\\QAappsettings.json";
            string strFileContents = File.ReadAllText(filePath);

            var serializer = new JavaScriptSerializer();
            var dictValues = serializer.DeserializeObject(strFileContents);
            Dictionary<string, object> json_Dictionary = serializer.Deserialize<Dictionary<string, object>>(strFileContents);

            foreach (KeyValuePair<string, object> item in json_Dictionary)
            {
                Dictionary<string, string> ApiDictValue = item.Value.ToStringDictionary();
                if (ApiDictValue.ContainsKey(apiURL))
                {
                    URL = ApiDictValue[apiURL].ToString();
                    return URL;
                }
            }
            return URL;
        }

        public string  getDir()
        {
            var dir1 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            var dir = dir1.Replace("\\bin\\Release", "");
            return dir;

        }
    }
}
