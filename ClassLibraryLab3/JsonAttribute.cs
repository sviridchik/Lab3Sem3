using System;
using System.IO;

namespace ClassLibraryLab3
{
    public class pathJAttribute:Attribute
    {
        public string path { get; set; }

        public pathJAttribute(string scratchJson)
        {
            if (scratchJson.EndsWith(".json"))
            {
                path = scratchJson;
            }
            else
            {
                path = Path.ChangeExtension(scratchJson, "json");
            }
        }
    }
}


