using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using voice_stream;

namespace voice_stream
{
    public partial class Voice_Chat : Form
    {
        public Voice_Chat()
        {
            InitializeComponent();
        }


        private void New1_Close_Click(object sender, EventArgs e)
        {
            Voice_Stream Voice_Form = (Voice_Stream)this.Owner;
            int St_King = 1;    //방송 스트리머
            if(St_King==1)  //방송 스트리머
            {
                Voice_Form.room_num[0] = 0;
            }
            else      //시청자
            {
                Voice_Form.num[0] -= 1;
            }
            Close();
        }
    }
}
