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
    class SettingsSave
    {
        public void saveSettings(Settings settings, string settingsFilePath)
        {



            try
            {
                if (!File.Exists(settingsFilePath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsFilePath));
                    using (File.Create(settingsFilePath))
                    {

                    }
                }
                    using (TextWriter writer = new StreamWriter(settingsFilePath))
                    {
                        XmlSerializer sr = new XmlSerializer(settings.GetType());

                        sr.Serialize(writer, settings);
                        writer.Close();

                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the settings.\n" + ex.Message);
                throw;
            }
        }
    }
}
