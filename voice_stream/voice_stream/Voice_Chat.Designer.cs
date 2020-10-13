namespace voice_stream
{
    partial class Voice_Chat
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Send_Message = new System.Windows.Forms.Button();
            this.New1_Close = new System.Windows.Forms.Button();
            this.New1_File = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 424);
            this.textBox.MaximumSize = new System.Drawing.Size(460, 25);
            this.textBox.MinimumSize = new System.Drawing.Size(460, 25);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(460, 21);
            this.textBox.TabIndex = 1;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 133);
            this.richTextBox.MaximumSize = new System.Drawing.Size(460, 280);
            this.richTextBox.MinimumSize = new System.Drawing.Size(460, 280);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(460, 280);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // Send_Message
            // 
            this.Send_Message.Location = new System.Drawing.Point(482, 424);
            this.Send_Message.MaximumSize = new System.Drawing.Size(100, 30);
            this.Send_Message.MinimumSize = new System.Drawing.Size(100, 30);
            this.Send_Message.Name = "Send_Message";
            this.Send_Message.Size = new System.Drawing.Size(100, 30);
            this.Send_Message.TabIndex = 3;
            this.Send_Message.Text = "메시지 전송";
            this.Send_Message.UseVisualStyleBackColor = true;
            // 
            // New1_Close
            // 
            this.New1_Close.Location = new System.Drawing.Point(722, 424);
            this.New1_Close.MaximumSize = new System.Drawing.Size(100, 30);
            this.New1_Close.MinimumSize = new System.Drawing.Size(100, 30);
            this.New1_Close.Name = "New1_Close";
            this.New1_Close.Size = new System.Drawing.Size(100, 30);
            this.New1_Close.TabIndex = 3;
            this.New1_Close.Text = "나가기";
            this.New1_Close.UseVisualStyleBackColor = true;
            this.New1_Close.Click += new System.EventHandler(this.New1_Close_Click);
            // 
            // New1_File
            // 
            this.New1_File.Location = new System.Drawing.Point(616, 424);
            this.New1_File.MaximumSize = new System.Drawing.Size(100, 30);
            this.New1_File.MinimumSize = new System.Drawing.Size(100, 30);
            this.New1_File.Name = "New1_File";
            this.New1_File.Size = new System.Drawing.Size(100, 30);
            this.New1_File.TabIndex = 3;
            this.New1_File.Text = "파일전송";
            this.New1_File.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(482, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(340, 400);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "스트리머 사진";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "hide시켜서 스트리머만 누를수 있는 오디오";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "폼만들어서 파일전송 선택할수잇는 시청자";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Voice_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.New1_File);
            this.Controls.Add(this.New1_Close);
            this.Controls.Add(this.Send_Message);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textBox);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Voice_Chat";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button Send_Message;
        private System.Windows.Forms.Button New1_Close;
        private System.Windows.Forms.Button New1_File;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}