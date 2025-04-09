using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeFitAdmin.tools
{
    public class ImageManager
    {
        public static async Task<Image> getImageFromUrl(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var stream = await client.GetStreamAsync(imageUrl);
                return Image.FromStream(stream);
            }
        }
    }
}
