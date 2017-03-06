namespace XamlBrewer.Uwp.RadDataGridSample.Models
{
    using System;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Imaging;

    public class Location
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public ImageSource Image
        {
            get
            {
                return new BitmapImage(new Uri(string.Format("ms-appx:///Assets/LocationFlags/{0}.png", this.Code)));
            }
        }
    }
}
