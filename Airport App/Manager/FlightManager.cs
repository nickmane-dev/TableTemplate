using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Airport_App.Manager
{
    static class FlightManager
    {
        public static string dataPath = @"flightData.xml";

        private static List<flight> v = new List<flight>();
        
        public static void loadData ()
        {
            if (!File.Exists(dataPath)) return;
            v = FlightDataManager.readData();
        }
        public static void startup ()
        {
            addFlight("AirBussines", "Cessna Citation Mustang", "28 июня 2022 г.", "Москва", "Челябинск", "8", "Бизнес", "74000", "0");
            addFlight("Aeroflot", "Airbus A380", "28 июня 2022 г.", "Москва", "Челябинск", "300", "Эконом,Бизнес", "5300", "800");
            addFlight("Aeroflot", "Boeing 747-8", "29 июня 2022 г.", "Москва", "Челябинск", "320", "Эконом,Бизнес", "4300", "500");
            addFlight("S7 Airlines", "Ан-225 «Мрия»", "29 июня 2022 г.", "Киев", "Челябинск", "2000", "-", "43000", "20000");
            addFlight("Aeroflot", "Boeing 747-8", "29 июня 2022 г.", "Вашингтон", "Челябинск", "300", "Эконом,Бизнес", "30000", "3000");
            addFlight("S7 Airlines", "Airbus A380", "30 июня 2022 г.", "Сочи", "Челябинск", "300", "Эконом,Бизнес", "5000", "600");
            addFlight("S7 Airlines", "Boeing 747 Dreamlifter", "30 июня 2022 г.", "Сочи", "Челябинск", "800", "Эконом,Бизнес", "5300", "800");
            addFlight("Aeroflot", "Airbus A380", "30 июня 2022 г.", "Махачкала", "Челябинск", "500", "Эконом,Бизнес", "100", "0");            
        } 
        public static String[] getFlight  (int id)
        {
            if (v.Count < id)
            {
                MessageBox.Show("Ошибка в списках", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            String[] var = new String[9];
            var[0] = v[id].nameAirline;
            var[1] = v[id].nameAirplane;
            var[2] = v[id].when;
            var[3] = v[id].where;
            var[4] = v[id].from;
            var[5] = v[id].passengesCount;
            var[6] = v[id].typesClass;
            var[7] = v[id].priceTicket.ToString();
            var[8] = v[id].priceBaggage.ToString();

            return var;
        }
        public static void addFlight (string _1, string _2, string _3, string _4, string _5, string _6, string _7, string _8, string _9)
        {
            v.Add(new flight 
            { 
                nameAirline = _1, 
                nameAirplane = _2, 
                when = _3, 
                where = _4, 
                from = _5, 
                passengesCount = _6, 
                typesClass = _7, 
                priceTicket = int.Parse(_8), 
                priceBaggage = int.Parse(_9) } );
       
        }

        public static void saveData ()
        {
            FlightDataManager.writeData(v);
        }

        public static void removeFlight (int id)
        {
            try
            {
                v.RemoveAt(id);
            } catch
            {
                MessageBox.Show("Данную строку удалить невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int getFlightCount ()
        {
            return v.Count;
        }

    }

    static class FlightDataManager
    {
        public static string dataPath = @"flightData.xml";

        public static List<flight> readData ()
        {
            if (!File.Exists(dataPath)) return null;

            List<flight> v = new List<flight>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(dataPath);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    String[] vs = new string[9]; ;
                    XmlNode attr = xnode.Attributes.GetNamedItem("id");

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {                        
                        if (childnode.Name == "nameAirline")
                            vs[0] = childnode.InnerText;
                        if (childnode.Name == "nameAirplane")
                            vs[1] = childnode.InnerText;
                        if (childnode.Name == "when")
                            vs[2] = childnode.InnerText;
                        if (childnode.Name == "where")
                            vs[3] = childnode.InnerText;
                        if (childnode.Name == "from")
                            vs[4] = childnode.InnerText;
                        if (childnode.Name == "passengesCount")
                            vs[5] = childnode.InnerText;
                        if (childnode.Name == "typesClass")
                            vs[6] = childnode.InnerText;
                        if (childnode.Name == "priceTicket")
                            vs[7] = childnode.InnerText;
                        if (childnode.Name == "priceBaggage")
                            vs[8] = childnode.InnerText;
                    }

                    v.Add(new flight 
                    { 
                        nameAirline = vs[0], 
                        nameAirplane = vs[1], 
                        when = vs[2], 
                        where = vs[3], 
                        from = vs[4], 
                        passengesCount = vs[5], 
                        typesClass = vs[6], 
                        priceTicket = int.Parse(vs[7]), 
                        priceBaggage = int.Parse(vs[8]) 
                    });
                }
            }

            return v;
        }

        public static void writeData (List<flight> var)
        {
            createData();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(dataPath);
            XmlElement xRoot = xDoc.DocumentElement;

            for (int i = 0; i < var.Count; i++)
            {
                // создаем новый элемент person
                XmlElement flightElem = xDoc.CreateElement("flight");

                // создаем атрибут name
                XmlAttribute nameAttr = xDoc.CreateAttribute("id");

                // создаем элементы company и age            
                XmlElement nameAirlineElem = xDoc.CreateElement("nameAirline");
                XmlElement nameAirplaneElem = xDoc.CreateElement("nameAirplane");
                XmlElement whenElem = xDoc.CreateElement("when");
                XmlElement whereElem = xDoc.CreateElement("where");
                XmlElement fromElem = xDoc.CreateElement("from");
                XmlElement passengesCountElem = xDoc.CreateElement("passengesCount");
                XmlElement typesClassElem = xDoc.CreateElement("typesClass");
                XmlElement priceTicketElem = xDoc.CreateElement("priceTicket");
                XmlElement priceBaggageElem = xDoc.CreateElement("priceBaggage");

                // создаем текстовые значения для элементов и атрибута
                XmlText nameText = xDoc.CreateTextNode(i.ToString());
                XmlText nameAirlineText = xDoc.CreateTextNode(var[i].nameAirline);
                XmlText nameAirplaneText = xDoc.CreateTextNode(var[i].nameAirplane);
                XmlText whenText = xDoc.CreateTextNode(var[i].when);
                XmlText whereText = xDoc.CreateTextNode(var[i].where);
                XmlText fromText = xDoc.CreateTextNode(var[i].from);
                XmlText passengesCountText = xDoc.CreateTextNode(var[i].passengesCount);
                XmlText typesClassText = xDoc.CreateTextNode(var[i].typesClass);
                XmlText priceTicketText = xDoc.CreateTextNode(var[i].priceTicket.ToString());
                XmlText priceBaggageText = xDoc.CreateTextNode(var[i].priceBaggage.ToString());

                //добавляем узлы
                nameAttr.AppendChild(nameText);
                nameAirlineElem.AppendChild(nameAirlineText);
                nameAirplaneElem.AppendChild(nameAirplaneText);
                whenElem.AppendChild(whenText);
                whereElem.AppendChild(whereText);
                fromElem.AppendChild(fromText);
                passengesCountElem.AppendChild(passengesCountText);
                typesClassElem.AppendChild(typesClassText);
                priceTicketElem.AppendChild(priceTicketText);
                priceBaggageElem.AppendChild(priceBaggageText);

                // добавляем атрибут name
                flightElem.Attributes.Append(nameAttr);
                // добавляем элементы company и age
                flightElem.AppendChild(nameAirlineElem);
                flightElem.AppendChild(nameAirplaneElem);
                flightElem.AppendChild(whenElem);
                flightElem.AppendChild(whereElem);
                flightElem.AppendChild(fromElem);
                flightElem.AppendChild(passengesCountElem);
                flightElem.AppendChild(typesClassElem);
                flightElem.AppendChild(priceTicketElem);
                flightElem.AppendChild(priceBaggageElem);

                // добавляем в корневой элемент новый элемент person
                xRoot?.AppendChild(flightElem);
                // сохраняем изменения xml-документа в файл
                xDoc.Save(dataPath);
            }
        }
        public static void deleteData ()
        {

        }
        public static void createData ()
        {

            if (File.Exists(dataPath))
                File.Delete(dataPath);

            // Создаем новый Xml документ.
            var doc = new XmlDocument();

            // Создаем Xml заголовок.
            var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            // Добавляем заголовок перед корневым элементом.
            doc.AppendChild(xmlDeclaration);

            // Создаем Корневой элемент
            var root = doc.CreateElement("flightData");

            // Добавляем новый корневой элемент в документ.
            doc.AppendChild(root);

            // Сохраняем документ.
            doc.Save(dataPath);

        }

    }

    class flight
    {

        public String nameAirline { get; set; }
        public String nameAirplane { get; set; }
        public String when { get; set; }
        public String where { get; set; }
        public String from { get; set; }
        public String passengesCount { get; set; }
        public String typesClass { get; set; }
        public Int32 priceTicket { get; set; }
        public Int32 priceBaggage { get; set; }


    }
}
