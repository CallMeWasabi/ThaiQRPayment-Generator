using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace AutoGeneratePromptPay
{
    public partial class PaymentForm : Form
    {
        private int m = 1, s = 00;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            label3.Visible = true;
            double amount = Form1.Instance.public_checkBox_rcManage.Checked ? 0 : Convert.ToDouble(Form1.Instance.public_textBox_amount.Text);
            label_time.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            timer1.Enabled = true;
            timer1.Interval = 1000;
            label_receive.Text = Form1.Instance.public_textBox_phoneNumber.Text;
            if (amount != 0)
            {
                label_amount.Text = Convert.ToDouble(Form1.Instance.public_textBox_amount.Text).ToString("F2", CultureInfo.InvariantCulture);
            } else
            {
                label_amount.Text = "Sender set amount";
                label3.Visible = false;
            }
            
            QrCodePromptPay packet = new QrCodePromptPay(Form1.Instance.public_textBox_phoneNumber.Text,
                                                         amount,
                                                         Form1.Instance.public_chekcBox_isStatic.Checked);
            packet.initPacket();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(packet.Packet, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBox_qrcode.Image = qrCode.GetGraphic(5);


            packet = null;
            qrGenerator.Dispose();
            qrCodeData.Dispose();
            qrCode.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            Form1.Instance.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == -1 && m == 0)
            {
                this.Close();
            } else if (s==-1&&m!=0)
            {
                m--;
                s = 59;
            }
            label_time.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
    }
}
