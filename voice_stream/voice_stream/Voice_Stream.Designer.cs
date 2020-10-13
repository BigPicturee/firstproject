namespace voice_stream
{
    partial class Voice_Stream
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
            this.Title_name = new System.Windows.Forms.Label();
            this.Make_Room = new System.Windows.Forms.Button();
            this.Join_Room1 = new System.Windows.Forms.GroupBox();
            this.Room_St1 = new System.Windows.Forms.Label();
            this.Room_Check1 = new System.Windows.Forms.Label();
            this.Room_Num1 = new System.Windows.Forms.Button();
            this.Join_Room4 = new System.Windows.Forms.GroupBox();
            this.Room_St4 = new System.Windows.Forms.Label();
            this.Room_Check4 = new System.Windows.Forms.Label();
            this.Room_Num4 = new System.Windows.Forms.Button();
            this.Join_Room2 = new System.Windows.Forms.GroupBox();
            this.Room_St2 = new System.Windows.Forms.Label();
            this.Room_Check2 = new System.Windows.Forms.Label();
            this.Room_Num2 = new System.Windows.Forms.Button();
            this.Join_Room5 = new System.Windows.Forms.GroupBox();
            this.Room_St5 = new System.Windows.Forms.Label();
            this.Room_Check5 = new System.Windows.Forms.Label();
            this.Room_Num5 = new System.Windows.Forms.Button();
            this.Join_Room3 = new System.Windows.Forms.GroupBox();
            this.Room_St3 = new System.Windows.Forms.Label();
            this.Room_Check3 = new System.Windows.Forms.Label();
            this.Room_Num3 = new System.Windows.Forms.Button();
            this.Join_Room6 = new System.Windows.Forms.GroupBox();
            this.Room_St6 = new System.Windows.Forms.Label();
            this.Room_Check6 = new System.Windows.Forms.Label();
            this.Room_Num6 = new System.Windows.Forms.Button();
            this.Voice_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.New_Check = new System.Windows.Forms.Button();
            this.Join_Room1.SuspendLayout();
            this.Join_Room4.SuspendLayout();
            this.Join_Room2.SuspendLayout();
            this.Join_Room5.SuspendLayout();
            this.Join_Room3.SuspendLayout();
            this.Join_Room6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_name
            // 
            this.Title_name.AutoSize = true;
            this.Title_name.Font = new System.Drawing.Font("굴림", 20F);
            this.Title_name.Location = new System.Drawing.Point(13, 13);
            this.Title_name.MaximumSize = new System.Drawing.Size(800, 30);
            this.Title_name.MinimumSize = new System.Drawing.Size(800, 30);
            this.Title_name.Name = "Title_name";
            this.Title_name.Size = new System.Drawing.Size(800, 30);
            this.Title_name.TabIndex = 0;
            this.Title_name.Text = "당신이 선택한 아름다운 목소리";
            this.Title_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Make_Room
            // 
            this.Make_Room.Location = new System.Drawing.Point(722, 96);
            this.Make_Room.MaximumSize = new System.Drawing.Size(100, 50);
            this.Make_Room.MinimumSize = new System.Drawing.Size(100, 50);
            this.Make_Room.Name = "Make_Room";
            this.Make_Room.Size = new System.Drawing.Size(100, 50);
            this.Make_Room.TabIndex = 1;
            this.Make_Room.Text = "방만들기";
            this.Make_Room.UseVisualStyleBackColor = true;
            this.Make_Room.Click += new System.EventHandler(this.Make_Room_Click);
            // 
            // Join_Room1
            // 
            this.Join_Room1.Controls.Add(this.Room_St1);
            this.Join_Room1.Controls.Add(this.Room_Check1);
            this.Join_Room1.Controls.Add(this.Room_Num1);
            this.Join_Room1.Location = new System.Drawing.Point(12, 91);
            this.Join_Room1.MaximumSize = new System.Drawing.Size(200, 140);
            this.Join_Room1.MinimumSize = new System.Drawing.Size(200, 140);
            this.Join_Room1.Name = "Join_Room1";
            this.Join_Room1.Size = new System.Drawing.Size(200, 140);
            this.Join_Room1.TabIndex = 3;
            this.Join_Room1.TabStop = false;
            this.Join_Room1.Text = "1번 보이스방";
            // 
            // Room_St1
            // 
            this.Room_St1.AutoSize = true;
            this.Room_St1.Location = new System.Drawing.Point(16, 60);
            this.Room_St1.Name = "Room_St1";
            this.Room_St1.Size = new System.Drawing.Size(29, 12);
            this.Room_St1.TabIndex = 2;
            this.Room_St1.Text = "빈방";
            // 
            // Room_Check1
            // 
            this.Room_Check1.AutoSize = true;
            this.Room_Check1.Location = new System.Drawing.Point(16, 40);
            this.Room_Check1.Name = "Room_Check1";
            this.Room_Check1.Size = new System.Drawing.Size(63, 12);
            this.Room_Check1.TabIndex = 1;
            this.Room_Check1.Text = "0명 접속중";
            // 
            // Room_Num1
            // 
            this.Room_Num1.Location = new System.Drawing.Point(55, 90);
            this.Room_Num1.MaximumSize = new System.Drawing.Size(80, 30);
            this.Room_Num1.MinimumSize = new System.Drawing.Size(80, 30);
            this.Room_Num1.Name = "Room_Num1";
            this.Room_Num1.Size = new System.Drawing.Size(80, 30);
            this.Room_Num1.TabIndex = 0;
            this.Room_Num1.Text = "참여하기";
            this.Room_Num1.UseVisualStyleBackColor = true;
            this.Room_Num1.Click += new System.EventHandler(this.Room_Num1_Click);
            // 
            // Join_Room4
            // 
            this.Join_Room4.Controls.Add(this.Room_St4);
            this.Join_Room4.Controls.Add(this.Room_Check4);
            this.Join_Room4.Controls.Add(this.Room_Num4);
            this.Join_Room4.Location = new System.Drawing.Point(12, 275);
            this.Join_Room4.MaximumSize = new System.Drawing.Size(200, 140);
            this.Join_Room4.MinimumSize = new System.Drawing.Size(200, 140);
            this.Join_Room4.Name = "Join_Room4";
            this.Join_Room4.Size = new System.Drawing.Size(200, 140);
            this.Join_Room4.TabIndex = 3;
            this.Join_Room4.TabStop = false;
            this.Join_Room4.Text = "4번 보이스방";
            // 
            // Room_St4
            // 
            this.Room_St4.AutoSize = true;
            this.Room_St4.Location = new System.Drawing.Point(18, 60);
            this.Room_St4.Name = "Room_St4";
            this.Room_St4.Size = new System.Drawing.Size(29, 12);
            this.Room_St4.TabIndex = 2;
            this.Room_St4.Text = "빈방";
            // 
            // Room_Check4
            // 
            this.Room_Check4.AutoSize = true;
            this.Room_Check4.Location = new System.Drawing.Point(16, 40);
            this.Room_Check4.Name = "Room_Check4";
            this.Room_Check4.Size = new System.Drawing.Size(63, 12);
            this.Room_Check4.TabIndex = 1;
            this.Room_Check4.Text = "0명 접속중";
            // 
            // Room_Num4
            // 
            this.Room_Num4.Location = new System.Drawing.Point(55, 90);
            this.Room_Num4.MaximumSize = new System.Drawing.Size(80, 30);
            this.Room_Num4.MinimumSize = new System.Drawing.Size(80, 30);
            this.Room_Num4.Name = "Room_Num4";
            this.Room_Num4.Size = new System.Drawing.Size(80, 30);
            this.Room_Num4.TabIndex = 0;
            this.Room_Num4.Text = "참여하기";
            this.Room_Num4.UseVisualStyleBackColor = true;
            this.Room_Num4.Click += new System.EventHandler(this.Room_Num4_Click);
            // 
            // Join_Room2
            // 
            this.Join_Room2.Controls.Add(this.Room_St2);
            this.Join_Room2.Controls.Add(this.Room_Check2);
            this.Join_Room2.Controls.Add(this.Room_Num2);
            this.Join_Room2.Location = new System.Drawing.Point(258, 91);
            this.Join_Room2.MaximumSize = new System.Drawing.Size(200, 140);
            this.Join_Room2.MinimumSize = new System.Drawing.Size(200, 140);
            this.Join_Room2.Name = "Join_Room2";
            this.Join_Room2.Size = new System.Drawing.Size(200, 140);
            this.Join_Room2.TabIndex = 3;
            this.Join_Room2.TabStop = false;
            this.Join_Room2.Text = "2번 보이스방";
            // 
            // Room_St2
            // 
            this.Room_St2.AutoSize = true;
            this.Room_St2.Location = new System.Drawing.Point(18, 60);
            this.Room_St2.Name = "Room_St2";
            this.Room_St2.Size = new System.Drawing.Size(29, 12);
            this.Room_St2.TabIndex = 2;
            this.Room_St2.Text = "빈방";
            // 
            // Room_Check2
            // 
            this.Room_Check2.AutoSize = true;
            this.Room_Check2.Location = new System.Drawing.Point(16, 40);
            this.Room_Check2.Name = "Room_Check2";
            this.Room_Check2.Size = new System.Drawing.Size(63, 12);
            this.Room_Check2.TabIndex = 1;
            this.Room_Check2.Text = "0명 접속중";
            // 
            // Room_Num2
            // 
            this.Room_Num2.Location = new System.Drawing.Point(55, 90);
            this.Room_Num2.MaximumSize = new System.Drawing.Size(80, 30);
            this.Room_Num2.MinimumSize = new System.Drawing.Size(80, 30);
            this.Room_Num2.Name = "Room_Num2";
            this.Room_Num2.Size = new System.Drawing.Size(80, 30);
            this.Room_Num2.TabIndex = 0;
            this.Room_Num2.Text = "참여하기";
            this.Room_Num2.UseVisualStyleBackColor = true;
            this.Room_Num2.Click += new System.EventHandler(this.Room_Num2_Click);
            // 
            // Join_Room5
            // 
            this.Join_Room5.Controls.Add(this.Room_St5);
            this.Join_Room5.Controls.Add(this.Room_Check5);
            this.Join_Room5.Controls.Add(this.Room_Num5);
            this.Join_Room5.Location = new System.Drawing.Point(258, 275);
            this.Join_Room5.MaximumSize = new System.Drawing.Size(200, 140);
            this.Join_Room5.MinimumSize = new System.Drawing.Size(200, 140);
            this.Join_Room5.Name = "Join_Room5";
            this.Join_Room5.Size = new System.Drawing.Size(200, 140);
            this.Join_Room5.TabIndex = 3;
            this.Join_Room5.TabStop = false;
            this.Join_Room5.Text = "5번 보이스방";
            // 
            // Room_St5
            // 
            this.Room_St5.AutoSize = true;
            this.Room_St5.Location = new System.Drawing.Point(18, 60);
            this.Room_St5.Name = "Room_St5";
            this.Room_St5.Size = new System.Drawing.Size(29, 12);
            this.Room_St5.TabIndex = 2;
            this.Room_St5.Text = "빈방";
            // 
            // Room_Check5
            // 
            this.Room_Check5.AutoSize = true;
            this.Room_Check5.Location = new System.Drawing.Point(16, 40);
            this.Room_Check5.Name = "Room_Check5";
            this.Room_Check5.Size = new System.Drawing.Size(63, 12);
            this.Room_Check5.TabIndex = 1;
            this.Room_Check5.Text = "0명 접속중";
            // 
            // Room_Num5
            // 
            this.Room_Num5.Location = new System.Drawing.Point(55, 90);
            this.Room_Num5.MaximumSize = new System.Drawing.Size(80, 30);
            this.Room_Num5.MinimumSize = new System.Drawing.Size(80, 30);
            this.Room_Num5.Name = "Room_Num5";
            this.Room_Num5.Size = new System.Drawing.Size(80, 30);
            this.Room_Num5.TabIndex = 0;
            this.Room_Num5.Text = "참여하기";
            this.Room_Num5.UseVisualStyleBackColor = true;
            this.Room_Num5.Click += new System.EventHandler(this.Room_Num5_Click);
            // 
            // Join_Room3
            // 
            this.Join_Room3.Controls.Add(this.Room_St3);
            this.Join_Room3.Controls.Add(this.Room_Check3);
            this.Join_Room3.Controls.Add(this.Room_Num3);
            this.Join_Room3.Location = new System.Drawing.Point(498, 91);
            this.Join_Room3.MaximumSize = new System.Drawing.Size(200, 140);
            this.Join_Room3.MinimumSize = new System.Drawing.Size(200, 140);
            this.Join_Room3.Name = "Join_Room3";
            this.Join_Room3.Size = new System.Drawing.Size(200, 140);
            this.Join_Room3.TabIndex = 3;
            this.Join_Room3.TabStop = false;
            this.Join_Room3.Text = "3번 보이스방";
            // 
            // Room_St3
            // 
            this.Room_St3.AutoSize = true;
            this.Room_St3.Location = new System.Drawing.Point(18, 60);
            this.Room_St3.Name = "Room_St3";
            this.Room_St3.Size = new System.Drawing.Size(29, 12);
            this.Room_St3.TabIndex = 2;
            this.Room_St3.Text = "빈방";
            // 
            // Room_Check3
            // 
            this.Room_Check3.AutoSize = true;
            this.Room_Check3.Location = new System.Drawing.Point(16, 40);
            this.Room_Check3.Name = "Room_Check3";
            this.Room_Check3.Size = new System.Drawing.Size(63, 12);
            this.Room_Check3.TabIndex = 1;
            this.Room_Check3.Text = "0명 접속중";
            // 
            // Room_Num3
            // 
            this.Room_Num3.Location = new System.Drawing.Point(55, 90);
            this.Room_Num3.MaximumSize = new System.Drawing.Size(80, 30);
            this.Room_Num3.MinimumSize = new System.Drawing.Size(80, 30);
            this.Room_Num3.Name = "Room_Num3";
            this.Room_Num3.Size = new System.Drawing.Size(80, 30);
            this.Room_Num3.TabIndex = 0;
            this.Room_Num3.Text = "참여하기";
            this.Room_Num3.UseVisualStyleBackColor = true;
            this.Room_Num3.Click += new System.EventHandler(this.Room_Num3_Click);
            // 
            // Join_Room6
            // 
            this.Join_Room6.Controls.Add(this.Room_St6);
            this.Join_Room6.Controls.Add(this.Room_Check6);
            this.Join_Room6.Controls.Add(this.Room_Num6);
            this.Join_Room6.Location = new System.Drawing.Point(498, 275);
            this.Join_Room6.MaximumSize = new System.Drawing.Size(200, 140);
            this.Join_Room6.MinimumSize = new System.Drawing.Size(200, 140);
            this.Join_Room6.Name = "Join_Room6";
            this.Join_Room6.Size = new System.Drawing.Size(200, 140);
            this.Join_Room6.TabIndex = 3;
            this.Join_Room6.TabStop = false;
            this.Join_Room6.Text = "6번 보이스방";
            // 
            // Room_St6
            // 
            this.Room_St6.AutoSize = true;
            this.Room_St6.Location = new System.Drawing.Point(18, 60);
            this.Room_St6.Name = "Room_St6";
            this.Room_St6.Size = new System.Drawing.Size(29, 12);
            this.Room_St6.TabIndex = 2;
            this.Room_St6.Text = "빈방";
            // 
            // Room_Check6
            // 
            this.Room_Check6.AutoSize = true;
            this.Room_Check6.Location = new System.Drawing.Point(16, 40);
            this.Room_Check6.Name = "Room_Check6";
            this.Room_Check6.Size = new System.Drawing.Size(63, 12);
            this.Room_Check6.TabIndex = 1;
            this.Room_Check6.Text = "0명 접속중";
            // 
            // Room_Num6
            // 
            this.Room_Num6.Location = new System.Drawing.Point(55, 90);
            this.Room_Num6.MaximumSize = new System.Drawing.Size(80, 30);
            this.Room_Num6.MinimumSize = new System.Drawing.Size(80, 30);
            this.Room_Num6.Name = "Room_Num6";
            this.Room_Num6.Size = new System.Drawing.Size(80, 30);
            this.Room_Num6.TabIndex = 0;
            this.Room_Num6.Text = "참여하기";
            this.Room_Num6.UseVisualStyleBackColor = true;
            this.Room_Num6.Click += new System.EventHandler(this.Room_Num6_Click);
            // 
            // Voice_Close
            // 
            this.Voice_Close.Location = new System.Drawing.Point(722, 438);
            this.Voice_Close.MaximumSize = new System.Drawing.Size(100, 50);
            this.Voice_Close.MinimumSize = new System.Drawing.Size(100, 50);
            this.Voice_Close.Name = "Voice_Close";
            this.Voice_Close.Size = new System.Drawing.Size(100, 50);
            this.Voice_Close.TabIndex = 1;
            this.Voice_Close.Text = "나가기";
            this.Voice_Close.UseVisualStyleBackColor = true;
            this.Voice_Close.Click += new System.EventHandler(this.Voice_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "현재 방송중인 채널";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 438);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(686, 100);
            this.listBox1.TabIndex = 5;
            // 
            // New_Check
            // 
            this.New_Check.Location = new System.Drawing.Point(722, 181);
            this.New_Check.MaximumSize = new System.Drawing.Size(100, 50);
            this.New_Check.MinimumSize = new System.Drawing.Size(100, 50);
            this.New_Check.Name = "New_Check";
            this.New_Check.Size = new System.Drawing.Size(100, 50);
            this.New_Check.TabIndex = 8;
            this.New_Check.Text = "새로고침";
            this.New_Check.UseVisualStyleBackColor = true;
            this.New_Check.Click += new System.EventHandler(this.New_Check_Click);
            // 
            // Voice_Stream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.New_Check);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Join_Room6);
            this.Controls.Add(this.Join_Room5);
            this.Controls.Add(this.Join_Room4);
            this.Controls.Add(this.Join_Room3);
            this.Controls.Add(this.Join_Room2);
            this.Controls.Add(this.Join_Room1);
            this.Controls.Add(this.Voice_Close);
            this.Controls.Add(this.Make_Room);
            this.Controls.Add(this.Title_name);
            this.MaximumSize = new System.Drawing.Size(850, 600);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "Voice_Stream";
            this.Text = "Voice_Stream";
            this.Join_Room1.ResumeLayout(false);
            this.Join_Room1.PerformLayout();
            this.Join_Room4.ResumeLayout(false);
            this.Join_Room4.PerformLayout();
            this.Join_Room2.ResumeLayout(false);
            this.Join_Room2.PerformLayout();
            this.Join_Room5.ResumeLayout(false);
            this.Join_Room5.PerformLayout();
            this.Join_Room3.ResumeLayout(false);
            this.Join_Room3.PerformLayout();
            this.Join_Room6.ResumeLayout(false);
            this.Join_Room6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_name;
        private System.Windows.Forms.Button Make_Room;
        private System.Windows.Forms.GroupBox Join_Room1;
        private System.Windows.Forms.Button Room_Num1;
        private System.Windows.Forms.GroupBox Join_Room4;
        private System.Windows.Forms.Button Room_Num4;
        private System.Windows.Forms.GroupBox Join_Room2;
        private System.Windows.Forms.Button Room_Num2;
        private System.Windows.Forms.GroupBox Join_Room5;
        private System.Windows.Forms.Button Room_Num5;
        private System.Windows.Forms.GroupBox Join_Room3;
        private System.Windows.Forms.Button Room_Num3;
        private System.Windows.Forms.GroupBox Join_Room6;
        private System.Windows.Forms.Button Room_Num6;
        private System.Windows.Forms.Button Voice_Close;
        private System.Windows.Forms.Label Room_Check4;
        private System.Windows.Forms.Label Room_Check2;
        private System.Windows.Forms.Label Room_Check5;
        private System.Windows.Forms.Label Room_Check3;
        private System.Windows.Forms.Label Room_Check6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Room_St4;
        private System.Windows.Forms.Label Room_St2;
        private System.Windows.Forms.Label Room_St5;
        private System.Windows.Forms.Label Room_St3;
        private System.Windows.Forms.Label Room_St6;
        public System.Windows.Forms.Label Room_Check1;
        public System.Windows.Forms.Label Room_St1;
        private System.Windows.Forms.Button New_Check;
    }
}

