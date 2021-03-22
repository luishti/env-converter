using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class EnvFileModel
    {
        public EnvFileModel()
        {
            FileRecords = new List<EnvFileRecordModel>();
        }

        public List<EnvFileRecordModel> FileRecords { get; set; }

        public override string ToString()
        {
            StringBuilder fileContent = new StringBuilder();

            foreach (var line in FileRecords)
            {
                fileContent.AppendLine($"{line.Key}={line.Value}");
            }

            return fileContent.ToString();
        }
    }
}