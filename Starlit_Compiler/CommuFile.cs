using CsvHelper.Configuration.Attributes;

namespace Starlit_Compiler
{
    public class CommuFile
    {
        [Name("Category")]
        public string Category { get; set; }
        [Name("Label")]
        public string Label { get; set; }
        [Name("Equivalent path")]
        public string FilePath { get; set; }
        [Name("Published URL")]
        public string FileUrl { get; set; }
    }
}
