using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExtractDJWBlacklistID
{
    class XmlUtility
    {
        public IEnumerable<int> GetSanctionReferenceNumbers(XElement person)
        {
            IEnumerable<int> sanctionReferenceNumbers = person.Element("SanctionsReferences").Elements("Reference").Select(c => {
                int number;
                bool success = int.TryParse(c.Value, out number);
                if (success) return number;
                else return -1;
            });

            return sanctionReferenceNumbers;
        }

        public IDsModel GetBlackListsID(XElement item)
        {
            string ID = item.Attribute("id").Value ?? "";
            var EUIDElements = item.Element("IDNumberTypes").Elements("ID").Where(c => c.Attribute("IDType").Value == "EU Consolidated Electronic List ID").Elements("IDValue");
            var OfacIDElements = item.Element("IDNumberTypes").Elements("ID").Where(c => c.Attribute("IDType").Value == "OFAC Unique ID").Elements("IDValue");
            var UNIDElements = item.Element("IDNumberTypes").Elements("ID").Where(c => c.Attribute("IDType").Value == "UN Permanent Reference No.").Elements("IDValue");

            string EUID = string.Empty;
            foreach (var element in EUIDElements)
            {
                EUID = $"{EUID}{element.Value};";
            }

            string OfacID = string.Empty;
            foreach (var element in OfacIDElements)
            {
                OfacID = $"{OfacID}{element.Value};";
            }

            string UNID = string.Empty;
            foreach (var element in UNIDElements)
            {
                UNID = $"{UNID}{element.Value};";
            }

            IDsModel model = new IDsModel
            {
                PersonID = ID,
                EUID = EUID,
                OfacID = OfacID,
                UNID = UNID
            };
            return model;
        }


        public IEnumerable<XElement> GetHasSanctionsReferencesRecords(XDocument xml, string recordName)
        {
            return xml.Root.Element("Records").Elements(recordName)
                .Where(c => c.Element("SanctionsReferences") != null && c.Element("IDNumberTypes") != null);

        }
    }
}
