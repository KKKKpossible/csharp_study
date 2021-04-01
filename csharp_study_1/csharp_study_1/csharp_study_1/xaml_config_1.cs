using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace csharp_study_1
{
    partial class xaml_config
    {
        public Dictionary<string, string> XmlRead(string path)
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read() == true)
                {
                    if (reader.IsStartElement() == true)
                    {
                        if (reader.Name.Equals("SETTING"))
                        {
                            string str_id = reader["ID"];
                            reader.Read();

                            string text_data_buff = reader.ReadElementContentAsString(_TEXT_DATA, "");
                            ret.Add(_TEXT_DATA, text_data_buff);

                            string cbox_data_buff = reader.ReadElementContentAsString(_CBOX_DATA, "");
                            ret.Add(_CBOX_DATA, cbox_data_buff);
                        }
                    }
                }
            }

            return ret;
        }

        public void XMLWrit(string path, Dictionary<string, string> xml_config)
        {

        }
    }
}
