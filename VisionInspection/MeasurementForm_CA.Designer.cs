
namespace VisionInspection
{
    partial class MeasurementForm_CA
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasurementForm_CA));
            label6 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            lblDateTime = new System.Windows.Forms.Label();
            lblModel = new System.Windows.Forms.Label();
            pic2 = new System.Windows.Forms.PictureBox();
            pic1 = new System.Windows.Forms.PictureBox();
            lblResult = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            picModel = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            lblNGList = new System.Windows.Forms.Label();
            lblServer = new System.Windows.Forms.Label();
            lblPLC = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblTrigger1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblFinal1 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnMinimize = new System.Windows.Forms.Button();
            timerFlicker = new System.Windows.Forms.Timer(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timerPLCMonitor = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picModel).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.MidnightBlue;
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(2195, 99);
            label6.TabIndex = 15;
            label6.Text = "C_PAD VISION - COMPLETE ASSY";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label6.DoubleClick += label6_DoubleClick;
            label6.MouseDown += label6_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pic2);
            panel1.Controls.Add(pic1);
            panel1.Controls.Add(lblResult);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 1091);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(2195, 281);
            panel1.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDateTime);
            panel3.Controls.Add(lblModel);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(724, 0);
            panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1089, 281);
            panel3.TabIndex = 47;
            // 
            // lblDateTime
            // 
            lblDateTime.BackColor = System.Drawing.Color.Black;
            lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            lblDateTime.ForeColor = System.Drawing.Color.White;
            lblDateTime.Location = new System.Drawing.Point(0, 178);
            lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(1089, 103);
            lblDateTime.TabIndex = 48;
            lblDateTime.Text = "2024-05-02 00:00:00";
            lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            lblModel.BackColor = System.Drawing.Color.Teal;
            lblModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblModel.Dock = System.Windows.Forms.DockStyle.Top;
            lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            lblModel.ForeColor = System.Drawing.Color.White;
            lblModel.Location = new System.Drawing.Point(0, 0);
            lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new System.Drawing.Size(1089, 176);
            lblModel.TabIndex = 47;
            lblModel.Text = "ME1a NNB NON-HUD TPO";
            lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic2
            // 
            pic2.BackColor = System.Drawing.Color.Black;
            pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic2.Dock = System.Windows.Forms.DockStyle.Left;
            pic2.Location = new System.Drawing.Point(362, 0);
            pic2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pic2.Name = "pic2";
            pic2.Size = new System.Drawing.Size(362, 281);
            pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 45;
            pic2.TabStop = false;
            // 
            // pic1
            // 
            pic1.BackColor = System.Drawing.Color.Black;
            pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic1.Dock = System.Windows.Forms.DockStyle.Left;
            pic1.Location = new System.Drawing.Point(0, 0);
            pic1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pic1.Name = "pic1";
            pic1.Size = new System.Drawing.Size(362, 281);
            pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 44;
            pic1.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.BackColor = System.Drawing.Color.Gray;
            lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblResult.Dock = System.Windows.Forms.DockStyle.Right;
            lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            lblResult.ForeColor = System.Drawing.Color.Black;
            lblResult.Location = new System.Drawing.Point(1813, 0);
            lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(382, 281);
            lblResult.TabIndex = 41;
            lblResult.Text = "OK";
            lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblResult.Click += lblResult_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel9);
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(0, 99);
            panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(2195, 992);
            panel4.TabIndex = 17;
            // 
            // panel9
            // 
            panel9.BackColor = System.Drawing.Color.White;
            panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel9.Controls.Add(picModel);
            panel9.Controls.Add(panel2);
            panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            panel9.Location = new System.Drawing.Point(0, 0);
            panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(2195, 992);
            panel9.TabIndex = 9;
            // 
            // picModel
            // 
            picModel.BackColor = System.Drawing.Color.White;
            picModel.Dock = System.Windows.Forms.DockStyle.Fill;
            picModel.Location = new System.Drawing.Point(0, 0);
            picModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            picModel.Name = "picModel";
            picModel.Size = new System.Drawing.Size(2193, 887);
            picModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picModel.TabIndex = 2;
            picModel.TabStop = false;
            picModel.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblNGList);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 887);
            panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(2193, 103);
            panel2.TabIndex = 1;
            // 
            // lblNGList
            // 
            lblNGList.BackColor = System.Drawing.Color.Gray;
            lblNGList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblNGList.Dock = System.Windows.Forms.DockStyle.Fill;
            lblNGList.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            lblNGList.ForeColor = System.Drawing.Color.White;
            lblNGList.Location = new System.Drawing.Point(0, 0);
            lblNGList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNGList.Name = "lblNGList";
            lblNGList.Size = new System.Drawing.Size(2193, 103);
            lblNGList.TabIndex = 47;
            lblNGList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServer
            // 
            lblServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblServer.BackColor = System.Drawing.Color.Red;
            lblServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            lblServer.ForeColor = System.Drawing.Color.Black;
            lblServer.Location = new System.Drawing.Point(1860, 17);
            lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServer.Name = "lblServer";
            lblServer.Size = new System.Drawing.Size(51, 63);
            lblServer.TabIndex = 23;
            lblServer.Text = "S";
            lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblServer.Visible = false;
            lblServer.Click += lblServer_Click;
            // 
            // lblPLC
            // 
            lblPLC.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblPLC.BackColor = System.Drawing.Color.Red;
            lblPLC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            lblPLC.ForeColor = System.Drawing.Color.Black;
            lblPLC.Location = new System.Drawing.Point(1920, 14);
            lblPLC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPLC.Name = "lblPLC";
            lblPLC.Size = new System.Drawing.Size(107, 63);
            lblPLC.TabIndex = 24;
            lblPLC.Text = "PLC";
            lblPLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPLC.MouseDown += lblPLC_MouseDown;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label3.Location = new System.Drawing.Point(288, 30);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 30);
            label3.TabIndex = 26;
            label3.Text = "TRIGG";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrigger1
            // 
            lblTrigger1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTrigger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            lblTrigger1.Location = new System.Drawing.Point(368, 30);
            lblTrigger1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTrigger1.Name = "lblTrigger1";
            lblTrigger1.Size = new System.Drawing.Size(78, 29);
            lblTrigger1.TabIndex = 26;
            lblTrigger1.Text = " ";
            lblTrigger1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label5.Location = new System.Drawing.Point(288, 60);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 30);
            label5.TabIndex = 26;
            label5.Text = "FINAL";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinal1
            // 
            lblFinal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblFinal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            lblFinal1.Location = new System.Drawing.Point(368, 60);
            lblFinal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFinal1.Name = "lblFinal1";
            lblFinal1.Size = new System.Drawing.Size(78, 29);
            lblFinal1.TabIndex = 26;
            lblFinal1.Text = " ";
            lblFinal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.White;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(2113, 17);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(68, 64);
            btnClose.TabIndex = 29;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMinimize.BackColor = System.Drawing.Color.White;
            btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new System.Drawing.Point(2036, 17);
            btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new System.Drawing.Size(68, 64);
            btnMinimize.TabIndex = 30;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // timerFlicker
            // 
            timerFlicker.Enabled = true;
            timerFlicker.Interval = 500;
            timerFlicker.Tick += timerFlicker_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(16, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(264, 77);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // timerPLCMonitor
            // 
            timerPLCMonitor.Interval = 500;
            timerPLCMonitor.Tick += timerPLCMonitor_Tick;
            // 
            // MeasurementForm_CA
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(2195, 1372);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnMinimize);
            Controls.Add(lblFinal1);
            Controls.Add(lblTrigger1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblServer);
            Controls.Add(lblPLC);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label6);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "MeasurementForm_CA";
            Text = "CPAD Vision Measurement";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picModel).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblPLC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrigger1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFinal1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timerFlicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerPLCMonitor;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox picModel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNGList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblModel;
    }
}

