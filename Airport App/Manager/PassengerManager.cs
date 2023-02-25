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
    static class PassengerManager
    {
        public static string dataPath = @"passengerData.xml";

        private static List<passenger> v = new List<passenger>();


        public static void loadData()
        {
            if (!File.Exists(dataPath)) return;
            v = PassengerDataManager.readData();
        }
        public static String[] getPassenger (int id)
        {
            if (v.Count < id)
            {
                MessageBox.Show("Ошибка в списках", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            String[] var = new String[10];
            var[0] = v[id].name;
            var[1] = v[id].surname;
            var[2] = v[id].patronymic;
            var[3] = v[id].hbd;
            var[4] = v[id].number;
            var[5] = v[id].passportSeria;
            var[6] = v[id].passage;
            var[7] = v[id].typeClass;
            var[8] = v[id].baggage;
            var[9] = v[id].numFlight;

            return var;
        }
        public static void addPassenger (string _name, string _surname, string _patronymic, string _hbd, string _number, string _passportSeria, string _passage, string _typeClass, string _baggage, string _numFlight)
        {
            v.Add(new passenger 
            { 
                name             = _name, 
                surname          = _surname, 
                patronymic       = _patronymic, 
                hbd              = _hbd, 
                number           = _number, 
                passportSeria    = _passportSeria, 
                passage          = _passage,
                typeClass        = _typeClass,
                baggage          = _baggage,
                numFlight        = _numFlight 
            } );
        }

        public static void removePassenger (int id)
        {
            try
            { v.RemoveAt(id); } catch
            {  MessageBox.Show("Данную строку удалить невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static void saveData()
        {
            PassengerDataManager.writeData(v);
        }

        public static void clearList ()
        {
            v.Clear();
        }

        public static int getPassengerCount ()
        {
            return v.Count;
        }

    }

    static class PassengerDataManager
    {
        public static string dataPath = @"passengerData.xml";

        public static List<passenger> readData()
        {
            if (!File.Exists(dataPath)) return null;

            List<passenger> v = new List<passenger>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(dataPath);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    String[] vs = new string[10]; ;
                    XmlNode attr = xnode.Attributes.GetNamedItem("id");

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "name")
                            vs[0] = childnode.InnerText;
                        if (childnode.Name == "surname")
                            vs[1] = childnode.InnerText;
                        if (childnode.Name == "patronymic")
                            vs[2] = childnode.InnerText;
                        if (childnode.Name == "hbd")
                            vs[3] = childnode.InnerText;
                        if (childnode.Name == "number")
                            vs[4] = childnode.InnerText;
                        if (childnode.Name == "passportSeria")
                            vs[5] = childnode.InnerText;
                        if (childnode.Name == "passage")
                            vs[6] = childnode.InnerText;
                        if (childnode.Name == "typeClass")
                            vs[7] = childnode.InnerText;
                        if (childnode.Name == "baggage")
                            vs[8] = childnode.InnerText;
                        if (childnode.Name == "numFlight")
                            vs[9] = childnode.InnerText;
                    }

                    v.Add(new passenger
                    {
                        name = vs[0],
                        surname = vs[1],
                        patronymic = vs[2],
                        hbd = vs[3],
                        number = vs[4],
                        passportSeria = vs[5],
                        passage = vs[6],
                        typeClass = vs[7],
                        baggage = vs[8],
                        numFlight = vs[9]
                    });
                }
            }

            return v;
        }

        public static void writeData(List<passenger> var)
        {
            createData();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(dataPath);
            XmlElement xRoot = xDoc.DocumentElement;

            for (int i = 0; i < var.Count; i++)
            {
                // создаем новый элемент person
                XmlElement nElem = xDoc.CreateElement("passenger");

                // создаем атрибут name
                XmlAttribute nameAttr = xDoc.CreateAttribute("id");

                // создаем элементы company и age            
                XmlElement q1Elem = xDoc.CreateElement("name");
                XmlElement q2Elem = xDoc.CreateElement("surname");
                XmlElement q3Elem = xDoc.CreateElement("patronymic");
                XmlElement q4Elem = xDoc.CreateElement("hbd");
                XmlElement q5Elem = xDoc.CreateElement("number");
                XmlElement q6Elem = xDoc.CreateElement("passportSeria");
                XmlElement q7Elem = xDoc.CreateElement("passage");
                XmlElement q8Elem = xDoc.CreateElement("typeClass");
                XmlElement q9Elem = xDoc.CreateElement("baggage");
                XmlElement q10Elem = xDoc.CreateElement("numFlight");

                // создаем текстовые значения для элементов и атрибута
                XmlText q1Text = xDoc.CreateTextNode(i.ToString());
                XmlText q2Text = xDoc.CreateTextNode(var[i].name);
                XmlText q3Text = xDoc.CreateTextNode(var[i].surname);
                XmlText q4Text = xDoc.CreateTextNode(var[i].patronymic);
                XmlText q5Text = xDoc.CreateTextNode(var[i].hbd);
                XmlText q6Text = xDoc.CreateTextNode(var[i].number);
                XmlText q7Text = xDoc.CreateTextNode(var[i].passportSeria);
                XmlText q8Text = xDoc.CreateTextNode(var[i].passage);
                XmlText q9Text = xDoc.CreateTextNode(var[i].typeClass);
                XmlText q10Text = xDoc.CreateTextNode(var[i].baggage);
                XmlText q11Text = xDoc.CreateTextNode(var[i].numFlight);

                //добавляем узлы
                nameAttr.AppendChild(q1Text);
                q1Elem.AppendChild(q2Text);
                q2Elem.AppendChild(q3Text);
                q3Elem.AppendChild(q4Text);
                q4Elem.AppendChild(q5Text);
                q5Elem.AppendChild(q6Text);
                q6Elem.AppendChild(q7Text);
                q7Elem.AppendChild(q8Text);
                q8Elem.AppendChild(q9Text);
                q9Elem.AppendChild(q10Text);

                // добавляем атрибут name
                nElem.Attributes.Append(nameAttr);
                // добавляем элементы company и age
                nElem.AppendChild(q1Elem);
                nElem.AppendChild(q2Elem);
                nElem.AppendChild(q3Elem);
                nElem.AppendChild(q4Elem);
                nElem.AppendChild(q5Elem);
                nElem.AppendChild(q6Elem);
                nElem.AppendChild(q7Elem);
                nElem.AppendChild(q8Elem);
                nElem.AppendChild(q9Elem);
                nElem.AppendChild(q10Elem);

                // добавляем в корневой элемент новый элемент person
                xRoot?.AppendChild(nElem);
                // сохраняем изменения xml-документа в файл
                xDoc.Save(dataPath);
            }
        }
        public static void deleteData()
        {

        }
        public static void createData()
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
            var root = doc.CreateElement("passengerData");

            // Добавляем новый корневой элемент в документ.
            doc.AppendChild(root);

            // Сохраняем документ.
            doc.Save(dataPath);

        }

    }

    class passenger
    {

        public String name { get; set; }
        public String surname { get; set; }
        public String patronymic { get; set; }
        public String hbd { get; set; }
        public String number { get; set; }
        public String passportSeria { get; set; }
        public String passage { get; set; }
        public String typeClass { get; set; }
        public String baggage { get; set; }
        public String numFlight { get; set; }

    }
}
