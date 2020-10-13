using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voice_stream
{
    public partial class Voice_Stream : Form
    {
        public int[] num = new int[6];
        public int[] host = new int[6];       
        List<Form> New_dig = new List<Form>();
        Voice_Chat New_dig1 = new Voice_Chat();
        Voice_Chat New_dig2 = new Voice_Chat();
        Voice_Chat New_dig3 = new Voice_Chat();
        Voice_Chat New_dig4 = new Voice_Chat();
        Voice_Chat New_dig5 = new Voice_Chat();
        Voice_Chat New_dig6 = new Voice_Chat();
        public int[] room_num = new int[6];
        
        
        
        public Voice_Stream()
        {
            InitializeComponent();
            New_dig.Add(New_dig1);
            New_dig.Add(New_dig2);
            New_dig.Add(New_dig3);
            New_dig.Add(New_dig4);
            New_dig.Add(New_dig5);
            New_dig.Add(New_dig6);

        }
        private void Room_Num1_Click(object sender, EventArgs e)
        {                       
            if (num[0] >= 10)
            {
                MessageBox.Show("인원 초과입니다. 다른방을 확인해주세요");
            }
            else
            {
                num[0]++;
                Room_Check1.Text = $"{num[0]}명 입장하셨습니다.";
            }            
        }

        private void Room_Num2_Click(object sender, EventArgs e)
        {
            if (num[1] >= 10)
            {
                MessageBox.Show("인원 초과입니다. 다른방을 확인해주세요");
            }
            else
            {
                num[1]++;
                Room_Check2.Text = $"{num[1]}명 입장하셨습니다.";
            }
        }

        private void Room_Num3_Click(object sender, EventArgs e)
        {
            if (num[2] >= 10)
            {
                MessageBox.Show("인원 초과입니다. 다른방을 확인해주세요");
            }
            else
            {
                num[2]++;
                Room_Check3.Text = $"{num[2]}명 입장하셨습니다.";
            }
        }

        private void Room_Num4_Click(object sender, EventArgs e)
        {
            if (num[3] >= 10)
            {
                MessageBox.Show("인원 초과입니다. 다른방을 확인해주세요");
            }
            else
            {
                num[3]++;
                Room_Check4.Text = $"{num[3]}명 입장하셨습니다.";
            }
        }

        private void Room_Num5_Click(object sender, EventArgs e)
        {
            if (num[4] >= 10)
            {
                MessageBox.Show("인원 초과입니다. 다른방을 확인해주세요");
            }
            else
            {
                num[4]++;
                Room_Check5.Text = $"{num[4]}명 입장하셨습니다.";
            }
        }

        private void Room_Num6_Click(object sender, EventArgs e)
        {
            if (num[5] >= 10)
            {
                MessageBox.Show("인원 초과입니다. 다른방을 확인해주세요");
            }
            else
            {
                num[5]++;
                Room_Check6.Text = $"{num[5]}명 입장하셨습니다.";
            }
        }

        private void Voice_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Make_Room_Click(object sender, EventArgs e)
        {
            List<Label> St_start = new List<Label>();
            St_start.Add(Room_St1);
            St_start.Add(Room_St2);
            St_start.Add(Room_St3);
            St_start.Add(Room_St4);
            St_start.Add(Room_St5);
            St_start.Add(Room_St6);
            int i = 0;
            string Now_Time = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            for (i = 0; i <6; i++)
            {
                if(room_num[i] == 0)
                {
                    room_num[i] = 1;                    
                    //label1.Text = $"{i+1}번방이 방이 개설되었습니다. {Now_Time}" ;
                    listBox1.Items.Add($"{i+1}번방이 방이 개설되었습니다. {Now_Time}");
                    St_start[i].Text = "스트리머 방송중";
                    break;
                }
                
               
            }
            if(i==6)
            {
                MessageBox.Show("개설할수 있는 방이 없습니다.");
            }
            if (i < 6)
            {
                New_dig[i].Owner = this; 
                New_dig[i].Show();
                
            }
            // Room_Check4.Text = $"{New_dig[i]}명 입장하셨습니다.";



        }      

        
        private void New_Check_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (room_num[i] == 0)
                {
                    Room_St1.Text = "빈방";
                    num[i] = 0;
                    Room_Check1.Text = $"{num[i]}명 접속중";
                }
            }
        }
    }
}
