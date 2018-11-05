using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    public static class ExtensionMethod
    {
        public static int ToInt(this object value)
        {
            if (value == null)
            {
                int result = 0;
                if (int.TryParse(value.ToString(), out result))
                    return result;
            }
            return 0;
        }

        public static Guid ToGuid(this object value)
        {
            if (value == null)
            {
                Guid result =Guid.NewGuid();
                if (Guid.TryParse(value.ToString(), out result))
                    return result;
            }
            return Guid.NewGuid();
        }

        
    }
}
