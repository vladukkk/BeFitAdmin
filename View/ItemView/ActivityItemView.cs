using BeFitAdmin.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFitAdmin
{
    public partial class ActivityItemView : UserControl
    {
        public ActivityItem ActivityItem { get; private set; }
        public EventHandler ItemClicked;
        public EventHandler ItemDelClick;

        public ActivityItemView(ActivityItem activityItem)
        {
            InitializeComponent();
            ActivityItem = activityItem;
        }

        private async void ActivityItemView_Load(object sender, EventArgs e)
        {
            labelTitle.Text = ActivityItem.Name;
            string Descriprion = ActivityItem.Description.Length > 100 ? ActivityItem.Description.Substring(0, 100) + "..." : ActivityItem.Description;
            textBoxDesc.Text = Descriprion;

            var image = await ImageManager.getImageFromUrl(ActivityItem.ImageUrl);

            if (image != null)
            {
                pictureBox1.Image = image.GetThumbnailImage(image.Width, image.Height, null, IntPtr.Zero);
            }

        }

        private void textBoxDesc_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemDelClick?.Invoke(this, e);
        }
    }
}
