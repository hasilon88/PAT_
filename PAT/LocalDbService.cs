namespace PAT;

public class LocalDbService
{

    public static string GetPath(string nameDb)
    {
        string pathDb = string.Empty;
        if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            pathDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathDb = Path.Combine(pathDb, nameDb);
        }    else if (DeviceInfo.Platform == DevicePlatform.macOS)
        {
            pathDb = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            pathDb = Path.Combine(pathDb, nameDb);
        }
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            pathDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathDb = Path.Combine(pathDb, nameDb);
        }
        return pathDb;
    }
}