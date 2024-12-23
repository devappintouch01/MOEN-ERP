namespace MOEN_ERP.Components
{
    public class Logz
    {
        public static bool AddLog(string logText)
        {
            bool ret = true;
            try
            {
                using (StreamWriter sw = File.AppendText("logfile.log"))
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
