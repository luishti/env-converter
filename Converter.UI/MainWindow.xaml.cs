using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace Converter.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SaveFileDialog _saveFileDialog;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertFile(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textEnvContent.Text))
                {
                    textEnvContent.Text = DefaultConverter.CreateEnvFileContent(textLaunchSettingsContent.Text);
                    textLaunchSettingsContent.Text = string.Empty;
                }
                else
                {
                    textLaunchSettingsContent.Text = DefaultConverter.CreateLaunchSettingsContent(textEnvContent.Text);
                    textEnvContent.Text = string.Empty;
                }
                labelConvertionStatus.Content = "Success!!";
            }
            catch (Exception ex)
            {
                labelConvertionStatus.Content = ex.Message;
            }
        }

        private void SaveEnvFile(object sender, RoutedEventArgs e)
        {
            _saveFileDialog = new SaveFileDialog();
            if (_saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(_saveFileDialog.FileName, textEnvContent.Text);
                labelConvertionStatus.Content = $"File saved at {_saveFileDialog.FileName}";
            }
        }

        private void SaveLaunchSettingsFile(object sender, RoutedEventArgs e)
        {
            _saveFileDialog = new SaveFileDialog();
            _saveFileDialog.Filter = "Json file (*.json)|*.json";
            if (_saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(_saveFileDialog.FileName, textLaunchSettingsContent.Text);
                labelConvertionStatus.Content = $"File saved at {_saveFileDialog.FileName}";
            }
        }
    }
}