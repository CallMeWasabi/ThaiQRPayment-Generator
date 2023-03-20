using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratePromptPay
{
    internal class QrCodePromptPay
    {
        public string Packet { get; set; }
        public string dynamic { get; set; }
        public string Seed { get; set; }
        public string PhoneNumber { get; set; }
        public double amount { get; set; }
        public QrCodePromptPay(string phoneNumber, double value, bool isStatic=true)
        {
            if (isStatic)
            {
                this.dynamic = "11";
            } else
            {
                this.dynamic = "12";
            }

            if (phoneNumber.Length==10)
            {
                this.PhoneNumber = phoneNumber.Substring(1, 9);
            } else
            {
                this.PhoneNumber = phoneNumber;
            }
            this.amount = value;
            this.Seed = String.Format("0002010102{0}29370016A00000067701011101130066{1}5802TH5303764540{2}{3}006304",
                                        this.dynamic,
                                        this.PhoneNumber,
                                        Convert.ToString(Convert.ToInt32(this.amount)).Length+3,
                                        this.amount.ToString("F2", CultureInfo.InvariantCulture)
                                        );
        }
        public void initPacket()
        {
            this.Packet = this.Seed;
            this.Packet = this.Packet + Crc16_ccitt_f(this.Seed);
        }
        public string Crc16_ccitt_f(string seed)
        {
            const ushort polynomial = 0x1021;
            ushort crc = 0xFFFF;

            byte[] bytes = Encoding.ASCII.GetBytes(seed);
            foreach (byte b in bytes)
            {
                crc ^= (ushort)(b << 8);
                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x8000) != 0)
                    {
                        crc = (ushort)((crc << 1) ^ polynomial);
                    }
                    else
                    {
                        crc <<= 1;
                    }
                }
            }

            return crc.ToString("X");
        }
    }
}
