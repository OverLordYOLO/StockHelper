using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StockHelper
{
    class SettingsLoad
    {



        public SettingsLoad()
        {

        }

        internal Settings loadSettings(string settingsFilePath)
        {
            Settings settings;
            try
            {
                if (File.Exists(settingsFilePath))
                {
                    using (FileStream read = new FileStream(settingsFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(Settings));
                        settings = (Settings)xs.Deserialize(read);
                        return settings;
                    }
                }
                else
                {
                    throw new Exception("No settings found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load settings.\n" + ex.Message);
                throw;
            }

        }
    }
}
// https://www.dotnetperls.com/openfiledialog