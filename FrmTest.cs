using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace BeepTest
{
    public unsafe partial class FrmTest : Form
    {

        private bool Busy = false;

[DllImport("AdaptHistEqualize.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true)]
private static extern void AdaptHistEqualize(byte *Scan0, int Width, int Height, int Stride,int TileX , int TileY , double CutLimit, bool SeparateChannel);

        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = true)]
        private static extern void CopyMemory(byte* Dest, byte* src, int Length);

        public FrmTest()
        {
            InitializeComponent();
        }

        private void ShowAdaptHistEqualizeResult()
        {
            Busy = true;
            Bitmap SrcB = (Bitmap)PicSrc.Image;
            Bitmap DstB = (Bitmap)PicDest.Image;
            BitmapData SrcBmpData = SrcB.LockBits(new Rectangle(0, 0, SrcB.Width, SrcB.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData DstBmpData = DstB.LockBits(new Rectangle(0, 0, DstB.Width, DstB.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            CopyMemory((byte*)DstBmpData.Scan0, (byte*)SrcBmpData.Scan0, SrcBmpData.Stride * SrcBmpData.Height);
            Stopwatch Sw = new Stopwatch();
            Sw.Start();

            AdaptHistEqualize((byte*)DstBmpData.Scan0, SrcBmpData.Width, SrcBmpData.Height, SrcBmpData.Stride, TileX.Value, TileY.Value, ClipLimit.Value * 0.001f, SepChannel.Checked);
         
            Sw.Stop();
            this.Text = Sw.ElapsedMilliseconds.ToString();
            SrcB.UnlockBits(SrcBmpData);
            DstB.UnlockBits(DstBmpData);
            PicDest.Invalidate();
            Application.DoEvents();
            Busy = false;
        }

       
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicSrc.Image.Dispose();
                PicDest.Image.Dispose();
                PicSrc.Image = Bitmap.FromFile(openFileDialog.FileName);
                PicDest.Image = Bitmap.FromFile(openFileDialog.FileName);
                ShowAdaptHistEqualizeResult();
            }
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            ShowAdaptHistEqualizeResult();
        }

        private void TileX_Scroll(object sender, ScrollEventArgs e)
        {
            LblTileX.Text = TileX.Value.ToString();
            if (Busy == false) ShowAdaptHistEqualizeResult();
        }

        private void TileY_Scroll(object sender, ScrollEventArgs e)
        {
            LblTileY.Text = TileY.Value.ToString();
            if (Busy == false) ShowAdaptHistEqualizeResult();
        }

        private void ClipLimit_Scroll(object sender, ScrollEventArgs e)
        {
            LblClipLimit.Text = (ClipLimit.Value * 0.001).ToString();
            if (Busy == false) ShowAdaptHistEqualizeResult();
        }

        private void SepChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (Busy == false) ShowAdaptHistEqualizeResult();
        }


      
    }
}
