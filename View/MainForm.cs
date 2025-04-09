using BeFitAdmin.tools;
using Firebase.Database;
using Svg.FilterEffects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFitAdmin
{
    public partial class MainForm : Form
    {
        private Point PANEL_LOCATION = new Point(207, 110);
        private ActivityControl activityControl;
        private PostsControl postsControl;
        public MainForm()
        {
            InitializeComponent();

            activityControl = new ActivityControl();
            postsControl = new PostsControl();
            activityControl.Location = postsControl.Location = PANEL_LOCATION;
            activityControl.Visible = postsControl.Visible = false;

            this.Controls.Add(postsControl);
            this.Controls.Add(activityControl);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            postsControl.Visible = true;
            activityControl.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(39, 37, 132); 
            Color endColor = Color.FromArgb(94, 112, 219); 

            using (LinearGradientBrush brush = new LinearGradientBrush(panel2.ClientRectangle, startColor, endColor, 0f))
            {
                e.Graphics.FillRectangle(brush, panel2.ClientRectangle);
            }
        }


        private void label6_Click_1(object sender, EventArgs e)
        {
            postsControl.Visible = false;
            activityControl.Visible = true;
        }
    }
}
