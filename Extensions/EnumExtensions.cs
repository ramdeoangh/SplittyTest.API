
namespace SplittyTest.API.Extensions
{
    using System.ComponentModel;
    using System.Reflection;
    public static class EnumExtensions
    {
        public static string ToDescriptionString<TEnum>(this TEnum @enum)
        {
            FieldInfo fieldInfo = @enum.GetType().GetField(@enum.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes?[0].Description ?? @enum.ToString();

        }
    }
}