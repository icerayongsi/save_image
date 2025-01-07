using System;
using System.Net;
using System.Net.Sockets;

namespace Save_image
{
    internal class PLCConnection
    {
        private string ipAddress;
        private int port;
        private TcpClient client;
        private NetworkStream stream;
        private bool isConnected;

        public PLCConnection(string ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
            this.isConnected = false; // ตั้งค่าเริ่มต้นเป็นไม่เชื่อมต่อ
        }

        public bool Connect()
        {
            try
            {
                // เชื่อมต่อไปยัง PLC โดยใช้ IP Address และ Port
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();
                isConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                // จัดการข้อผิดพลาดการเชื่อมต่อ
                Console.WriteLine("เกิดข้อผิดพลาดในการเชื่อมต่อ PLC: " + ex.Message);
                return false;
            }
        }
        public bool IsConnected
        {
            get { return isConnected; }
        }

        public void Disconnect()
        {
            try
            {
                // ปิดการเชื่อมต่อกับ PLC
                stream.Close();
                client.Close();
                isConnected = false;
            }
            catch (Exception ex)
            {
                // จัดการข้อผิดพลาดในการปิดการเชื่อมต่อ
                Console.WriteLine("เกิดข้อผิดพลาดในการปิดการเชื่อมต่อกับ PLC: " + ex.Message);
            }
        }

        public void SendData(byte[] data)
        {
            try
            {
                // ส่งข้อมูลไปยัง PLC
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                // จัดการข้อผิดพลาดในการส่งข้อมูล
                Console.WriteLine("เกิดข้อผิดพลาดในการส่งข้อมูลไปยัง PLC: " + ex.Message);
            }
        }

        public byte[] ReceiveData(int length)
        {
            byte[] buffer = new byte[length];
            try
            {
                // รับข้อมูลจาก PLC
                int bytesRead = stream.Read(buffer, 0, length);
                byte[] receivedData = new byte[bytesRead];
                Array.Copy(buffer, receivedData, bytesRead);
                return receivedData;
            }
            catch (Exception ex)
            {
                // จัดการข้อผิดพลาดในการรับข้อมูล
                Console.WriteLine("เกิดข้อผิดพลาดในการรับข้อมูลจาก PLC: " + ex.Message);
                return null;
            }
        }
    }
}
