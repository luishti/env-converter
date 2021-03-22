using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class LaunchSettingsModel
    {
        public LaunchSettingsModel()
        {
            FileRecords = new List<LaunchSettingsRecordModel>();
        }

        public List<LaunchSettingsRecordModel> FileRecords { get; set; }

        public override string ToString()
        {
            StringBuilder fileContent = new StringBuilder();

            foreach (var line in FileRecords)
            {
                fileContent.AppendLine($"\"{line.Key}\": \"{line.Value}\",");
            }

            return fileContent.ToString();
        }
    }
}