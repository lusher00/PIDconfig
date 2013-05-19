namespace PID_Config
{
    partial class PID_config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.cmbComSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P_text_box = new System.Windows.Forms.TextBox();
            this.I_text_box = new System.Windows.Forms.TextBox();
            this.D_text_box = new System.Windows.Forms.TextBox();
            this.P_send = new System.Windows.Forms.Button();
            this.I_send = new System.Windows.Forms.Button();
            this.D_send = new System.Windows.Forms.Button();
            this.ALL_send = new System.Windows.Forms.Button();
            this.p_minus = new System.Windows.Forms.Button();
            this.i_minus = new System.Windows.Forms.Button();
            this.d_minus = new System.Windows.Forms.Button();
            this.p_plus = new System.Windows.Forms.Button();
            this.i_plus = new System.Windows.Forms.Button();
            this.d_plus = new System.Windows.Forms.Button();
            this.pitch_trackBar = new System.Windows.Forms.TrackBar();
            this.pitch_textBox = new System.Windows.Forms.TextBox();
            this.openPort = new System.Windows.Forms.Button();
            this.closePort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaudSelect = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.pTerm_text_box = new System.Windows.Forms.TextBox();
            this.iTerm_text_box = new System.Windows.Forms.TextBox();
            this.dTerm_text_box = new System.Windows.Forms.TextBox();
            this.m_text_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.logging_checkBox = new System.Windows.Forms.CheckBox();
            this.d_increase_textBox = new System.Windows.Forms.TextBox();
            this.i_increase_textBox = new System.Windows.Forms.TextBox();
            this.p_increase_textBox = new System.Windows.Forms.TextBox();
            this.p_send_checkBox = new System.Windows.Forms.CheckBox();
            this.i_send_checkBox = new System.Windows.Forms.CheckBox();
            this.d_send_checkBox = new System.Windows.Forms.CheckBox();
            this.mult1_textBox = new System.Windows.Forms.TextBox();
            this.mult2_textBox = new System.Windows.Forms.TextBox();
            this.mult3_textBox = new System.Windows.Forms.TextBox();
            this.mult4_textBox = new System.Windows.Forms.TextBox();
            this.velocity_left_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Z_text_box = new System.Windows.Forms.TextBox();
            this.z_plus = new System.Windows.Forms.Button();
            this.z_minus = new System.Windows.Forms.Button();
            this.z_increase_textBox = new System.Windows.Forms.TextBox();
            this.z_send_checkBox = new System.Windows.Forms.CheckBox();
            this.Z_send = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ZERO_ALL_send = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.velocity_right_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.right_pos_text_box = new System.Windows.Forms.TextBox();
            this.left_pos_text_box = new System.Windows.Forms.TextBox();
            this.left_mot_text_box = new System.Windows.Forms.TextBox();
            this.right_mot_text_box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.left_mot_plus = new System.Windows.Forms.Button();
            this.right_mot_plus = new System.Windows.Forms.Button();
            this.right_mot_minus = new System.Windows.Forms.Button();
            this.left_mot_minus = new System.Windows.Forms.Button();
            this.left_mot_send = new System.Windows.Forms.Button();
            this.right_mot_send = new System.Windows.Forms.Button();
            this.mot_L_increase_textBox = new System.Windows.Forms.TextBox();
            this.mot_R_increase_textBox = new System.Windows.Forms.TextBox();
            this.pos_R_increase_textBox = new System.Windows.Forms.TextBox();
            this.pos_L_increase_textBox = new System.Windows.Forms.TextBox();
            this.right_pos_send = new System.Windows.Forms.Button();
            this.left_pos_send = new System.Windows.Forms.Button();
            this.right_pos_minus = new System.Windows.Forms.Button();
            this.left_pos_minus = new System.Windows.Forms.Button();
            this.right_pos_plus = new System.Windows.Forms.Button();
            this.left_pos_plus = new System.Windows.Forms.Button();
            this.right_mot_send_checkbox = new System.Windows.Forms.CheckBox();
            this.left_mot_send_checkbox = new System.Windows.Forms.CheckBox();
            this.right_pos_send_checkbox = new System.Windows.Forms.CheckBox();
            this.left_pos_send_checkbox = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIn.Location = new System.Drawing.Point(400, 107);
            this.txtIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(456, 25);
            this.txtIn.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsStatus
            // 
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(96, 17);
            this.stsStatus.Text = "Select serial port!";
            // 
            // txtOut
            // 
            this.txtOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOut.Location = new System.Drawing.Point(495, 442);
            this.txtOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(432, 23);
            this.txtOut.TabIndex = 3;
            // 
            // cmbComSelect
            // 
            this.cmbComSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbComSelect.FormattingEnabled = true;
            this.cmbComSelect.Location = new System.Drawing.Point(495, 32);
            this.cmbComSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(73, 24);
            this.cmbComSelect.Sorted = true;
            this.cmbComSelect.TabIndex = 9;
            this.cmbComSelect.SelectionChangeCommitted += new System.EventHandler(this.cmbComSelect_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select COM:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClear.Location = new System.Drawing.Point(796, 107);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 25);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "DIF GAIN";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "INT GAIN";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "PROP GAIN";
            // 
            // P_text_box
            // 
            this.P_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.P_text_box.Location = new System.Drawing.Point(495, 319);
            this.P_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.P_text_box.Name = "P_text_box";
            this.P_text_box.Size = new System.Drawing.Size(63, 23);
            this.P_text_box.TabIndex = 15;
            this.P_text_box.TextChanged += new System.EventHandler(this.P_text_box_TextChanged);
            // 
            // I_text_box
            // 
            this.I_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.I_text_box.Location = new System.Drawing.Point(495, 349);
            this.I_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.I_text_box.Name = "I_text_box";
            this.I_text_box.Size = new System.Drawing.Size(63, 23);
            this.I_text_box.TabIndex = 16;
            this.I_text_box.TextChanged += new System.EventHandler(this.I_text_box_TextChanged);
            // 
            // D_text_box
            // 
            this.D_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.D_text_box.Location = new System.Drawing.Point(495, 379);
            this.D_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.D_text_box.Name = "D_text_box";
            this.D_text_box.Size = new System.Drawing.Size(63, 23);
            this.D_text_box.TabIndex = 17;
            this.D_text_box.TextChanged += new System.EventHandler(this.D_text_box_TextChanged);
            // 
            // P_send
            // 
            this.P_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.P_send.Location = new System.Drawing.Point(695, 320);
            this.P_send.Margin = new System.Windows.Forms.Padding(4);
            this.P_send.Name = "P_send";
            this.P_send.Size = new System.Drawing.Size(45, 23);
            this.P_send.TabIndex = 18;
            this.P_send.Text = "SET";
            this.P_send.UseVisualStyleBackColor = true;
            this.P_send.Click += new System.EventHandler(this.P_send_Click);
            // 
            // I_send
            // 
            this.I_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.I_send.Location = new System.Drawing.Point(695, 351);
            this.I_send.Margin = new System.Windows.Forms.Padding(4);
            this.I_send.Name = "I_send";
            this.I_send.Size = new System.Drawing.Size(45, 23);
            this.I_send.TabIndex = 19;
            this.I_send.Text = "SET";
            this.I_send.UseVisualStyleBackColor = true;
            this.I_send.Click += new System.EventHandler(this.I_send_Click);
            // 
            // D_send
            // 
            this.D_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.D_send.Location = new System.Drawing.Point(695, 382);
            this.D_send.Margin = new System.Windows.Forms.Padding(4);
            this.D_send.Name = "D_send";
            this.D_send.Size = new System.Drawing.Size(45, 23);
            this.D_send.TabIndex = 20;
            this.D_send.Text = "SET";
            this.D_send.UseVisualStyleBackColor = true;
            this.D_send.Click += new System.EventHandler(this.D_send_Click);
            // 
            // ALL_send
            // 
            this.ALL_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ALL_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALL_send.Location = new System.Drawing.Point(749, 320);
            this.ALL_send.Margin = new System.Windows.Forms.Padding(4);
            this.ALL_send.Name = "ALL_send";
            this.ALL_send.Size = new System.Drawing.Size(59, 85);
            this.ALL_send.TabIndex = 21;
            this.ALL_send.Text = "SET ALL";
            this.ALL_send.UseVisualStyleBackColor = true;
            this.ALL_send.Click += new System.EventHandler(this.ALL_send_Click);
            // 
            // p_minus
            // 
            this.p_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.p_minus.Location = new System.Drawing.Point(601, 320);
            this.p_minus.Margin = new System.Windows.Forms.Padding(4);
            this.p_minus.Name = "p_minus";
            this.p_minus.Size = new System.Drawing.Size(25, 23);
            this.p_minus.TabIndex = 27;
            this.p_minus.Text = "-";
            this.p_minus.UseVisualStyleBackColor = true;
            this.p_minus.Click += new System.EventHandler(this.p_minus_Click);
            // 
            // i_minus
            // 
            this.i_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.i_minus.Location = new System.Drawing.Point(601, 351);
            this.i_minus.Margin = new System.Windows.Forms.Padding(4);
            this.i_minus.Name = "i_minus";
            this.i_minus.Size = new System.Drawing.Size(25, 23);
            this.i_minus.TabIndex = 28;
            this.i_minus.Text = "-";
            this.i_minus.UseVisualStyleBackColor = true;
            this.i_minus.Click += new System.EventHandler(this.i_minus_Click);
            // 
            // d_minus
            // 
            this.d_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d_minus.Location = new System.Drawing.Point(601, 382);
            this.d_minus.Margin = new System.Windows.Forms.Padding(4);
            this.d_minus.Name = "d_minus";
            this.d_minus.Size = new System.Drawing.Size(25, 23);
            this.d_minus.TabIndex = 30;
            this.d_minus.Text = "-";
            this.d_minus.UseVisualStyleBackColor = true;
            this.d_minus.Click += new System.EventHandler(this.d_minus_Click);
            // 
            // p_plus
            // 
            this.p_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.p_plus.Location = new System.Drawing.Point(566, 320);
            this.p_plus.Margin = new System.Windows.Forms.Padding(4);
            this.p_plus.Name = "p_plus";
            this.p_plus.Size = new System.Drawing.Size(27, 23);
            this.p_plus.TabIndex = 31;
            this.p_plus.Text = "+";
            this.p_plus.UseVisualStyleBackColor = true;
            this.p_plus.Click += new System.EventHandler(this.p_plus_Click);
            // 
            // i_plus
            // 
            this.i_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.i_plus.Location = new System.Drawing.Point(566, 351);
            this.i_plus.Margin = new System.Windows.Forms.Padding(4);
            this.i_plus.Name = "i_plus";
            this.i_plus.Size = new System.Drawing.Size(27, 23);
            this.i_plus.TabIndex = 32;
            this.i_plus.Text = "+";
            this.i_plus.UseVisualStyleBackColor = true;
            this.i_plus.Click += new System.EventHandler(this.i_plus_Click);
            // 
            // d_plus
            // 
            this.d_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d_plus.Location = new System.Drawing.Point(566, 382);
            this.d_plus.Margin = new System.Windows.Forms.Padding(4);
            this.d_plus.Name = "d_plus";
            this.d_plus.Size = new System.Drawing.Size(27, 23);
            this.d_plus.TabIndex = 33;
            this.d_plus.Text = "+";
            this.d_plus.UseVisualStyleBackColor = true;
            this.d_plus.Click += new System.EventHandler(this.d_plus_Click);
            // 
            // pitch_trackBar
            // 
            this.pitch_trackBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pitch_trackBar.Location = new System.Drawing.Point(342, 64);
            this.pitch_trackBar.Maximum = 180;
            this.pitch_trackBar.Minimum = -180;
            this.pitch_trackBar.Name = "pitch_trackBar";
            this.pitch_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.pitch_trackBar.Size = new System.Drawing.Size(45, 310);
            this.pitch_trackBar.TabIndex = 34;
            this.pitch_trackBar.Scroll += new System.EventHandler(this.pitch_trackBar_Scroll);
            // 
            // pitch_textBox
            // 
            this.pitch_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pitch_textBox.Location = new System.Drawing.Point(111, 354);
            this.pitch_textBox.Name = "pitch_textBox";
            this.pitch_textBox.Size = new System.Drawing.Size(74, 23);
            this.pitch_textBox.TabIndex = 35;
            this.pitch_textBox.TextChanged += new System.EventHandler(this.pitch_textBox_TextChanged);
            // 
            // openPort
            // 
            this.openPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.openPort.Location = new System.Drawing.Point(575, 33);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(50, 23);
            this.openPort.TabIndex = 38;
            this.openPort.Text = "open";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // closePort
            // 
            this.closePort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.closePort.Location = new System.Drawing.Point(573, 61);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(52, 28);
            this.closePort.TabIndex = 39;
            this.closePort.Text = "close";
            this.closePort.UseVisualStyleBackColor = true;
            this.closePort.Click += new System.EventHandler(this.closePort_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Baud Rate:";
            // 
            // cmbBaudSelect
            // 
            this.cmbBaudSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBaudSelect.FormattingEnabled = true;
            this.cmbBaudSelect.Location = new System.Drawing.Point(495, 64);
            this.cmbBaudSelect.Name = "cmbBaudSelect";
            this.cmbBaudSelect.Size = new System.Drawing.Size(73, 24);
            this.cmbBaudSelect.TabIndex = 41;
            this.cmbBaudSelect.SelectedIndexChanged += new System.EventHandler(this.cmbBaudSelect_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSend.Location = new System.Drawing.Point(852, 442);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 43;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // port
            // 
            this.port.ReadBufferSize = 64;
            this.port.ReceivedBytesThreshold = 32;
            // 
            // pTerm_text_box
            // 
            this.pTerm_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pTerm_text_box.Location = new System.Drawing.Point(883, 320);
            this.pTerm_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.pTerm_text_box.Name = "pTerm_text_box";
            this.pTerm_text_box.Size = new System.Drawing.Size(111, 23);
            this.pTerm_text_box.TabIndex = 46;
            // 
            // iTerm_text_box
            // 
            this.iTerm_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iTerm_text_box.Location = new System.Drawing.Point(883, 351);
            this.iTerm_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.iTerm_text_box.Name = "iTerm_text_box";
            this.iTerm_text_box.Size = new System.Drawing.Size(111, 23);
            this.iTerm_text_box.TabIndex = 47;
            // 
            // dTerm_text_box
            // 
            this.dTerm_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dTerm_text_box.Location = new System.Drawing.Point(883, 382);
            this.dTerm_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.dTerm_text_box.Name = "dTerm_text_box";
            this.dTerm_text_box.Size = new System.Drawing.Size(111, 23);
            this.dTerm_text_box.TabIndex = 48;
            // 
            // m_text_box
            // 
            this.m_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_text_box.Location = new System.Drawing.Point(883, 412);
            this.m_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.m_text_box.Name = "m_text_box";
            this.m_text_box.Size = new System.Drawing.Size(111, 23);
            this.m_text_box.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(804, 415);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "P + I + D";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "PITCH";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // logging_checkBox
            // 
            this.logging_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logging_checkBox.AutoSize = true;
            this.logging_checkBox.Location = new System.Drawing.Point(631, 35);
            this.logging_checkBox.Name = "logging_checkBox";
            this.logging_checkBox.Size = new System.Drawing.Size(78, 21);
            this.logging_checkBox.TabIndex = 55;
            this.logging_checkBox.Text = "Logging";
            this.logging_checkBox.UseVisualStyleBackColor = true;
            this.logging_checkBox.CheckedChanged += new System.EventHandler(this.logging_CheckStateChanged);
            // 
            // d_increase_textBox
            // 
            this.d_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d_increase_textBox.Location = new System.Drawing.Point(634, 382);
            this.d_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.d_increase_textBox.Name = "d_increase_textBox";
            this.d_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.d_increase_textBox.TabIndex = 58;
            // 
            // i_increase_textBox
            // 
            this.i_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.i_increase_textBox.Location = new System.Drawing.Point(634, 351);
            this.i_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.i_increase_textBox.Name = "i_increase_textBox";
            this.i_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.i_increase_textBox.TabIndex = 57;
            // 
            // p_increase_textBox
            // 
            this.p_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.p_increase_textBox.Location = new System.Drawing.Point(634, 320);
            this.p_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.p_increase_textBox.Name = "p_increase_textBox";
            this.p_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.p_increase_textBox.TabIndex = 56;
            // 
            // p_send_checkBox
            // 
            this.p_send_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.p_send_checkBox.AutoSize = true;
            this.p_send_checkBox.Location = new System.Drawing.Point(673, 325);
            this.p_send_checkBox.Name = "p_send_checkBox";
            this.p_send_checkBox.Size = new System.Drawing.Size(15, 14);
            this.p_send_checkBox.TabIndex = 59;
            this.p_send_checkBox.UseVisualStyleBackColor = true;
            // 
            // i_send_checkBox
            // 
            this.i_send_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.i_send_checkBox.AutoSize = true;
            this.i_send_checkBox.Location = new System.Drawing.Point(673, 356);
            this.i_send_checkBox.Name = "i_send_checkBox";
            this.i_send_checkBox.Size = new System.Drawing.Size(15, 14);
            this.i_send_checkBox.TabIndex = 60;
            this.i_send_checkBox.UseVisualStyleBackColor = true;
            // 
            // d_send_checkBox
            // 
            this.d_send_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d_send_checkBox.AutoSize = true;
            this.d_send_checkBox.Location = new System.Drawing.Point(673, 387);
            this.d_send_checkBox.Name = "d_send_checkBox";
            this.d_send_checkBox.Size = new System.Drawing.Size(15, 14);
            this.d_send_checkBox.TabIndex = 61;
            this.d_send_checkBox.UseVisualStyleBackColor = true;
            // 
            // mult1_textBox
            // 
            this.mult1_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mult1_textBox.Location = new System.Drawing.Point(13, 420);
            this.mult1_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.mult1_textBox.Name = "mult1_textBox";
            this.mult1_textBox.Size = new System.Drawing.Size(63, 23);
            this.mult1_textBox.TabIndex = 62;
            // 
            // mult2_textBox
            // 
            this.mult2_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mult2_textBox.Location = new System.Drawing.Point(84, 420);
            this.mult2_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.mult2_textBox.Name = "mult2_textBox";
            this.mult2_textBox.Size = new System.Drawing.Size(63, 23);
            this.mult2_textBox.TabIndex = 63;
            // 
            // mult3_textBox
            // 
            this.mult3_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mult3_textBox.Location = new System.Drawing.Point(155, 420);
            this.mult3_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.mult3_textBox.Name = "mult3_textBox";
            this.mult3_textBox.Size = new System.Drawing.Size(63, 23);
            this.mult3_textBox.TabIndex = 64;
            // 
            // mult4_textBox
            // 
            this.mult4_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mult4_textBox.Location = new System.Drawing.Point(226, 420);
            this.mult4_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.mult4_textBox.Name = "mult4_textBox";
            this.mult4_textBox.Size = new System.Drawing.Size(63, 23);
            this.mult4_textBox.TabIndex = 65;
            // 
            // velocity_left_textBox
            // 
            this.velocity_left_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.velocity_left_textBox.Location = new System.Drawing.Point(495, 139);
            this.velocity_left_textBox.Name = "velocity_left_textBox";
            this.velocity_left_textBox.Size = new System.Drawing.Size(63, 23);
            this.velocity_left_textBox.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "LEFT RPM";
            // 
            // Z_text_box
            // 
            this.Z_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Z_text_box.Location = new System.Drawing.Point(495, 409);
            this.Z_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.Z_text_box.Name = "Z_text_box";
            this.Z_text_box.Size = new System.Drawing.Size(63, 23);
            this.Z_text_box.TabIndex = 68;
            this.Z_text_box.TextChanged += new System.EventHandler(this.Z_text_box_TextChanged);
            // 
            // z_plus
            // 
            this.z_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.z_plus.Location = new System.Drawing.Point(566, 413);
            this.z_plus.Margin = new System.Windows.Forms.Padding(4);
            this.z_plus.Name = "z_plus";
            this.z_plus.Size = new System.Drawing.Size(27, 23);
            this.z_plus.TabIndex = 69;
            this.z_plus.Text = "+";
            this.z_plus.UseVisualStyleBackColor = true;
            this.z_plus.Click += new System.EventHandler(this.z_plus_Click);
            // 
            // z_minus
            // 
            this.z_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.z_minus.Location = new System.Drawing.Point(601, 413);
            this.z_minus.Margin = new System.Windows.Forms.Padding(4);
            this.z_minus.Name = "z_minus";
            this.z_minus.Size = new System.Drawing.Size(25, 23);
            this.z_minus.TabIndex = 70;
            this.z_minus.Text = "-";
            this.z_minus.UseVisualStyleBackColor = true;
            this.z_minus.Click += new System.EventHandler(this.z_minus_Click);
            // 
            // z_increase_textBox
            // 
            this.z_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.z_increase_textBox.Location = new System.Drawing.Point(634, 413);
            this.z_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.z_increase_textBox.Name = "z_increase_textBox";
            this.z_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.z_increase_textBox.TabIndex = 71;
            // 
            // z_send_checkBox
            // 
            this.z_send_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.z_send_checkBox.AutoSize = true;
            this.z_send_checkBox.Location = new System.Drawing.Point(673, 418);
            this.z_send_checkBox.Name = "z_send_checkBox";
            this.z_send_checkBox.Size = new System.Drawing.Size(15, 14);
            this.z_send_checkBox.TabIndex = 72;
            this.z_send_checkBox.UseVisualStyleBackColor = true;
            // 
            // Z_send
            // 
            this.Z_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Z_send.Location = new System.Drawing.Point(695, 412);
            this.Z_send.Margin = new System.Windows.Forms.Padding(4);
            this.Z_send.Name = "Z_send";
            this.Z_send.Size = new System.Drawing.Size(45, 23);
            this.Z_send.TabIndex = 73;
            this.Z_send.Text = "SET";
            this.Z_send.UseVisualStyleBackColor = true;
            this.Z_send.Click += new System.EventHandler(this.Z_send_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 74;
            this.label8.Text = "ZERO ANG";
            // 
            // ZERO_ALL_send
            // 
            this.ZERO_ALL_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ZERO_ALL_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZERO_ALL_send.Location = new System.Drawing.Point(816, 320);
            this.ZERO_ALL_send.Margin = new System.Windows.Forms.Padding(4);
            this.ZERO_ALL_send.Name = "ZERO_ALL_send";
            this.ZERO_ALL_send.Size = new System.Drawing.Size(59, 85);
            this.ZERO_ALL_send.TabIndex = 75;
            this.ZERO_ALL_send.Text = "ZERO ALL";
            this.ZERO_ALL_send.UseVisualStyleBackColor = true;
            this.ZERO_ALL_send.Click += new System.EventHandler(this.ZERO_ALL_send_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(568, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "RIGHT RPM";
            // 
            // velocity_right_textBox
            // 
            this.velocity_right_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.velocity_right_textBox.Location = new System.Drawing.Point(671, 139);
            this.velocity_right_textBox.Name = "velocity_right_textBox";
            this.velocity_right_textBox.Size = new System.Drawing.Size(74, 23);
            this.velocity_right_textBox.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 79;
            this.label11.Text = "RIGHT POS";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(405, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 80;
            this.label12.Text = "LEFT POS";
            // 
            // right_pos_text_box
            // 
            this.right_pos_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_pos_text_box.Location = new System.Drawing.Point(495, 199);
            this.right_pos_text_box.Name = "right_pos_text_box";
            this.right_pos_text_box.Size = new System.Drawing.Size(63, 23);
            this.right_pos_text_box.TabIndex = 81;
            // 
            // left_pos_text_box
            // 
            this.left_pos_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_pos_text_box.Location = new System.Drawing.Point(495, 169);
            this.left_pos_text_box.Name = "left_pos_text_box";
            this.left_pos_text_box.Size = new System.Drawing.Size(63, 23);
            this.left_pos_text_box.TabIndex = 82;
            // 
            // left_mot_text_box
            // 
            this.left_mot_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_mot_text_box.Location = new System.Drawing.Point(495, 229);
            this.left_mot_text_box.Name = "left_mot_text_box";
            this.left_mot_text_box.Size = new System.Drawing.Size(63, 23);
            this.left_mot_text_box.TabIndex = 83;
            // 
            // right_mot_text_box
            // 
            this.right_mot_text_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_mot_text_box.Location = new System.Drawing.Point(495, 259);
            this.right_mot_text_box.Name = "right_mot_text_box";
            this.right_mot_text_box.Size = new System.Drawing.Size(63, 23);
            this.right_mot_text_box.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(403, 232);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 85;
            this.label13.Text = "LEFT MOT";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(393, 262);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 86;
            this.label14.Text = "RIGHT MOT";
            // 
            // left_mot_plus
            // 
            this.left_mot_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_mot_plus.Location = new System.Drawing.Point(566, 229);
            this.left_mot_plus.Margin = new System.Windows.Forms.Padding(4);
            this.left_mot_plus.Name = "left_mot_plus";
            this.left_mot_plus.Size = new System.Drawing.Size(27, 23);
            this.left_mot_plus.TabIndex = 87;
            this.left_mot_plus.Text = "+";
            this.left_mot_plus.UseVisualStyleBackColor = true;
            this.left_mot_plus.Click += new System.EventHandler(this.left_mot_plus_Click);
            // 
            // right_mot_plus
            // 
            this.right_mot_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_mot_plus.Location = new System.Drawing.Point(566, 259);
            this.right_mot_plus.Margin = new System.Windows.Forms.Padding(4);
            this.right_mot_plus.Name = "right_mot_plus";
            this.right_mot_plus.Size = new System.Drawing.Size(27, 23);
            this.right_mot_plus.TabIndex = 88;
            this.right_mot_plus.Text = "+";
            this.right_mot_plus.UseVisualStyleBackColor = true;
            this.right_mot_plus.Click += new System.EventHandler(this.right_mot_plus_Click);
            // 
            // right_mot_minus
            // 
            this.right_mot_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_mot_minus.Location = new System.Drawing.Point(601, 259);
            this.right_mot_minus.Margin = new System.Windows.Forms.Padding(4);
            this.right_mot_minus.Name = "right_mot_minus";
            this.right_mot_minus.Size = new System.Drawing.Size(25, 23);
            this.right_mot_minus.TabIndex = 90;
            this.right_mot_minus.Text = "-";
            this.right_mot_minus.UseVisualStyleBackColor = true;
            this.right_mot_minus.Click += new System.EventHandler(this.right_mot_minus_Click);
            // 
            // left_mot_minus
            // 
            this.left_mot_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_mot_minus.Location = new System.Drawing.Point(601, 229);
            this.left_mot_minus.Margin = new System.Windows.Forms.Padding(4);
            this.left_mot_minus.Name = "left_mot_minus";
            this.left_mot_minus.Size = new System.Drawing.Size(25, 23);
            this.left_mot_minus.TabIndex = 89;
            this.left_mot_minus.Text = "-";
            this.left_mot_minus.UseVisualStyleBackColor = true;
            this.left_mot_minus.Click += new System.EventHandler(this.left_mot_minus_Click);
            // 
            // left_mot_send
            // 
            this.left_mot_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_mot_send.Location = new System.Drawing.Point(695, 229);
            this.left_mot_send.Margin = new System.Windows.Forms.Padding(4);
            this.left_mot_send.Name = "left_mot_send";
            this.left_mot_send.Size = new System.Drawing.Size(45, 23);
            this.left_mot_send.TabIndex = 91;
            this.left_mot_send.Text = "SET";
            this.left_mot_send.UseVisualStyleBackColor = true;
            this.left_mot_send.Click += new System.EventHandler(this.left_mot_send_Click);
            // 
            // right_mot_send
            // 
            this.right_mot_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_mot_send.Location = new System.Drawing.Point(695, 259);
            this.right_mot_send.Margin = new System.Windows.Forms.Padding(4);
            this.right_mot_send.Name = "right_mot_send";
            this.right_mot_send.Size = new System.Drawing.Size(45, 23);
            this.right_mot_send.TabIndex = 92;
            this.right_mot_send.Text = "SET";
            this.right_mot_send.UseVisualStyleBackColor = true;
            this.right_mot_send.Click += new System.EventHandler(this.right_mot_send_Click);
            // 
            // mot_L_increase_textBox
            // 
            this.mot_L_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mot_L_increase_textBox.Location = new System.Drawing.Point(634, 229);
            this.mot_L_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.mot_L_increase_textBox.Name = "mot_L_increase_textBox";
            this.mot_L_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.mot_L_increase_textBox.TabIndex = 93;
            // 
            // mot_R_increase_textBox
            // 
            this.mot_R_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mot_R_increase_textBox.Location = new System.Drawing.Point(634, 259);
            this.mot_R_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.mot_R_increase_textBox.Name = "mot_R_increase_textBox";
            this.mot_R_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.mot_R_increase_textBox.TabIndex = 94;
            // 
            // pos_R_increase_textBox
            // 
            this.pos_R_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pos_R_increase_textBox.Location = new System.Drawing.Point(634, 199);
            this.pos_R_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.pos_R_increase_textBox.Name = "pos_R_increase_textBox";
            this.pos_R_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.pos_R_increase_textBox.TabIndex = 102;
            // 
            // pos_L_increase_textBox
            // 
            this.pos_L_increase_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pos_L_increase_textBox.Location = new System.Drawing.Point(634, 169);
            this.pos_L_increase_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.pos_L_increase_textBox.Name = "pos_L_increase_textBox";
            this.pos_L_increase_textBox.Size = new System.Drawing.Size(32, 23);
            this.pos_L_increase_textBox.TabIndex = 101;
            // 
            // right_pos_send
            // 
            this.right_pos_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_pos_send.Location = new System.Drawing.Point(695, 199);
            this.right_pos_send.Margin = new System.Windows.Forms.Padding(4);
            this.right_pos_send.Name = "right_pos_send";
            this.right_pos_send.Size = new System.Drawing.Size(45, 23);
            this.right_pos_send.TabIndex = 100;
            this.right_pos_send.Text = "SET";
            this.right_pos_send.UseVisualStyleBackColor = true;
            this.right_pos_send.Click += new System.EventHandler(this.right_pos_send_Click);
            // 
            // left_pos_send
            // 
            this.left_pos_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_pos_send.Location = new System.Drawing.Point(695, 169);
            this.left_pos_send.Margin = new System.Windows.Forms.Padding(4);
            this.left_pos_send.Name = "left_pos_send";
            this.left_pos_send.Size = new System.Drawing.Size(45, 23);
            this.left_pos_send.TabIndex = 99;
            this.left_pos_send.Text = "SET";
            this.left_pos_send.UseVisualStyleBackColor = true;
            this.left_pos_send.Click += new System.EventHandler(this.left_pos_send_Click);
            // 
            // right_pos_minus
            // 
            this.right_pos_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_pos_minus.Location = new System.Drawing.Point(601, 199);
            this.right_pos_minus.Margin = new System.Windows.Forms.Padding(4);
            this.right_pos_minus.Name = "right_pos_minus";
            this.right_pos_minus.Size = new System.Drawing.Size(25, 23);
            this.right_pos_minus.TabIndex = 98;
            this.right_pos_minus.Text = "-";
            this.right_pos_minus.UseVisualStyleBackColor = true;
            this.right_pos_minus.Click += new System.EventHandler(this.right_pos_minus_Click);
            // 
            // left_pos_minus
            // 
            this.left_pos_minus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_pos_minus.Location = new System.Drawing.Point(601, 169);
            this.left_pos_minus.Margin = new System.Windows.Forms.Padding(4);
            this.left_pos_minus.Name = "left_pos_minus";
            this.left_pos_minus.Size = new System.Drawing.Size(25, 23);
            this.left_pos_minus.TabIndex = 97;
            this.left_pos_minus.Text = "-";
            this.left_pos_minus.UseVisualStyleBackColor = true;
            this.left_pos_minus.Click += new System.EventHandler(this.left_pos_minus_Click);
            // 
            // right_pos_plus
            // 
            this.right_pos_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_pos_plus.Location = new System.Drawing.Point(566, 199);
            this.right_pos_plus.Margin = new System.Windows.Forms.Padding(4);
            this.right_pos_plus.Name = "right_pos_plus";
            this.right_pos_plus.Size = new System.Drawing.Size(27, 23);
            this.right_pos_plus.TabIndex = 96;
            this.right_pos_plus.Text = "+";
            this.right_pos_plus.UseVisualStyleBackColor = true;
            this.right_pos_plus.Click += new System.EventHandler(this.right_pos_plus_Click);
            // 
            // left_pos_plus
            // 
            this.left_pos_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_pos_plus.Location = new System.Drawing.Point(566, 169);
            this.left_pos_plus.Margin = new System.Windows.Forms.Padding(4);
            this.left_pos_plus.Name = "left_pos_plus";
            this.left_pos_plus.Size = new System.Drawing.Size(27, 23);
            this.left_pos_plus.TabIndex = 95;
            this.left_pos_plus.Text = "+";
            this.left_pos_plus.UseVisualStyleBackColor = true;
            this.left_pos_plus.Click += new System.EventHandler(this.left_pos_plus_Click);
            // 
            // right_mot_send_checkbox
            // 
            this.right_mot_send_checkbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_mot_send_checkbox.AutoSize = true;
            this.right_mot_send_checkbox.Location = new System.Drawing.Point(673, 264);
            this.right_mot_send_checkbox.Name = "right_mot_send_checkbox";
            this.right_mot_send_checkbox.Size = new System.Drawing.Size(15, 14);
            this.right_mot_send_checkbox.TabIndex = 106;
            this.right_mot_send_checkbox.UseVisualStyleBackColor = true;
            // 
            // left_mot_send_checkbox
            // 
            this.left_mot_send_checkbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_mot_send_checkbox.AutoSize = true;
            this.left_mot_send_checkbox.Location = new System.Drawing.Point(673, 234);
            this.left_mot_send_checkbox.Name = "left_mot_send_checkbox";
            this.left_mot_send_checkbox.Size = new System.Drawing.Size(15, 14);
            this.left_mot_send_checkbox.TabIndex = 105;
            this.left_mot_send_checkbox.UseVisualStyleBackColor = true;
            // 
            // right_pos_send_checkbox
            // 
            this.right_pos_send_checkbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_pos_send_checkbox.AutoSize = true;
            this.right_pos_send_checkbox.Location = new System.Drawing.Point(673, 204);
            this.right_pos_send_checkbox.Name = "right_pos_send_checkbox";
            this.right_pos_send_checkbox.Size = new System.Drawing.Size(15, 14);
            this.right_pos_send_checkbox.TabIndex = 104;
            this.right_pos_send_checkbox.UseVisualStyleBackColor = true;
            // 
            // left_pos_send_checkbox
            // 
            this.left_pos_send_checkbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_pos_send_checkbox.AutoSize = true;
            this.left_pos_send_checkbox.Location = new System.Drawing.Point(673, 174);
            this.left_pos_send_checkbox.Name = "left_pos_send_checkbox";
            this.left_pos_send_checkbox.Size = new System.Drawing.Size(15, 14);
            this.left_pos_send_checkbox.TabIndex = 103;
            this.left_pos_send_checkbox.UseVisualStyleBackColor = true;
            // 
            // PID_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 525);
            this.Controls.Add(this.right_mot_send_checkbox);
            this.Controls.Add(this.left_mot_send_checkbox);
            this.Controls.Add(this.right_pos_send_checkbox);
            this.Controls.Add(this.left_pos_send_checkbox);
            this.Controls.Add(this.pos_R_increase_textBox);
            this.Controls.Add(this.pos_L_increase_textBox);
            this.Controls.Add(this.right_pos_send);
            this.Controls.Add(this.left_pos_send);
            this.Controls.Add(this.right_pos_minus);
            this.Controls.Add(this.left_pos_minus);
            this.Controls.Add(this.right_pos_plus);
            this.Controls.Add(this.left_pos_plus);
            this.Controls.Add(this.mot_R_increase_textBox);
            this.Controls.Add(this.mot_L_increase_textBox);
            this.Controls.Add(this.right_mot_send);
            this.Controls.Add(this.left_mot_send);
            this.Controls.Add(this.right_mot_minus);
            this.Controls.Add(this.left_mot_minus);
            this.Controls.Add(this.right_mot_plus);
            this.Controls.Add(this.left_mot_plus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.right_mot_text_box);
            this.Controls.Add(this.left_mot_text_box);
            this.Controls.Add(this.left_pos_text_box);
            this.Controls.Add(this.right_pos_text_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.velocity_right_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ZERO_ALL_send);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Z_send);
            this.Controls.Add(this.z_send_checkBox);
            this.Controls.Add(this.z_increase_textBox);
            this.Controls.Add(this.z_minus);
            this.Controls.Add(this.z_plus);
            this.Controls.Add(this.Z_text_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.velocity_left_textBox);
            this.Controls.Add(this.mult4_textBox);
            this.Controls.Add(this.mult3_textBox);
            this.Controls.Add(this.mult2_textBox);
            this.Controls.Add(this.mult1_textBox);
            this.Controls.Add(this.d_send_checkBox);
            this.Controls.Add(this.i_send_checkBox);
            this.Controls.Add(this.p_send_checkBox);
            this.Controls.Add(this.d_increase_textBox);
            this.Controls.Add(this.i_increase_textBox);
            this.Controls.Add(this.p_increase_textBox);
            this.Controls.Add(this.logging_checkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.m_text_box);
            this.Controls.Add(this.dTerm_text_box);
            this.Controls.Add(this.iTerm_text_box);
            this.Controls.Add(this.pTerm_text_box);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cmbBaudSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closePort);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.pitch_textBox);
            this.Controls.Add(this.pitch_trackBar);
            this.Controls.Add(this.d_plus);
            this.Controls.Add(this.i_plus);
            this.Controls.Add(this.p_plus);
            this.Controls.Add(this.d_minus);
            this.Controls.Add(this.i_minus);
            this.Controls.Add(this.p_minus);
            this.Controls.Add(this.ALL_send);
            this.Controls.Add(this.D_send);
            this.Controls.Add(this.I_send);
            this.Controls.Add(this.P_send);
            this.Controls.Add(this.D_text_box);
            this.Controls.Add(this.I_text_box);
            this.Controls.Add(this.P_text_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbComSelect);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(261, 237);
            this.Name = "PID_config";
            this.Text = "P.I.D. Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PID_config_FormClosing);
            this.Load += new System.EventHandler(this.PID_config_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsStatus;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.ComboBox cmbComSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox P_text_box;
        private System.Windows.Forms.TextBox I_text_box;
        private System.Windows.Forms.TextBox D_text_box;
        private System.Windows.Forms.Button P_send;
        private System.Windows.Forms.Button I_send;
        private System.Windows.Forms.Button D_send;
        private System.Windows.Forms.Button ALL_send;
        private System.Windows.Forms.Button p_minus;
        private System.Windows.Forms.Button i_minus;
        private System.Windows.Forms.Button d_minus;
        private System.Windows.Forms.Button p_plus;
        private System.Windows.Forms.Button i_plus;
        private System.Windows.Forms.Button d_plus;
        private System.Windows.Forms.TrackBar pitch_trackBar;
        private System.Windows.Forms.TextBox pitch_textBox;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Button closePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBaudSelect;
        private System.Windows.Forms.Button btnSend;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.TextBox pTerm_text_box;
        private System.Windows.Forms.TextBox iTerm_text_box;
        private System.Windows.Forms.TextBox dTerm_text_box;
        private System.Windows.Forms.TextBox m_text_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox logging_checkBox;
        private System.Windows.Forms.TextBox d_increase_textBox;
        private System.Windows.Forms.TextBox i_increase_textBox;
        private System.Windows.Forms.TextBox p_increase_textBox;
        private System.Windows.Forms.CheckBox p_send_checkBox;
        private System.Windows.Forms.CheckBox i_send_checkBox;
        private System.Windows.Forms.CheckBox d_send_checkBox;
        private System.Windows.Forms.TextBox mult1_textBox;
        private System.Windows.Forms.TextBox mult2_textBox;
        private System.Windows.Forms.TextBox mult3_textBox;
        private System.Windows.Forms.TextBox mult4_textBox;
        private System.Windows.Forms.TextBox velocity_left_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Z_text_box;
        private System.Windows.Forms.Button z_plus;
        private System.Windows.Forms.Button z_minus;
        private System.Windows.Forms.TextBox z_increase_textBox;
        private System.Windows.Forms.CheckBox z_send_checkBox;
        private System.Windows.Forms.Button Z_send;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ZERO_ALL_send;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox velocity_right_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox right_pos_text_box;
        private System.Windows.Forms.TextBox left_pos_text_box;
        private System.Windows.Forms.TextBox left_mot_text_box;
        private System.Windows.Forms.TextBox right_mot_text_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button left_mot_plus;
        private System.Windows.Forms.Button right_mot_plus;
        private System.Windows.Forms.Button right_mot_minus;
        private System.Windows.Forms.Button left_mot_minus;
        private System.Windows.Forms.Button left_mot_send;
        private System.Windows.Forms.Button right_mot_send;
        private System.Windows.Forms.TextBox mot_L_increase_textBox;
        private System.Windows.Forms.TextBox mot_R_increase_textBox;
        private System.Windows.Forms.TextBox pos_R_increase_textBox;
        private System.Windows.Forms.TextBox pos_L_increase_textBox;
        private System.Windows.Forms.Button right_pos_send;
        private System.Windows.Forms.Button left_pos_send;
        private System.Windows.Forms.Button right_pos_minus;
        private System.Windows.Forms.Button left_pos_minus;
        private System.Windows.Forms.Button right_pos_plus;
        private System.Windows.Forms.Button left_pos_plus;
        private System.Windows.Forms.CheckBox right_mot_send_checkbox;
        private System.Windows.Forms.CheckBox left_mot_send_checkbox;
        private System.Windows.Forms.CheckBox right_pos_send_checkbox;
        private System.Windows.Forms.CheckBox left_pos_send_checkbox;
        
    }
}

