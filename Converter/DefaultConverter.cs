namespace Converter
{
    public static class DefaultConverter
    {
        public static string CreateLaunchSettingsContent(string envContent)
        {
            var launchSettings = new LaunchSettingsModel();

            var fileLines = envContent.Split("\n");
            foreach (var fileLine in fileLines)
            {
                if (fileLine.Length > 0)
                {
                    var keyValue = fileLine.Split('=', 2);
                    launchSettings.FileRecords.Add(new LaunchSettingsRecordModel
                    {
                        Key = ReplaceSpecialCharacters(keyValue[0].ToString()),
                        Value = ReplaceSpecialCharacters(keyValue[1].ToString())
                    });
                }
            }

            return launchSettings.ToString();
        }

        public static string CreateEnvFileContent(string launchSettingsContent)
        {
            var envFile = new EnvFileModel();

            var fileLines = launchSettingsContent.Split("\n");
            foreach (var fileLine in fileLines)
            {
                if (fileLine.Length > 0)
                {
                    var keyValue = fileLine.Split(':', 2);
                    envFile.FileRecords.Add(new EnvFileRecordModel
                    {
                        Key = ReplaceSpecialCharacters(keyValue[0].ToString()),
                        Value = ReplaceSpecialCharacters(keyValue[1].ToString())
                    });
                }
            }

            return envFile.ToString();
        }

        private static string ReplaceSpecialCharacters(string currentValue)
        {
            var replacedValue = currentValue.Trim();
            replacedValue = replacedValue.Replace("\r", "");
            replacedValue = replacedValue.Replace("\n", "");
            replacedValue = replacedValue.Replace("\"", "");
            replacedValue = replacedValue.Replace(",", "");

            return replacedValue;
        }
    }
}