using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace PMStenthree
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        short[] recdata = new short[12];
        string[] ports;

        public static short Byte2Hex(byte high, byte low)
        {
            return (short)((high & 0xff) << 8 | (low & 0xff));
        }

        public Form1()
        {
            InitializeComponent();
            InitPortscb();
        }

        public void InitPortscb()
        {
            waycb.Items.Add("STD");
            waycb.Items.Add("CF=1");
            waycb.SelectedIndex = 0;

            ports = SerialPort.GetPortNames();

            serialPort.DataReceived += ParseData;

            portcb.DataSource = ports;
            if (ports.Length != 0) portcb.SelectedIndex = 0;
        }

        public void ParseData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort com = (SerialPort)sender;
            int num = serialPort.BytesToRead;
            int selected = 0;
            byte[] buffer = new byte[num];
            serialPort.Read(buffer, 0, num);
            string text;
            text = "";
            for (int i = 0; i < num; i++) text += buffer[i].ToString("x") + " ";
            Action action = () =>
            {
                Debuglb.Text = num.ToString() + "|" + text;
                selected = waycb.SelectedIndex;
            };
            Invoke(action);
            if (num > 0)
            {
                if (buffer[0] == 0x42 && buffer[1] == 0x4d)
                {
                    if (selected == 0)
                    {
                        for (int i = 0; i < 12; i++) recdata[i] = Byte2Hex(buffer[2 * (i + 2) + 4], buffer[(2 * (i + 2)) + 5]);
                    }
                    if (selected == 1)
                    {
                        for (int i = 0; i < 12; i++) recdata[i] = Byte2Hex(buffer[2 * (i + 2)], buffer[(2 * (i + 2)) + 1]);
                    }

                    action = () =>
                    {
                        pm10lb.Text = "PM1.0  " + recdata[0].ToString() + " ug/m3";
                        pm25lb.Text = "PM2.5  " + recdata[1].ToString() + " ug/m3";
                        pmtenlb.Text = "PM1 0  " + recdata[2].ToString() + " ug/m3";
                        pm25aqi.Text = "AQI    " + CalcAQI(recdata[1], 1);
                        pmtenaqi.Text = "AQI    " + CalcAQI(recdata[2], 2);

                        pm25bg.Image = AQIColor(CalcAQI(recdata[1], 1));
                        pmtenbg.Image = AQIColor(CalcAQI(recdata[2], 2));
                    };
                    Invoke(action);
                }

            }
        }

        //Calc AQI
        //C->input
        //t->type
        //1->pm2.5
        //2->pm10
        //return AQI(int)

        private int CalcLev(double c)
        {
            int res = 0;

            if (c >= 0 && c <= 50) res = 0;
            else if (c >= 51 && c <= 100) res = 1;
            else if (c >= 101 && c <= 150) res = 2;
            else if (c >= 151 && c <= 200) res = 3;
            else if (c >= 201 && c <= 300) res = 4;
            else res = 5;

            return res;
        }

        private Image AQIColor(double c)
        {
            switch (CalcLev(c))
            {
                case 0:
                    return Properties.Resources.green;
                case 1:
                    return Properties.Resources.yellow;
                case 2:
                    return Properties.Resources.orange;
                case 3:
                    return Properties.Resources.red;
                case 4:
                    return Properties.Resources.purple;
                case 5:
                    return Properties.Resources.deep;
                default:
                    return Properties.Resources.what;
            }
        }

        private double CalcIAQI(int v, int lI, int hI, int lC, int hC)
        {
            return (v - lC) * (hI - lI) / (hC - lC) + lI;
        }

        private double CalcAQI(int c, int t)
        {
            double res = 500;
            if(t == 1)
            {
                if (c >= 0 && c < 35) res = CalcIAQI(c, 0, 50, 0, 35);
                else if (c >= 35 && c < 75) res = CalcIAQI(c, 50, 100, 35, 75);
                else if (c >= 75 && c < 115) res = CalcIAQI(c, 100, 150, 75, 115);
                else if (c >= 115 && c < 150) res = CalcIAQI(c, 150, 200, 115, 150);
                else if (c >= 150 && c < 250) res = CalcIAQI(c, 200, 300, 150, 250);
                else if (c >= 250 && c < 350) res = CalcIAQI(c, 300, 400, 250, 350);
                else if (c >= 350 && c < 500) res = CalcIAQI(c, 400, 500, 350, 500);
            }
            if (t == 2)
            {
                if (c >= 0 && c < 50) res = CalcIAQI(c, 0, 50, 0, 50);
                else if (c >= 50 && c < 150) res = CalcIAQI(c, 50, 100, 50, 150);
                else if (c >= 150 && c < 250) res = CalcIAQI(c, 100, 150, 150, 250);
                else if (c >= 250 && c < 350) res = CalcIAQI(c, 150, 200, 250, 350);
                else if (c >= 350 && c < 420) res = CalcIAQI(c, 200, 300, 350, 420);
                else if (c >= 420 && c < 500) res = CalcIAQI(c, 300, 400, 420, 500);
                else if (c >= 500 && c < 600) res = CalcIAQI(c, 400, 500, 500, 600);
            }

            return res;
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            if (portcb.Text == null || portcb.Text == "")
            {
                ports = SerialPort.GetPortNames();
                portcb.DataSource = ports;
                if (ports.Length != 0) portcb.SelectedIndex = 0;
                return;
            }
            if (serialPort.IsOpen)
            {
                serialPort.Close();

                pm10lb.Text = "PM1.0    --------";
                pm25lb.Text = "PM2.5    --------";
                pmtenlb.Text = "PM1 0    --------";
                pm10aqi.Text = "AQI    --------";
                pm25aqi.Text = "AQI    --------";
                pmtenaqi.Text = "AQI    --------";

                pm10bg.Image = PMStenthree.Properties.Resources.what;
                pm25bg.Image = PMStenthree.Properties.Resources.what;
                pmtenbg.Image = PMStenthree.Properties.Resources.what;

                Debuglb.Text = "Ready";

                Connectbtn.Text = "Connect";
                cntckb.Checked = false;
            }else
            {
                serialPort.PortName = portcb.Text;
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();

                Debuglb.Text = "OK";

                Connectbtn.Text = "Disconnect";
                cntckb.Checked = true;
            }
        }
    }
}
