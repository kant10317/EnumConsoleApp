using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EnumConsoleApp
{
    public static class EnumExtension
    {
        /// <summary>
        /// 取得Enum的描述標籤內容
        /// </summary>
        /// <param name="self">Enum Type</param>
        /// <returns></returns>
        public static string ToDescription(this Enum self)
        {
            FieldInfo pInfo = self.GetType().GetField(self.ToString());
            DescriptionAttribute[] attributes = null;

            if (pInfo != null)
            {
                attributes =
                    (DescriptionAttribute[])pInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
            }

            return self.ToString();
        }

        /// <summary>
        /// 取得Enum的Value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="soure"></param>
        /// <returns></returns>
        public static int ToInt<T>(this T soure) where T : IConvertible//enum
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be an enumerated type");

            return (int)(IConvertible)soure;
        }

        public static string GetXmlEnumAttributeValueFromEnum<TEnum>(this TEnum value) where TEnum : struct, IConvertible
        {
            var enumType = typeof(TEnum);
            if (!enumType.IsEnum) return null;//or string.Empty, or throw exception

            var member = enumType.GetMember(value.ToString()).FirstOrDefault();
            if (member == null) return null;//or string.Empty, or throw exception

            var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
            if (attribute == null) return null;//or string.Empty, or throw exception
            return attribute.Name;
        }

    }
}
