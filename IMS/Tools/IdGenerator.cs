using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Tools
{   
    /// <summary>
    /// Generates a unique id, that consists of numbers and letters
    /// just like a google youtube video link.
    /// </summary>
    public class IdGenerator
    {
        // https://stackoverflow.com/questions/11313205/generate-a-unique-id
        // Author: Ashraf Ali
        public static string UniqueId()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(11)
                .ToList().ForEach(e => builder.Append(e));
            return builder.ToString();
        }
    }
}
