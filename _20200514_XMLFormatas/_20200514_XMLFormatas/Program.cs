using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _20200514_XMLFormatas
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObjektasXML));
            XmlReader reader = XmlReader.Create("formatas.abcdef");
            ObjektasXML objektas = (ObjektasXML)xml.Deserialize(reader);
            Console.WriteLine("Zodis yra: "  + objektas.Zodis);
        }


        private void SukurtiXMLFaila()
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObjektasXML));

            System.IO.FileStream strea = System.IO.File.Create("formatas.abcdef");
            ObjektasXML xML = new ObjektasXML()
            {
                Skaicius = 5,
                Zodis = "Labas"
            };
            xml.Serialize(strea, xML);
        }
    }
}
