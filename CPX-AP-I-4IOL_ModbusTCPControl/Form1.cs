using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus;

namespace CPX_AP_I_4IOL_ModbusTCPControl
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private static Modbus.Device.ModbusIpMaster m_Master;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btn_Connect_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                if (m_Master!=null)
                {
                    m_Master.Dispose();
                }               
            }
            catch
            {

            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(txt_IP.Text, 502);
            m_Master = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient);
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1,Convert.ToUInt16(0 + Convert.ToInt16(txt_AddressStart.Text)), 1);
            if (GetBitfromInt(smsStatus[0], 0))
            {
                lbl_i_In.Image = imageList_Status.Images[1];
            }
            else
            {
                lbl_i_In.Image = imageList_Status.Images[0];
            }
            if (GetBitfromInt(smsStatus[0], 1))
            {
                lbl_i_Out.Image = imageList_Status.Images[1];
            }
            else
            {
                lbl_i_Out.Image = imageList_Status.Images[0];
            }
            if (GetBitfromInt(smsStatus[0], 2))
            {
                lbl_i_Move.Image = imageList_Status.Images[1];
            }
            else
            {
                lbl_i_Move.Image = imageList_Status.Images[0];
            }
            if (GetBitfromInt(smsStatus[0], 3))
            {
                lbl_i_Device.Image = imageList_Status.Images[1];
            }
            else
            {
                lbl_i_Device.Image = imageList_Status.Images[0];
            }
            if (GetBitfromInt(smsStatus[0], 4))
            {
                lbl_i_Intermediate.Image = imageList_Status.Images[1];
            }
            else
            {
                lbl_i_Intermediate.Image = imageList_Status.Images[0];
            }
            //ushort[] ISDUstatus = m_Master.ReadHoldingRegisters(34000, 127);

        }
        public bool GetBitfromInt(int myInt, int bitNumber)
        {
            return (myInt & (1 << bitNumber)) != 0;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }       

        private void btn_In_MouseDown(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] | 1));
        }

        private void btn_In_MouseUp(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] & 65534));
        }

        private void btn_Out_MouseDown(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] | 2));
        }

        private void btn_Out_MouseUp(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] & 65536 - 1 - 2));
        }

        private void btn_Intermediate_MouseDown(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] | 16));
        }

        private void btn_Intermediate_MouseUp(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] & 65536 - 1 - 16));
        }

        private void btn_Ack_MouseDown(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] | 4));
        }

        private void btn_Ack_MouseUp(object sender, MouseEventArgs e)
        {
            ushort[] smsStatus = m_Master.ReadHoldingRegisters(1, Convert.ToUInt16(txt_AddressStart.Text), 1);
            m_Master.WriteSingleRegister(1, Convert.ToUInt16(txt_AddressStart.Text), (ushort)((int)smsStatus[0] & 65536 - 1 - 4));
        }

        private void cob_Command_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] DatasFormatted;
            if (cob_Command.SelectedIndex == 0)
            {
                m_Master.WriteSingleRegister(1, 34001, 50);
            }
            else if (cob_Command.SelectedIndex == 1)
            {
                m_Master.WriteSingleRegister(1, 34001, 51);
            }
            else if (cob_Command.SelectedIndex == 2)
            {//read
                txt_Data.Text = "";
                m_Master.WriteSingleRegister(1, 34001, 100);
                ushort[] ISDUdata = m_Master.ReadHoldingRegisters(1, 34007, Convert.ToUInt16(txt_Length.Text));
                DatasFormatted = new string[Convert.ToUInt16(txt_Length.Text)];
                switch (cob_Type.Text)
                {
                    case "Signed":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            DatasFormatted[i] = Convert.ToInt16(ISDUdata[i]).ToString();
                        }
                        break;
                    case "Unsigned":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            DatasFormatted[i] = ISDUdata[i].ToString();
                        }
                        break;
                    case "Hex":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            DatasFormatted[i] = "0x" + Convert.ToString(ISDUdata[i], 16).PadLeft(4, '0').ToUpper();

                        }
                        break;
                    case "Binary":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            DatasFormatted[i] = Convert.ToString(ISDUdata[i], 2).PadLeft(16, '0');
                        }
                        break;
                    case "Long AB CD":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            b[0] = bb[0];
                            b[1] = bb[1];
                            b[2] = ba[0];
                            b[3] = ba[1];
                            Int32 m = BitConverter.ToInt32(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    case "Long CD AB":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            b[0] = ba[0];
                            b[1] = ba[1];
                            b[2] = bb[0];
                            b[3] = bb[1];
                            Int32 m = BitConverter.ToInt32(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    case "Long BA DC":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[ i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            Array.Reverse(ba);
                            Array.Reverse(bb);
                            b[0] = bb[0];
                            b[1] = bb[1];
                            b[2] = ba[0];
                            b[3] = ba[1];
                            Int32 m = BitConverter.ToInt32(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    case "Long DC BA":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            Array.Reverse(ba);
                            Array.Reverse(bb);
                            b[0] = ba[0];
                            b[1] = ba[1];
                            b[2] = bb[0];
                            b[3] = bb[1];
                            Int32 m = BitConverter.ToInt32(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    case "Float AB CD":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            b[0] = bb[0];
                            b[1] = bb[1];
                            b[2] = ba[0];
                            b[3] = ba[1];
                            float m = BitConverter.ToSingle(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    case "Float CD AB":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            b[0] = ba[0];
                            b[1] = ba[1];
                            b[2] = bb[0];
                            b[3] = bb[1];
                            float m = BitConverter.ToSingle(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    case "Float BA DC":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            Array.Reverse(ba);
                            Array.Reverse(bb);
                            b[0] = bb[0];
                            b[1] = bb[1];
                            b[2] = ba[0];
                            b[3] = ba[1];
                            float m = BitConverter.ToSingle(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    case "Float DC BA":
                        for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                        {
                            byte[] ba = BitConverter.GetBytes(ISDUdata[i]);
                            byte[] bb = BitConverter.GetBytes(ISDUdata[i + 1]);
                            byte[] b = new byte[4];
                            Array.Reverse(ba);
                            Array.Reverse(bb);
                            b[0] = ba[0];
                            b[1] = ba[1];
                            b[2] = bb[0];
                            b[3] = bb[1];
                            float m = BitConverter.ToSingle(b, 0);
                            DatasFormatted[i] = m.ToString();
                            DatasFormatted[i + 1] = "";
                        }
                        break;
                    default:
                        break;
                }
                for (int i = 0; i < Convert.ToInt16(txt_Length.Text); i++)
                {
                    if (txt_Data.Text !="")
                    {
                        txt_Data.Text = txt_Data.Text + "\r\n";
                    }

                    txt_Data.Text = txt_Data.Text + DatasFormatted[i];
                }
                
            }
            else if (cob_Command.SelectedIndex == 3)
            {//write
                m_Master.WriteSingleRegister(1, 34001, 101);

            }
        }

        private void cob_ParaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("0");
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("No selected!", "Error");
            }
            else
            {
                int mIndex = listBox1.SelectedIndex;
                new Form2(listBox1.SelectedItem.ToString()).ShowDialog();
                listBox1.Items.Remove(listBox1.SelectedItem);
                
                listBox1.Items.Insert(mIndex, Form2.newValue);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {             
                new Form2(listBox1.Items[index].ToString()).ShowDialog();
                listBox1.Items.RemoveAt(index);//先移除当前项的值
                listBox1.Items.Insert(index, Form2.newValue);//在当前指定项插入新的值

            }
        }
    }
}
