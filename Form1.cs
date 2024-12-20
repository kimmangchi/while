using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {

        int user = 0;
        int userWinCount = 0;
        int computerWinCount = 0;

        public Form1()
        {
            InitializeComponent();        
        }

        private void button1_Rock_Click(object sender, EventArgs e)
        {
            this.user = 1;
            textBox_result.Text += "사용자: 바위 ";

            Random randomObj = new Random();
            int randomValue = randomObj.Next(1, 3);
            
            //사용자가 주먹을 낼 때
            if (this.user == 1 && randomValue == 1)
            {
                textBox_result.Text += " 컴퓨터: 바위";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "무승부";
                textBox_result.Text += "\r\n\r\n";
            }
            else if (this.user == 1 && randomValue == 2)
            {
                textBox_result.Text += " 컴퓨터: 보";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "패배";
                textBox_result.Text += "\r\n\r\n";
                computerWinCount++;
                if (computerWinCount == 3)
                {
                    textBox_result.Text += result(computerWinCount);
                }

            }
            else if (this.user == 1 && randomValue == 3)
            {
                textBox_result.Text += " 컴퓨터: 가위";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "승리";
                textBox_result.Text += "\r\n\r\n";
                userWinCount++;
                if (userWinCount == 3)
                {
                    textBox_result.Text += result(userWinCount);
                }
            }
        }

        private void button2_Scissors_Click(object sender, EventArgs e)
        {
            this.user = 2;
            textBox_result.Text += "사용자: 가위 ";

            Random randomObj = new Random();
            int randomValue = randomObj.Next(1, 3);

            //사용자가 가위를 낼 때
            if (this.user == 2 && randomValue == 2)
            {
                textBox_result.Text += " 컴퓨터: 가위";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "무승부";
                textBox_result.Text += "\r\n\r\n";
            }
            else if (this.user == 2 && randomValue == 3)
            {
                textBox_result.Text += " 컴퓨터: 바위";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "패배";
                textBox_result.Text += "\r\n\r\n";
                computerWinCount++;
                if (computerWinCount == 3)
                {
                    textBox_result.Text += result(computerWinCount);
                }
            }
            else if (this.user == 2 && randomValue == 1)
            {
                textBox_result.Text += " 컴퓨터: 보";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "승리";
                textBox_result.Text += "\r\n\r\n";
                userWinCount++;
                if (userWinCount == 3)
                {
                    textBox_result.Text += result(userWinCount);
                }
            }
        }

        private void button3_Paper_Click(object sender, EventArgs e)
        {
            this.user = 3;
            textBox_result.Text += "사용자: 보 ";

            Random randomObj = new Random();
            int randomValue = randomObj.Next(1, 3);

            //사용자가 보를 낼 때
            if (this.user == 3 && randomValue == 3)
            {
                textBox_result.Text += " 컴퓨터: 보";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "무승부";
                textBox_result.Text += "\r\n\r\n";
            }
            else if (this.user == 3 && randomValue == 1)
            {
                textBox_result.Text += " 컴퓨터: 가위";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "패배";
                textBox_result.Text += "\r\n\r\n";
                computerWinCount++;
                if (computerWinCount == 3)
                {
                    textBox_result.Text += result(computerWinCount);
                }
            }
            else if (this.user == 3 && randomValue == 2)
            {
                textBox_result.Text += " 컴퓨터: 바위";
                textBox_result.Text += "\r\n";
                textBox_result.Text += "승리";
                textBox_result.Text += "\r\n\r\n";
                userWinCount++;
                if(userWinCount == 3)
                {
                    textBox_result.Text += result(userWinCount);
                }
            }
        }

        string result(int x)
        {
            if(this.userWinCount == 3)
            {
                return "최종 승리!!";
            }
            else if(this.computerWinCount == 3)
            {
                return "최종 패배!!";
            }
            else
            {
                return "승패가 나지 않았어!";
            }
        }
    }
}
