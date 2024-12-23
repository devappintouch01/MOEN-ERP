namespace MOEN_ERP.API.Services
{
    public class Logz
    {
        public static bool AddLog(string logText)
        {
            bool ret = true;
            try
            {
                using (StreamWriter sw = File.AppendText("logfile-api.log"))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:fffff")} - {logText}");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return ret;
        }

    }
}
