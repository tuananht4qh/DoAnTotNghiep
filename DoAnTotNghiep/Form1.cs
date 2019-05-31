using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
namespace DoAnTotNghiep
{
    public partial class Form1 : Form
    {
        Bitmap image1;
        public Form1()
        {
            InitializeComponent();
        }


        public void button2_Click(object sender, EventArgs e)
        {
            Bitmap b = (Bitmap)anhxam.Image.Clone();
            b = ContrastStretch(b);
            //b = Normalization(b);
            anhxuly.Image = b;
            //Tính histogram
            double[] histogram = TinhHistogram(b);
            //Chuyển đổi kiểu dữ liệu
            PointPairList points = ChuyenDoiHistogram(histogram);
            //Vẽ biểu đồ histogram và cho hiển thị
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image1 = new Bitmap(open.FileName);
                anhgoc.Image = image1;
            }
        }

       /* public void Button3_Click(object sender, EventArgs e)
        {
           

        }

        protected void Lb2_Click(object sender, EventArgs e)
        {
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }*/
        private void MausangXam_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int t = (int)(p.R * 0.299 + p.G * 0.587 + p.B * 0.114);
                    bmp.SetPixel(x, y, Color.FromArgb(t, t, t));

                }
            }
            anhxam.Image = bmp;
            //Tính histogram
            double[] histogram = TinhHistogram(bmp);
            //Chuyển đổi kiểu dữ liệu
            PointPairList points = ChuyenDoiHistogram(histogram);
            //Vẽ biểu đồ histogram và cho hiển thị
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();
        }
        public void Gray_Click(object sender, EventArgs e)
        {
            Bitmap kq = (Bitmap)anhxam.Image.Clone();
            for (int y = 0; y < kq.Height; y++)
            {
                for (int x = 0; x < kq.Width; x++)
                {
                    Color q = kq.GetPixel(x, y);
                    kq.SetPixel(x, y, Color.FromArgb(255 - q.R, 255 - q.G, 255 - q.B));

                }
            }
            anhamban.Image = kq;
            //Tính histogram
            double[] histogram = TinhHistogram(kq);           
            //Chuyển đổi kiểu dữ liệu
            PointPairList points = ChuyenDoiHistogram(histogram);
            //Vẽ biểu đồ histogram và cho hiển thị
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();

        }
        //Tính histogram của hình mức xám
        double[] TinhHistogram(Bitmap hinhmucxam)
        {
            double[] histogram = new double[256];
            for (int x = 0; x < hinhmucxam.Width; x++)
                for (int y = 0; y < hinhmucxam.Height; y++)
                {
                    Color color = hinhmucxam.GetPixel(x, y);
                    byte gray = color.R;
                    histogram[gray]++;
                }
            return histogram;
        }

        PointPairList ChuyenDoiHistogram(double[] histogram)
        {
            //PointPairList là kiểu dữ liệu của zedgraph để vẽ biểu đồ
            PointPairList point = new PointPairList();
            for (int i = 0; i < histogram.Length; i++)
            {
                //i tương ứng với trục nằm ngang, từ 0-255
                //histogram[i] tương ứng với trục đứng, là số pixel có cùng mức xám 
                point.Add(i, histogram[i]);
            }
            return point;
        }
        //Thiết lập biểu đồ trong zedGraph
        GraphPane BieuDoHistogram(PointPairList histogram)
        {
            //GraphPane là đối tượng biểu dồ trong ZedGraph
            GraphPane gp = new GraphPane();
            gp.Title.Text = @"Biểu đồ Histogram";//Tên của biểu đồ
            gp.Rect = new RectangleF(0, 0, 512, 536);//Khung chứa biểu đố

            //THiết lập trục ngang
            gp.XAxis.Title.Text = @"Giá trị mức xám của điểm ảnh";
            gp.XAxis.Scale.Min = 0; //nhỏ nhất là 0
            gp.XAxis.Scale.Max = 255; // lớn nhất là 255
            gp.XAxis.Scale.MajorStep = 5; //mỗi bước chính là 5
            gp.XAxis.Scale.MinorStep = 1;// Mỗi bước trong một bước chính là 1

            //Thiết lập trục đứng
            gp.YAxis.Title.Text = @"Số điểm ảnh có cùng mức xám";
            gp.YAxis.Scale.Min = 0; //nhỏ nhất là 0
            gp.YAxis.Scale.Max = 83886; // số này phải lớn hơn kich thước của ảnh
            gp.YAxis.Scale.MajorStep = 5; //mỗi bước chính là 5
            gp.YAxis.Scale.MinorStep = 1;// Mỗi bước trong một bước chính là 1

            //Dùng biểu đồ dạng bar để biểu diễn Histogram
            gp.AddBar("Histogram", histogram, Color.AliceBlue);
            return gp;
        }
        public static Bitmap ContrastStretch(Bitmap srcImage,double blackPointPercent = 0.03, double whitePointPercent = 0.02)
        /*Trong đó: -blackPointPercent là % pixel tối nhất chuyển sang màu đen
                    -whitePointPercent là % pixel sáng nhất chuyển sang màu trắng.
        */
        {
            //truy cập đến điểm ảnh:Truy cập từ con trỏ đầu tiên
            //lock bit cho hình ảnh nguồn của bạn vào bộ nhớ hệ thống
            Rectangle rect = new Rectangle(0, 0, srcImage.Width, srcImage.Height);
            BitmapData srcData = srcImage.LockBits(rect, ImageLockMode.ReadOnly,PixelFormat.Format32bppArgb);

            //Tạo một bitmap mà bạn sẽ viết dữ liệu pixel mới
            Bitmap destImage = new Bitmap(srcImage.Width, srcImage.Height);

            //Lock bits cho bitmap có thể ghi của bạn vào bộ nhớ hệ thống
            Rectangle rect2 = new Rectangle(0, 0, destImage.Width, destImage.Height);
            BitmapData destData = destImage.LockBits(rect2, ImageLockMode.WriteOnly,PixelFormat.Format32bppArgb);

            //Lấy chiều rộng của một hàng pixel trong bitmap
            int stride = srcData.Stride;

            //Quét các dòng đầu tiên trong bitmap
            IntPtr srcScan0 = srcData.Scan0;
            IntPtr destScan0 = destData.Scan0;

            var freq = new int[256];

            unsafe
            {
                //Tạo một mảng dữ liệu pixel từ hình ảnh nguồn
                byte* src = (byte*)srcScan0;

                //Lấy số lượng pixel cho mỗi giá trị cường độ
                for (int y = 0; y < srcImage.Height; ++y)
                {
                    for (int x = 0; x < srcImage.Width; ++x)
                    {
                        freq[src[y * stride + x * 4]]++;
                    }
                }

                //Lấy tổng số pixel trong ảnh
                int numPixels = srcImage.Width * srcImage.Height;

                //Đặt giá trị cường độ tối thiểu của hình ảnh (0 = đen)
                int minI = 0;

                //Lấy tổng số pixel màu đen
                var blackPixels = numPixels * blackPointPercent;

                //Đặt một biến để tổng hợp các pixel sẽ chuyển sang màu đen
                int accum = 0;

                //Tổng hợp các màu tối nhất cho đến khi bạn đạt được tổng số pixel đen
                while (minI < 255)
                {
                    accum += freq[minI];
                    if (accum > blackPixels) break;
                    minI++;
                }

                //Đặt cường độ tối đa của hình ảnh (255 = trắng)
                int maxI = 255;

                //Đặt tổng số pixel trắng
                var whitePixels = numPixels * whitePointPercent;

                //Đặt lại biến tổng trở về 0
                accum = 0;

                //Tổng hợp các pixel sáng nhất sẽ chuyển sang màu trắng
                while (maxI > 0)
                {
                    accum += freq[maxI];
                    if (accum > whitePixels) break;
                    maxI--;
                }

                //Một phần của phương trình chuẩn hóa không thay đổi theo từng pixel
                double spread = 255d / (maxI - minI);

                //Tạo một mảng dữ liệu pixel từ hình ảnh được tạo
                byte* dst = (byte*)destScan0;

                //Viết dữ liệu pixel mới vào hình ảnh
                for (int y = 0; y < srcImage.Height; ++y)
                {
                    for (int x = 0; x < srcImage.Width; ++x)
                    {
                        int i = y * stride + x * 4;

                        //Một phần của phương trình thay đổi theo từng pixel
                        double value = Math.Round((src[i] - minI) * spread);

                        byte val = (byte)(Math.Min(Math.Max(value, 0), 255));
                        dst[i] = val;
                        dst[i + 1] = val;
                        dst[i + 2] = val;
                        dst[i + 3] = 255;
                    }
                }
            }

            //Unlock bits from system memory
            srcImage.UnlockBits(srcData);
            destImage.UnlockBits(destData);

            return destImage;
        }
        public static Bitmap Normalization(Bitmap img)
        {
            int w = img.Width;
            int h = img.Height;

            BitmapData sd = img.LockBits(new Rectangle(0, 0, w, h),ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = sd.Stride * sd.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(sd.Scan0, buffer, 0, bytes);
            img.UnlockBits(sd);
            int current = 0;
            byte max = 0;
            byte min = 255;
            for (int i = 0; i < buffer.Length; i++)
            {
                max = Math.Max(max, buffer[i]);
                min = Math.Min(min, buffer[i]);
            }
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    current = y * sd.Stride + x * 4;
                    for (int i = 0; i < 3; i++)
                    {
                        result[current + i] = (byte)((buffer[current + i] - min) * 100 / (max - min));
                    }
                    result[current + 3] = 255;
                }
            }
            Bitmap resimg = new Bitmap(w, h);
            BitmapData rd = resimg.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, rd.Scan0, bytes);
            resimg.UnlockBits(rd);
            return resimg;
        }
    }
}
