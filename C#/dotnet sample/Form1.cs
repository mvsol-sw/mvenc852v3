using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MVSol;
using System.IO.Ports;
using System.Threading;
using MVSol.Enc852;



namespace mvenc852_test_win
{
    public partial class Form1 : Form
    {
        Serial_port serialform = new Serial_port();
        public MVSol.Enc852.MVEnc852v3Comm comm;
        public TriggerControl tc;
        public TriggerGenerator tg;
        



        bool paintingstart = true;

        public Form1()
        {
            InitializeComponent();


        }
        private void ReadTrigger0() {
            TriggerControl tc = comm.GetTriggerControl(0);

            numericUpDown_Resolution.Value = (decimal)comm.GetEncoderResolution();
            if (comm.GetUnit() != 0)
            {
                checkBox_unit0.Text = "㎛";
            }
            else
            {
                checkBox_unit0.Text = "Count";
            }
            if (tc.TriggerBase != 0)
            {
                checkBox_Triggerbase0.Text = "Distance";
            }
            else
            {
                checkBox_Triggerbase0.Text = "Count";
            }
            Visibledata();
            
            
            numericUpDown_StartPosition0.Value = comm.GetTriggerPositionStart(0);
            numericUpDown_EndPosition0.Value = comm.GetTriggerPositionEnd(0);
            comboBox_TriggerPositionDirection0.SelectedIndex = (int)tc.TriggerDirectionality;
            comboBox_TriggerPositionDirection0sub.SelectedIndex = comboBox_TriggerPositionDirection0.SelectedIndex;
            comboBox_EncoderType0.SelectedIndex = (int)tc.EncoderType;



            comboBox_Encoderchannel0.SelectedIndex = tc.EncoderChannel;
            int Getmultidata = tc.Multi;
            if (Getmultidata == 2)
            {
                comboBox_EncoderMulti0.SelectedIndex = 1;
            }
            else if (Getmultidata == 4)
            {
                comboBox_EncoderMulti0.SelectedIndex = 2;
            }
            else
            {
                comboBox_EncoderMulti0.SelectedIndex = 0;
            }
            comboBox_TriggerOut0.SelectedIndex = (int)tc.TriggerOut;
            comboBox_EncoderDirectionFactor0.SelectedIndex = (int)tc.EncoderDirectionFactor;
            comboBox_CondFactor0.SelectedIndex = (int)tc.ConditionFactor;
            comboBox_EncCorrection0.SelectedIndex = tc.EncoderCorrection;
           

            int x, y; 
            comm.GetTriggerGenerator(0, out x, out y);
            numericUpDown_High0.Value = x;
            label_High0.Text = x.ToString();
            numericUpDown_Cycle0.Value = y;
            label_Cycle0.Text = y.ToString();
        }
        private void ReadTrigger1()
        {
            TriggerControl tc = comm.GetTriggerControl(1);

            numericUpDown_Resolution.Value = (decimal)comm.GetEncoderResolution();
            if (comm.GetUnit() != 0)
            {
                checkBox_unit1.Text = "㎛";
            }
            else
            {
                checkBox_unit1.Text = "Count";
            }
            if (tc.TriggerBase != 0)
            {
                checkBox_Triggerbase1.Text = "Distance";
            }
            else
            {
                checkBox_Triggerbase1.Text = "Count";
            }
            Visibledata();


            numericUpDown_StartPosition1.Value = comm.GetTriggerPositionStart(1);
            numericUpDown_EndPosition1.Value = comm.GetTriggerPositionEnd(1);
            comboBox_TriggerPositionDirection1.SelectedIndex = (int)tc.TriggerDirectionality;
            comboBox_TriggerPositionDirection1sub.SelectedIndex = comboBox_TriggerPositionDirection1.SelectedIndex;
            comboBox_EncoderType1.SelectedIndex = (int)tc.EncoderType;



            comboBox_Encoderchannel1.SelectedIndex = tc.EncoderChannel;
            int Getmultidata = tc.Multi;
            if (Getmultidata == 2)
            {
                comboBox_EncoderMulti1.SelectedIndex = 1;
            }
            else if (Getmultidata == 4)
            {
                comboBox_EncoderMulti1.SelectedIndex = 2;
            }
            else
            {
                comboBox_EncoderMulti1.SelectedIndex = 0;
            }
            comboBox_TriggerOut1.SelectedIndex = (int)tc.TriggerOut;
            comboBox_EncoderDirectionFactor1.SelectedIndex = (int)tc.EncoderDirectionFactor;
            comboBox_CondFactor1.SelectedIndex = (int)tc.ConditionFactor;
            comboBox_EncCorrection1.SelectedIndex = tc.EncoderCorrection;


            int x, y;
            comm.GetTriggerGenerator(1, out x, out y);
            numericUpDown_High1.Value = x;
            label_High1.Text = x.ToString();
            numericUpDown_Cycle1.Value = y;
            label_Cycle1.Text = y.ToString();

        }
        private void ReadTrigger2()
        {
            TriggerControl tc = comm.GetTriggerControl(2);

            numericUpDown_Resolution.Value = (decimal)comm.GetEncoderResolution();
            if (comm.GetUnit() != 0)
            {
                checkBox_unit2.Text = "㎛";
            }
            else
            {
                checkBox_unit2.Text = "Count";
            }
            if (tc.TriggerBase != 0)
            {
                checkBox_Triggerbase2.Text = "Distance";
            }
            else
            {
                checkBox_Triggerbase2.Text = "Count";
            }
            Visibledata();


            numericUpDown_StartPosition2.Value = comm.GetTriggerPositionStart(2);
            numericUpDown_EndPosition2.Value = comm.GetTriggerPositionEnd(2);
            comboBox_TriggerPositionDirection2.SelectedIndex = (int)tc.TriggerDirectionality;
            comboBox_TriggerPositionDirection2sub.SelectedIndex = comboBox_TriggerPositionDirection2.SelectedIndex;
            comboBox_EncoderType2.SelectedIndex = (int)tc.EncoderType;



            comboBox_Encoderchannel2.SelectedIndex = tc.EncoderChannel;
            int Getmultidata = tc.Multi;
            if (Getmultidata == 2)
            {
                comboBox_EncoderMulti2.SelectedIndex = 1;
            }
            else if (Getmultidata == 4)
            {
                comboBox_EncoderMulti2.SelectedIndex = 2;
            }
            else
            {
                comboBox_EncoderMulti2.SelectedIndex = 0;
            }
            comboBox_TriggerOut2.SelectedIndex = (int)tc.TriggerOut;
            comboBox_EncoderDirectionFactor2.SelectedIndex = (int)tc.EncoderDirectionFactor;
            comboBox_CondFactor2.SelectedIndex = (int)tc.ConditionFactor;
            comboBox_EncCorrection2.SelectedIndex = tc.EncoderCorrection;


            int x, y;
            comm.GetTriggerGenerator(2, out x, out y);
            numericUpDown_High2.Value = x;
            label_High2.Text = x.ToString();
            numericUpDown_Cycle2.Value = y;
            label_Cycle2.Text = y.ToString();
        }

        private void ReadTrigger3()
        {
            TriggerControl tc = comm.GetTriggerControl(3);

            numericUpDown_Resolution.Value = (decimal)comm.GetEncoderResolution();
            if (comm.GetUnit() != 0)
            {
                checkBox_unit3.Text = "㎛";
            }
            else
            {
                checkBox_unit3.Text = "Count";
            }
            if (tc.TriggerBase != 0)
            {
                checkBox_Triggerbase3.Text = "Distance";
            }
            else
            {
                checkBox_Triggerbase3.Text = "Count";
            }
            Visibledata();


            numericUpDown_StartPosition3.Value = comm.GetTriggerPositionStart(3);
            numericUpDown_EndPosition3.Value = comm.GetTriggerPositionEnd(3);
            comboBox_TriggerPositionDirection3.SelectedIndex = (int)tc.TriggerDirectionality;
            comboBox_TriggerPositionDirection3sub.SelectedIndex = comboBox_TriggerPositionDirection3.SelectedIndex;
            comboBox_EncoderType3.SelectedIndex = (int)tc.EncoderType;



            comboBox_Encoderchannel3.SelectedIndex = tc.EncoderChannel;
            int Getmultidata = tc.Multi;
            if (Getmultidata == 2)
            {
                comboBox_EncoderMulti3.SelectedIndex = 1;
            }
            else if (Getmultidata == 4)
            {
                comboBox_EncoderMulti3.SelectedIndex = 2;
            }
            else
            {
                comboBox_EncoderMulti3.SelectedIndex = 0;
            }
            comboBox_TriggerOut3.SelectedIndex = (int)tc.TriggerOut;
            comboBox_EncoderDirectionFactor3.SelectedIndex = (int)tc.EncoderDirectionFactor;
            comboBox_CondFactor3.SelectedIndex = (int)tc.ConditionFactor;
            comboBox_EncCorrection3.SelectedIndex = tc.EncoderCorrection;


            int x, y;
            comm.GetTriggerGenerator(3, out x, out y);
            numericUpDown_High3.Value = x;
            label_High3.Text = x.ToString();
            numericUpDown_Cycle3.Value = y;
            label_Cycle3.Text = y.ToString();

        }


        private void ReadVirtual()
        {
            numericUpDown_VirtualEncoder0.Value = comm.GetVirtualEncoder(0);
            numericUpDown_VirtualEncoder1.Value = comm.GetVirtualEncoder(1);
            numericUpDown_VirtualEncoder2.Value = comm.GetVirtualEncoder(2);
            numericUpDown_VirtualEncoder3.Value = comm.GetVirtualEncoder(3);
        }

        private void ReadGlobal() {
            
        }
        private void Readmain() {
            if (tabControl1.SelectedTab == tabPage_trigger)
            {
                numericUpDown_timerCurrentPosition0.Value = comm.GetEncoderPosition(0);
            }
            else if (tabControl1.SelectedTab == tabPage_trigger1) {
                numericUpDown_timerCurrentPosition1.Value = comm.GetEncoderPosition(1);
            }
            else if (tabControl1.SelectedTab == tabPage_trigger2)
            {
                numericUpDown_timerCurrentPosition2.Value = comm.GetEncoderPosition(2);
            }
            else if (tabControl1.SelectedTab == tabPage_trigger3)
            {
                numericUpDown_timerCurrentPosition3.Value = comm.GetEncoderPosition(3);
            }
        }
        private void ReadStatus()
        {

            numericUpDown_DI0Count.Value = (decimal)comm.GetDigitalInputCount(0);
            numericUpDown_DI1Count.Value = (decimal)comm.GetDigitalInputCount(1);
            numericUpDown_DI2Count.Value = (decimal)comm.GetDigitalInputCount(2);
            numericUpDown_DI3Count.Value = (decimal)comm.GetDigitalInputCount(3);
            numericUpDown_DI4Count.Value = (decimal)comm.GetDigitalInputCount(4);
            numericUpDown_DI5Count.Value = (decimal)comm.GetDigitalInputCount(5);
            numericUpDown_DI6Count.Value = (decimal)comm.GetDigitalInputCount(6);
            numericUpDown_Trigger0Count.Value = (decimal)comm.GetTriggerCount(0);
            numericUpDown_Trigger1Count.Value = (decimal)comm.GetTriggerCount(1);
            numericUpDown_Trigger2Count.Value = (decimal)comm.GetTriggerCount(2);
            numericUpDown_Trigger3Count.Value = (decimal)comm.GetTriggerCount(3);
            numericUpDown_EncoderPosition0.Value = (decimal)comm.GetEncoderPosition(0);
            numericUpDown_EncoderPosition1.Value = (decimal)comm.GetEncoderPosition(1);
            numericUpDown_EncoderPosition2.Value = (decimal)comm.GetEncoderPosition(2);
            numericUpDown_EncoderPosition3.Value = (decimal)comm.GetEncoderPosition(3);
            numericUpDown_ErrorCount0.Value = (decimal)comm.GetErrorCount(0);
            numericUpDown_ErrorCount1.Value = (decimal)comm.GetErrorCount(1);
            numericUpDown_ErrorCount2.Value = (decimal)comm.GetErrorCount(2);
            numericUpDown_ErrorCount3.Value = (decimal)comm.GetErrorCount(3);
            checkBox_DI0.Checked = (comm.GetDigitalInputState(0) != 0);
            checkBox_DI1.Checked = (comm.GetDigitalInputState(1) != 0);
            checkBox_DI2.Checked = (comm.GetDigitalInputState(2) != 0);
            checkBox_DI3.Checked = (comm.GetDigitalInputState(3) != 0);
            checkBox_DI4.Checked = (comm.GetDigitalInputState(4) != 0);
            checkBox_DI5.Checked = (comm.GetDigitalInputState(5) != 0);
            checkBox_DI6.Checked = (comm.GetDigitalInputState(6) != 0);

        }
        private void ReadAllData()
        {
            ReadGlobal();
            //ReadStatus();
            textBox_firmver.Text = comm.GetFirmVersion().ToString();
            textBox_logicver.Text = comm.GetLogicVersion().ToString();
            ReadVirtual();
            ReadTrigger0();
            ReadTrigger1();
            ReadTrigger2();
            ReadTrigger3();
        }


        private void Errorlog() {

            panel_Error.BackColor = Color.Red;
            labelComState.ForeColor = Color.Red;
            labelComState.Text = "연결안됨";
            labelError.Text = "포트가 닫혀있습니다.";
            cOM열기ToolStripMenuItem.Enabled = true;
            cOM닫기ToolStripMenuItem.Enabled = false;
            saveFlashToolStripMenuItem.Enabled = false;
            도움말ToolStripMenuItem.Enabled = false;
            FileToolStripMenuItem.Enabled = false;
            Thread.Sleep(1000);
            labelError.Text = " ";
            panel_Error.BackColor = SystemColors.ControlLight;
        }
        private void cOM열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (serialform.ShowDialog() == DialogResult.OK)
                {
                    textBox_portname.Text = serialform.comboBox_selectport.Text;


                    comm = new MVSol.Enc852.MVEnc852v3Comm(textBox_portname.Text);

                    if (!comm.IsOpen)
                    {
                        comm.Open();
                        labelComState.ForeColor = Color.Lime;
                        labelComState.Text = "연결됨";
                        cOM열기ToolStripMenuItem.Enabled = false;
                        cOM닫기ToolStripMenuItem.Enabled = true;
                        saveLoadToolStripMenuItem.Enabled = true;
                        도움말ToolStripMenuItem.Enabled = true;
                        FileToolStripMenuItem.Enabled = true;
                        ReadAllData();
                        panel_Error.BackColor = Color.White;
                        tabControl1.Visible = true;

                        timer_Trigger.Start();

                    }
                }
                else
                {
                }
            }
            catch {

                Errorlog();

            }
        }

        private void 메뉴얼ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cOM닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //com닫기 추가해야함
            cOM열기ToolStripMenuItem.Enabled = true;
            cOM닫기ToolStripMenuItem.Enabled = false;
            saveLoadToolStripMenuItem.Enabled = false;
            도움말ToolStripMenuItem.Enabled = false;
            FileToolStripMenuItem.Enabled = false;
            tabControl1.SelectedTab = tabPage_trigger;
            tabControl1.Visible = false;
            timer_Virtual.Stop();
            timer_Trigger.Stop();
            comm.Close();
            labelComState.ForeColor = Color.Red;
            labelComState.Text = "연결 안됨";
            textBox_portname.Text = "";
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //화살표 그리기
            //Graphics graphics = panel3.CreateGraphics();
            //Pen pen = new Pen(Color.SkyBlue, 6);
            //pen.StartCap = LineCap.ArrowAnchor; //Line의 시작점 모양 변경 
            //pen.EndCap = LineCap.ArrowAnchor; //Line의 끝점 모양 변경
            //graphics.DrawLine(pen, 40, 110, 350, 110);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
                Graphics mvgr = panel3.CreateGraphics();

                Pen blackpen = new Pen(Color.Black, 2);
                Pen bluepen = new Pen(Color.SkyBlue, 3);

                mvgr.DrawRectangle(blackpen, new Rectangle(40, 150, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(40, 220, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(40, 290, 100, 50));
                int x = 0, y = 0;
                Point linex = new Point(x + 141, y + 175);
                Point liney = new Point(x + 190, y + 175);
                mvgr.DrawLine(bluepen, linex, liney);


                int Firstint = 240;
                int Secondint = 60;
                for (int i = 1; i < 5; i++)
                {
                    bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    Secondint = Secondint + 70;
                    Point First = new Point(Firstint, Secondint);
                    Point Second = new Point(Firstint, (Secondint) + 20);
                    mvgr.DrawLine(bluepen, First, Second);
                }
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                Point lastFirst = new Point(240, 410);
                Point lastSecond = new Point(240, 460);
                mvgr.DrawLine(bluepen, lastFirst, lastSecond);

                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                Point data1 = new Point(85, 271);
                Point data2 = new Point(85, 280);
                mvgr.DrawLine(bluepen, data1, data2);
                Point data3 = new Point(230, 280);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data2, data3);


                Point data4 = new Point(85, 341);
                Point data5 = new Point(85, 373);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                mvgr.DrawLine(bluepen, data4, data5);
                Point data6 = new Point(185, 373);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data5, data6);

                Point data7 = new Point(290, 314);
                Point data8 = new Point(400, 150);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data8, data7);

                Point data9 = new Point(300, 490);
                Point data10 = new Point(400, 490);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data10, data9);

                mvgr.DrawRectangle(blackpen, new Rectangle(190, 80, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 150, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 220, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 290, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 360, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(180, 460, 120, 70));
         
        }


        private void timer_Trigger_Tick(object sender, EventArgs e)
        {
            Readmain();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadStatus();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (comm != null) {
                comm.Close();
                comm.Dispose();
                comm = null;
            }

        }

        private void saveFlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comm.SaveFlash();
        }

        private void loadFlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comm.LoadFlash();
        }


        private void 전체초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("디바이스를 초기화 하시겠습니까?", "디바이스 초기화 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                comm.SetDefaultParameter();
            }
        }

        private void numericUpDown_VirtualEncoder0_ValueChanged(object sender, EventArgs e)
        {
            if (comm.IsOpen)
                try
                {
                    comm.SetVirtualEncoder(0, (uint)numericUpDown_VirtualEncoder0.Value);
                    numericUpDown_VirtualEncoder0.BackColor = Color.White;
                }
                catch (System.Exception ex)
                {
                    labelError.Text = "Virtual Encoder0 설정 에러" + ex.Message;
                    panel_Error.BackColor = Color.Red;
                }
        }

        private void numericUpDown_VirtualEncoder1_ValueChanged(object sender, EventArgs e)
        {
            if (comm.IsOpen)
                try
                {
                    comm.SetVirtualEncoder(1, (uint)numericUpDown_VirtualEncoder1.Value);
                    numericUpDown_VirtualEncoder0.BackColor = Color.White;
                }
                catch (System.Exception ex)
                {
                    labelError.Text = "Virtual Encoder1 설정 에러" + ex.Message;
                    panel_Error.BackColor = Color.Red;
                }
        }

        private void numericUpDown_VirtualEncoder2_ValueChanged(object sender, EventArgs e)
        {
            if (comm.IsOpen)
                try
                {
                    comm.SetVirtualEncoder(2, (uint)numericUpDown_VirtualEncoder2.Value);
                    numericUpDown_VirtualEncoder0.BackColor = Color.White;
                }
                catch (System.Exception ex)
                {
                    labelError.Text = "Virtual Encoder 설정 에러" + ex.Message;
                    panel_Error.BackColor = Color.Red;
                }
        }

        private void numericUpDown_VirtualEncoder3_ValueChanged(object sender, EventArgs e)
        {
            if (comm.IsOpen)
                try
                {
                    comm.SetVirtualEncoder(3, (uint)numericUpDown_VirtualEncoder3.Value);
                    numericUpDown_VirtualEncoder0.BackColor = Color.White;
                }
                catch (System.Exception ex)
                {
                    labelError.Text = "Virtual Encoder 설정 에러" + ex.Message;
                    panel_Error.BackColor = Color.Red;
                }
        }

        private void numericUpDown_Resolution_ValueChanged(object sender, EventArgs e)
        {
            if (comm.IsOpen)
                try
                {
                    comm.SetEncoderResolution((double)numericUpDown_Resolution.Value);
                    numericUpDown_Resolution.BackColor = Color.White;
                }
                catch (System.Exception ex)
                {
                    labelError.Text = "Resolution 설정 에러" + ex.Message;
                    panel_Error.BackColor = Color.Red;
                }
        }

        private void button_ClearDi_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCountAll();
        }

        private void button_ClearPosition_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPositionAll();
        }

        private void button_ClearError_Click(object sender, EventArgs e)
        {
            comm.ClearErrorCountAll();
        }

        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCountAll();
            comm.ClearTriggerCountAll();
            comm.ClearEncoderPositionAll();
           comm.ClearErrorCountAll();
        }

        private void button_ClearTrigger_Click(object sender, EventArgs e)
        {
            comm.ClearTriggerCountAll();
        }
        private void button_DI0Count_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCount(0);


        }

        private void button_DI1CountClear_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCount(1);

        }

        private void button_DI2CountClear_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCount(2);

        }

        private void button_DI3CountClear_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCount(3);

        }

        private void button_DI4CountClear_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCount(4);

        }

        private void button_DI5CountClear_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCount(5);

        }

        private void button_DI6CountClear_Click(object sender, EventArgs e)
        {
            comm.ClearDigitalInputCount(6);

        }

        private void button_TriggerCount0_Click(object sender, EventArgs e)
        {
            comm.ClearTriggerCount(0);

        }

        private void button_TriggerCount1_Click(object sender, EventArgs e)
        {

            comm.ClearTriggerCount(1);

        }

        private void button_TriggerCount2_Click(object sender, EventArgs e)
        {
            comm.ClearTriggerCount(2);

        }

        private void button_TriggerCount3_Click(object sender, EventArgs e)
        {
            comm.ClearTriggerCount(3);

        }

        private void button_EncoderPosition0Clear_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(0);

        }

        private void button_EncoderPosition1Clear_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(1);

        }

        private void button_EncoderPosition2Clear_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(2);

        }

        private void button_EncoderPosition3Clear_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(3);

        }

        private void button_ErrorCount0_Click(object sender, EventArgs e)
        {

            comm.ClearErrorCount(0);

        }

        private void button_ErrorCount1_Click(object sender, EventArgs e)
        {
            comm.ClearErrorCount(1);

        }

        private void button_ErrorCount2_Click(object sender, EventArgs e)
        {
            comm.ClearErrorCount(2);
        }

        private void button_ErrorCount3_Click(object sender, EventArgs e)
        {
            comm.ClearErrorCount(3);
        }

        private void Visibledata()
        {
            if (comm.GetUnit() == 1)
            {
                labeldata.Visible = true;
                labeldata1.Visible = true;
                labeldata2.Visible = true;
                labeldata3.Visible = true;
                labeldata4.Visible = true;
                labeldata5.Visible = true;
                labeldata6.Visible = true;
                labeldata7.Visible = true;
                labeldata8.Visible = true;
                labeldata9.Visible = true;
                labeldata10.Visible = true;
                labeldata11.Visible = true;

            }
            else {
                labeldata.Visible = false;
                labeldata1.Visible = false;
                labeldata2.Visible = false;
                labeldata3.Visible = false;
                labeldata4.Visible = false;
                labeldata5.Visible = false;
                labeldata6.Visible = false;
                labeldata7.Visible = false;
                labeldata8.Visible = false;
                labeldata9.Visible = false;
                labeldata10.Visible = false;
                labeldata11.Visible = false;
            }
        }

        private void comboBox_TriggerPositionDirection0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants)comboBox_TriggerPositionDirection0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
                comboBox_TriggerPositionDirection0sub.SelectedIndex = comboBox_TriggerPositionDirection0.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection0.BackColor = Color.Red;
            }
        }

        private void button_PositionClear0_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(0);
        }

        private void tabPage_trigger_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_unit0_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetUnit((uint)(checkBox_unit0.Checked ? 1 : 0));
                if (checkBox_unit0.Checked == true)
                {
                    checkBox_unit0.BackColor = Color.White;
                    checkBox_unit0.Text = "㎛";
                    checkBox_unit1.Text = "㎛";
                    checkBox_unit2.Text = "㎛";
                    checkBox_unit3.Text = "㎛";
                    Visibledata();
                    numericUpDown_StartPosition0.Value = comm.GetTriggerPositionStart(0);
                    numericUpDown_EndPosition0.Value = comm.GetTriggerPositionEnd(0);
                }
                else
                {
                    checkBox_unit0.BackColor = Color.White;
                    checkBox_unit0.Text = "Count";
                    checkBox_unit1.Text = "Count";
                    checkBox_unit2.Text = "Count";
                    checkBox_unit3.Text = "Count";
                    Visibledata();
                    numericUpDown_StartPosition0.Value = comm.GetTriggerPositionStart(0);
                    numericUpDown_EndPosition0.Value = comm.GetTriggerPositionEnd(0);
                }
            }
            catch (System.Exception ex)
            {
                
                checkBox_unit0.BackColor = Color.Red;
            }
        }

        private void checkBox_Triggerbase_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
            int x = checkBox_Triggerbase0.Checked ? 1 : 0;
            tc.TriggerBase = ((TriggerBaseConstants)(checkBox_Triggerbase0.Checked ? 1 : 0));
            comm.SetTriggerControl(0, tc);

                if (checkBox_Triggerbase0.Checked == true)
                {
                    checkBox_Triggerbase0.Text = "Distance";
                }
                else
                {
                    checkBox_Triggerbase0.Text = "Count";
                }
            }
            catch (System.Exception ex)
            {
              
                checkBox_Triggerbase0.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderMulti0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.Multi = (int)comboBox_EncoderMulti0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
            }
            catch (System.Exception ex)
            {
                
                comboBox_EncoderMulti0.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerPositionDirection0sub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants) comboBox_TriggerPositionDirection0sub.SelectedIndex;
                comm.SetTriggerControl(0, tc);
                comboBox_TriggerPositionDirection0.SelectedIndex = comboBox_TriggerPositionDirection0sub.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection0sub.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderDirectionFactor0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.EncoderDirectionFactor = (EncoderDirectionFactorConstants)comboBox_EncoderDirectionFactor0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
            }
            catch (System.Exception ex)
            {
               
                comboBox_EncoderDirectionFactor0.BackColor = Color.Red;
            }
        }

        private void comboBox_EncCorrection0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.EncoderCorrection = comboBox_EncCorrection0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
            }
            catch (System.Exception ex)
            {
                // StatusLabel.Text = "Mode4 Start 설정 에러." + ex.Message;
                comboBox_EncCorrection0.BackColor = Color.Red;
            }
        }

        private void numericUpDown_High0_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(0);
                tg.PulseHigh = (int)numericUpDown_High0.Value;
                comm.SetTriggerGenerator(0, tg);
                label_High0.Text = numericUpDown_High0.Value.ToString();
            }
            catch (System.Exception ex)
            {
                numericUpDown_High0.BackColor = Color.Red;
            }
        }

        private void numericUpDown_Cycle0_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(0);
                tg.Cycle = (int)numericUpDown_Cycle0.Value;
                comm.SetTriggerGenerator(0, tg);
                label_Cycle0.Text = numericUpDown_Cycle0.Value.ToString();
            }
            catch (System.Exception ex)
            {
                numericUpDown_Cycle0.BackColor = Color.Red;
            }
        }

        private void comboBox_Encoderchannel0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.EncoderChannel = comboBox_Encoderchannel0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
            }
            catch (System.Exception ex)
            {
               
                comboBox_Encoderchannel0.BackColor = Color.Red;
            }
        }

        private void numericUpDown_StartPosition0_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionStart(0,(int) numericUpDown_StartPosition0.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_StartPosition0.BackColor = Color.Red;
            }
        }

        private void numericUpDown_EndPosition0_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionEnd(0, (int)numericUpDown_EndPosition0.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_EndPosition0.BackColor = Color.Red;
            }
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage_trigger)
            {
                timer_Trigger.Start();
            }
            else if(tabControl1.SelectedTab == tabPage_Status)
            {
                timer_Trigger.Stop();
            }

            if (tabControl1.SelectedTab == tabPage_Status)
            {
                timer_Virtual.Start();
            }
            else
            {
                timer_Virtual.Stop();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
                Graphics mvgr = panel2.CreateGraphics();

                Pen blackpen = new Pen(Color.Black, 2);
                Pen bluepen = new Pen(Color.SkyBlue, 3);

                mvgr.DrawRectangle(blackpen, new Rectangle(40, 150, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(40, 220, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(40, 290, 100, 50));
                int x = 0, y = 0;
                Point linex = new Point(x + 141, y + 175);
                Point liney = new Point(x + 190, y + 175);
                mvgr.DrawLine(bluepen, linex, liney);


                int Firstint = 240;
                int Secondint = 60;
                for (int i = 1; i < 5; i++)
                {
                    bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    Secondint = Secondint + 70;
                    Point First = new Point(Firstint, Secondint);
                    Point Second = new Point(Firstint, (Secondint) + 20);
                    mvgr.DrawLine(bluepen, First, Second);
                }
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                Point lastFirst = new Point(240, 410);
                Point lastSecond = new Point(240, 460);
                mvgr.DrawLine(bluepen, lastFirst, lastSecond);

                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                Point data1 = new Point(85, 271);
                Point data2 = new Point(85, 280);
                mvgr.DrawLine(bluepen, data1, data2);
                Point data3 = new Point(230, 280);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data2, data3);


                Point data4 = new Point(85, 341);
                Point data5 = new Point(85, 373);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                mvgr.DrawLine(bluepen, data4, data5);
                Point data6 = new Point(185, 373);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data5, data6);

                Point data7 = new Point(290, 314);
                Point data8 = new Point(400, 150);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data8, data7);

                Point data9 = new Point(300, 490);
                Point data10 = new Point(400, 490);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data10, data9);

                mvgr.DrawRectangle(blackpen, new Rectangle(190, 80, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 150, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 220, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 290, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 360, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(180, 460, 120, 70));

            


        }

    private void panel4_Paint(object sender, PaintEventArgs e)
        {

                Graphics mvgr = panel4.CreateGraphics();

                Pen blackpen = new Pen(Color.Black, 2);
                Pen bluepen = new Pen(Color.SkyBlue, 3);

                mvgr.DrawRectangle(blackpen, new Rectangle(40, 150, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(40, 220, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(40, 290, 100, 50));
                int x = 0, y = 0;
                Point linex = new Point(x + 141, y + 175);
                Point liney = new Point(x + 190, y + 175);
                mvgr.DrawLine(bluepen, linex, liney);


                int Firstint = 240;
                int Secondint = 60;
                for (int i = 1; i < 5; i++)
                {
                    bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    Secondint = Secondint + 70;
                    Point First = new Point(Firstint, Secondint);
                    Point Second = new Point(Firstint, (Secondint) + 20);
                    mvgr.DrawLine(bluepen, First, Second);
                }
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                Point lastFirst = new Point(240, 410);
                Point lastSecond = new Point(240, 460);
                mvgr.DrawLine(bluepen, lastFirst, lastSecond);

                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                Point data1 = new Point(85, 271);
                Point data2 = new Point(85, 280);
                mvgr.DrawLine(bluepen, data1, data2);
                Point data3 = new Point(230, 280);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data2, data3);


                Point data4 = new Point(85, 341);
                Point data5 = new Point(85, 373);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                mvgr.DrawLine(bluepen, data4, data5);
                Point data6 = new Point(185, 373);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data5, data6);

                Point data7 = new Point(290, 314);
                Point data8 = new Point(400, 150);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data8, data7);

                Point data9 = new Point(300, 490);
                Point data10 = new Point(400, 490);
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                mvgr.DrawLine(bluepen, data10, data9);

                mvgr.DrawRectangle(blackpen, new Rectangle(190, 80, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 150, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 220, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 290, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(190, 360, 100, 50));
                mvgr.DrawRectangle(blackpen, new Rectangle(180, 460, 120, 70));
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
       
            Graphics mvgr = panel5.CreateGraphics();

            Pen blackpen = new Pen(Color.Black, 2);
            Pen bluepen = new Pen(Color.SkyBlue, 3);

            mvgr.DrawRectangle(blackpen, new Rectangle(40, 150, 100, 50));
            mvgr.DrawRectangle(blackpen, new Rectangle(40, 220, 100, 50));
            mvgr.DrawRectangle(blackpen, new Rectangle(40, 290, 100, 50));
            int x = 0, y = 0;
            Point linex = new Point(x + 141, y + 175);
            Point liney = new Point(x + 190, y + 175);
            mvgr.DrawLine(bluepen, linex, liney);


            int Firstint = 240;
            int Secondint = 60;
            for (int i = 1; i < 5; i++)
            {
                bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                Secondint = Secondint + 70;
                Point First = new Point(Firstint, Secondint);
                Point Second = new Point(Firstint, (Secondint) + 20);
                mvgr.DrawLine(bluepen, First, Second);
            }
            bluepen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            Point lastFirst = new Point(240, 410);
            Point lastSecond = new Point(240, 460);
            mvgr.DrawLine(bluepen, lastFirst, lastSecond);

            bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            Point data1 = new Point(85, 271);
            Point data2 = new Point(85, 280);
            mvgr.DrawLine(bluepen, data1, data2);
            Point data3 = new Point(230, 280);
            bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            mvgr.DrawLine(bluepen, data2, data3);


            Point data4 = new Point(85, 341);
            Point data5 = new Point(85, 373);
            bluepen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
            mvgr.DrawLine(bluepen, data4, data5);
            Point data6 = new Point(185, 373);
            bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            mvgr.DrawLine(bluepen, data5, data6);

            Point data7 = new Point(290, 314);
            Point data8 = new Point(400, 150);
            bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            mvgr.DrawLine(bluepen, data8, data7);

            Point data9 = new Point(300, 490);
            Point data10 = new Point(400, 490);
            bluepen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            mvgr.DrawLine(bluepen, data10, data9);

            mvgr.DrawRectangle(blackpen, new Rectangle(190, 80, 100, 50));
            mvgr.DrawRectangle(blackpen, new Rectangle(190, 150, 100, 50));
            mvgr.DrawRectangle(blackpen, new Rectangle(190, 220, 100, 50));
            mvgr.DrawRectangle(blackpen, new Rectangle(190, 290, 100, 50));
            mvgr.DrawRectangle(blackpen, new Rectangle(190, 360, 100, 50));
            mvgr.DrawRectangle(blackpen, new Rectangle(180, 460, 120, 70));
            paintingstart = false;
        
        }

        

      

        private void comboBox_EncCorrection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.EncoderCorrection = comboBox_EncCorrection1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncCorrection1.BackColor = Color.Red;
            }
        }

        private void comboBox_CondFactor0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.ConditionFactor = (ConditionFactorConstants)comboBox_CondFactor0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_CondFactor0.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderType0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.EncoderType = (EncoderTypeConstants)comboBox_EncoderType0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderType0.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerOut0_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(0);
                tc.TriggerOut = (TriggerOutOperatorConstants)comboBox_TriggerOut0.SelectedIndex;
                comm.SetTriggerControl(0, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerOut0.BackColor = Color.Red;
            }
        }

        private void PushMouseMeun_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void dI0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Save File";
            savefile.FileName = "data.ini";
            savefile.Filter = "구성 요소 (*.ini)| * ini| 모든파일 (*.*)|*.*";


            DialogResult showdilog = savefile.ShowDialog();

            if (showdilog == DialogResult.OK)
            {
                string filename = savefile.FileName;
                comm.SaveToFile(filename);
            }
            else {
                return;
            }

           
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadfile = new OpenFileDialog();
            loadfile.Title = "Load File";
            loadfile.FileName = "";
            loadfile.Filter = "구성 요소 (*.ini)| * ini| 모든파일 (*.*)|*.*";
            DialogResult showdilog = loadfile.ShowDialog();

            if (showdilog == DialogResult.OK)
            {
                string filename = loadfile.FileName;
                comm.LoadFromFile(filename);
            }
            else
            {
                return;
            }

           
        }

        

        private void comboBox_EncoderDirectionFactor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.EncoderDirectionFactor = (EncoderDirectionFactorConstants)comboBox_EncoderDirectionFactor1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderDirectionFactor1.BackColor = Color.Red;
            }
        }

        private void comboBox_CondFactor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.ConditionFactor = (ConditionFactorConstants)comboBox_CondFactor1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_CondFactor1.BackColor = Color.Red;
            }
        }

        private void comboBox_Encoderchannel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.EncoderChannel = comboBox_Encoderchannel1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_Encoderchannel1.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.EncoderType = (EncoderTypeConstants)comboBox_EncoderType1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderType1.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderMulti1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.Multi = (int)comboBox_EncoderMulti1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderMulti1.BackColor = Color.Red;
            }
        }
        private void comboBox_TriggerPositionDirection1sub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants)comboBox_TriggerPositionDirection1sub.SelectedIndex;
                comm.SetTriggerControl(1, tc);
                comboBox_TriggerPositionDirection1.SelectedIndex = comboBox_TriggerPositionDirection1sub.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection1sub.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerOut1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.TriggerOut = (TriggerOutOperatorConstants)comboBox_TriggerOut1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerOut1.BackColor = Color.Red;
            }
        }
        private void comboBox_TriggerPositionDirection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants)comboBox_TriggerPositionDirection1.SelectedIndex;
                comm.SetTriggerControl(1, tc);
                comboBox_TriggerPositionDirection1sub.SelectedIndex = comboBox_TriggerPositionDirection1.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection1.BackColor = Color.Red;
            }

        }

        private void checkBox_unit1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
                comm.SetUnit((uint)(checkBox_unit1.Checked ? 1 : 0));
                if (checkBox_unit1.Checked == true)
                {
                    checkBox_unit1.BackColor = Color.White;
                    checkBox_unit0.Text = "㎛";
                    checkBox_unit1.Text = "㎛";
                    checkBox_unit2.Text = "㎛";
                    checkBox_unit3.Text = "㎛";
                    Visibledata();
                    numericUpDown_StartPosition1.Value = comm.GetTriggerPositionStart(1);
                    numericUpDown_EndPosition1.Value = comm.GetTriggerPositionEnd(1);
                }
                else
                {
                    checkBox_unit1.BackColor = Color.White;
                    checkBox_unit0.Text = "Count";
                    checkBox_unit1.Text = "Count";
                    checkBox_unit2.Text = "Count";
                    checkBox_unit3.Text = "Count";
                    Visibledata();
                    numericUpDown_StartPosition1.Value = comm.GetTriggerPositionStart(1);
                    numericUpDown_EndPosition1.Value = comm.GetTriggerPositionEnd(1);
                }
            }
            catch (System.Exception ex)
            {
                checkBox_unit1.BackColor = Color.Red;
            }
        }

        private void numericUpDown_StartPosition1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionStart(1, (int)numericUpDown_StartPosition1.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_StartPosition1.BackColor = Color.Red;
            }
        }

        private void numericUpDown_EndPosition1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionStart(1, (int)numericUpDown_EndPosition0.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_EndPosition0.BackColor = Color.Red;
            }
        }

        private void button_PositionClear1_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(1);
        }
        private void numericUpDown_High1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(1);
                tg.PulseHigh = (int)numericUpDown_High1.Value;
                comm.SetTriggerGenerator(1, tg);
                label_High1.Text = numericUpDown_High1.Value.ToString();

            }
            catch (System.Exception ex)
            {
                numericUpDown_High1.BackColor = Color.Red;
            }
        }

        private void checkBox_Triggerbase1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(1);
                int x = checkBox_Triggerbase1.Checked ? 1 : 0;
                tc.TriggerBase = ((TriggerBaseConstants)(checkBox_Triggerbase1.Checked ? 1 : 0));
                comm.SetTriggerControl(1, tc);

                if (checkBox_Triggerbase1.Checked == true)
                {
                    checkBox_Triggerbase1.Text = "Distance";
                }
                else
                {
                    checkBox_Triggerbase1.Text = "Count";
                }
            }
            catch (System.Exception ex)
            {

                checkBox_Triggerbase1.BackColor = Color.Red;
            }
        }

        private void numericUpDown_Cycle1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(1);
                tg.Cycle = (int)numericUpDown_Cycle1.Value;
                comm.SetTriggerGenerator(1, tg);
                label_Cycle1.Text = numericUpDown_Cycle1.Value.ToString();
            }
            catch (System.Exception ex)
            {
                numericUpDown_Cycle1.BackColor = Color.Red;
            }
        }

        private void comboBox_EncCorrection2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.EncoderCorrection = comboBox_EncCorrection2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
                
            }
            catch (System.Exception ex)
            {
                comboBox_EncCorrection2.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderDirectionFactor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.EncoderDirectionFactor = (EncoderDirectionFactorConstants)comboBox_EncoderDirectionFactor2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderDirectionFactor2.BackColor = Color.Red;
            }
        }

        private void comboBox_CondFactor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.ConditionFactor = (ConditionFactorConstants)comboBox_CondFactor2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_CondFactor2.BackColor = Color.Red;
            }
        }

        private void comboBox_Encoderchannel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.EncoderChannel = comboBox_Encoderchannel2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_Encoderchannel2.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.EncoderType = (EncoderTypeConstants)comboBox_EncoderType2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderType2.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderMulti2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.Multi = (int)comboBox_EncoderMulti2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderMulti2.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerPositionDirection2sub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants)comboBox_TriggerPositionDirection1sub.SelectedIndex;
                comm.SetTriggerControl(2, tc);
                comboBox_TriggerPositionDirection2.SelectedIndex = comboBox_TriggerPositionDirection2sub.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection2sub.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerOut2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.TriggerOut = (TriggerOutOperatorConstants)comboBox_TriggerOut2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerOut2.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerPositionDirection2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants)comboBox_TriggerPositionDirection2.SelectedIndex;
                comm.SetTriggerControl(2, tc);
                comboBox_TriggerPositionDirection2sub.SelectedIndex = comboBox_TriggerPositionDirection2.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection2.BackColor = Color.Red;
            }
        }

        private void checkBox_unit2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetUnit((uint)(checkBox_unit2.Checked ? 1 : 0));
                if (checkBox_unit2.Checked == true)
                {
                    checkBox_unit2.BackColor = Color.White;
                    checkBox_unit2.Text = "㎛";
                    Visibledata();
                    numericUpDown_StartPosition2.Value = comm.GetTriggerPositionStart(2);
                    numericUpDown_EndPosition2.Value = comm.GetTriggerPositionEnd(2);
                }
                else
                {
                    checkBox_unit2.BackColor = Color.White;
                    checkBox_unit2.Text = "Count";
                    Visibledata();
                    numericUpDown_StartPosition2.Value = comm.GetTriggerPositionStart(2);
                    numericUpDown_EndPosition2.Value = comm.GetTriggerPositionEnd(2);
                }
            }
            catch (System.Exception ex)
            {
                checkBox_unit2.BackColor = Color.Red;
            }
        }

        private void numericUpDown_StartPosition2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionStart(2, (int)numericUpDown_StartPosition2.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_StartPosition2.BackColor = Color.Red;
            }
        }

        private void numericUpDown_EndPosition2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionEnd(2, (int)numericUpDown_StartPosition2.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_StartPosition2.BackColor = Color.Red;
            }
        }

        private void button_PositionClear2_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(2);
        }

        private void checkBox_Triggerbase2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(2);
                int x = checkBox_Triggerbase2.Checked ? 1 : 0;
                tc.TriggerBase = ((TriggerBaseConstants)(checkBox_Triggerbase2.Checked ? 1 : 0));
                comm.SetTriggerControl(2, tc);

                if (checkBox_Triggerbase2.Checked == true)
                {
                    checkBox_Triggerbase2.Text = "Distance";
                }
                else
                {
                    checkBox_Triggerbase2.Text = "Count";
                }
            }
            catch (System.Exception ex)
            {

                checkBox_Triggerbase2.BackColor = Color.Red;
            }
        }

        private void numericUpDown_High2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(2);
                tg.PulseHigh = (int)numericUpDown_High2.Value;
                comm.SetTriggerGenerator(2, tg);
                label_High2.Text = numericUpDown_High2.Value.ToString();
            }
            catch (System.Exception ex)
            {
                numericUpDown_High2.BackColor = Color.Red;
            }
        }

        private void numericUpDown_Cycle2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(2);
                tg.Cycle = (int)numericUpDown_Cycle2.Value;
                comm.SetTriggerGenerator(2, tg);
                label_Cycle2.Text = numericUpDown_Cycle2.Value.ToString();
            }
            catch (System.Exception ex)
            {
                numericUpDown_Cycle2.BackColor = Color.Red;
            }
        }

        private void comboBox_EncCorrection3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.EncoderCorrection = comboBox_EncCorrection3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncCorrection3.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderDirectionFactor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.EncoderDirectionFactor = (EncoderDirectionFactorConstants)comboBox_EncoderDirectionFactor3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderDirectionFactor3.BackColor = Color.Red;
            }
        }

        private void comboBox_CondFactor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.ConditionFactor = (ConditionFactorConstants)comboBox_CondFactor3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_CondFactor3.BackColor = Color.Red;
            }
        }

        private void comboBox_Encoderchannel3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.EncoderChannel = comboBox_Encoderchannel3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_Encoderchannel3.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.EncoderType = (EncoderTypeConstants)comboBox_EncoderType3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderType3.BackColor = Color.Red;
            }
        }

        private void comboBox_EncoderMulti3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.Multi = (int)comboBox_EncoderMulti3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_EncoderMulti3.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerPositionDirection3sub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants)comboBox_TriggerPositionDirection3sub.SelectedIndex;
                comm.SetTriggerControl(3, tc);
                comboBox_TriggerPositionDirection3.SelectedIndex = comboBox_TriggerPositionDirection3sub.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection3sub.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerOut3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.TriggerOut = (TriggerOutOperatorConstants)comboBox_TriggerOut3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerOut3.BackColor = Color.Red;
            }
        }

        private void checkBox_unit3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetUnit((uint)(checkBox_unit3.Checked ? 1 : 0));
                if (checkBox_unit3.Checked == true)
                {
                    checkBox_unit3.BackColor = Color.White;
                    checkBox_unit0.Text = "㎛";
                    checkBox_unit1.Text = "㎛";
                    checkBox_unit2.Text = "㎛";
                    checkBox_unit3.Text = "㎛";
                    Visibledata();
                    numericUpDown_StartPosition3.Value = comm.GetTriggerPositionStart(3);
                    numericUpDown_EndPosition3.Value = comm.GetTriggerPositionEnd(3);
                }
                else
                {
                    checkBox_unit3.BackColor = Color.White;
                    checkBox_unit0.Text = "Count";
                    checkBox_unit1.Text = "Count";
                    checkBox_unit2.Text = "Count";
                    checkBox_unit3.Text = "Count";
                    Visibledata();
                    numericUpDown_StartPosition3.Value = comm.GetTriggerPositionStart(3);
                    numericUpDown_EndPosition3.Value = comm.GetTriggerPositionEnd(3);
                }
            }
            catch (System.Exception ex)
            {
                checkBox_unit3.BackColor = Color.Red;
            }
        }

        private void comboBox_TriggerPositionDirection3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                tc.TriggerDirectionality = (TriggerDirectionalityConstants)comboBox_TriggerPositionDirection3.SelectedIndex;
                comm.SetTriggerControl(3, tc);
                comboBox_TriggerPositionDirection3sub.SelectedIndex = comboBox_TriggerPositionDirection3.SelectedIndex;
            }
            catch (System.Exception ex)
            {
                comboBox_TriggerPositionDirection2.BackColor = Color.Red;
            }
        }

        private void numericUpDown_StartPosition3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionStart(3, (int)numericUpDown_StartPosition3.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_StartPosition3.BackColor = Color.Red;
            }
        }

        private void numericUpDown_EndPosition3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                comm.SetTriggerPositionEnd(3, (int)numericUpDown_StartPosition3.Value);
            }
            catch (System.Exception ex)
            {
                numericUpDown_StartPosition3.BackColor = Color.Red;
            }
        }

        private void button_PositionClear3_Click(object sender, EventArgs e)
        {
            comm.ClearEncoderPosition(3);
        }

        private void checkBox_Triggerbase3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerControl tc = comm.GetTriggerControl(3);
                int x = checkBox_Triggerbase3.Checked ? 1 : 0;
                tc.TriggerBase = ((TriggerBaseConstants)(checkBox_Triggerbase3.Checked ? 1 : 0));
                comm.SetTriggerControl(3, tc);

                if (checkBox_Triggerbase3.Checked == true)
                {
                    checkBox_Triggerbase3.Text = "Distance";
                }
                else
                {
                    checkBox_Triggerbase3.Text = "Count";
                }
            }
            catch (System.Exception ex)
            {

                checkBox_Triggerbase3.BackColor = Color.Red;
            }
        }

        private void numericUpDown_High3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(3);
                tg.PulseHigh = (int)numericUpDown_High3.Value;
                comm.SetTriggerGenerator(3, tg);
                label_High3.Text = numericUpDown_High3.Value.ToString();
            }
            catch (System.Exception ex)
            {
                numericUpDown_High3.BackColor = Color.Red;
            }
        }

        private void numericUpDown_Cycle3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerGenerator tg = comm.GetTriggerGenerator(3);
                tg.Cycle = (int)numericUpDown_Cycle3.Value;
                comm.SetTriggerGenerator(3, tg);
                label_Cycle3.Text = numericUpDown_Cycle3.Value.ToString();
            }
            catch (System.Exception ex)
            {
                numericUpDown_Cycle3.BackColor = Color.Red;
            }
        }

        private void checkBox_ScopeStart_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
