using System;
using System.IO;
using System.Web.Script.Serialization;


class RestarterSettings : JSONSettings<RestarterSettings>
{
    public string LCoreExe = "";
    public bool RegSearch = true;
}

class JSONSettings<T> where T : new()
{
    public void Save(string fileName)
    {
        try
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
        }
        catch
        {
            //Error writing settings file.
        }
    }

    public static void Save(T pSettings, string fileName)
    {
        File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
    }

    public static T Load(string fileName)
    {
        T t = new T();
        if (File.Exists(fileName))
        {
            t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
        }
        else
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));
        }
        return t;
    }
}
