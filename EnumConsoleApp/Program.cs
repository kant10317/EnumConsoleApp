using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConsoleApp
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("===Enum.GetNames===");
            foreach (string name in Enum.GetNames(typeof(Suits)))
            {
                System.Console.WriteLine(name);
            }

            System.Console.WriteLine("===Enum.GetValue===");
            foreach (int value in Enum.GetValues(typeof(Suits)))
            {
                System.Console.WriteLine(value);
            }

            System.Console.WriteLine("===Enum.GetXmlEnumAttributeValueFromEnum===");
            Console.WriteLine(OutputInvoiceTypeCode.Item31.GetXmlEnumAttributeValueFromEnum());

            foreach (OutputInvoiceTypeCode item in Enum.GetValues(typeof(OutputInvoiceTypeCode)))
            {
                Console.WriteLine(item.GetXmlEnumAttributeValueFromEnum());
            }

            System.Console.WriteLine("===Enum.Parse===");
            var a = (Suits)Enum.Parse(typeof(Suits), "Spades");

            int x = (int)WeekDay.Sun;
            int y = (int)WeekDay.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);

            System.Console.WriteLine("===Enum.Extension===");
            var description = WeekDay.Sun.ToDescription();
            Console.WriteLine("Sun description = {0}", description);

            var enumValue = WeekDay.Mon.ToInt();
            Console.WriteLine("Mon description = {0}", enumValue);

            Console.ReadLine();
        }

        public enum Suits
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds,
            NumSuits
        }

        public enum OutputInvoiceTypeCode
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("31")]
            Item31,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("32")]
            Item32,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("33")]
            Item33,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("34")]
            Item34,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("35")]
            Item35,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("36")]
            Item36,
        }

    }
}
