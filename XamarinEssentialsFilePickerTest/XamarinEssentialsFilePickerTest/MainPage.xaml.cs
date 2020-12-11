using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsFilePickerTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await ReadFileAsync();
        }

        private async Task ReadFileAsync()
        {
            // pick file
            var options = new PickOptions
            {
                PickerTitle = "Title"
            };
            var result = await FilePicker.PickAsync(options);
            if (result == null)
            {
                Trace.WriteLine("PickAsync result is null");
                return;
            }

            Trace.WriteLine($"File path: {result.FullPath}");

            // open file and read content
            using (var reader = new StreamReader(await result.OpenReadAsync()))
            {
                var content = await reader.ReadToEndAsync();
                Trace.WriteLine($"File content: {content}");
            }
        }
    }
}
