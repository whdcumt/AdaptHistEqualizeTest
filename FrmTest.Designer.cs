namespace BeepTest
{
    partial class FrmTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.CmdOpen = new System.Windows.Forms.Button();
            this.LblClipLimit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClipLimit = new System.Windows.Forms.HScrollBar();
            this.LblTileY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TileY = new System.Windows.Forms.HScrollBar();
            this.LblTileX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TileX = new System.Windows.Forms.HScrollBar();
            this.SepChannel = new System.Windows.Forms.CheckBox();
            this.PicDest = new System.Windows.Forms.PictureBox();
            this.PicSrc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(10, 10);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(70, 29);
            this.CmdOpen.TabIndex = 57;
            this.CmdOpen.Text = "打开图像";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // LblClipLimit
            // 
            this.LblClipLimit.AutoSize = true;
            this.LblClipLimit.Location = new System.Drawing.Point(1069, 19);
            this.LblClipLimit.Name = "LblClipLimit";
            this.LblClipLimit.Size = new System.Drawing.Size(29, 12);
            this.LblClipLimit.TabIndex = 80;
            this.LblClipLimit.Text = "0.01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(760, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 79;
            this.label5.Text = "裁剪限幅";
            // 
            // ClipLimit
            // 
            this.ClipLimit.LargeChange = 1;
            this.ClipLimit.Location = new System.Drawing.Point(816, 19);
            this.ClipLimit.Maximum = 1000;
            this.ClipLimit.Minimum = 10;
            this.ClipLimit.Name = "ClipLimit";
            this.ClipLimit.Size = new System.Drawing.Size(250, 17);
            this.ClipLimit.TabIndex = 78;
            this.ClipLimit.Value = 10;
            this.ClipLimit.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ClipLimit_Scroll);
            // 
            // LblTileY
            // 
            this.LblTileY.AutoSize = true;
            this.LblTileY.Location = new System.Drawing.Point(734, 19);
            this.LblTileY.Name = "LblTileY";
            this.LblTileY.Size = new System.Drawing.Size(23, 12);
            this.LblTileY.TabIndex = 77;
            this.LblTileY.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 76;
            this.label3.Text = "垂直网格";
            // 
            // TileY
            // 
            this.TileY.LargeChange = 1;
            this.TileY.Location = new System.Drawing.Point(480, 19);
            this.TileY.Minimum = 1;
            this.TileY.Name = "TileY";
            this.TileY.Size = new System.Drawing.Size(250, 17);
            this.TileY.TabIndex = 75;
            this.TileY.Value = 10;
            this.TileY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TileY_Scroll);
            // 
            // LblTileX
            // 
            this.LblTileX.AutoSize = true;
            this.LblTileX.Location = new System.Drawing.Point(401, 19);
            this.LblTileX.Name = "LblTileX";
            this.LblTileX.Size = new System.Drawing.Size(17, 12);
            this.LblTileX.TabIndex = 74;
            this.LblTileX.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 73;
            this.label1.Text = "水平网格";
            // 
            // TileX
            // 
            this.TileX.LargeChange = 1;
            this.TileX.Location = new System.Drawing.Point(137, 19);
            this.TileX.Minimum = 1;
            this.TileX.Name = "TileX";
            this.TileX.Size = new System.Drawing.Size(250, 17);
            this.TileX.TabIndex = 72;
            this.TileX.Value = 15;
            this.TileX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TileX_Scroll);
            // 
            // SepChannel
            // 
            this.SepChannel.AutoSize = true;
            this.SepChannel.Location = new System.Drawing.Point(1114, 18);
            this.SepChannel.Name = "SepChannel";
            this.SepChannel.Size = new System.Drawing.Size(72, 16);
            this.SepChannel.TabIndex = 81;
            this.SepChannel.Text = "通道分离";
            this.SepChannel.UseVisualStyleBackColor = true;
            this.SepChannel.CheckedChanged += new System.EventHandler(this.SepChannel_CheckedChanged);
            // 
            // PicDest
            // 
            this.PicDest.Image = global::AdaptHistEqualizeTest.Properties.Resources._21;
            this.PicDest.Location = new System.Drawing.Point(600, 55);
            this.PicDest.Name = "PicDest";
            this.PicDest.Size = new System.Drawing.Size(575, 550);
            this.PicDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDest.TabIndex = 65;
            this.PicDest.TabStop = false;
            // 
            // PicSrc
            // 
            this.PicSrc.Image = global::AdaptHistEqualizeTest.Properties.Resources._21;
            this.PicSrc.Location = new System.Drawing.Point(12, 55);
            this.PicSrc.Name = "PicSrc";
            this.PicSrc.Size = new System.Drawing.Size(575, 550);
            this.PicSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSrc.TabIndex = 64;
            this.PicSrc.TabStop = false;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 618);
            this.Controls.Add(this.SepChannel);
            this.Controls.Add(this.LblClipLimit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClipLimit);
            this.Controls.Add(this.LblTileY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TileY);
            this.Controls.Add(this.LblTileX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TileX);
            this.Controls.Add(this.PicDest);
            this.Controls.Add(this.PicSrc);
            this.Controls.Add(this.CmdOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自适应直方图增强测试";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicDest;
        private System.Windows.Forms.PictureBox PicSrc;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.Label LblClipLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar ClipLimit;
        private System.Windows.Forms.Label LblTileY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar TileY;
        private System.Windows.Forms.Label LblTileX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar TileX;
        private System.Windows.Forms.CheckBox SepChannel;
    }
}

