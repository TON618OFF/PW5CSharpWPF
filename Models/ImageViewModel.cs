using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace practice_5.Models
{
    internal class ImageViewModel
    {
        public List<BitmapImage> Images { get; set; }

        public ImageViewModel(List<string> imagePaths)
        {
            Images = new List<BitmapImage>();
            foreach (string imagePath in imagePaths)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new System.Uri(imagePath);
                image.EndInit();
                Images.Add(image);
            }
        }

        public BitmapImage Image1 => Images[0];
        public BitmapImage Image2 => Images[1];
        public BitmapImage Image3 => Images[2];
        public BitmapImage Image4 => Images[3];
        public BitmapImage Image5 => Images[4];
        public BitmapImage Image6 => Images[5];
        public BitmapImage Image7 => Images[6];
        public BitmapImage Image8 => Images[7];
        public BitmapImage Image9 => Images[8];
    }
}
