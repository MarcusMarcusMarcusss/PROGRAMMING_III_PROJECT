namespace MusicPlayer_Project
{    /*
     * Name:Mark Xie
     * Student Id:p447119
     * Date:11/11/2019
     * Programming III
     */
    partial class MoeMusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoeMusicPlayer));
            this.PanelButtom = new System.Windows.Forms.Panel();
            this.BtnfullSize = new System.Windows.Forms.Button();
            this.LBLMediaTime = new System.Windows.Forms.Label();
            this.LBLMediaName = new System.Windows.Forms.Label();
            this.PicBoxMusicfile = new System.Windows.Forms.PictureBox();
            this.BtnRewind = new System.Windows.Forms.Button();
            this.BtnFast = new System.Windows.Forms.Button();
            this.BtnNextSong = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPreviousSong = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.LbUserName = new System.Windows.Forms.Label();
            this.panelPlayList = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.LBOutput = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStatus = new System.Windows.Forms.Label();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnSearchList = new System.Windows.Forms.Button();
            this.TbSearcPlayList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.panelHead = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.Btnclose = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.timerMediaDuration = new System.Windows.Forms.Timer(this.components);
            this.PanelButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMusicfile)).BeginInit();
            this.panelPlayList.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelButtom
            // 
            this.PanelButtom.BackColor = System.Drawing.Color.Transparent;
            this.PanelButtom.Controls.Add(this.BtnfullSize);
            this.PanelButtom.Controls.Add(this.LBLMediaTime);
            this.PanelButtom.Controls.Add(this.LBLMediaName);
            this.PanelButtom.Controls.Add(this.PicBoxMusicfile);
            this.PanelButtom.Controls.Add(this.BtnRewind);
            this.PanelButtom.Controls.Add(this.BtnFast);
            this.PanelButtom.Controls.Add(this.BtnNextSong);
            this.PanelButtom.Controls.Add(this.BtnStop);
            this.PanelButtom.Controls.Add(this.BtnPreviousSong);
            this.PanelButtom.Controls.Add(this.btnStart);
            this.PanelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtom.Location = new System.Drawing.Point(0, 516);
            this.PanelButtom.Name = "PanelButtom";
            this.PanelButtom.Size = new System.Drawing.Size(865, 69);
            this.PanelButtom.TabIndex = 2;
            // 
            // BtnfullSize
            // 
            this.BtnfullSize.BackColor = System.Drawing.Color.Transparent;
            this.BtnfullSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnfullSize.FlatAppearance.BorderSize = 0;
            this.BtnfullSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnfullSize.ForeColor = System.Drawing.Color.White;
            this.BtnfullSize.Image = global::MusicPlayer_Project.Properties.Resources.expand_24px;
            this.BtnfullSize.Location = new System.Drawing.Point(835, 36);
            this.BtnfullSize.Name = "BtnfullSize";
            this.BtnfullSize.Size = new System.Drawing.Size(21, 23);
            this.BtnfullSize.TabIndex = 37;
            this.toolTip.SetToolTip(this.BtnfullSize, "Full Screen");
            this.BtnfullSize.UseVisualStyleBackColor = false;
            this.BtnfullSize.Click += new System.EventHandler(this.BtnfullSize_Click);
            // 
            // LBLMediaTime
            // 
            this.LBLMediaTime.AutoSize = true;
            this.LBLMediaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMediaTime.ForeColor = System.Drawing.Color.White;
            this.LBLMediaTime.Location = new System.Drawing.Point(65, 34);
            this.LBLMediaTime.Name = "LBLMediaTime";
            this.LBLMediaTime.Size = new System.Drawing.Size(0, 15);
            this.LBLMediaTime.TabIndex = 36;
            // 
            // LBLMediaName
            // 
            this.LBLMediaName.AutoEllipsis = true;
            this.LBLMediaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMediaName.ForeColor = System.Drawing.Color.White;
            this.LBLMediaName.Location = new System.Drawing.Point(62, 11);
            this.LBLMediaName.Name = "LBLMediaName";
            this.LBLMediaName.Size = new System.Drawing.Size(130, 24);
            this.LBLMediaName.TabIndex = 35;
            // 
            // PicBoxMusicfile
            // 
            this.PicBoxMusicfile.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxMusicfile.Image")));
            this.PicBoxMusicfile.InitialImage = null;
            this.PicBoxMusicfile.Location = new System.Drawing.Point(10, 13);
            this.PicBoxMusicfile.Name = "PicBoxMusicfile";
            this.PicBoxMusicfile.Size = new System.Drawing.Size(46, 44);
            this.PicBoxMusicfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxMusicfile.TabIndex = 34;
            this.PicBoxMusicfile.TabStop = false;
            this.toolTip.SetToolTip(this.PicBoxMusicfile, "Add Mp3 file");
            this.PicBoxMusicfile.Click += new System.EventHandler(this.PicBoxMusicfile_Click);
            // 
            // BtnRewind
            // 
            this.BtnRewind.BackColor = System.Drawing.Color.Transparent;
            this.BtnRewind.FlatAppearance.BorderSize = 0;
            this.BtnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRewind.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRewind.Image = ((System.Drawing.Image)(resources.GetObject("BtnRewind.Image")));
            this.BtnRewind.Location = new System.Drawing.Point(255, 20);
            this.BtnRewind.Name = "BtnRewind";
            this.BtnRewind.Size = new System.Drawing.Size(30, 30);
            this.BtnRewind.TabIndex = 28;
            this.toolTip.SetToolTip(this.BtnRewind, "Rewind ");
            this.BtnRewind.UseVisualStyleBackColor = false;
            this.BtnRewind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRewind_MouseDown);
            this.BtnRewind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRewind_MouseUp);
            // 
            // BtnFast
            // 
            this.BtnFast.BackColor = System.Drawing.Color.Transparent;
            this.BtnFast.FlatAppearance.BorderSize = 0;
            this.BtnFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFast.ForeColor = System.Drawing.Color.Transparent;
            this.BtnFast.Image = ((System.Drawing.Image)(resources.GetObject("BtnFast.Image")));
            this.BtnFast.Location = new System.Drawing.Point(531, 22);
            this.BtnFast.Name = "BtnFast";
            this.BtnFast.Size = new System.Drawing.Size(30, 30);
            this.BtnFast.TabIndex = 27;
            this.toolTip.SetToolTip(this.BtnFast, "FastForword");
            this.BtnFast.UseVisualStyleBackColor = false;
            this.BtnFast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFast_MouseDown);
            this.BtnFast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFast_MouseUp);
            // 
            // BtnNextSong
            // 
            this.BtnNextSong.BackColor = System.Drawing.Color.Transparent;
            this.BtnNextSong.FlatAppearance.BorderSize = 0;
            this.BtnNextSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSong.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNextSong.Image = global::MusicPlayer_Project.Properties.Resources.chevron_right_30px;
            this.BtnNextSong.Location = new System.Drawing.Point(478, 22);
            this.BtnNextSong.Name = "BtnNextSong";
            this.BtnNextSong.Size = new System.Drawing.Size(30, 30);
            this.BtnNextSong.TabIndex = 23;
            this.toolTip.SetToolTip(this.BtnNextSong, "Next Song");
            this.BtnNextSong.UseVisualStyleBackColor = false;
            this.BtnNextSong.Click += new System.EventHandler(this.BtnNextSong_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.Color.Transparent;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Location = new System.Drawing.Point(384, 22);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(30, 30);
            this.BtnStop.TabIndex = 22;
            this.toolTip.SetToolTip(this.BtnStop, "Stop ");
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPreviousSong
            // 
            this.BtnPreviousSong.BackColor = System.Drawing.Color.Transparent;
            this.BtnPreviousSong.FlatAppearance.BorderSize = 0;
            this.BtnPreviousSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreviousSong.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPreviousSong.Image = global::MusicPlayer_Project.Properties.Resources.chevron_left_30px;
            this.BtnPreviousSong.Location = new System.Drawing.Point(314, 22);
            this.BtnPreviousSong.Name = "BtnPreviousSong";
            this.BtnPreviousSong.Size = new System.Drawing.Size(30, 30);
            this.BtnPreviousSong.TabIndex = 20;
            this.toolTip.SetToolTip(this.BtnPreviousSong, "Pervious Song");
            this.BtnPreviousSong.UseVisualStyleBackColor = false;
            this.BtnPreviousSong.Click += new System.EventHandler(this.BtnPreviousSong_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Image = global::MusicPlayer_Project.Properties.Resources.start_40px;
            this.btnStart.Location = new System.Drawing.Point(420, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(35, 35);
            this.btnStart.TabIndex = 19;
            this.toolTip.SetToolTip(this.btnStart, "Start/Pause");
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.ForeColor = System.Drawing.Color.MediumOrchid;
            this.LbUserName.Location = new System.Drawing.Point(672, 8);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbUserName.Size = new System.Drawing.Size(101, 24);
            this.LbUserName.TabIndex = 26;
            this.LbUserName.Text = "UserName";
            this.LbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPlayList
            // 
            this.panelPlayList.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayList.Controls.Add(this.BtnClear);
            this.panelPlayList.Controls.Add(this.BtnAddFile);
            this.panelPlayList.Controls.Add(this.LBOutput);
            this.panelPlayList.Controls.Add(this.labelStatus);
            this.panelPlayList.Controls.Add(this.BtnSort);
            this.panelPlayList.Controls.Add(this.BtnSearchList);
            this.panelPlayList.Controls.Add(this.TbSearcPlayList);
            this.panelPlayList.Controls.Add(this.label1);
            this.panelPlayList.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPlayList.Location = new System.Drawing.Point(614, 39);
            this.panelPlayList.Name = "panelPlayList";
            this.panelPlayList.Size = new System.Drawing.Size(251, 477);
            this.panelPlayList.TabIndex = 3;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClear.Image = global::MusicPlayer_Project.Properties.Resources.insert_button_30px;
            this.BtnClear.Location = new System.Drawing.Point(215, 123);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(30, 30);
            this.BtnClear.TabIndex = 29;
            this.toolTip.SetToolTip(this.BtnClear, "Clear playlist");
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.BtnAddFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddFile.BackgroundImage")));
            this.BtnAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddFile.FlatAppearance.BorderSize = 0;
            this.BtnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddFile.ForeColor = System.Drawing.Color.White;
            this.BtnAddFile.Location = new System.Drawing.Point(182, 423);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(29, 25);
            this.BtnAddFile.TabIndex = 27;
            this.toolTip.SetToolTip(this.BtnAddFile, "Add file");
            this.BtnAddFile.UseVisualStyleBackColor = false;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // LBOutput
            // 
            this.LBOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.LBOutput.ContextMenuStrip = this.contextMenuStrip1;
            this.LBOutput.FormattingEnabled = true;
            this.LBOutput.Location = new System.Drawing.Point(12, 69);
            this.LBOutput.Name = "LBOutput";
            this.LBOutput.Size = new System.Drawing.Size(201, 381);
            this.LBOutput.TabIndex = 6;
            this.LBOutput.DoubleClick += new System.EventHandler(this.LBOutput_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(162, 16);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 28;
            this.labelStatus.Text = "Status";
            // 
            // BtnSort
            // 
            this.BtnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSort.BackColor = System.Drawing.Color.Transparent;
            this.BtnSort.FlatAppearance.BorderSize = 0;
            this.BtnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSort.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSort.Image = global::MusicPlayer_Project.Properties.Resources.alphabetical_sorting_25px1;
            this.BtnSort.Location = new System.Drawing.Point(215, 77);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(30, 30);
            this.BtnSort.TabIndex = 25;
            this.toolTip.SetToolTip(this.BtnSort, "Sort Songlist");
            this.BtnSort.UseVisualStyleBackColor = false;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnSearchList
            // 
            this.BtnSearchList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchList.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchList.BackgroundImage = global::MusicPlayer_Project.Properties.Resources.search_filled_25px1;
            this.BtnSearchList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearchList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSearchList.FlatAppearance.BorderSize = 0;
            this.BtnSearchList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSearchList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSearchList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchList.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSearchList.Location = new System.Drawing.Point(217, 36);
            this.BtnSearchList.Name = "BtnSearchList";
            this.BtnSearchList.Size = new System.Drawing.Size(25, 25);
            this.BtnSearchList.TabIndex = 11;
            this.toolTip.SetToolTip(this.BtnSearchList, "Search from list");
            this.BtnSearchList.UseVisualStyleBackColor = false;
            this.BtnSearchList.Click += new System.EventHandler(this.BtnSearchList_Click);
            // 
            // TbSearcPlayList
            // 
            this.TbSearcPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearcPlayList.BackColor = System.Drawing.Color.SlateBlue;
            this.TbSearcPlayList.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.TbSearcPlayList.ForeColor = System.Drawing.Color.White;
            this.TbSearcPlayList.Location = new System.Drawing.Point(16, 36);
            this.TbSearcPlayList.Name = "TbSearcPlayList";
            this.TbSearcPlayList.Size = new System.Drawing.Size(197, 27);
            this.TbSearcPlayList.TabIndex = 9;
            this.TbSearcPlayList.Text = "Search Playlist";
            this.TbSearcPlayList.Click += new System.EventHandler(this.TbSearchStore_Click);
            this.TbSearcPlayList.TextChanged += new System.EventHandler(this.TbSearcPlayList_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "PlayList";
            // 
            // timerTick
            // 
            this.timerTick.Interval = 5;
            this.timerTick.Tick += new System.EventHandler(this.TimerTick_Tick_1);
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Transparent;
            this.panelHead.Controls.Add(this.label4);
            this.panelHead.Controls.Add(this.BtnMinus);
            this.panelHead.Controls.Add(this.BtnMax);
            this.panelHead.Controls.Add(this.LbUserName);
            this.panelHead.Controls.Add(this.Btnclose);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(865, 39);
            this.panelHead.TabIndex = 1;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHead_MouseMove);
            this.panelHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHead_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = global::MusicPlayer_Project.Properties.Resources.disney_movies_96px;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "MoePlayer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinus.BackgroundImage = global::MusicPlayer_Project.Properties.Resources.minus_math_20px;
            this.BtnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMinus.FlatAppearance.BorderSize = 0;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinus.Location = new System.Drawing.Point(779, 19);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(19, 19);
            this.BtnMinus.TabIndex = 7;
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.BackColor = System.Drawing.Color.Transparent;
            this.BtnMax.BackgroundImage = global::MusicPlayer_Project.Properties.Resources.full_screen_21px;
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMax.Location = new System.Drawing.Point(805, 12);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(21, 23);
            this.BtnMax.TabIndex = 15;
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // Btnclose
            // 
            this.Btnclose.BackColor = System.Drawing.Color.Transparent;
            this.Btnclose.BackgroundImage = global::MusicPlayer_Project.Properties.Resources.shutdown_20px1;
            this.Btnclose.FlatAppearance.BorderSize = 0;
            this.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnclose.ForeColor = System.Drawing.Color.Transparent;
            this.Btnclose.Location = new System.Drawing.Point(833, 12);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(20, 20);
            this.Btnclose.TabIndex = 5;
            this.Btnclose.UseVisualStyleBackColor = false;
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 44);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(612, 472);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // timerMediaDuration
            // 
            this.timerMediaDuration.Enabled = true;
            this.timerMediaDuration.Interval = 1000;
            this.timerMediaDuration.Tick += new System.EventHandler(this.TimerMediaDuration_Tick);
            // 
            // MoeMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 585);
            this.Controls.Add(this.panelPlayList);
            this.Controls.Add(this.PanelButtom);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoeMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoeMusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoeMusicPlayer_FormClosing);
            this.PanelButtom.ResumeLayout(false);
            this.PanelButtom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMusicfile)).EndInit();
            this.panelPlayList.ResumeLayout(false);
            this.panelPlayList.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelButtom;
        private System.Windows.Forms.Panel panelPlayList;
        private System.Windows.Forms.ListBox LBOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbSearcPlayList;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Button BtnPreviousSong;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnNextSong;
        private System.Windows.Forms.Button BtnSearchList;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button Btnclose;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelHead;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button BtnFast;
        private System.Windows.Forms.Label labelStatus;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button BtnAddFile;
        private System.Windows.Forms.PictureBox PicBoxMusicfile;
        private System.Windows.Forms.Button BtnRewind;
        private System.Windows.Forms.Label LBLMediaTime;
        private System.Windows.Forms.Label LBLMediaName;
        private System.Windows.Forms.Button BtnfullSize;
        private System.Windows.Forms.Timer timerMediaDuration;
        private System.Windows.Forms.Button BtnClear;
    }
}