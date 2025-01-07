using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVSDK_Net;

namespace Save_image
{
    public partial class FormMonitor : Form
    {
        private int count_clear = 0;
        private bool hold_photo = false;
        private bool save_photo = false;
        private static MyCamera cam = new MyCamera();
        private static string m_bitMapSavePath = Environment.CurrentDirectory + @"\BitMaps";
        private PLCConnection plcCommRX;
        private PLCConnection plcCommTX;
        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", CharSet = CharSet.Ansi)]
        internal static extern void CopyMemory(IntPtr pDst, IntPtr pSrc, int len);

        public FormMonitor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormMonitor_Load(object sender, EventArgs e)
        {
            plcCommRX = new PLCConnection("192.168.1.160", 11000);
            //plcCommTX = new PLCConnection("192.168.1.10", 12001);
            bool plcconnectRX = plcCommRX.Connect();
            //bool plcconnectTX = plcCommTX.Connect();
        }

   
        private bool SaveToBitmap(Bitmap bitmap)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Bitmap is null");
                return false;
            }

            if (!Directory.Exists(m_bitMapSavePath))
            {
                Directory.CreateDirectory(m_bitMapSavePath);
            }

            try
            {
                string imagePath = Path.Combine(m_bitMapSavePath, $"{Guid.NewGuid()}.bmp"); // Generate unique file name
                bitmap.Save(imagePath, ImageFormat.Bmp); // Save bitmap as BMP file
                //MessageBox.Show($"Save bitmap Successfully! Save path is [{imagePath}]");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save bitmap: {ex.Message}");
                return false;
            }
        }

        private static bool ConvertToBitmap(ref IMVDefine.IMV_Frame frame, ref Bitmap bitmap)
        {
            IntPtr pDstRGB;
            BitmapData bmpData;
            Rectangle bitmapRect = new Rectangle();

            var ImgSize = (int)frame.frameInfo.width * (int)frame.frameInfo.height * 3;

            try
            {
                pDstRGB = Marshal.AllocHGlobal(ImgSize);
            }
            catch
            {
                return false;
            }
            if (pDstRGB == IntPtr.Zero)
            {
                return false;
            }

            IMVDefine.IMV_PixelConvertParam stPixelConvertParam = new IMVDefine.IMV_PixelConvertParam();
            int res = IMVDefine.IMV_OK;
            stPixelConvertParam.nWidth = frame.frameInfo.width;
            stPixelConvertParam.nHeight = frame.frameInfo.height;
            stPixelConvertParam.ePixelFormat = frame.frameInfo.pixelFormat;
            stPixelConvertParam.pSrcData = frame.pData;
            stPixelConvertParam.nSrcDataLen = frame.frameInfo.size;
            stPixelConvertParam.nPaddingX = frame.frameInfo.paddingX;
            stPixelConvertParam.nPaddingY = frame.frameInfo.paddingY;
            stPixelConvertParam.eBayerDemosaic = IMVDefine.IMV_EBayerDemosaic.demosaicNearestNeighbor;
            stPixelConvertParam.eDstPixelFormat = IMVDefine.IMV_EPixelType.gvspPixelBGR8;
            stPixelConvertParam.pDstBuf = pDstRGB;
            stPixelConvertParam.nDstBufSize = (uint)ImgSize;

            res = cam.IMV_PixelConvert(ref stPixelConvertParam);
            if (res != IMVDefine.IMV_OK)
            {
                MessageBox.Show("Image convert to BGR failed!");
                return false;
            }

            bitmap = new Bitmap((int)frame.frameInfo.width, (int)frame.frameInfo.height, PixelFormat.Format24bppRgb);

            bitmapRect.Height = bitmap.Height;
            bitmapRect.Width = bitmap.Width;
            bmpData = bitmap.LockBits(bitmapRect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
            CopyMemory(bmpData.Scan0, pDstRGB, bmpData.Stride * bitmap.Height);
            bitmap.UnlockBits(bmpData);

            Marshal.FreeHGlobal(pDstRGB);

            return true;
        }

        private Bitmap ConvertFrameToBitmap(ref IMVDefine.IMV_Frame frame)
        {
            Bitmap bitmap = null;
            if (!ConvertToBitmap(ref frame, ref bitmap))
            {
                return null;
            }
            return bitmap;
        }
        private Bitmap GetBitmapFromPictureBox(PictureBox pictureBox)
        {
            Bitmap bitmap = null;
            if (pictureBox.BackgroundImage != null)
            {
                bitmap = new Bitmap(pictureBox.BackgroundImage);
            }
            return bitmap;
        }
        private void CaptureAndDisplayImage()
        {
            int res = IMVDefine.IMV_OK;
            IMVDefine.IMV_DeviceList deviceList = new IMVDefine.IMV_DeviceList();
            IMVDefine.IMV_EInterfaceType interfaceTp = IMVDefine.IMV_EInterfaceType.interfaceTypeAll;
            res = MyCamera.IMV_EnumDevices(ref deviceList, (uint)interfaceTp);
            ledCamerastatus.BackColor = Color.Lime;
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Enumeration devices failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Enumeration devices failed! ErrorCode: [{res}]";
                ledCamerastatus.BackColor = Color.Red;
                return;
            }
            if (deviceList.nDevNum < 1)
            {
                //MessageBox.Show("No device found.");
                txtmessage.Text = "No device found.";
                ledCamerastatus.BackColor = Color.Red;
                return;
            }

            int nCamIndex = 0; // assuming the first camera in the list
            res = cam.IMV_CreateHandle(IMVDefine.IMV_ECreateHandleMode.modeByIndex, nCamIndex);
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Create devHandle failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Create devHandle failed! ErrorCode: [{res}]";
                ledCamerastatus.BackColor = Color.Red;
                return;
            }

            res = cam.IMV_Open();
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Open camera failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Open camera failed! ErrorCode: [{res}]";
                ledCamerastatus.BackColor = Color.Red;
                return;
            }

            res = cam.IMV_StartGrabbing();
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Start grabbing failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Start grabbing failed! ErrorCode: [{res}]";
                ledCamerastatus.BackColor = Color.Red;
                return;
            }

            IMVDefine.IMV_Frame frame = new IMVDefine.IMV_Frame();
            res = cam.IMV_GetFrame(ref frame, 1000);
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Get frame failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Get frame failed! ErrorCode: [{res}]";
                ledCamerastatus.BackColor = Color.Red;
                return;
            }

            Bitmap bitmap = ConvertFrameToBitmap(ref frame);
            if (bitmap != null)
            {
                pictureBoxSec.BackgroundImage = bitmap; // แสดงภาพใน PictureBox
            }
            cam.IMV_ReleaseFrame(ref frame);
            cam.IMV_StopGrabbing();
            cam.IMV_Close();
            cam.IMV_DestroyHandle();
        }
        private void CaptureAndSaveImage()
        {
            string date_time = DateTime.Now.ToString("dd/MM/yy  HH:mm:ss", new System.Globalization.CultureInfo("en-US"));
            txtdatetime.Text = date_time;
            Bitmap bitmapSec = GetBitmapFromPictureBox(pictureBoxSec);         
            if (bitmapSec != null)
            {            
                pictureBoxCapture.BackgroundImage = bitmapSec; // Display the image from pictureBoxSec in pictureBox1
                Thread.Sleep(200);
               
                if (!SaveToBitmap(bitmapSec))
                {
                    //MessageBox.Show("Save Bitmap failed");
                    txtmessage.Text = "Save Bitmap failed";
                }
                save_photo = true;
            }

        }
        private void btnOnCamera_Click(object sender, EventArgs e)
        {
            int res = IMVDefine.IMV_OK;
            IMVDefine.IMV_DeviceList deviceList = new IMVDefine.IMV_DeviceList();
            IMVDefine.IMV_EInterfaceType interfaceTp = IMVDefine.IMV_EInterfaceType.interfaceTypeAll;
            res = MyCamera.IMV_EnumDevices(ref deviceList, (uint)interfaceTp);
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Enumeration devices failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Enumeration devices failed! ErrorCode: [{res}]";
                return;
            }
            if (deviceList.nDevNum < 1)
            {
                //MessageBox.Show("No device found.");
                txtmessage.Text = "No device found.";
                return;
            }

            int nCamIndex = 0; // assuming the first camera in the list
            res = cam.IMV_CreateHandle(IMVDefine.IMV_ECreateHandleMode.modeByIndex, nCamIndex);
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Create devHandle failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Create devHandle failed! ErrorCode: [{res}]";
                return;
            }

            res = cam.IMV_Open();
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Open camera failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Open camera failed! ErrorCode: [{res}]";
                return;
            }

            res = cam.IMV_StartGrabbing();
            if (res != IMVDefine.IMV_OK)
            {
                //MessageBox.Show($"Start grabbing failed! ErrorCode: [{res}]");
                txtmessage.Text = $"Start grabbing failed! ErrorCode: [{res}]";
                return;
            }

            timerSec.Start(); // เริ่มจับเวลาเพื่อจับภาพทุกๆ 1 วินาที
        }
        private void btnTakePhotoManual_Click(object sender, EventArgs e)
        {                     
            CaptureAndSaveImage();            
        }
        private void timerSec_Tick(object sender, EventArgs e)
        {

            CaptureAndDisplayImage();            
            if (save_photo == true)
            {
                count_clear += 1;
            }
            if(count_clear >=5)
            {
                pictureBoxCapture.BackgroundImage = Save_image.Properties.Resources.noImage;
                count_clear = 0;
                save_photo = false;
            }
        }

        private void btnCloseCamera_Click(object sender, EventArgs e)
        {
            ledCamerastatus.BackColor = Color.LightGray;
            pictureBoxSec.BackgroundImage = Save_image.Properties.Resources.noImage;
            timerSec.Stop();
        }

        private void timerPLC_Tick(object sender, EventArgs e)
        {
            if (plcCommRX.IsConnected)
            {
                int No_memory = 500; //
                int No_head_dev = 0; // start memory
                int dataLength = (No_memory * 2) + 11; // ระบุความยาวของข้อมูลที่คุณต้องการรับ
                byte B_No_head_dev1 = (byte)(No_head_dev & 0xFF);
                byte B_No_head_dev2 = (byte)((No_head_dev >> 8) & 0xFF);
                byte B_No_head_dev3 = (byte)((No_head_dev >> 16) & 0xFF);
                byte B_No_memory1 = (byte)(No_memory & 0xFF);
                byte B_No_memory2 = (byte)((No_memory >> 8) & 0xFF);

                byte[] packet = { 0x50, 0x00, 0x00, 0xFF, 0xFF, 0x03, 0x00, 0x0C, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x00, B_No_head_dev1, B_No_head_dev2, B_No_head_dev3, 0xA8, B_No_memory1, B_No_memory2 }; // start: D4400  end: D4899// No. = 500 

                plcCommRX.SendData(packet);
                try
                {

                    byte[] responseData = plcCommRX.ReceiveData(dataLength).ToArray();
                    byte[] returnData = responseData.Skip(11).ToArray();
                    byte[] returnStatus = responseData.Take(11).ToArray();
                    if (responseData.Length != 0)
                    {
                        int plc_status = ToWord(new byte[] { returnData[0], returnData[1] }); //
                        int take_photo = ToWord(new byte[] { returnData[2], returnData[3] }); //
                        string c1 = ToHex2String(ToWord(new byte[] { returnData[20], returnData[21] }));
                        string c2 = ToHex2String(ToWord(new byte[] { returnData[22], returnData[23] }));
                        string c3 = ToHex2String(ToWord(new byte[] { returnData[24], returnData[25] }));
                        string c4 = ToHex2String(ToWord(new byte[] { returnData[26], returnData[27] }));
                        string c5 = ToHex2String(ToWord(new byte[] { returnData[28], returnData[29] }));
                        string c6 = ToHex2String(ToWord(new byte[] { returnData[30], returnData[31] }));
                        string c7 = ToHex2String(ToWord(new byte[] { returnData[32], returnData[33] }));
                        string c8 = ToHex2String(ToWord(new byte[] { returnData[34], returnData[35] }));
                        string c9 = ToHex2String(ToWord(new byte[] { returnData[36], returnData[37] }));
                        string c10 = ToHex2String(ToWord(new byte[] { returnData[38], returnData[39] }));
                        string c_all = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10;  
                        txtatno.Text = c_all.ToString();
                        if (take_photo == 1 && hold_photo == false)
                        {
                            led_takephoto.BackColor = Color.Blue;
                            CaptureAndDisplayImage();
                            CaptureAndSaveImage();
                            
                            hold_photo = true;
                        }
                        if (take_photo == 0 && hold_photo == true)
                        {
                            led_takephoto.BackColor = Color.DimGray;
                            hold_photo = false;
                        }
                        if (save_photo == true)
                        {
                            count_clear += 1;
                        }
                        if (count_clear >= 300)
                        {
                            pictureBoxCapture.BackgroundImage = Save_image.Properties.Resources.noImage;
                            count_clear = 0;
                            save_photo = false;
                        }
                        if (plc_status == 1)
                        {
                            led_plc_connect.BackColor = Color.Lime;
                        }
                        else
                        {
                            led_plc_connect.BackColor = Color.DimGray;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private float ToFloat(byte[] input)
        {
            byte[] newArray = new[] { input[2], input[3], input[0], input[1] }; // 2 wordn 0.000000
            return BitConverter.ToSingle(newArray, 0);
        }

        private int ToWord(byte[] input)
        {
            byte[] newArray = new[] { input[0], input[1] }; // 1 word -32,768 ถึง 32,767
            return BitConverter.ToInt16(newArray, 0);
        }

        private int ToWord32(byte[] input)
        {
            byte[] newArray = new[] { input[0], input[1], input[2], input[3] }; // 2 word -2,147,483,648 ถึง 2,147,483,647. 
            return BitConverter.ToInt32(newArray, 0);
        }
        private string ToHex2String(int value)
        {
            // Get the bytes from the integer
            byte[] bytes = BitConverter.GetBytes((ushort)value);

            // Check if the system's endianness is different from what you expect
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            // Convert each byte to its ASCII representation and join them
            return string.Join("", bytes.Select(b => ((char)b).ToString()));
        }

    }
}
