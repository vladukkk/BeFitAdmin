namespace BeFitAdmin
{
    partial class PostsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxDescRes = new System.Windows.Forms.TextBox();
            this.labelTitleRes = new System.Windows.Forms.Label();
            this.pictureBoxRes = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRes)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(92, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBoxRes);
            this.panel5.Location = new System.Drawing.Point(817, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 543);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.textBoxDescRes);
            this.panel6.Controls.Add(this.labelTitleRes);
            this.panel6.Location = new System.Drawing.Point(19, 131);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 396);
            this.panel6.TabIndex = 3;
            // 
            // textBoxDescRes
            // 
            this.textBoxDescRes.BackColor = System.Drawing.Color.White;
            this.textBoxDescRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescRes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescRes.Location = new System.Drawing.Point(4, 56);
            this.textBoxDescRes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescRes.Multiline = true;
            this.textBoxDescRes.Name = "textBoxDescRes";
            this.textBoxDescRes.ReadOnly = true;
            this.textBoxDescRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescRes.Size = new System.Drawing.Size(237, 349);
            this.textBoxDescRes.TabIndex = 11;
            // 
            // labelTitleRes
            // 
            this.labelTitleRes.AutoSize = true;
            this.labelTitleRes.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleRes.Location = new System.Drawing.Point(14, 6);
            this.labelTitleRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleRes.Name = "labelTitleRes";
            this.labelTitleRes.Size = new System.Drawing.Size(0, 30);
            this.labelTitleRes.TabIndex = 11;
            // 
            // pictureBoxRes
            // 
            this.pictureBoxRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxRes.Location = new System.Drawing.Point(19, 15);
            this.pictureBoxRes.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRes.Name = "pictureBoxRes";
            this.pictureBoxRes.Size = new System.Drawing.Size(241, 152);
            this.pictureBoxRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRes.TabIndex = 2;
            this.pictureBoxRes.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(756, 428);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(227)))));
            this.buttonAddPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPost.ForeColor = System.Drawing.Color.White;
            this.buttonAddPost.Location = new System.Drawing.Point(14, 508);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(243, 41);
            this.buttonAddPost.TabIndex = 7;
            this.buttonAddPost.Text = "add new";
            this.buttonAddPost.UseVisualStyleBackColor = false;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Posts";
            // 
            // PostsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonAddPost);
            this.Controls.Add(this.label7);
            this.Name = "PostsControl";
            this.Size = new System.Drawing.Size(1111, 568);
            this.Load += new System.EventHandler(this.PostsControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PostsControl_Paint);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxDescRes;
        private System.Windows.Forms.Label labelTitleRes;
        private System.Windows.Forms.PictureBox pictureBoxRes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.Label label7;
    }
}
