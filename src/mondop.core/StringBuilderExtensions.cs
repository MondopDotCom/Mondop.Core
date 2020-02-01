using System.Text;

namespace Mondop.Core
{
    public static class StringBuilderExtensions
    {
        public static void AppendLineIfNotNullOrWhiteSpace(this StringBuilder stringBuilder, string textToAppend)
        {
            if (!string.IsNullOrWhiteSpace(textToAppend))
                stringBuilder.AppendLine(textToAppend);
        }
    }
}
