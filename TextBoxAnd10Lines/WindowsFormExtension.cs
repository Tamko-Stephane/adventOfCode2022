using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBoxAnd10Lines
{
    public static class WindowsFormExtension
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
            {
                source.Text = value;                
            }
            else
            source.AppendText("\r\n" + value);
        }
    }
}
