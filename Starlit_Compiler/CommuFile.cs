using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starlit_Compiler
{
    public class CommuFile
    {
        public string Label { get; }
        public string FilePath { get; }
        public string FileUrl { get; }

        public CommuFile (string Name, string File, string Url)
        {
            Label = Name;
            FilePath = File;
            FileUrl = Url;
        }
        public override string ToString()
        {
            return Label;
        }
    }
}
