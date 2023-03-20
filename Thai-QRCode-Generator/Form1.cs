using System;
using System.Windows.Forms;

namespace AutoGeneratePromptPay
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public TextBox public_textBox_phoneNumber;
        public TextBox public_textBox_amount;
        public CheckBox public_chekcBox_isStatic;
        public CheckBox public_checkBox_rcManage;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            public_textBox_phoneNumber = textBox_phoneNumber;
            public_textBox_amount = textBox_amount;
            public_chekcBox_isStatic = checkbox_isStatic;
            public_checkBox_rcManage = checkBox_rcManage;
        }
        private void callPaymentForm()
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            this.Enabled = false;
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            bool run = true;
            if (textBox_phoneNumber.Text.Length == 10 && textBox_phoneNumber.Text[0]=='0')
            {
                if (!checkBox_rcManage.Checked)
                {
                    if (textBox_amount.Text.Trim().Length==0)
                    {
                        textBox_amount.Text = String.Empty;
                        textBox_amount.Focus();
                        run = false;
                        MessageBox.Show("Error request amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (Convert.ToDouble(textBox_amount.Text) < 0)
                    {
                        run = false;
                        MessageBox.Show("Error value must more than or equal to zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        foreach (char c in textBox_amount.Text)
                        {
                            if (!Char.IsDigit(c) && c != '.')
                            {
                                MessageBox.Show("Error symbol in amount please check ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                run = false;
                                break;
                            }
                        }
                    }
                    if (run)
                    {
                        callPaymentForm();
                    }
                }
                else
                {
                    callPaymentForm();
                }
            } else {
                MessageBox.Show("Error phone number must have 10 number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void checkBox_rcManage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rcManage.Checked == true)
            {
                textBox_amount.Text = "Sender set amount";
                textBox_amount.Enabled = false;
            } else
            {
                textBox_amount.Text = string.Empty;
                textBox_amount.Enabled = true;
            }
        }
    }
}
