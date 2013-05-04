using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

//using System.Text.UnicodeEncoding;

using FTD2XX_NET;

//using FT_HANDLE = System.UInt32;

namespace PID_Config
{
    public partial class PID_config : Form
    {
        protected Thread pThreadRead;

        string InputData = String.Empty;
        string[] ParsedData = null;
        //int p_val, i_val, d_val;
        int scroll_pitch, scroll_roll, scroll_yaw;
        
        // Load images
        Bitmap mybitmap1 = new Bitmap(RS232.Properties.Resources.horizon);
        Bitmap mybitmap2 = new Bitmap(RS232.Properties.Resources.bezel);
        Bitmap mybitmap3 = new Bitmap(RS232.Properties.Resources.heading);
        Bitmap mybitmap4 = new Bitmap(RS232.Properties.Resources.wings);
        
        double PitchAngle = 0, RollAngle = 0, YawAngle = 0;
        
        double pTerm = 0, iTerm = 0, dTerm = 0;
        double pGain = 0, iGain = 0, dGain = 0;

        double leftMotGain=1.0, rightMotGain=1.0;
        double leftRPM = 0, rightRPM = 0;
        int leftPosition, rightPosition;

        int numCommands = 0;
        double delta_t = 0;
        double zero_ang = 0;

        Point ptBoule = new Point(-25, -410); //Ground-Sky initial location
        Point ptHeading = new Point(-592, 150); // Heading ticks
        Point ptRotation = new Point(150, 150); // Point of rotation

        FileStream fileStream;
        UnicodeEncoding uniEncoding;

        int accel_x, accel_z;
        int gyro_y;
        double R;
        double accel_pitch_ang;
        double filtered_ang;
        
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control:
        delegate void SetTextCallback(string text);

        public PID_config()
        {
            InitializeComponent();

            uniEncoding = new UnicodeEncoding();
            
            string[] bauds = {"115200", "57600", "38400", "19200", "9600"};

            foreach (string baud in bauds)
            {
                cmbBaudSelect.Items.Add(baud);
            }
            cmbBaudSelect.Text = bauds[0];
            // Nice methods to browse all available ports:
            string[] ports = SerialPort.GetPortNames();

            // Add all port names to the combo box:
            foreach (string port in ports)
            {
                cmbComSelect.Items.Add(port);
            }
            
            // This bit of code (using double buffer) reduces flicker from Refresh commands
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //////////// END "reduce flicker" code ///////
        }
        private void PID_config_FormClosing(object sender, FormClosingEventArgs e)
        {
            pThreadRead.Abort();
        }
        private void PID_config_Load(object sender, EventArgs e)
        {
            mybitmap2.MakeTransparent(Color.Yellow); // Sets image transparency
            mybitmap3.MakeTransparent(Color.Black); // Sets image transparency
            mybitmap4.MakeTransparent(Color.Yellow); // Sets image transparency

            pThreadRead = new Thread(new ThreadStart(ReadThread));
            
            openPort.Enabled = true;
            closePort.Enabled = false;
            pThreadRead.Start();
            stsStatus.Text = "Closed...";
            P_send.Enabled = false;
            I_send.Enabled = false;
            D_send.Enabled = false;
            Z_send.Enabled = false;
            ALL_send.Enabled = false;
            ZERO_ALL_send.Enabled = false;

            p_increase_textBox.Text = "5";
            p_send_checkBox.Checked = true;
            i_increase_textBox.Text = ".1";
            i_send_checkBox.Checked = true;
            d_increase_textBox.Text = ".1";
            d_send_checkBox.Checked = true;
            z_increase_textBox.Text = ".1";
            z_send_checkBox.Checked = true;

            left_mot_text_box.Text = "1.0";
            mot_L_increase_textBox.Text = "0.01";
            left_mot_send_checkbox.Checked = true;
            right_mot_text_box.Text = "1.0";
            mot_R_increase_textBox.Text = "0.01";
            right_mot_send_checkbox.Checked = true;
        }
        
        int loopCnt, loop_cnt;
        private unsafe void ReadThread()
        {
            
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (true)
            {
                loopCnt++;
                SetMult2Text(loopCnt.ToString());
                if (port.IsOpen == true)
                {
                    try { InputData = port.ReadLine(); }
                    catch { continue; }

                    if (logging_checkBox.Checked)
                    {
                        try
                        {
                            fileStream.Write(uniEncoding.GetBytes(InputData), 0, uniEncoding.GetByteCount(InputData));
                        }
                        catch { }
                    }

                    ParsedData = InputData.Split(';');

                    try { numCommands = Convert.ToInt16(ParsedData[1]); }
                    catch { continue; }

                    if (numCommands != ParsedData.Length)
                        continue;

                    SetText(InputData);

                    switch (ParsedData[0])
                    {
                        case "DBG":
                            try { accel_x = Convert.ToInt32(ParsedData[2]); }
                            catch { }
                            try { accel_z = Convert.ToInt32(ParsedData[3]); }
                            catch { }
                            try { gyro_y = Convert.ToInt32(ParsedData[4]); }
                            catch { }
                            try { R = Convert.ToDouble(ParsedData[5]); }
                            catch { }
                            try { accel_pitch_ang = Convert.ToDouble(ParsedData[6]); }
                            catch { }
                            try { PitchAngle = Convert.ToDouble(ParsedData[7]); }
                            catch { }
                            try { delta_t = Convert.ToDouble(ParsedData[8]); }
                            catch { }

                
                            //loopCnt = 0;

                            //SetPText(pGain.ToString());
                            //SetIText(iGain.ToString());
                            //SetDText(dGain.ToString());
                            //SetZText(zero_ang.ToString());

                            break;

                        case "PARAMS":
                            try { pGain = Convert.ToDouble(ParsedData[2]); }
                            catch { }
                            try { iGain = Convert.ToDouble(ParsedData[3]); }
                            catch { } 
                            try { dGain = Convert.ToDouble(ParsedData[4]); }
                            catch { }
                            try { zero_ang = Convert.ToDouble(ParsedData[5]); }
                            catch { }

                            loopCnt = 0;

                            SetPText(pGain.ToString());
                            SetIText(iGain.ToString());
                            SetDText(dGain.ToString());
                            SetZText(zero_ang.ToString());
                            
                            break;

                        case "UPDATE":
                            try { PitchAngle = Convert.ToDouble(ParsedData[2]); }
                            catch { }
                            try { pTerm = Convert.ToDouble(ParsedData[4]); }
                            catch { }
                            try { iTerm = Convert.ToDouble(ParsedData[5]); }
                            catch { }
                            try { dTerm = Convert.ToDouble(ParsedData[6]); }
                            catch { }
                            try { delta_t = Convert.ToDouble(ParsedData[7]); }
                            catch { }
                            /*
                            try { velocity = Convert.ToInt32(ParsedData[8])*100.0*60.0/1856.0; }
                            catch { }
                            */
                            try { loop_cnt = Convert.ToInt32(ParsedData[9]); }
                            catch { }

                            SetPitchText(PitchAngle.ToString());
                            SetPtermText(pTerm.ToString());
                            SetItermText(iTerm.ToString());
                            SetDtermText(dTerm.ToString());
                            
                            SetMult1Text(loop_cnt.ToString());
                           
                            break;

                        default:
                            break;
                    }

                    Invalidate();
                    
                }
            }
        }
       
        #region[Graphics]
        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            // Calling the base class OnPaint
            base.OnPaint(paintEvnt);


            // Clipping mask for Attitude Indicator
            paintEvnt.Graphics.Clip = new Region(new Rectangle(0, 0, 300, 300));
            paintEvnt.Graphics.FillRegion(Brushes.Black, paintEvnt.Graphics.Clip);


            // Make sure lines are drawn smoothly
            paintEvnt.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            // Create the graphics object
            Graphics gfx = paintEvnt.Graphics;

            // Adjust and draw horizon image
            RotateAndTranslate(paintEvnt, mybitmap1, RollAngle, 0, ptBoule, (double)(4 * PitchAngle), ptRotation, 1);

            RotateAndTranslate2(paintEvnt, mybitmap3, YawAngle, RollAngle, 0, ptHeading, (double)(4 * PitchAngle), ptRotation, 1);



            // Draw a mask
            //Pen maskPen = new Pen(this.BackColor, 220); // width of mask
            //gfx.DrawRectangle(maskPen, -100, -100, 500, 500); // size of mask

            gfx.DrawImage(mybitmap2, 0, 0); // Draw bezel image
            gfx.DrawImage(mybitmap4, 75, 125); // Draw wings image
            
            //myPen = new Pen(System.Drawing.Color.Green, 3);
            //gfx.DrawLine(myPen, 200, 20, 20, 210); // Draw a line

            // The sliders are updated from the Pitch, Roll & Yaw values (calculated first from serial data)
            //slider1.Value = Convert.ToInt16(PitchAngle); //Update sliders
            //slider2.Value = Convert.ToInt16((-1.0 * RollAngle / Math.PI) * 180);  //with values from
            //slider3.Value = Convert.ToInt16((YawAngle / Math.PI) * 180);   //serial data (if available)           

            // Update text boxes with angles (if we have any)

            /*
            if (port.IsOpen == false) // Use slider values if port is closed
            {
                textBox1.Text = Convert.ToString(slider1.Value);
                textBox2.Text = Convert.ToString(slider2.Value);
                textBox3.Text = Convert.ToString(slider3.Value);
            }

            if (ArduinoData != null && port.IsOpen==true) // Use Arduino data if port is open
            {
                textBox1.Text = ArduinoData[0];
                textBox2.Text = ArduinoData[1];
                textBox3.Text = ArduinoData[2];
            }
            */
        }
        protected void RotateAndTranslate(PaintEventArgs pe, Image img, Double alphaRot, Double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;

            // Rotation

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }

                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta)));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translation

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Rotate image support
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Dispay image
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            //pe.Graphics.DrawImage(
            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }
        protected void RotateAndTranslate2(PaintEventArgs pe, Image img, Double yawRot, Double alphaRot, Double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;

            // Rotation

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }

                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta) + yawRot));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translation

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Rotate image support
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Dispay image
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }
        
        private void pitch_trackBar_Scroll(object sender, EventArgs e)
        {
            scroll_pitch = pitch_trackBar.Value;
            PitchAngle = scroll_pitch;
            pitch_textBox.Text = scroll_pitch.ToString();
            Invalidate();
        }
        private void pitch_textBox_TextChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                pitch_trackBar.Value = Convert.ToInt32(pitch_textBox.Text);
            }
            catch
            {
                pitch_textBox.Clear();
            }
            finally
            {
                scroll_pitch = pitch_trackBar.Value;
                PitchAngle = scroll_pitch;
                Invalidate();
            }
            */
        }
        
       
        #endregion
        #region[Unused]
        private void cmbComSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }
        private void cmbBaudSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            port.BaudRate = Convert.ToInt32(cmbBaudSelect.SelectedItem);
        }
        #endregion
        #region[Comm]
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }
        private unsafe void openPort_Click(object sender, EventArgs e)
        {
            if (port.IsOpen) 
                port.Close();
            
            port.PortName = cmbComSelect.SelectedItem.ToString();
            
            // try to open the selected port:
            try
            {
                port.Open();
                port.ReadTimeout = 50;
                
            }
            // give a message, if the port is not available:
            catch
            {
                MessageBox.Show("Serial port " + port.PortName + " cannot be opened!", "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbComSelect.SelectedText = "";
                stsStatus.Text = "Select serial port!";
            }

            if(port.IsOpen)
            {
                P_send.Enabled = true;
                I_send.Enabled = true;
                D_send.Enabled = true;
                Z_send.Enabled = true;
                ALL_send.Enabled = true;
                ZERO_ALL_send.Enabled = true;
                openPort.Enabled = false;
                closePort.Enabled = true;
                cmbComSelect.Enabled = false;
                cmbBaudSelect.Enabled = false;
                pitch_trackBar.Enabled = false;
                stsStatus.Text = port.PortName + " : " + port.BaudRate + " : " + port.DataBits + " : " + port.Parity + " : " + port.StopBits;
                
            }
        }
        private void closePort_Click(object sender, EventArgs e)
        {
            // Close our device
            try
            {
                port.Close();
            }
            catch
            {
                MessageBox.Show("Can't close the port!");
            }
            
            if(!port.IsOpen)
            {
                P_send.Enabled = false;
                I_send.Enabled = false;
                D_send.Enabled = false;
                Z_send.Enabled = false;
                ALL_send.Enabled = false;
                ZERO_ALL_send.Enabled = false; 
                openPort.Enabled = true;
                closePort.Enabled = false;
                cmbBaudSelect.Enabled = true;
                cmbComSelect.Enabled = true;
                pitch_trackBar.Enabled = true; 
                stsStatus.Text = "Closed...";
            }
            
        }
        private unsafe void btnSend_Click(object sender, EventArgs e)
        {
            

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIn.Clear();
        }
        #endregion
        #region Text Setters
        /* To make a thread-safe call a Windows Forms control:

        1.  Query the control's InvokeRequired property.
        2.  If InvokeRequired returns true,  call Invoke with a delegate that makes the actual call to the control.
        3.  If InvokeRequired returns false, call the control directly.

        In the following code example, this logic is implemented in a utility method called SetText. 
        A delegate type named SetTextDelegate encapsulates the SetText method. 
        When the TextBox control's InvokeRequired returns true, the SetText method creates an instance
        of SetTextDelegate and calls the form's Invoke method. 
        This causes the SetText method to be called on the thread that created the TextBox control,
        and in this thread context the Text property is set directly

        also see: http://msdn2.microsoft.com/en-us/library/ms171728(VS.80).aspx
        
        This method demonstrates a pattern for making thread-safe
        calls on a Windows Forms control. 
        If the calling thread is different from the thread that
        created the TextBox control, this method creates a
        SetTextCallback and calls itself asynchronously using the
        Invoke method.
        If the calling thread is the same as the thread that created
        the TextBox control, the Text property is set directly. */
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else this.txtIn.Text = text;
        }
        private void SetPText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.P_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetPText);
                this.Invoke(d, new object[] { text });
            }
            else this.P_text_box.Text = text;
        }
        private void SetIText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.I_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetIText);
                this.Invoke(d, new object[] { text });
            }
            else this.I_text_box.Text = text;
        }
        private void SetDText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.D_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetDText);
                this.Invoke(d, new object[] { text });
            }
            else this.D_text_box.Text = text;
        }
        private void SetZText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Z_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetZText);
                this.Invoke(d, new object[] { text });
            }
            else this.Z_text_box.Text = text;
        }
        private void SetPtermText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.P_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetPtermText);
                this.Invoke(d, new object[] { text });
            }
            else this.pTerm_text_box.Text = text;
        }
        private void SetItermText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.I_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetItermText);
                this.Invoke(d, new object[] { text });
            }
            else this.iTerm_text_box.Text = text;
        }
        private void SetDtermText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.D_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetDtermText);
                this.Invoke(d, new object[] { text });
            }
            else this.dTerm_text_box.Text = text;
        }
        private void SetMText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.D_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMText);
                this.Invoke(d, new object[] { text });
            }
            else this.m_text_box.Text = text;
        }
        private void SetPitchText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.pitch_textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetPitchText);
                this.Invoke(d, new object[] { text });
            }
            else this.pitch_textBox.Text = text;
        }
        private void SetOutputText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetOutputText);
                this.Invoke(d, new object[] { text });
            }
            else this.txtOut.Text = text;
        }

        private void SetLeftRPMText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.velocity_left_textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLeftRPMText);
                this.Invoke(d, new object[] { text });
            }
            else this.velocity_left_textBox.Text = text;
        }
        private void SetRightRPMText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.velocity_right_textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetRightRPMText);
                this.Invoke(d, new object[] { text });
            }
            else this.velocity_right_textBox.Text = text;
        }
        private void SetLeftPosText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.right_pos_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetRightPosText);
                this.Invoke(d, new object[] { text });
            }
            else this.left_pos_text_box.Text = text;
        }
        private void SetRightPosText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.right_pos_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetRightPosText);
                this.Invoke(d, new object[] { text });
            }
            else this.right_pos_text_box.Text = text;
        }
        private void SetLeftMotText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.left_pos_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetLeftMotText);
                this.Invoke(d, new object[] { text });
            }
            else this.left_mot_text_box.Text = text;
        }
        private void SetRightMotText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.right_pos_text_box.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetRightMotText);
                this.Invoke(d, new object[] { text });
            }
            else this.right_mot_text_box.Text = text;
        }
        
        private void SetMult1Text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMult1Text);
                this.Invoke(d, new object[] { text });
            }
            else this.mult1_textBox.Text = text;
        }
        private void SetMult2Text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMult2Text);
                this.Invoke(d, new object[] { text });
            }
            else this.mult2_textBox.Text = text;
        }
        private void SetMult3Text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMult3Text);
                this.Invoke(d, new object[] { text });
            }
            else this.mult3_textBox.Text = text;
        }
        private void SetMult4Text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMult4Text);
                this.Invoke(d, new object[] { text });
            }
            else this.mult4_textBox.Text = text;
        }
        #endregion
        #region[Buttons]
        private void P_send_Click(object sender, EventArgs e)
        {
            String output = "P;" + (pGain * 1).ToString() + "\r";
            if(port.IsOpen == true)
                port.WriteLine(output);
            SetOutputText(output);
            
        }
        private void I_send_Click(object sender, EventArgs e)
        {
            String output = "I;" + (iGain * 1).ToString() + "\r";
            if (port.IsOpen == true)
                port.WriteLine(output);
            SetOutputText(output);
            
        }
        private void D_send_Click(object sender, EventArgs e)
        {
            String output = "D;" + (dGain * 1).ToString() + "\r";
            if (port.IsOpen == true)
                port.WriteLine(output);
            SetOutputText(output);
            
        }
        private void Z_send_Click(object sender, EventArgs e)
        {
            String output = "ANG;" + (zero_ang * 100.0).ToString() + "\r";
            if (port.IsOpen == true)
                port.WriteLine(output);
            SetOutputText(output);

        }
        private void ALL_send_Click(object sender, EventArgs e)
        {
            String output = "PID;" + (pGain * 100).ToString() + ";" + (iGain * 100).ToString() + ";" + (dGain * 100).ToString() + "\r";
            if (port.IsOpen == true)
                port.WriteLine(output);
            SetOutputText(output);
            
        }
        private void ZERO_ALL_send_Click(object sender, EventArgs e)
        {
            String output = "ZERO\r";
            if (port.IsOpen == true)
                port.WriteLine(output);
            SetOutputText(output);

        }
        private void p_plus_Click(object sender, EventArgs e)
        {
            try { pGain += Convert.ToDouble(p_increase_textBox.Text); }
            catch { }
            SetPText(pGain.ToString());
            if (p_send_checkBox.Checked)
            {
                String output = "P;" + (pGain * 100).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void p_minus_Click(object sender, EventArgs e)
        {
            try { pGain -= Convert.ToDouble(p_increase_textBox.Text); }
            catch { }
            SetPText(pGain.ToString());
            if (p_send_checkBox.Checked)
            {
                String output = "P;" + (pGain * 100).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void i_plus_Click(object sender, EventArgs e)
        {
            try { iGain += Convert.ToDouble(i_increase_textBox.Text); }
            catch { }
            SetIText(iGain.ToString());
            if (i_send_checkBox.Checked)
            {
                String output = "I;" + (iGain * 100).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void i_minus_Click(object sender, EventArgs e)
        {
            try { iGain -= Convert.ToDouble(i_increase_textBox.Text); }
            catch { }
            SetIText(iGain.ToString());
            if (i_send_checkBox.Checked)
            {
                String output = "I;" + (iGain * 100).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void d_plus_Click(object sender, EventArgs e)
        {
            try { dGain += Convert.ToDouble(d_increase_textBox.Text); }
            catch { }
            SetDText(dGain.ToString());
            if (d_send_checkBox.Checked)
            {
                String output = "D;" + (dGain * 100).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void d_minus_Click(object sender, EventArgs e)
        {
            try { dGain -= Convert.ToDouble(d_increase_textBox.Text); }
            catch { }
            SetDText(dGain.ToString());
            if (d_send_checkBox.Checked)
            {
                String output = "D;" + (dGain * 100).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void z_plus_Click(object sender, EventArgs e)
        {
            try { zero_ang += Convert.ToDouble(z_increase_textBox.Text); }
            catch { }
            SetZText(zero_ang.ToString());
            if (z_send_checkBox.Checked)
            {
                String output = "ANG;" + (zero_ang * 1000.0).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void z_minus_Click(object sender, EventArgs e)
        {
            try { zero_ang -= Convert.ToDouble(z_increase_textBox.Text); }
            catch { }
            SetZText(zero_ang.ToString());
            if (z_send_checkBox.Checked)
            {
                String output = "ANG;" + (zero_ang * 1000.0).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }

        private void left_pos_plus_Click(object sender, EventArgs e)
        {

        }
        private void left_pos_minus_Click(object sender, EventArgs e)
        {

        }
        private void right_pos_plus_Click(object sender, EventArgs e)
        {

        }
        private void right_pos_minus_Click(object sender, EventArgs e)
        {

        }
        private void left_mot_plus_Click(object sender, EventArgs e)
        {
            try { leftMotGain += Convert.ToDouble(mot_L_increase_textBox.Text); }
            catch { }
            SetLeftMotText(leftMotGain.ToString());
            if (left_mot_send_checkbox.Checked)
            {
                String output = "MOTL;" + (leftMotGain).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
  
        }
        private void left_mot_minus_Click(object sender, EventArgs e)
        {
            try { leftMotGain -= Convert.ToDouble(mot_L_increase_textBox.Text); }
            catch { }
            SetLeftMotText(leftMotGain.ToString());
            if (left_mot_send_checkbox.Checked)
            {
                String output = "MOTL;" + (leftMotGain).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void right_mot_plus_Click(object sender, EventArgs e)
        {
            try { rightMotGain += Convert.ToDouble(mot_R_increase_textBox.Text); }
            catch { }
            SetRightMotText(rightMotGain.ToString());
            if (right_mot_send_checkbox.Checked)
            {
                String output = "MOTR;" + (rightMotGain).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }

        }
        private void right_mot_minus_Click(object sender, EventArgs e)
        {
            try { rightMotGain -= Convert.ToDouble(mot_R_increase_textBox.Text); }
            catch { }
            SetRightMotText(rightMotGain.ToString());
            if (right_mot_send_checkbox.Checked)
            {
                String output = "MOTR;" + (rightMotGain).ToString() + "\r";
                if (port.IsOpen == true)
                    port.WriteLine(output);
                SetOutputText(output);
            }
        }
        private void left_pos_send_Click(object sender, EventArgs e)
        {

        }
        private void right_pos_send_Click(object sender, EventArgs e)
        {

        }
        private void left_mot_send_Click(object sender, EventArgs e)
        {

        }
        private void right_mot_send_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void P_text_box_TextChanged(object sender, EventArgs e)
        {
            try { pGain = Convert.ToDouble(P_text_box.Text); }
            catch { P_text_box.Clear(); }
        }
        private void I_text_box_TextChanged(object sender, EventArgs e)
        {
            try { iGain = Convert.ToDouble(I_text_box.Text); }
            catch { I_text_box.Clear(); }
            
        }
        private void D_text_box_TextChanged(object sender, EventArgs e)
        {
            try { dGain = Convert.ToDouble(D_text_box.Text); }
            catch { D_text_box.Clear(); }
        }
        private void Z_text_box_TextChanged(object sender, EventArgs e)
        {
            try { zero_ang = Convert.ToDouble(Z_text_box.Text); }
            catch { Z_text_box.Clear(); }
        }

        private void logging_CheckStateChanged(object sender, EventArgs e)
        {
            if (logging_checkBox.Checked)
            {
                DateTime currentDateTime = DateTime.Now;
                String dateStr = currentDateTime.ToString("yyyy-MM-dd HH_mm_ss");

                fileStream = new FileStream(@"c:\MyStuff\balance_logs\balance_logs_"+dateStr+".txt", FileMode.Append);
            }
            else
            {
                fileStream.Close();
            }
        }


            


    }
}
