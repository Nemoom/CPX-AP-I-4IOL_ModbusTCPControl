namespace CPX_AP_I_4IOL_ModbusTCPControl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_ISDU = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cob_Channel = new System.Windows.Forms.ComboBox();
            this.txt_ModuleNumber = new System.Windows.Forms.TextBox();
            this.cob_Command = new System.Windows.Forms.ComboBox();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.txt_Subindex = new System.Windows.Forms.TextBox();
            this.txt_Index = new System.Windows.Forms.TextBox();
            this.lbl_ISDUstatus = new System.Windows.Forms.Label();
            this.cob_Type = new System.Windows.Forms.ComboBox();
            this.cob_ParaList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_AddressStart = new System.Windows.Forms.TextBox();
            this.btn_In = new System.Windows.Forms.Button();
            this.btn_Out = new System.Windows.Forms.Button();
            this.btn_Ack = new System.Windows.Forms.Button();
            this.btn_Intermediate = new System.Windows.Forms.Button();
            this.lbl_i_In = new System.Windows.Forms.Label();
            this.lbl_i_Out = new System.Windows.Forms.Label();
            this.lbl_i_Move = new System.Windows.Forms.Label();
            this.lbl_i_Device = new System.Windows.Forms.Label();
            this.lbl_i_Intermediate = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.imageList_Status = new System.Windows.Forms.ImageList(this.components);
            this.imageList_Error = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_ISDU.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ISDU
            // 
            this.gb_ISDU.Controls.Add(this.tableLayoutPanel1);
            this.gb_ISDU.Controls.Add(this.cob_ParaList);
            this.gb_ISDU.Location = new System.Drawing.Point(742, 28);
            this.gb_ISDU.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ISDU.Name = "gb_ISDU";
            this.gb_ISDU.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ISDU.Size = new System.Drawing.Size(500, 439);
            this.gb_ISDU.TabIndex = 0;
            this.gb_ISDU.TabStop = false;
            this.gb_ISDU.Text = "IO-Link ISDU";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cob_Channel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_ModuleNumber, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cob_Command, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Data, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_Length, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_Subindex, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_Index, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ISDUstatus, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cob_Type, 2, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MetaPlusLF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MetaPlusLF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MetaPlusLF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISDU Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Command";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Module number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Channel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Index";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Subindex";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Length";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Data";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "34000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "34001";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 23);
            this.label14.TabIndex = 13;
            this.label14.Text = "34002";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "34003";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 23);
            this.label16.TabIndex = 15;
            this.label16.Text = "34004";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 23);
            this.label17.TabIndex = 16;
            this.label17.Text = "34005";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 23);
            this.label18.TabIndex = 17;
            this.label18.Text = "34006";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 288);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 46);
            this.label19.TabIndex = 18;
            this.label19.Text = "34007..34126";
            // 
            // cob_Channel
            // 
            this.cob_Channel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cob_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Channel.FormattingEnabled = true;
            this.cob_Channel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cob_Channel.Location = new System.Drawing.Point(258, 147);
            this.cob_Channel.Name = "cob_Channel";
            this.cob_Channel.Size = new System.Drawing.Size(231, 31);
            this.cob_Channel.TabIndex = 19;
            // 
            // txt_ModuleNumber
            // 
            this.txt_ModuleNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ModuleNumber.Location = new System.Drawing.Point(258, 111);
            this.txt_ModuleNumber.Name = "txt_ModuleNumber";
            this.txt_ModuleNumber.Size = new System.Drawing.Size(231, 30);
            this.txt_ModuleNumber.TabIndex = 22;
            // 
            // cob_Command
            // 
            this.cob_Command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cob_Command.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Command.FormattingEnabled = true;
            this.cob_Command.Items.AddRange(new object[] {
            "50 Read (with Byte swap)",
            "51 Write (with Byte swap)",
            "100 Read",
            "101 Write"});
            this.cob_Command.Location = new System.Drawing.Point(258, 75);
            this.cob_Command.Name = "cob_Command";
            this.cob_Command.Size = new System.Drawing.Size(231, 31);
            this.cob_Command.TabIndex = 23;
            this.cob_Command.SelectedIndexChanged += new System.EventHandler(this.cob_Command_SelectedIndexChanged);
            // 
            // txt_Data
            // 
            this.txt_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Data.Location = new System.Drawing.Point(258, 291);
            this.txt_Data.Multiline = true;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(231, 43);
            this.txt_Data.TabIndex = 24;
            // 
            // txt_Length
            // 
            this.txt_Length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Length.Location = new System.Drawing.Point(258, 255);
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.Size = new System.Drawing.Size(231, 30);
            this.txt_Length.TabIndex = 25;
            // 
            // txt_Subindex
            // 
            this.txt_Subindex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Subindex.Location = new System.Drawing.Point(258, 219);
            this.txt_Subindex.Name = "txt_Subindex";
            this.txt_Subindex.Size = new System.Drawing.Size(231, 30);
            this.txt_Subindex.TabIndex = 26;
            // 
            // txt_Index
            // 
            this.txt_Index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Index.Location = new System.Drawing.Point(258, 183);
            this.txt_Index.Name = "txt_Index";
            this.txt_Index.Size = new System.Drawing.Size(231, 30);
            this.txt_Index.TabIndex = 27;
            // 
            // lbl_ISDUstatus
            // 
            this.lbl_ISDUstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ISDUstatus.Location = new System.Drawing.Point(258, 36);
            this.lbl_ISDUstatus.Name = "lbl_ISDUstatus";
            this.lbl_ISDUstatus.Size = new System.Drawing.Size(231, 36);
            this.lbl_ISDUstatus.TabIndex = 28;
            // 
            // cob_Type
            // 
            this.cob_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cob_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Type.FormattingEnabled = true;
            this.cob_Type.Items.AddRange(new object[] {
            "Signed",
            "Unsigned",
            "Hex",
            "Binary",
            "Long AB CD",
            "Long CD AB",
            "Long BA DC",
            "Long DC BA",
            "Float AB CD",
            "Float CD AB",
            "Float BA DC",
            "Float DC BA"});
            this.cob_Type.Location = new System.Drawing.Point(258, 340);
            this.cob_Type.Name = "cob_Type";
            this.cob_Type.Size = new System.Drawing.Size(231, 31);
            this.cob_Type.TabIndex = 29;
            // 
            // cob_ParaList
            // 
            this.cob_ParaList.Dock = System.Windows.Forms.DockStyle.Top;
            this.cob_ParaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_ParaList.FormattingEnabled = true;
            this.cob_ParaList.Items.AddRange(new object[] {
            "Speed \"In\"(256.0 1)",
            "Speed \"Out\"(257.0 1)",
            "Force(258.0 1)",
            "Reference(259.0 1)",
            "\"Start Press\" position(261.0 4)",
            "End Position \"Out\"(262.0 4)",
            "Intermediate position(264.0 4)"});
            this.cob_ParaList.Location = new System.Drawing.Point(4, 27);
            this.cob_ParaList.Name = "cob_ParaList";
            this.cob_ParaList.Size = new System.Drawing.Size(492, 31);
            this.cob_ParaList.TabIndex = 0;
            this.cob_ParaList.SelectedIndexChanged += new System.EventHandler(this.cob_ParaList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(254, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMS Control";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ProcessData";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_AddressStart, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_In, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Out, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Ack, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_Intermediate, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_i_In, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_i_Out, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_i_Move, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_i_Device, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_i_Intermediate, 2, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 246);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "Register";
            // 
            // txt_AddressStart
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_AddressStart, 2);
            this.txt_AddressStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_AddressStart.Location = new System.Drawing.Point(133, 3);
            this.txt_AddressStart.Name = "txt_AddressStart";
            this.txt_AddressStart.Size = new System.Drawing.Size(272, 30);
            this.txt_AddressStart.TabIndex = 1;
            this.txt_AddressStart.Text = "0";
            this.txt_AddressStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_In
            // 
            this.btn_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_In.Location = new System.Drawing.Point(3, 34);
            this.btn_In.Name = "btn_In";
            this.tableLayoutPanel2.SetRowSpan(this.btn_In, 3);
            this.btn_In.Size = new System.Drawing.Size(124, 99);
            this.btn_In.TabIndex = 2;
            this.btn_In.Text = "Move \"In\"(1)";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_In_MouseDown);
            this.btn_In.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_In_MouseUp);
            // 
            // btn_Out
            // 
            this.btn_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Out.Location = new System.Drawing.Point(133, 34);
            this.btn_Out.Name = "btn_Out";
            this.tableLayoutPanel2.SetRowSpan(this.btn_Out, 3);
            this.btn_Out.Size = new System.Drawing.Size(124, 99);
            this.btn_Out.TabIndex = 3;
            this.btn_Out.Text = "Move \"Out\"(2)";
            this.btn_Out.UseVisualStyleBackColor = true;
            this.btn_Out.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Out_MouseDown);
            this.btn_Out.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Out_MouseUp);
            // 
            // btn_Ack
            // 
            this.btn_Ack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ack.Location = new System.Drawing.Point(3, 139);
            this.btn_Ack.Name = "btn_Ack";
            this.tableLayoutPanel2.SetRowSpan(this.btn_Ack, 3);
            this.btn_Ack.Size = new System.Drawing.Size(124, 104);
            this.btn_Ack.TabIndex = 4;
            this.btn_Ack.Text = "Quit Error(3)";
            this.btn_Ack.UseVisualStyleBackColor = true;
            this.btn_Ack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Ack_MouseDown);
            this.btn_Ack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Ack_MouseUp);
            // 
            // btn_Intermediate
            // 
            this.btn_Intermediate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Intermediate.Location = new System.Drawing.Point(133, 139);
            this.btn_Intermediate.Name = "btn_Intermediate";
            this.tableLayoutPanel2.SetRowSpan(this.btn_Intermediate, 3);
            this.btn_Intermediate.Size = new System.Drawing.Size(124, 104);
            this.btn_Intermediate.TabIndex = 5;
            this.btn_Intermediate.Text = "Move \"Intermediate\"(5)";
            this.btn_Intermediate.UseVisualStyleBackColor = true;
            this.btn_Intermediate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Intermediate_MouseDown);
            this.btn_Intermediate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Intermediate_MouseUp);
            // 
            // lbl_i_In
            // 
            this.lbl_i_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_i_In.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_In.Image")));
            this.lbl_i_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_In.Location = new System.Drawing.Point(264, 31);
            this.lbl_i_In.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_In.Name = "lbl_i_In";
            this.lbl_i_In.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_In.Size = new System.Drawing.Size(140, 35);
            this.lbl_i_In.TabIndex = 21;
            this.lbl_i_In.Text = "    In";
            this.lbl_i_In.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_i_Out
            // 
            this.lbl_i_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_i_Out.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Out.Image")));
            this.lbl_i_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Out.Location = new System.Drawing.Point(264, 66);
            this.lbl_i_Out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Out.Name = "lbl_i_Out";
            this.lbl_i_Out.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Out.Size = new System.Drawing.Size(140, 35);
            this.lbl_i_Out.TabIndex = 22;
            this.lbl_i_Out.Text = "    Out";
            this.lbl_i_Out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_i_Move
            // 
            this.lbl_i_Move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_i_Move.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Move.Image")));
            this.lbl_i_Move.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Move.Location = new System.Drawing.Point(264, 101);
            this.lbl_i_Move.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Move.Name = "lbl_i_Move";
            this.lbl_i_Move.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Move.Size = new System.Drawing.Size(140, 35);
            this.lbl_i_Move.TabIndex = 23;
            this.lbl_i_Move.Text = "    Move";
            this.lbl_i_Move.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_i_Device
            // 
            this.lbl_i_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_i_Device.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Device.Image")));
            this.lbl_i_Device.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Device.Location = new System.Drawing.Point(264, 136);
            this.lbl_i_Device.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Device.Name = "lbl_i_Device";
            this.lbl_i_Device.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Device.Size = new System.Drawing.Size(140, 35);
            this.lbl_i_Device.TabIndex = 24;
            this.lbl_i_Device.Text = "    Device";
            this.lbl_i_Device.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_i_Intermediate
            // 
            this.lbl_i_Intermediate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_i_Intermediate.Image = ((System.Drawing.Image)(resources.GetObject("lbl_i_Intermediate.Image")));
            this.lbl_i_Intermediate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_i_Intermediate.Location = new System.Drawing.Point(264, 171);
            this.lbl_i_Intermediate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_i_Intermediate.Name = "lbl_i_Intermediate";
            this.lbl_i_Intermediate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbl_i_Intermediate.Size = new System.Drawing.Size(140, 35);
            this.lbl_i_Intermediate.TabIndex = 25;
            this.lbl_i_Intermediate.Text = "    Intermediate";
            this.lbl_i_Intermediate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(414, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ISDU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Start);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(36, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 333);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position List";
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Start.Location = new System.Drawing.Point(3, 283);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(194, 47);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(3, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 257);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 76);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_IP);
            this.groupBox3.Controls.Add(this.btn_Connect);
            this.groupBox3.Location = new System.Drawing.Point(33, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection";
            // 
            // txt_IP
            // 
            this.txt_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_IP.Location = new System.Drawing.Point(3, 26);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(199, 30);
            this.txt_IP.TabIndex = 1;
            this.txt_IP.Text = "192.168.1.10";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Connect.Location = new System.Drawing.Point(202, 26);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(114, 29);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // imageList_Status
            // 
            this.imageList_Status.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Status.ImageStream")));
            this.imageList_Status.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Status.Images.SetKeyName(0, "status-offline.png");
            this.imageList_Status.Images.SetKeyName(1, "status.png");
            // 
            // imageList_Error
            // 
            this.imageList_Error.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Error.ImageStream")));
            this.imageList_Error.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Error.Images.SetKeyName(0, "status-offline.png");
            this.imageList_Error.Images.SetKeyName(1, "status-busy.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_ISDU);
            this.Font = new System.Drawing.Font("MetaPlusLF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SMS Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_ISDU.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ISDU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cob_Channel;
        private System.Windows.Forms.TextBox txt_ModuleNumber;
        private System.Windows.Forms.ComboBox cob_Command;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.TextBox txt_Subindex;
        private System.Windows.Forms.TextBox txt_Index;
        private System.Windows.Forms.Label lbl_ISDUstatus;
        private System.Windows.Forms.ComboBox cob_ParaList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_AddressStart;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.Button btn_Ack;
        private System.Windows.Forms.Button btn_Intermediate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox cob_Type;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_i_In;
        private System.Windows.Forms.Label lbl_i_Out;
        private System.Windows.Forms.Label lbl_i_Move;
        private System.Windows.Forms.Label lbl_i_Device;
        private System.Windows.Forms.Label lbl_i_Intermediate;
        private System.Windows.Forms.ImageList imageList_Status;
        private System.Windows.Forms.ImageList imageList_Error;
        private System.Windows.Forms.Timer timer1;
    }
}

