using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Game
{
    public partial class lbl_timer : Form
    {
        private List<(string Title, string[] Lyrics, Image Image)> songData;
        private string[] currentLyrics;
        private DateTime startTime;
        private int currentLineIndex;
        private int score;
        public lbl_timer()
        {
            InitializeComponent();
            Init_SongData();
           
        }

        

        private void Init_SongData()
        {
            songData = new List<(String Title, string[] Lyrics, Image Image)>
            {
                ("APT.-ROSÉ", new string[]{ "Kissy face, kissy face", 
                    "Sent to your phone but",
                    "I'm trying to kiss your lips for real",
                    "Red hearts, red hearts","That's what I'm on yeah",
                    "Come give me something I can feel",
                    "Don't you want me like I want you, baby",
                    "Don't you need me like I need you now",
                    "Sleep tomorrow but tonight go crazy",
                    "All you gotta do is just meet me at the" },Properties.Resources.APT),

                ("Hurt-NewJeans", new string[]{"보고 싶은 생각에",
                "들어간 우리 창에",
                "나는 말을 거는데",
                "보내지는 않을래",
                "느린 한마디보다",
                "조용함이 더 좋아",
                "기다리고 있지만",
                "매일 이런 건 아냐",
                "난 재미없어 게임 같은 건" },Properties.Resources.hurt),

                ("희재-성시경", new string[] {"그대 떠나가는 그 순간도",
                "나를 걱정했었나요",
                "무엇도 해줄 수 없는 내 맘 앞에서",
                "그대 나를 떠나 간다해도",
                "난 그댈 보낸적 없죠",
                "여전히 그댄 나를 살게 하는 이율테니",
                "이런 사랑 이런 행복 쉽다 했었죠",
                "이런 웃음 이런 축복",
                "내게 쉽게 올리 없죠",
                "눈물 조차 울음 조차 닦지 못한 나" },Properties.Resources.희재),

                ("HAPPY-DAY6(데이식스)",new string[]{"그런 날이 올까요",
                "May I be happy?",
                "매일 웃고 싶어요",
                "걱정 없고 싶어요",
                "아무나 좀 답을 알려주세요",
                "So help me",
                "주저앉고 있어요",
                "눈물 날 것 같아요",
                "그러니까 제발 제발 제발요",
                "Tell me it's okay to be happy"},Properties.Resources.happy),

                ("Sia-Snowman", new string[]{"Let's go below zero",
                "And hide from the sun",
                "I love you forever",
                "And we'll have some fun",
                "Yes let's hit the north pole",
                "And live happily",
                "Please don't cry no tears now",
                "It's christmas baby",
                "My snowman and me yea",
                "My snowman and me"}, Properties.Resources.snowman)



            };
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var selecedSong = songData[rand.Next(songData.Count)];
            currentLyrics = selecedSong.Lyrics;
            currentLineIndex = 0;
            txtbox_input.Clear();
            lbl_title.Text = selecedSong.Title;
            pictureBox1.Image = selecedSong.Image;
            lbl_lyrics.Text = currentLyrics[currentLineIndex];
            startTime = DateTime.Now;
            timer1.Interval = 1000;
            lbl_time.Text = " 타이머 : 0분 0초";
            timer1.Start();
            score = 10;


        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtbox_input.Clear();
        }

        private void txtbox_input_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                var input = txtbox_input.Text;
                var correctText = currentLyrics[currentLineIndex];

                
                if (input.Equals(correctText))
                {
                    score += 5; // 정답 시 5점 추가
                }
                else
                {
                    score = Math.Max(0, score - 1);
                }

                currentLineIndex++;
                txtbox_input.Clear();

                // 다음 가사로 이동 또는 게임 종료
                if (currentLineIndex < currentLyrics.Length)
                {
                    lbl_lyrics.Text = currentLyrics[currentLineIndex];
                }
                else
                {
                    EndGame();
                }
            }
        }

        private void EndGame()
            {
                TimeSpan elapsedTime = DateTime.Now - startTime;
                timer1.Stop();
                lbl_time.Text = $"{elapsedTime.Minutes}분 {elapsedTime.Seconds}초";
                MessageBox.Show($"소요시간 : {elapsedTime.Minutes}분 {elapsedTime.Seconds}초 \n score : {score}");
                lbl_result.Text += $"score: {score} {elapsedTime.Minutes}분 {elapsedTime.Seconds}초\n ";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;   
            lbl_time.Text = $"타이머 : {elapsedTime.Minutes}분 {elapsedTime.Seconds}초";

        }
    }
    } 


