using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_Basic_PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("student.xml");

            var rootElement = xmlDocument.DocumentElement;

         

            Student student = new Student()
            {
                 Name= rootElement.GetElementsByTagName("name")[0].InnerText,
                 Surname=rootElement.GetElementsByTagName("surname")[0].InnerText,
                 Age=int.Parse(rootElement.GetElementsByTagName("age")[0].InnerText),
                Specialty=rootElement.GetElementsByTagName("specialty")[0].InnerText,
                StudyCourse=int.Parse(rootElement.GetElementsByTagName("studyCourse")[0].InnerText),
                AverageMark=double.Parse(rootElement.GetElementsByTagName("averageMark")[0].InnerText)
            };

            string rootEl = rootElement.Name;
            string childElementName = rootElement.GetElementsByTagName("name")[0].Name;
            string childElementSurname = rootElement.GetElementsByTagName("surname")[0].Name;
            string childElementAge = rootElement.GetElementsByTagName("age")[0].Name;
            string childElementSpecialty = rootElement.GetElementsByTagName("specialty")[0].Name;
            string childElementStudyCourse = rootElement.GetElementsByTagName("studyCourse")[0].Name;
            string childElementAverageMark = rootElement.GetElementsByTagName("averageMark")[0].Name;

            Console.WriteLine("<" + rootEl + ">" + "\n" +
                "\t" + "<" + childElementName + ">" + student.Name + "</" + childElementName + ">\n" +
                "\t" + "<" + childElementSurname + ">" + student.Surname + "</" + childElementSurname + ">\n" +
                "\t" + "<" + childElementAge + ">" + student.Age + "</" + childElementAge + ">\n" +
                "\t" + "<" + childElementSpecialty + ">" + student.Specialty + "</" + childElementSpecialty + ">\n" +
                "\t" + "<" + childElementStudyCourse + ">" + student.StudyCourse + "</" + childElementStudyCourse + ">\n" +
                "\t" + "<" + childElementAverageMark + ">" + student.AverageMark + "</" + childElementAverageMark + ">\n" +
                "</" + rootEl + ">");

            Console.Read();
        }
    }
}
