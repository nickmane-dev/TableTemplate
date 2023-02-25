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
    static class PersonalManager
    {
        public static string dataPath = @"personalData.xml";

        private static List<employee> v = new List<employee>();

        public static void startup ()
        {
            addEmloyee("Максим", "Тимашов", "Евгеньевич", "20.05.2004", "Администратор", "sexunk");
            addEmloyee("Дементий", "Чупахин", "Максимович", "1.12.2004", "Отдел рейсов", "raboshapka");
            addEmloyee("Артём", "Хажеев", "Наилевич", "12.02.2004", "Отдел кадров", "kot");
            addEmloyee("Влад", "Слесарев", "Викторович", "09.23.2004", "Регистратор", "spartanets174");
            addEmloyee("Вадим", "Шиленков", "Владиславович", "27.07.2004", "root", "2mad");
        }

        public static void loadData()
        {
            if (!File.Exists(dataPath)) return;
            v = PersonalDataManager.readData();
        }
        public static String[] getEmployee (int id)
        {
            if (v.Count < id)
            {
                MessageBox.Show("Ошибка в списках", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            String[] var = new String[6];
            var[0] = v[id].name;
            var[1] = v[id].surname;
            var[2] = v[id].patronymic;
            var[3] = v[id].hbd;
            var[4] = v[id].jobTitle;
            var[5] = v[id].password;

            return var;
        }
        public static void addEmloyee (string _name, string _surname, string _patronymic, string _hbd, string _jobTitle, string _password)
        {
            v.Add(new employee { name = _name, surname = _surname, patronymic = _patronymic, hbd = _hbd, jobTitle = _jobTitle, password = _password } );
        }
        public static void saveData()
        {
            PersonalDataManager.writeData(v);
        }

        public static string getGroup (string name, string surname, string password)
        {
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i].name.ToLower() == name.ToLower())
                {
                    if (v[i].surname.ToLower() == surname.ToLower())
                    {
                        if (v[i].password == password)
                        return v[i].jobTitle;
                    }
                }
            }
            return null;
        }

        public static void removeEmployee (int id)
        {
            try
            {
                v.RemoveAt(id);
            } catch
            {
                MessageBox.Show("Данную строку удалить невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int getPersonalCount ()
        {
            return v.Count;
        }

    }

    static class PersonalDataManager
    {
        public static string dataPath = @"personalData.xml";

        public static List<employee> readData()
        {
            if (!File.Exists(dataPath)) return null;

            List<employee> v = new List<employee>();

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
                        if (childnode.Name == "jobTitle")
                            vs[4] = childnode.InnerText;
                        if (childnode.Name == "password")
                            vs[5] = childnode.InnerText;
                    }

                    v.Add(new employee
                    {
                        name = vs[0],
                        surname = vs[1],
                        patronymic = vs[2],
                        hbd = vs[3],
                        jobTitle = vs[4],
                        password = vs[5]
                    }) ;
                }
            }

            return v;
        }

        public static void writeData(List<employee> var)
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
                XmlElement q5Elem = xDoc.CreateElement("jobTitle");
                XmlElement q6Elem = xDoc.CreateElement("password");

                // создаем текстовые значения для элементов и атрибута
                XmlText q1Text = xDoc.CreateTextNode(i.ToString());
                XmlText q2Text = xDoc.CreateTextNode(var[i].name);
                XmlText q3Text = xDoc.CreateTextNode(var[i].surname);
                XmlText q4Text = xDoc.CreateTextNode(var[i].patronymic);
                XmlText q5Text = xDoc.CreateTextNode(var[i].hbd);
                XmlText q6Text = xDoc.CreateTextNode(var[i].jobTitle);
                XmlText q7Text = xDoc.CreateTextNode(var[i].password);

                //добавляем узлы
                nameAttr.AppendChild(q1Text);
                q1Elem.AppendChild(q2Text);
                q2Elem.AppendChild(q3Text);
                q3Elem.AppendChild(q4Text);
                q4Elem.AppendChild(q5Text);
                q5Elem.AppendChild(q6Text);
                q6Elem.AppendChild(q7Text);

                // добавляем атрибут name
                nElem.Attributes.Append(nameAttr);
                // добавляем элементы company и age
                nElem.AppendChild(q1Elem);
                nElem.AppendChild(q2Elem);
                nElem.AppendChild(q3Elem);
                nElem.AppendChild(q4Elem);
                nElem.AppendChild(q5Elem);
                nElem.AppendChild(q6Elem);

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
            var root = doc.CreateElement("personalData");

            // Добавляем новый корневой элемент в документ.
            doc.AppendChild(root);

            // Сохраняем документ.
            doc.Save(dataPath);

        }

    }

    class employee
    {

        public String name { get; set; }
        public String surname { get; set; }
        public String patronymic { get; set; }
        public String hbd { get; set; }
        public String jobTitle { get; set; }
        public String password { get; set; }


    }
}
