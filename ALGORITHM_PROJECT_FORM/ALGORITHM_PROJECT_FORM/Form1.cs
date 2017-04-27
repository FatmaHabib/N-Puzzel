using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALGORITHM_PROJECT_FORM
{
    public partial class Form1 : Form
    {
        public input send_data;
       // public solve show_data;
        public Form1()
        {
            InitializeComponent();
            send_data = new input();
           // show_data = new solve();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void play_Click(object sender, EventArgs e)
        {
            #region num=3
            if (choice.Text.ToString() == "3")
            {
                ///new positions
                  this.Width =470;
                this.Height=411;
                play.Location = new Point(250, 300);
                label1.Location = new Point(250, 130);
                choice.Location = new Point(277, 170);
                label2.Location = new Point(250, 220);
                choice_her.Location = new Point(277, 260);
                label3.Visible = true;
                label3.Location = new Point(17, 258);
                moves.Visible = true;
                moves.Location = new Point(90, 300);
                ///////// buttons visbility
                place_1	.Visible=true;	//00
                place_2.Visible=true;		//01
                place_4.Visible=true;		//02
                button6.Visible=false;		//03
                button5.Visible=false;		//04
                button4.Visible=false;		//05
                button2.Visible=false;		//06
                button26.Visible=false;	//07
                button25.Visible=false;	//08
                button24.Visible=false;	//09
                place_5.Visible=true;		//10
                place_6.Visible=true;		//11
                place_7.Visible=true;		//12
                place_8.Visible=false;		//13
                place_11.Visible=false;	//14
                button3.Visible=false;		//15
                button1.Visible=false;		//16
                button23.Visible=false;	//17
                button22.Visible=false;	//18
                button21.Visible=false;	//19
                place_9.Visible=true;		//20
                place_10.Visible=true;	//21
                place_12.Visible=true;	//22
                place_16.Visible=false;	//23
                button20.Visible=false;	//24
                button19.Visible=false;	//25
                button18.Visible=false;	//26
                button17.Visible=false;	//27
                button35.Visible=false;	//28
                button34.Visible=false;	//29
                place_13.Visible=false;	//30
                place_14.Visible=false;	//31
                place_15.Visible=false;	//32
                button7	.Visible=false;	//33
                button33.Visible=false;	//34
                button32.Visible=false;	//35
                button31.Visible=false;	//36
                button30.Visible=false;	//37
                button29.Visible=false;	//38
                button28.Visible=false;	//39
                button13.Visible=false;	//40
                button10.Visible=false;	//41
                button27.Visible=false;	//42
                button53.Visible=false;	//43
                button52.Visible=false;	//44
                button51.Visible=false;	//45
                button50.Visible=false;	//46
                button49.Visible=false;	//47
                button55.Visible=false;	//48
                button54.Visible=false;	//49
                button12.Visible=false;	//50
                button9.Visible=false;		//51
                button48.Visible=false;	//52
                button46.Visible=false;	//53
                button44.Visible=false;	//54
                button43.Visible=false;	//55
                button42.Visible=false;	//56
                button36.Visible=false;	//57
                button64.Visible=false;	//58
                button66.Visible=false;	//59
                button11.Visible=false;	//60
                button8.Visible=false;		//61
                button47.Visible=false;	//62
                button45.Visible=false;	//63
                button41.Visible=false;	//64
                button40.Visible=false;	//65
                button39.Visible=false;	//66
                button57.Visible=false;	//67
                button63.Visible=false;	//68
                button65.Visible=false;	//69
                button14.Visible=false;	//70
                place_3.Visible=false;		//71
                button38.Visible=false;	//72
                button37.Visible=false;	//73
                button60.Visible=false;	//74
                button59.Visible=false;	//75
                button58.Visible=false;	//76
                button56.Visible=false;	//77
                button62.Visible=false;	//78
                button61.Visible=false;	//79
                button15.Visible=false;	//80
                button78.Visible=false;	//81
                button77.Visible=false;	//82
                button76.Visible=false;	//83
                button75.Visible=false;	//84
                button74.Visible=false;	//85
                button73.Visible=false;	//86
                button72.Visible=false;	//87
                button71.Visible=false;	//88
                button70.Visible=false;	//89
                button16.Visible=false;	//90
                button69.Visible=false;	//91
                button68.Visible=false;	//92
                button67.Visible=false;	//93
                button82.Visible=false;	//94
                button81.Visible=false;	//95
                button80.Visible=false;	//96
                button79.Visible=false;	//97
                button84.Visible=false;	//98
                button83.Visible = false;	//99
                /////////// send the data to solve the puzzle
                if (send_data.tc_3 > 9)
                    MessageBox.Show("There is no more PUZZLES");
                else
                { 
                send_data.ReadData(3, choice_her.Text.ToString()[0]);
                /////////// not solved
                if (!send_data.solve_Npuzzle())
                {
                    if (send_data.puzzle[0, 0] == 0)
                        place_1.Visible = false;
                    else
                        place_1.Text = send_data.puzzle[0, 0].ToString();
                    ///
                    if (send_data.puzzle[0, 1] == 0)
                        place_2.Visible = false;
                    else
                        place_2.Text = send_data.puzzle[0, 1].ToString();
                    ///
                    if (send_data.puzzle[0, 2] == 0)
                        place_4.Visible = false;
                    else
                        place_4.Text = send_data.puzzle[0, 2].ToString();
                    ///
                    if (send_data.puzzle[1, 0] == 0)
                        place_5.Visible = false;
                    else
                        place_5.Text = send_data.puzzle[1, 0].ToString();
                    ///
                    if (send_data.puzzle[1, 1] == 0)
                        place_6.Visible = false;
                    else
                        place_6.Text = send_data.puzzle[1, 1].ToString();
                    ///
                    if (send_data.puzzle[1, 2] == 0)
                        place_7.Visible = false;
                    else
                        place_7.Text = send_data.puzzle[1, 2].ToString();
                    ///
                    if (send_data.puzzle[2, 0] == 0)
                        place_9.Visible = false;
                    else
                        place_9.Text = send_data.puzzle[2, 0].ToString();
                    ///
                    if (send_data.puzzle[2, 1] == 0)
                        place_10.Visible = false;
                    else
                        place_10.Text = send_data.puzzle[2, 1].ToString();
                    ///
                    if (send_data.puzzle[2, 2] == 0)
                        place_12.Visible = false;
                    else
                        place_12.Text = send_data.puzzle[2, 2].ToString();
                    ///
                    moves.Text = "0";
                    MessageBox.Show("There is no Solution for this PUZZLE");
                }
                //// sloving result
                else
                {
                    for (int y = send_data.Final_answer.Count - 1; y >= 0; y--)
                    {
                         MessageBox.Show("NEXT");
                        moves.Text = (send_data.Final_answer.Count - 2).ToString();
                        if (send_data.Final_answer[y].arr[0, 0] == 0)
                            place_1.Visible = false;
                        else
                        {
                            place_1.Text = send_data.Final_answer[y].arr[0, 0].ToString();
                            place_1.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 1] == 0)
                            place_2.Visible = false;

                        else
                        {
                            place_2.Text = send_data.Final_answer[y].arr[0, 1].ToString();
                            place_2.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 2] == 0)
                            place_4.Visible = false;
                        //place_3.Image = System.Drawing.Image.FromFile(@"C:\Users\Farah Bakkari\Documents\Visual Studio 2013\Projects\ALGORITHM_PROJECT_FORM\ALGORITHM_PROJECT_FORM\bin\Debug\1.jpg");
                        else
                        {
                            place_4.Text = send_data.Final_answer[y].arr[0, 2].ToString();
                            place_4.Visible = true;
                            //place_3.Image = null;
                        }
                        if (send_data.Final_answer[y].arr[1, 0] == 0)
                            place_5.Visible = false;
                        else
                        {
                            place_5.Text = send_data.Final_answer[y].arr[1, 0].ToString();
                            place_5.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 1] == 0)
                            place_6.Visible = false;
                        else
                        {
                            place_6.Text = send_data.Final_answer[y].arr[1, 1].ToString();
                            place_6.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 2] == 0)
                            place_7.Visible = false;
                        else
                        {
                            place_7.Text = send_data.Final_answer[y].arr[1, 2].ToString();
                            place_7.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 0] == 0)
                            place_9.Visible = false;
                        else
                        {
                            place_9.Text = send_data.Final_answer[y].arr[2, 0].ToString();
                            place_9.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 1] == 0)
                            place_10.Visible = false;
                        else
                        {
                            place_10.Text = send_data.Final_answer[y].arr[2, 1].ToString();
                            place_10.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 2] == 0)
                            place_12.Visible = false;
                        else
                        {
                            place_12.Text = send_data.Final_answer[y].arr[2, 2].ToString();
                            place_12.Visible = true;
                        }
                    }
                }
               }
            }
            #endregion
            #region num=4
            else if (choice.Text.ToString() == "4")
            {    
           
                ///new positions
                  this.Width =520;
                this.Height=461;
                play.Location = new Point(290, 350);
                label1.Location = new Point(300, 130);
                choice.Location = new Point(350, 170);
                label2.Location = new Point(300, 220);
                choice_her.Location = new Point(350, 260);
                label3.Visible = true;
                label3.Location = new Point(17, 300);
                moves.Visible = true;
                moves.Location = new Point(90, 350);
                ///////// buttons visbility
                place_1	.Visible=true;	//00
                place_2.Visible=true;		//01
                place_4.Visible=true;		//02
                button6.Visible=true;		//03
                button5.Visible=false;		//04
                button4.Visible=false;		//05
                button2.Visible=false;		//06
                button26.Visible=false;	//07
                button25.Visible=false;	//08
                button24.Visible=false;	//09
                place_5.Visible=true;		//10
                place_6.Visible=true;		//11
                place_7.Visible=true;		//12
                place_8.Visible=true;		//13
                place_11.Visible=false;	//14
                button3.Visible=false;		//15
                button1.Visible=false;		//16
                button23.Visible=false;	//17
                button22.Visible=false;	//18
                button21.Visible=false;	//19
                place_9.Visible=true;		//20
                place_10.Visible=true;	//21
                place_12.Visible=true;	//22
                place_16.Visible=true;	//23
                button20.Visible=false;	//24
                button19.Visible=false;	//25
                button18.Visible=false;	//26
                button17.Visible=false;	//27
                button35.Visible=false;	//28
                button34.Visible=false;	//29
                place_13.Visible=true;	//30
                place_14.Visible =true;	//31
                place_15.Visible =true;	//32
                button7.Visible =true;	//33
                button33.Visible=false;	//34
                button32.Visible=false;	//35
                button31.Visible=false;	//36
                button30.Visible=false;	//37
                button29.Visible=false;	//38
                button28.Visible=false;	//39
                button13.Visible=false;	//40
                button10.Visible=false;	//41
                button27.Visible=false;	//42
                button53.Visible=false;	//43
                button52.Visible=false;	//44
                button51.Visible=false;	//45
                button50.Visible=false;	//46
                button49.Visible=false;	//47
                button55.Visible=false;	//48
                button54.Visible=false;	//49
                button12.Visible=false;	//50
                button9.Visible=false;		//51
                button48.Visible=false;	//52
                button46.Visible=false;	//53
                button44.Visible=false;	//54
                button43.Visible=false;	//55
                button42.Visible=false;	//56
                button36.Visible=false;	//57
                button64.Visible=false;	//58
                button66.Visible=false;	//59
                button11.Visible=false;	//60
                button8.Visible=false;		//61
                button47.Visible=false;	//62
                button45.Visible=false;	//63
                button41.Visible=false;	//64
                button40.Visible=false;	//65
                button39.Visible=false;	//66
                button57.Visible=false;	//67
                button63.Visible=false;	//68
                button65.Visible=false;	//69
                button14.Visible=false;	//70
                place_3.Visible=false;		//71
                button38.Visible=false;	//72
                button37.Visible=false;	//73
                button60.Visible=false;	//74
                button59.Visible=false;	//75
                button58.Visible=false;	//76
                button56.Visible=false;	//77
                button62.Visible=false;	//78
                button61.Visible=false;	//79
                button15.Visible=false;	//80
                button78.Visible=false;	//81
                button77.Visible=false;	//82
                button76.Visible=false;	//83
                button75.Visible=false;	//84
                button74.Visible=false;	//85
                button73.Visible=false;	//86
                button72.Visible=false;	//87
                button71.Visible=false;	//88
                button70.Visible=false;	//89
                button16.Visible=false;	//90
                button69.Visible=false;	//91
                button68.Visible=false;	//92
                button67.Visible=false;	//93
                button82.Visible=false;	//94
                button81.Visible=false;	//95
                button80.Visible=false;	//96
                button79.Visible=false;	//97
                button84.Visible=false;	//98
                button83.Visible = false;	//99
                /////////// send the data to solve the puzzle
                if (send_data.tc_4 >= 3 && send_data.tc_4 <= 6)
                {
                    MessageBox.Show("This Puzzle has to be solved in Manhatten method");
                    choice_her.Text = "Manhatten";
                }
                /*else*/ if (send_data.tc_4 > 11)
                    MessageBox.Show("There is no more PUZZLES");
                else
                { 
                send_data.ReadData(4, choice_her.Text.ToString()[0]);
                /////////// not solved
                if (!send_data.solve_Npuzzle())
                {
                    if (send_data.puzzle[0, 0] == 0)
                        place_1.Visible = false;
                    else
                        place_1.Text = send_data.puzzle[0, 0].ToString();
                    ///
                    if (send_data.puzzle[0, 1] == 0)
                        place_2.Visible = false;
                    else
                        place_2.Text = send_data.puzzle[0, 1].ToString();
                    ///
                    if (send_data.puzzle[0, 2] == 0)
                        place_4.Visible = false;
                    else
                        place_4.Text = send_data.puzzle[0, 2].ToString();
                    ///
                    if (send_data.puzzle[0, 3] == 0)
                        button6.Visible = false;
                    else
                        button6.Text = send_data.puzzle[0, 3].ToString();
                    ///
                    if (send_data.puzzle[1, 0] == 0)
                        place_5.Visible = false;
                    else
                        place_5.Text = send_data.puzzle[1, 0].ToString();
                    ///
                    if (send_data.puzzle[1, 1] == 0)
                        place_6.Visible = false;
                    else
                        place_6.Text = send_data.puzzle[1, 1].ToString();
                    ///
                    if (send_data.puzzle[1, 2] == 0)
                        place_7.Visible = false;
                    else
                        place_7.Text = send_data.puzzle[1, 2].ToString();
                    ///
                    if (send_data.puzzle[1, 3] == 0)
                        place_8.Visible = false;
                    else
                        place_8.Text = send_data.puzzle[1, 3].ToString();
                    ///
                    if (send_data.puzzle[2, 0] == 0)
                        place_9.Visible = false;
                    else
                        place_9.Text = send_data.puzzle[2, 0].ToString();
                    ///
                    if (send_data.puzzle[2, 1] == 0)
                        place_10.Visible = false;
                    else
                        place_10.Text = send_data.puzzle[2, 1].ToString();
                    ///
                    if (send_data.puzzle[2, 2] == 0)
                        place_12.Visible = false;
                    else
                        place_12.Text = send_data.puzzle[2, 2].ToString();
                    ///
                    if (send_data.puzzle[2, 3] == 0)
                        place_16.Visible = false;
                    else
                        place_16.Text = send_data.puzzle[2, 3].ToString();
                    ///
                    if (send_data.puzzle[3, 0] == 0)
                        place_13.Visible = false;
                    else
                        place_13.Text = send_data.puzzle[3, 0].ToString();
                    ///
                    if (send_data.puzzle[3, 1] == 0)
                        place_14.Visible = false;
                    else
                        place_14.Text = send_data.puzzle[3, 1].ToString();
                    ///
                    if (send_data.puzzle[3, 2] == 0)
                        place_15.Visible = false;
                    else
                        place_15.Text = send_data.puzzle[3, 2].ToString();
                    ///
                    if (send_data.puzzle[3, 3] == 0)
                        button7.Visible = false;
                    else
                        button7.Text = send_data.puzzle[3, 3].ToString();
                    ///
                    moves.Text = "0";
                    MessageBox.Show("There is no Solution for this PUZZLE");
                }
                //// sloving result
                else
                {
                    for (int y = send_data.Final_answer.Count - 1; y >= 0; y--)
                    {
                         MessageBox.Show("NEXT");
                        moves.Text = (send_data.Final_answer.Count - 2).ToString();
                        if (send_data.Final_answer[y].arr[0, 0] == 0)
                            place_1.Visible = false;
                        else
                        {
                            place_1.Text = send_data.Final_answer[y].arr[0, 0].ToString();
                            place_1.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 1] == 0)
                            place_2.Visible = false;

                        else
                        {
                            place_2.Text = send_data.Final_answer[y].arr[0, 1].ToString();
                            place_2.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 2] == 0)
                            place_4.Visible = false;
                        //place_3.Image = System.Drawing.Image.FromFile(@"C:\Users\Farah Bakkari\Documents\Visual Studio 2013\Projects\ALGORITHM_PROJECT_FORM\ALGORITHM_PROJECT_FORM\bin\Debug\1.jpg");
                        else
                        {
                            place_4.Text = send_data.Final_answer[y].arr[0, 2].ToString();
                            place_4.Visible = true;
                            //place_3.Image = null;
                        }
                        if (send_data.Final_answer[y].arr[0, 3] == 0)
                            button6.Visible = false;

                        else
                        {
                            button6.Text = send_data.Final_answer[y].arr[0, 3].ToString();
                            button6.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 0] == 0)
                            place_5.Visible = false;
                        else
                        {
                            place_5.Text = send_data.Final_answer[y].arr[1, 0].ToString();
                            place_5.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 1] == 0)
                            place_6.Visible = false;
                        else
                        {
                            place_6.Text = send_data.Final_answer[y].arr[1, 1].ToString();
                            place_6.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 2] == 0)
                            place_7.Visible = false;
                        else
                        {
                            place_7.Text = send_data.Final_answer[y].arr[1, 2].ToString();
                            place_7.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 3] == 0)
                            place_8.Visible = false;
                        else
                        {
                            place_8.Text = send_data.Final_answer[y].arr[1, 3].ToString();
                            place_8.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 0] == 0)
                            place_9.Visible = false;
                        else
                        {
                            place_9.Text = send_data.Final_answer[y].arr[2, 0].ToString();
                            place_9.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 1] == 0)
                            place_10.Visible = false;
                        else
                        {
                            place_10.Text = send_data.Final_answer[y].arr[2, 1].ToString();
                            place_10.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 2] == 0)
                            place_12.Visible = false;
                        else
                        {
                            place_12.Text = send_data.Final_answer[y].arr[2, 2].ToString();
                            place_12.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 3] == 0)
                            place_16.Visible = false;
                        else
                        {
                            place_16.Text = send_data.Final_answer[y].arr[2, 3].ToString();
                            place_16.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 0] == 0)
                            place_13.Visible = false;
                        else
                        {
                            place_13.Text = send_data.Final_answer[y].arr[3, 0].ToString();
                            place_13.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 1] == 0)
                            place_14.Visible = false;
                        else
                        {
                            place_14.Text = send_data.Final_answer[y].arr[3, 1].ToString();
                            place_14.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 2] == 0)
                            place_15.Visible = false;
                        else
                        {
                            place_15.Text = send_data.Final_answer[y].arr[3, 2].ToString();
                            place_15.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 3] == 0)
                            button7.Visible = false;
                        else
                        {
                            button7.Text = send_data.Final_answer[y].arr[3, 3].ToString();
                            button7.Visible = true;
                        }
                    }
                }
               }
            }
           

            
 #endregion
            #region num=5
            else if (choice.Text.ToString() == "5")
            {

                ///new positions
                this.Width = 570;
                this.Height = 511;
                play.Location = new Point(320, 400);
                label1.Location = new Point(360, 130);
                choice.Location = new Point(430, 170);
                label2.Location = new Point(360, 260);
                choice_her.Location = new Point(430, 300);
                label3.Visible = true;
                label3.Location = new Point(17, 350);
                moves.Visible = true;
                moves.Location = new Point(90, 400);
                ///////// buttons visbility
                place_1.Visible = true;	//00
                place_2.Visible = true;		//01
                place_4.Visible = true;		//02
                button6.Visible = true;		//03
                button5.Visible = true;		//04
                button4.Visible = false;		//05
                button2.Visible = false;		//06
                button26.Visible = false;	//07
                button25.Visible = false;	//08
                button24.Visible = false;	//09
                place_5.Visible = true;		//10
                place_6.Visible = true;		//11
                place_7.Visible = true;		//12
                place_8.Visible = true;		//13
                place_11.Visible = true;	//14
                button3.Visible = false;		//15
                button1.Visible = false;		//16
                button23.Visible = false;	//17
                button22.Visible = false;	//18
                button21.Visible = false;	//19
                place_9.Visible = true;		//20
                place_10.Visible = true;	//21
                place_12.Visible = true;	//22
                place_16.Visible = true;	//23
                button20.Visible = true;	//24
                button19.Visible = false;	//25
                button18.Visible = false;	//26
                button17.Visible = false;	//27
                button35.Visible = false;	//28
                button34.Visible = false;	//29
                place_13.Visible = true;	//30
                place_14.Visible = true;	//31
                place_15.Visible = true;	//32
                button7.Visible = true;	//33
                button33.Visible = true;	//34
                button32.Visible = false;	//35
                button31.Visible = false;	//36
                button30.Visible = false;	//37
                button29.Visible = false;	//38
                button28.Visible = false;	//39
                button13.Visible = true;	//40
                button10.Visible = true;	//41
                button27.Visible = true;	//42
                button53.Visible = true;	//43
                button52.Visible = true;	//44
                button51.Visible = false;	//45
                button50.Visible = false;	//46
                button49.Visible = false;	//47
                button55.Visible = false;	//48
                button54.Visible = false;	//49
                button12.Visible = false;	//50
                button9.Visible = false;		//51
                button48.Visible = false;	//52
                button46.Visible = false;	//53
                button44.Visible = false;	//54
                button43.Visible = false;	//55
                button42.Visible = false;	//56
                button36.Visible = false;	//57
                button64.Visible = false;	//58
                button66.Visible = false;	//59
                button11.Visible = false;	//60
                button8.Visible = false;		//61
                button47.Visible = false;	//62
                button45.Visible = false;	//63
                button41.Visible = false;	//64
                button40.Visible = false;	//65
                button39.Visible = false;	//66
                button57.Visible = false;	//67
                button63.Visible = false;	//68
                button65.Visible = false;	//69
                button14.Visible = false;	//70
                place_3.Visible = false;		//71
                button38.Visible = false;	//72
                button37.Visible = false;	//73
                button60.Visible = false;	//74
                button59.Visible = false;	//75
                button58.Visible = false;	//76
                button56.Visible = false;	//77
                button62.Visible = false;	//78
                button61.Visible = false;	//79
                button15.Visible = false;	//80
                button78.Visible = false;	//81
                button77.Visible = false;	//82
                button76.Visible = false;	//83
                button75.Visible = false;	//84
                button74.Visible = false;	//85
                button73.Visible = false;	//86
                button72.Visible = false;	//87
                button71.Visible = false;	//88
                button70.Visible = false;	//89
                button16.Visible = false;	//90
                button69.Visible = false;	//91
                button68.Visible = false;	//92
                button67.Visible = false;	//93
                button82.Visible = false;	//94
                button81.Visible = false;	//95
                button80.Visible = false;	//96
                button79.Visible = false;	//97
                button84.Visible = false;	//98
                button83.Visible = false;	//99
                /////////// send the data to solve the puzzle
                if (send_data.tc_5 > 1)
                    MessageBox.Show("There is no more PUZZLES");
                else { 
                send_data.ReadData(5, choice_her.Text.ToString()[0]);
                /////////// not solved
                if (!send_data.solve_Npuzzle())
                {
                    if (send_data.puzzle[0, 0] == 0)
                        place_1.Visible = false;
                    else
                        place_1.Text = send_data.puzzle[0, 0].ToString();
                    ///
                    if (send_data.puzzle[0, 1] == 0)
                        place_2.Visible = false;
                    else
                        place_2.Text = send_data.puzzle[0, 1].ToString();
                    ///
                    if (send_data.puzzle[0, 2] == 0)
                        place_4.Visible = false;
                    else
                        place_4.Text = send_data.puzzle[0, 2].ToString();
                    ///
                    if (send_data.puzzle[0, 3] == 0)
                        button6.Visible = false;
                    else
                        button6.Text = send_data.puzzle[0, 3].ToString();
                    ///
                    if (send_data.puzzle[0, 4] == 0)
                        button5.Visible = false;
                    else
                        button5.Text = send_data.puzzle[0, 4].ToString();
                    ///
                    if (send_data.puzzle[1, 0] == 0)
                        place_5.Visible = false;
                    else
                        place_5.Text = send_data.puzzle[1, 0].ToString();
                    ///
                    if (send_data.puzzle[1, 1] == 0)
                        place_6.Visible = false;
                    else
                        place_6.Text = send_data.puzzle[1, 1].ToString();
                    ///
                    if (send_data.puzzle[1, 2] == 0)
                        place_7.Visible = false;
                    else
                        place_7.Text = send_data.puzzle[1, 2].ToString();
                    ///
                    if (send_data.puzzle[1, 3] == 0)
                        place_8.Visible = false;
                    else
                        place_8.Text = send_data.puzzle[1, 3].ToString();
                    ///
                    if (send_data.puzzle[1, 4] == 0)
                        place_11.Visible = false;
                    else
                        place_11.Text = send_data.puzzle[1, 4].ToString();
                    ///
                    if (send_data.puzzle[2, 0] == 0)
                        place_9.Visible = false;
                    else
                        place_9.Text = send_data.puzzle[2, 0].ToString();
                    ///
                    if (send_data.puzzle[2, 1] == 0)
                        place_10.Visible = false;
                    else
                        place_10.Text = send_data.puzzle[2, 1].ToString();
                    ///
                    if (send_data.puzzle[2, 2] == 0)
                        place_12.Visible = false;
                    else
                        place_12.Text = send_data.puzzle[2, 2].ToString();
                    ///
                    if (send_data.puzzle[2, 3] == 0)
                        place_16.Visible = false;
                    else
                        place_16.Text = send_data.puzzle[2, 3].ToString();
                    ///
                    if (send_data.puzzle[2, 4] == 0)
                        button20.Visible = false;
                    else
                        button20.Text = send_data.puzzle[2, 4].ToString();
                    ///
                    if (send_data.puzzle[3, 0] == 0)
                        place_13.Visible = false;
                    else
                        place_13.Text = send_data.puzzle[3, 0].ToString();
                    ///
                    if (send_data.puzzle[3, 1] == 0)
                        place_14.Visible = false;
                    else
                        place_14.Text = send_data.puzzle[3, 1].ToString();
                    ///
                    if (send_data.puzzle[3, 2] == 0)
                        place_15.Visible = false;
                    else
                        place_15.Text = send_data.puzzle[3, 2].ToString();
                    ///
                    if (send_data.puzzle[3, 3] == 0)
                        button7.Visible = false;
                    else
                        button7.Text = send_data.puzzle[3, 3].ToString();
                    ///
                    if (send_data.puzzle[3, 4] == 0)
                        button33.Visible = false;
                    else
                        button33.Text = send_data.puzzle[3, 4].ToString();
                    ///
                    if (send_data.puzzle[4, 0] == 0)
                        button13.Visible = false;
                    else
                        button13.Text = send_data.puzzle[4, 0].ToString();
                    ///
                    if (send_data.puzzle[4, 1] == 0)
                        button10.Visible = false;
                    else
                        button10.Text = send_data.puzzle[4, 1].ToString();
                    ///
                    if (send_data.puzzle[4, 2] == 0)
                        button27.Visible = false;
                    else
                        button27.Text = send_data.puzzle[4, 2].ToString();
                    ///
                    if (send_data.puzzle[4, 3] == 0)
                        button53.Visible = false;
                    else
                        button53.Text = send_data.puzzle[4, 3].ToString();
                    ///
                    if (send_data.puzzle[4, 4] == 0)
                        button52.Visible = false;
                    else
                        button52.Text = send_data.puzzle[4, 4].ToString();
                    ///
                    moves.Text = "0";
                    MessageBox.Show("There is no Solution for this PUZZLE");
                }
                //// sloving result
                else
                {
                    for (int y = send_data.Final_answer.Count - 1; y >= 0; y--)
                    {
                         MessageBox.Show("NEXT");
                        moves.Text = (send_data.Final_answer.Count - 2).ToString();
                        if (send_data.Final_answer[y].arr[0, 0] == 0)
                            place_1.Visible = false;
                        else
                        {
                            place_1.Text = send_data.Final_answer[y].arr[0, 0].ToString();
                            place_1.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 1] == 0)
                            place_2.Visible = false;

                        else
                        {
                            place_2.Text = send_data.Final_answer[y].arr[0, 1].ToString();
                            place_2.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 2] == 0)
                            place_4.Visible = false;
                        //place_3.Image = System.Drawing.Image.FromFile(@"C:\Users\Farah Bakkari\Documents\Visual Studio 2013\Projects\ALGORITHM_PROJECT_FORM\ALGORITHM_PROJECT_FORM\bin\Debug\1.jpg");
                        else
                        {
                            place_4.Text = send_data.Final_answer[y].arr[0, 2].ToString();
                            place_4.Visible = true;
                            //place_3.Image = null;
                        }
                        if (send_data.Final_answer[y].arr[0, 3] == 0)
                            button6.Visible = false;

                        else
                        {
                            button6.Text = send_data.Final_answer[y].arr[0, 3].ToString();
                            button6.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 4] == 0)
                            button5.Visible = false;

                        else
                        {
                            button5.Text = send_data.Final_answer[y].arr[0, 4].ToString();
                            button5.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 0] == 0)
                            place_5.Visible = false;
                        else
                        {
                            place_5.Text = send_data.Final_answer[y].arr[1, 0].ToString();
                            place_5.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 1] == 0)
                            place_6.Visible = false;
                        else
                        {
                            place_6.Text = send_data.Final_answer[y].arr[1, 1].ToString();
                            place_6.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 2] == 0)
                            place_7.Visible = false;
                        else
                        {
                            place_7.Text = send_data.Final_answer[y].arr[1, 2].ToString();
                            place_7.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 3] == 0)
                            place_8.Visible = false;
                        else
                        {
                            place_8.Text = send_data.Final_answer[y].arr[1, 3].ToString();
                            place_8.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 4] == 0)
                            place_11.Visible = false;
                        else
                        {
                            place_11.Text = send_data.Final_answer[y].arr[1, 4].ToString();
                            place_11.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 0] == 0)
                            place_9.Visible = false;
                        else
                        {
                            place_9.Text = send_data.Final_answer[y].arr[2, 0].ToString();
                            place_9.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 1] == 0)
                            place_10.Visible = false;
                        else
                        {
                            place_10.Text = send_data.Final_answer[y].arr[2, 1].ToString();
                            place_10.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 2] == 0)
                            place_12.Visible = false;
                        else
                        {
                            place_12.Text = send_data.Final_answer[y].arr[2, 2].ToString();
                            place_12.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 3] == 0)
                            place_16.Visible = false;
                        else
                        {
                            place_16.Text = send_data.Final_answer[y].arr[2, 3].ToString();
                            place_16.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 4] == 0)
                            button20.Visible = false;
                        else
                        {
                            button20.Text = send_data.Final_answer[y].arr[2, 4].ToString();
                            button20.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 0] == 0)
                            place_13.Visible = false;
                        else
                        {
                            place_13.Text = send_data.Final_answer[y].arr[3, 0].ToString();
                            place_13.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 1] == 0)
                            place_14.Visible = false;
                        else
                        {
                            place_14.Text = send_data.Final_answer[y].arr[3, 1].ToString();
                            place_14.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 2] == 0)
                            place_15.Visible = false;
                        else
                        {
                            place_15.Text = send_data.Final_answer[y].arr[3, 2].ToString();
                            place_15.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 3] == 0)
                            button7.Visible = false;
                        else
                        {
                            button7.Text = send_data.Final_answer[y].arr[3, 3].ToString();
                            button7.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 4] == 0)
                            button33.Visible = false;
                        else
                        {
                            button33.Text = send_data.Final_answer[y].arr[3, 4].ToString();
                            button33.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 0] == 0)
                            button13.Visible = false;
                        else
                        {
                            button13.Text = send_data.Final_answer[y].arr[4, 0].ToString();
                            button13.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 1] == 0)
                            button10.Visible = false;
                        else
                        {
                            button10.Text = send_data.Final_answer[y].arr[4, 1].ToString();
                            button10.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 2] == 0)
                            button27.Visible = false;
                        else
                        {
                            button27.Text = send_data.Final_answer[y].arr[4, 2].ToString();
                            button27.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 3] == 0)
                            button53.Visible = false;
                        else
                        {
                            button53.Text = send_data.Final_answer[y].arr[4, 3].ToString();
                            button53.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 4] == 0)
                            button52.Visible = false;
                        else
                        {
                            button52.Text = send_data.Final_answer[y].arr[4, 4].ToString();
                            button52.Visible = true;

                        }
                    }
                    }
                }
            }



            #endregion
            #region num=10
            else if (choice.Text.ToString() == "10")
            {

                ///new positions 1364, 876
                this.Width = 1190;
                this.Height = 736;
                play.Location = new Point(909, 430);
                label1.Location = new Point(944, 159);
                choice.Location = new Point(993, 203);
                label2.Location = new Point(944, 282);
                choice_her.Location = new Point(993, 333);
                label3.Visible = true;
                label3.Location = new Point(909, 554);
                moves.Visible = true;
                moves.Location = new Point(966, 614);
                ///////// buttons visbility
                place_1.Visible = true;	//00
                place_2.Visible = true;		//01
                place_4.Visible = true;		//02
                button6.Visible = true;		//03
                button5.Visible = true;		//04
                button4.Visible = true;		//05
                button2.Visible = true;		//06
                button26.Visible = true;	//07
                button25.Visible = true;	//08
                button24.Visible = true;	//09
                place_5.Visible = true;		//10
                place_6.Visible = true;		//11
                place_7.Visible = true;		//12
                place_8.Visible = true;		//13
                place_11.Visible = true;	//14
                button3.Visible = true;		//15
                button1.Visible = true;		//16
                button23.Visible = true;	//17
                button22.Visible = true;	//18
                button21.Visible = true;	//19
                place_9.Visible = true;		//20
                place_10.Visible = true;	//21
                place_12.Visible = true;	//22
                place_16.Visible = true;	//23
                button20.Visible = true;	//24
                button19.Visible = true;	//25
                button18.Visible = true;	//26
                button17.Visible = true;	//27
                button35.Visible = true;	//28
                button34.Visible = true;	//29
                place_13.Visible = true;	//30
                place_14.Visible = true;	//31
                place_15.Visible = true;	//32
                button7.Visible = true;	//33
                button33.Visible = true;	//34
                button32.Visible = true;	//35
                button31.Visible = true;	//36
                button30.Visible = true;	//37
                button29.Visible = true;	//38
                button28.Visible = true;	//39
                button13.Visible = true;	//40
                button10.Visible = true;	//41
                button27.Visible = true;	//42
                button53.Visible = true;	//43
                button52.Visible = true;	//44
                button51.Visible = true;	//45
                button50.Visible = true;	//46
                button49.Visible = true;	//47
                button55.Visible = true;	//48
                button54.Visible = true;	//49
                button12.Visible = true;	//50
                button9.Visible = true;		//51
                button48.Visible = true;	//52
                button46.Visible = true;	//53
                button44.Visible = true;	//54
                button43.Visible = true;	//55
                button42.Visible = true;	//56
                button36.Visible = true;	//57
                button64.Visible = true;	//58
                button66.Visible = true;	//59
                button11.Visible = true;	//60
                button8.Visible = true;		//61
                button47.Visible = true;	//62
                button45.Visible = true;	//63
                button41.Visible = true;	//64
                button40.Visible = true;	//65
                button39.Visible = true;	//66
                button57.Visible = true;	//67
                button63.Visible = true;	//68
                button65.Visible = true;	//69
                button14.Visible = true;	//70
                place_3.Visible = true;		//71
                button38.Visible = true;	//72
                button37.Visible = true;	//73
                button60.Visible = true;	//74
                button59.Visible = true;	//75
                button58.Visible = true;	//76
                button56.Visible = true;	//77
                button62.Visible = true;	//78
                button61.Visible = true;	//79
                button15.Visible = true;	//80
                button78.Visible = true;	//81
                button77.Visible = true;	//82
                button76.Visible = true;	//83
                button75.Visible = true;	//84
                button74.Visible = true;	//85
                button73.Visible = true;	//86
                button72.Visible = true;	//87
                button71.Visible = true;	//88
                button70.Visible = true;	//89
                button16.Visible = true;	//90
                button69.Visible = true;	//91
                button68.Visible = true;	//92
                button67.Visible = true;	//93
                button82.Visible = true;	//94
                button81.Visible = true;	//95
                button80.Visible = true;	//96
                button79.Visible = true;	//97
                button84.Visible = true;	//98
                button83.Visible = true;	//99
                /////////// send the data to solve the puzzle
                if (send_data.tc_10 > 3)
                    MessageBox.Show("There is no more PUZZLES");
                else{
                    send_data.ReadData(10, choice_her.Text.ToString()[0]);
                /////////// not solved
                if (!send_data.solve_Npuzzle())
                {
                    if (send_data.puzzle[0, 0] == 0)
                        place_1.Visible = false;
                    else
                        place_1.Text = send_data.puzzle[0, 0].ToString();
                    ///
                    if (send_data.puzzle[0, 1] == 0)
                        place_2.Visible = false;
                    else
                        place_2.Text = send_data.puzzle[0, 1].ToString();
                    ///
                    if (send_data.puzzle[0, 2] == 0)
                        place_4.Visible = false;
                    else
                        place_4.Text = send_data.puzzle[0, 2].ToString();
                    ///
                    if (send_data.puzzle[0, 3] == 0)
                        button6.Visible = false;
                    else
                        button6.Text = send_data.puzzle[0, 3].ToString();
                    ///
                    if (send_data.puzzle[0, 4] == 0)
                        button5.Visible = false;
                    else
                        button5.Text = send_data.puzzle[0, 4].ToString();
                    ///
                    if (send_data.puzzle[0, 5] == 0)
                        button4.Visible = false;
                    else
                        button4.Text = send_data.puzzle[0, 5].ToString();
                    ///
                    if (send_data.puzzle[0, 6] == 0)
                        button2.Visible = false;
                    else
                        button2.Text = send_data.puzzle[0, 6].ToString();
                    ///
                    if (send_data.puzzle[0, 7] == 0)
                        button26.Visible = false;
                    else
                        button26.Text = send_data.puzzle[0, 7].ToString();
                    ///
                    if (send_data.puzzle[0, 8] == 0)
                        button25.Visible = false;
                    else
                        button25.Text = send_data.puzzle[0, 8].ToString();
                    ///
                    if (send_data.puzzle[0, 9] == 0)
                        button24.Visible = false;
                    else
                        button24.Text = send_data.puzzle[0, 9].ToString();
                    ///
                    if (send_data.puzzle[1, 0] == 0)
                        place_5.Visible = false;
                    else
                        place_5.Text = send_data.puzzle[1, 0].ToString();
                    ///
                    if (send_data.puzzle[1, 1] == 0)
                        place_6.Visible = false;
                    else
                        place_6.Text = send_data.puzzle[1, 1].ToString();
                    ///
                    if (send_data.puzzle[1, 2] == 0)
                        place_7.Visible = false;
                    else
                        place_7.Text = send_data.puzzle[1, 2].ToString();
                    ///
                    if (send_data.puzzle[1, 3] == 0)
                        place_8.Visible = false;
                    else
                        place_8.Text = send_data.puzzle[1, 3].ToString();
                    ///
                    if (send_data.puzzle[1, 4] == 0)
                        place_11.Visible = false;
                    else
                        place_11.Text = send_data.puzzle[1, 4].ToString();
                    ///
                    if (send_data.puzzle[1, 5] == 0)
                        button3.Visible = false;
                    else
                        button3.Text = send_data.puzzle[1, 5].ToString();
                    ///
                    if (send_data.puzzle[1, 6] == 0)
                        button1.Visible = false;
                    else
                        button1.Text = send_data.puzzle[1, 6].ToString();
                    ///
                    if (send_data.puzzle[1, 7] == 0)
                        button23.Visible = false;
                    else
                        button23.Text = send_data.puzzle[1, 7].ToString();
                    ///
                    if (send_data.puzzle[1, 8] == 0)
                        button22.Visible = false;
                    else
                        button22.Text = send_data.puzzle[1, 8].ToString();
                    ///
                    if (send_data.puzzle[1, 9] == 0)
                        button21.Visible = false;
                    else
                        button21.Text = send_data.puzzle[1, 9].ToString();
                    ///
                    if (send_data.puzzle[2, 0] == 0)
                        place_9.Visible = false;
                    else
                        place_9.Text = send_data.puzzle[2, 0].ToString();
                    ///
                    if (send_data.puzzle[2, 1] == 0)
                        place_10.Visible = false;
                    else
                        place_10.Text = send_data.puzzle[2, 1].ToString();
                    ///
                    if (send_data.puzzle[2, 2] == 0)
                        place_12.Visible = false;
                    else
                        place_12.Text = send_data.puzzle[2, 2].ToString();
                    ///
                    if (send_data.puzzle[2, 3] == 0)
                        place_16.Visible = false;
                    else
                        place_16.Text = send_data.puzzle[2, 3].ToString();
                    ///
                    if (send_data.puzzle[2, 4] == 0)
                        button20.Visible = false;
                    else
                        button20.Text = send_data.puzzle[2, 4].ToString();
                    ///
                    if (send_data.puzzle[2, 5] == 0)
                        button19.Visible = false;
                    else
                        button19.Text = send_data.puzzle[2, 5].ToString();
                    ///
                    if (send_data.puzzle[2, 6] == 0)
                        button18.Visible = false;
                    else
                        button18.Text = send_data.puzzle[2, 6].ToString();
                    ///
                    if (send_data.puzzle[2, 7] == 0)
                        button17.Visible = false;
                    else
                        button17.Text = send_data.puzzle[2, 7].ToString();
                    ///
                    if (send_data.puzzle[2, 8] == 0)
                        button35.Visible = false;
                    else
                        button35.Text = send_data.puzzle[2, 8].ToString();
                    ///
                    if (send_data.puzzle[2, 9] == 0)
                        button34.Visible = false;
                    else
                        button34.Text = send_data.puzzle[2, 9].ToString();
                    ///
                    if (send_data.puzzle[3, 0] == 0)
                        place_13.Visible = false;
                    else
                        place_13.Text = send_data.puzzle[3, 0].ToString();
                    ///
                    if (send_data.puzzle[3, 1] == 0)
                        place_14.Visible = false;
                    else
                        place_14.Text = send_data.puzzle[3, 1].ToString();
                    ///
                    if (send_data.puzzle[3, 2] == 0)
                        place_15.Visible = false;
                    else
                        place_15.Text = send_data.puzzle[3, 2].ToString();
                    ///
                    if (send_data.puzzle[3, 3] == 0)
                        button7.Visible = false;
                    else
                        button7.Text = send_data.puzzle[3, 3].ToString();
                    ///
                    if (send_data.puzzle[3, 4] == 0)
                        button33.Visible = false;
                    else
                        button33.Text = send_data.puzzle[3, 4].ToString();
                    ///
                    if (send_data.puzzle[3, 5] == 0)
                        button32.Visible = false;
                    else
                        button32.Text = send_data.puzzle[3, 5].ToString();
                    ///
                    if (send_data.puzzle[3, 6] == 0)
                        button31.Visible = false;
                    else
                        button31.Text = send_data.puzzle[3, 6].ToString();
                    ///
                    if (send_data.puzzle[3, 7] == 0)
                        button30.Visible = false;
                    else
                        button30.Text = send_data.puzzle[3, 7].ToString();
                    ///
                    if (send_data.puzzle[3, 8] == 0)
                        button29.Visible = false;
                    else
                        button29.Text = send_data.puzzle[3, 8].ToString();
                    ///
                    if (send_data.puzzle[3, 9] == 0)
                        button28.Visible = false;
                    else
                        button28.Text = send_data.puzzle[3, 9].ToString();
                    ///
                    if (send_data.puzzle[4, 0] == 0)
                        button13.Visible = false;
                    else
                        button13.Text = send_data.puzzle[4, 0].ToString();
                    ///
                    if (send_data.puzzle[4, 1] == 0)
                        button10.Visible = false;
                    else
                        button10.Text = send_data.puzzle[4, 1].ToString();
                    ///
                    if (send_data.puzzle[4, 2] == 0)
                        button27.Visible = false;
                    else
                        button27.Text = send_data.puzzle[4, 2].ToString();
                    ///
                    if (send_data.puzzle[4, 3] == 0)
                        button53.Visible = false;
                    else
                        button53.Text = send_data.puzzle[4, 3].ToString();
                    ///
                    if (send_data.puzzle[4, 4] == 0)
                        button52.Visible = false;
                    else
                        button52.Text = send_data.puzzle[4, 4].ToString();
                    ///
                    if (send_data.puzzle[4, 5] == 0)
                        button51.Visible = false;
                    else
                        button51.Text = send_data.puzzle[4, 5].ToString();
                    ///
                    if (send_data.puzzle[4, 6] == 0)
                        button50.Visible = false;
                    else
                        button50.Text = send_data.puzzle[4, 6].ToString();
                    ///
                    if (send_data.puzzle[4, 7] == 0)
                        button49.Visible = false;
                    else
                        button49.Text = send_data.puzzle[4, 7].ToString();
                    ///
                    if (send_data.puzzle[4, 8] == 0)
                        button55.Visible = false;
                    else
                        button55.Text = send_data.puzzle[4, 8].ToString();
                    ///
                    if (send_data.puzzle[4, 9] == 0)
                        button54.Visible = false;
                    else
                        button54.Text = send_data.puzzle[4, 9].ToString();
                    ///
                    if (send_data.puzzle[5, 0] == 0)
                        button12.Visible = false;
                    else
                        button12.Text = send_data.puzzle[5, 0].ToString();
                    ///
                    if (send_data.puzzle[5, 1] == 0)
                        button9.Visible = false;
                    else
                        button9.Text = send_data.puzzle[5, 1].ToString();
                    ///
                    if (send_data.puzzle[5, 2] == 0)
                        button48.Visible = false;
                    else
                        button48.Text = send_data.puzzle[5, 2].ToString();
                    ///
                    if (send_data.puzzle[5, 3] == 0)
                        button46.Visible = false;
                    else
                        button46.Text = send_data.puzzle[5, 3].ToString();
                    ///
                    if (send_data.puzzle[5, 4] == 0)
                        button44.Visible = false;
                    else
                        button44.Text = send_data.puzzle[5, 4].ToString();
                    ///
                    if (send_data.puzzle[5, 5] == 0)
                        button43.Visible = false;
                    else
                        button43.Text = send_data.puzzle[5, 5].ToString();
                    ///
                    if (send_data.puzzle[5, 6] == 0)
                        button42.Visible = false;
                    else
                        button42.Text = send_data.puzzle[5, 6].ToString();
                    ///
                    if (send_data.puzzle[5, 7] == 0)
                        button36.Visible = false;
                    else
                        button36.Text = send_data.puzzle[5, 7].ToString();
                    ///
                    if (send_data.puzzle[5, 8] == 0)
                        button64.Visible = false;
                    else
                        button64.Text = send_data.puzzle[5, 8].ToString();
                    ///
                    if (send_data.puzzle[5, 9] == 0)
                        button66.Visible = false;
                    else
                        button66.Text = send_data.puzzle[5, 9].ToString();
                    ///
                    if (send_data.puzzle[6, 0] == 0)
                        button11.Visible = false;
                    else
                        button11.Text = send_data.puzzle[6, 0].ToString();
                    ///
                    if (send_data.puzzle[6, 1] == 0)
                        button8.Visible = false;
                    else
                        button8.Text = send_data.puzzle[6, 1].ToString();
                    ///
                    if (send_data.puzzle[6, 2] == 0)
                        button47.Visible = false;
                    else
                        button47.Text = send_data.puzzle[6, 2].ToString();
                    ///
                    if (send_data.puzzle[6, 3] == 0)
                        button45.Visible = false;
                    else
                        button45.Text = send_data.puzzle[6, 3].ToString();
                    ///
                    if (send_data.puzzle[6, 4] == 0)
                        button41.Visible = false;
                    else
                        button41.Text = send_data.puzzle[6, 4].ToString();
                    ///
                    if (send_data.puzzle[6, 5] == 0)
                        button40.Visible = false;
                    else
                        button40.Text = send_data.puzzle[6, 5].ToString();
                    ///
                    if (send_data.puzzle[6, 6] == 0)
                        button39.Visible = false;
                    else
                        button39.Text = send_data.puzzle[6, 6].ToString();
                    ///
                    if (send_data.puzzle[6, 7] == 0)
                        button57.Visible = false;
                    else
                        button57.Text = send_data.puzzle[6, 7].ToString();
                    ///
                    if (send_data.puzzle[6, 8] == 0)
                        button63.Visible = false;
                    else
                        button63.Text = send_data.puzzle[6, 8].ToString();
                    ///
                    if (send_data.puzzle[6, 9] == 0)
                        button65.Visible = false;
                    else
                        button65.Text = send_data.puzzle[6, 9].ToString();
                    ///
                    if (send_data.puzzle[7, 0] == 0)
                        button14.Visible = false;
                    else
                        button14.Text = send_data.puzzle[7, 0].ToString();
                    ///
                    if (send_data.puzzle[7, 1] == 0)
                        place_3.Visible = false;
                    else
                        place_3.Text = send_data.puzzle[7, 1].ToString();
                    ///
                    if (send_data.puzzle[7, 2] == 0)
                        button38.Visible = false;
                    else
                        button38.Text = send_data.puzzle[7, 2].ToString();
                    ///
                    if (send_data.puzzle[7, 3] == 0)
                        button37.Visible = false;
                    else
                        button37.Text = send_data.puzzle[7, 3].ToString();
                    ///
                    if (send_data.puzzle[7, 4] == 0)
                        button60.Visible = false;
                    else
                        button60.Text = send_data.puzzle[7, 4].ToString();
                    ///
                    if (send_data.puzzle[7, 5] == 0)
                        button59.Visible = false;
                    else
                        button59.Text = send_data.puzzle[7, 5].ToString();
                    ///
                    if (send_data.puzzle[7, 6] == 0)
                        button58.Visible = false;
                    else
                        button58.Text = send_data.puzzle[7, 6].ToString();
                    ///
                    if (send_data.puzzle[7, 7] == 0)
                        button56.Visible = false;
                    else
                        button56.Text = send_data.puzzle[7, 7].ToString();
                    ///
                    if (send_data.puzzle[7, 8] == 0)
                        button62.Visible = false;
                    else
                        button62.Text = send_data.puzzle[7, 8].ToString();
                    ///
                    if (send_data.puzzle[7, 9] == 0)
                        button61.Visible = false;
                    else
                        button61.Text = send_data.puzzle[7, 9].ToString();
                    ///
                    if (send_data.puzzle[8, 0] == 0)
                        button15.Visible = false;
                    else
                        button15.Text = send_data.puzzle[8, 0].ToString();
                    ///
                    if (send_data.puzzle[8, 1] == 0)
                        button78.Visible = false;
                    else
                        button78.Text = send_data.puzzle[8, 1].ToString();
                    ///
                    if (send_data.puzzle[8, 2] == 0)
                        button77.Visible = false;
                    else
                        button77.Text = send_data.puzzle[8, 2].ToString();
                    ///
                    if (send_data.puzzle[8, 3] == 0)
                        button76.Visible = false;
                    else
                        button76.Text = send_data.puzzle[8, 3].ToString();
                    ///
                    if (send_data.puzzle[8, 4] == 0)
                        button75.Visible = false;
                    else
                        button75.Text = send_data.puzzle[8, 4].ToString();
                    ///
                    if (send_data.puzzle[8, 5] == 0)
                        button74.Visible = false;
                    else
                        button74.Text = send_data.puzzle[8, 5].ToString();
                    ///
                    if (send_data.puzzle[8, 6] == 0)
                        button73.Visible = false;
                    else
                        button73.Text = send_data.puzzle[8, 6].ToString();
                    ///
                    if (send_data.puzzle[8, 7] == 0)
                        button72.Visible = false;
                    else
                        button72.Text = send_data.puzzle[8, 7].ToString();
                    ///
                    if (send_data.puzzle[8, 8] == 0)
                        button71.Visible = false;
                    else
                        button71.Text = send_data.puzzle[8, 8].ToString();
                    ///
                    if (send_data.puzzle[8, 9] == 0)
                        button70.Visible = false;
                    else
                        button70.Text = send_data.puzzle[8, 9].ToString();
                    ///
                    if (send_data.puzzle[9, 0] == 0)
                        button16.Visible = false;
                    else
                        button16.Text = send_data.puzzle[9, 0].ToString();
                    ///
                    if (send_data.puzzle[9, 1] == 0)
                        button69.Visible = false;
                    else
                        button69.Text = send_data.puzzle[9, 1].ToString();
                    ///
                    if (send_data.puzzle[9, 2] == 0)
                        button68.Visible = false;
                    else
                        button68.Text = send_data.puzzle[9, 2].ToString();
                    ///
                    if (send_data.puzzle[9, 3] == 0)
                        button67.Visible = false;
                    else
                        button67.Text = send_data.puzzle[9, 3].ToString();
                    ///
                    if (send_data.puzzle[9, 4] == 0)
                        button82.Visible = false;
                    else
                        button82.Text = send_data.puzzle[9, 4].ToString();
                    ///
                    if (send_data.puzzle[9, 5] == 0)
                        button81.Visible = false;
                    else
                        button81.Text = send_data.puzzle[9, 5].ToString();
                    ///
                    if (send_data.puzzle[9, 6] == 0)
                        button80.Visible = false;
                    else
                        button80.Text = send_data.puzzle[9, 6].ToString();
                    ///
                    if (send_data.puzzle[9, 7] == 0)
                        button79.Visible = false;
                    else
                        button79.Text = send_data.puzzle[9, 7].ToString();
                    ///
                    if (send_data.puzzle[9, 8] == 0)
                        button84.Visible = false;
                    else
                        button84.Text = send_data.puzzle[9, 8].ToString();
                    ///
                    if (send_data.puzzle[9, 9] == 0)
                        button83.Visible = false;
                    else
                        button83.Text = send_data.puzzle[9, 9].ToString();
                    
                    ///

                    moves.Text = "0";
                    MessageBox.Show("There is no Solution for this PUZZLE");
                }
                //// sloving result
                else
                {
                    for (int y = send_data.Final_answer.Count - 1; y >= 0; y--)
                    {
                         MessageBox.Show("NEXT");
                        moves.Text = (send_data.Final_answer.Count - 2).ToString();
                        if (send_data.Final_answer[y].arr[0, 0] == 0)
                            place_1.Visible = false;
                        else
                        {
                            place_1.Text = send_data.Final_answer[y].arr[0, 0].ToString();
                            place_1.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 1] == 0)
                            place_2.Visible = false;

                        else
                        {
                            place_2.Text = send_data.Final_answer[y].arr[0, 1].ToString();
                            place_2.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 2] == 0)
                            place_4.Visible = false;
                        //place_3.Image = System.Drawing.Image.FromFile(@"C:\Users\Farah Bakkari\Documents\Visual Studio 2013\Projects\ALGORITHM_PROJECT_FORM\ALGORITHM_PROJECT_FORM\bin\Debug\1.jpg");
                        else
                        {
                            place_4.Text = send_data.Final_answer[y].arr[0, 2].ToString();
                            place_4.Visible = true;
                            //place_3.Image = null;
                        }
                        if (send_data.Final_answer[y].arr[0, 3] == 0)
                            button6.Visible = false;

                        else
                        {
                            button6.Text = send_data.Final_answer[y].arr[0, 3].ToString();
                            button6.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 4] == 0)
                            button5.Visible = false;

                        else
                        {
                            button5.Text = send_data.Final_answer[y].arr[0, 4].ToString();
                            button5.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 5] == 0)
                            button4.Visible = false;

                        else
                        {
                            button4.Text = send_data.Final_answer[y].arr[0, 5].ToString();
                            button4.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 6] == 0)
                            button2.Visible = false;

                        else
                        {
                            button2.Text = send_data.Final_answer[y].arr[0, 6].ToString();
                            button2.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 7] == 0)
                            button26.Visible = false;

                        else
                        {
                            button26.Text = send_data.Final_answer[y].arr[0, 7].ToString();
                            button26.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 8] == 0)
                            button25.Visible = false;

                        else
                        {
                            button25.Text = send_data.Final_answer[y].arr[0, 8].ToString();
                            button25.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[0, 9] == 0)
                            button24.Visible = false;

                        else
                        {
                            button24.Text = send_data.Final_answer[y].arr[0, 9].ToString();
                            button24.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 0] == 0)
                            place_5.Visible = false;
                        else
                        {
                            place_5.Text = send_data.Final_answer[y].arr[1, 0].ToString();
                            place_5.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 1] == 0)
                            place_6.Visible = false;
                        else
                        {
                            place_6.Text = send_data.Final_answer[y].arr[1, 1].ToString();
                            place_6.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 2] == 0)
                            place_7.Visible = false;
                        else
                        {
                            place_7.Text = send_data.Final_answer[y].arr[1, 2].ToString();
                            place_7.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 3] == 0)
                            place_8.Visible = false;
                        else
                        {
                            place_8.Text = send_data.Final_answer[y].arr[1, 3].ToString();
                            place_8.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 4] == 0)
                            place_11.Visible = false;
                        else
                        {
                            place_11.Text = send_data.Final_answer[y].arr[1, 4].ToString();
                            place_11.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 5] == 0)
                            button3.Visible = false;
                        else
                        {
                            button3.Text = send_data.Final_answer[y].arr[1, 5].ToString();
                            button3.Visible = true;

                        }
                        if (send_data.Final_answer[y].arr[1, 6] == 0)
                            button1.Visible = false;
                        else
                        {
                            button1.Text = send_data.Final_answer[y].arr[1, 6].ToString();
                            button1.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 7] == 0)
                            button23.Visible = false;
                        else
                        {
                            button23.Text = send_data.Final_answer[y].arr[1, 7].ToString();
                            button23.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 8] == 0)
                            button22.Visible = false;
                        else
                        {
                            button22.Text = send_data.Final_answer[y].arr[1, 8].ToString();
                            button22.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[1, 9] == 0)
                            button21.Visible = false;
                        else
                        {
                            button21.Text = send_data.Final_answer[y].arr[1, 9].ToString();
                            button21.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 0] == 0)
                            place_9.Visible = false;
                        else
                        {
                            place_9.Text = send_data.Final_answer[y].arr[2, 0].ToString();
                            place_9.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 1] == 0)
                            place_10.Visible = false;
                        else
                        {
                            place_10.Text = send_data.Final_answer[y].arr[2, 1].ToString();
                            place_10.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 2] == 0)
                            place_12.Visible = false;
                        else
                        {
                            place_12.Text = send_data.Final_answer[y].arr[2, 2].ToString();
                            place_12.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 3] == 0)
                            place_16.Visible = false;
                        else
                        {
                            place_16.Text = send_data.Final_answer[y].arr[2, 3].ToString();
                            place_16.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 4] == 0)
                            button20.Visible = false;
                        else
                        {
                            button20.Text = send_data.Final_answer[y].arr[2, 4].ToString();
                            button20.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 5] == 0)
                            button19.Visible = false;
                        else
                        {
                            button19.Text = send_data.Final_answer[y].arr[2, 5].ToString();
                            button19.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 6] == 0)
                            button18.Visible = false;
                        else
                        {
                            button18.Text = send_data.Final_answer[y].arr[2, 6].ToString();
                            button18.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 7] == 0)
                            button17.Visible = false;
                        else
                        {
                            button17.Text = send_data.Final_answer[y].arr[2, 7].ToString();
                            button17.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 8] == 0)
                            button35.Visible = false;
                        else
                        {
                            button35.Text = send_data.Final_answer[y].arr[2, 8].ToString();
                            button35.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[2, 9] == 0)
                            button34.Visible = false;
                        else
                        {
                            button20.Text = send_data.Final_answer[y].arr[2, 9].ToString();
                            button20.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 0] == 0)
                            place_13.Visible = false;
                        else
                        {
                            place_13.Text = send_data.Final_answer[y].arr[3, 0].ToString();
                            place_13.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 1] == 0)
                            place_14.Visible = false;
                        else
                        {
                            place_14.Text = send_data.Final_answer[y].arr[3, 1].ToString();
                            place_14.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 2] == 0)
                            place_15.Visible = false;
                        else
                        {
                            place_15.Text = send_data.Final_answer[y].arr[3, 2].ToString();
                            place_15.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 3] == 0)
                            button7.Visible = false;
                        else
                        {
                            button7.Text = send_data.Final_answer[y].arr[3, 3].ToString();
                            button7.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 4] == 0)
                            button33.Visible = false;
                        else
                        {
                            button33.Text = send_data.Final_answer[y].arr[3, 4].ToString();
                            button33.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 5] == 0)
                            button32.Visible = false;
                        else
                        {
                            button32.Text = send_data.Final_answer[y].arr[3, 5].ToString();
                            button32.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 6] == 0)
                            button31.Visible = false;
                        else
                        {
                            button31.Text = send_data.Final_answer[y].arr[3, 6].ToString();
                            button31.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 7] == 0)
                            button30.Visible = false;
                        else
                        {
                            button30.Text = send_data.Final_answer[y].arr[3, 7].ToString();
                            button30.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 8] == 0)
                            button29.Visible = false;
                        else
                        {
                            button29.Text = send_data.Final_answer[y].arr[3, 8].ToString();
                            button29.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[3, 9] == 0)
                            button28.Visible = false;
                        else
                        {
                            button28.Text = send_data.Final_answer[y].arr[3, 9].ToString();
                            button28.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 0] == 0)
                            button13.Visible = false;
                        else
                        {
                            button13.Text = send_data.Final_answer[y].arr[4, 0].ToString();
                            button13.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 1] == 0)
                            button10.Visible = false;
                        else
                        {
                            button10.Text = send_data.Final_answer[y].arr[4, 1].ToString();
                            button10.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 2] == 0)
                            button27.Visible = false;
                        else
                        {
                            button27.Text = send_data.Final_answer[y].arr[4, 2].ToString();
                            button27.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 3] == 0)
                            button53.Visible = false;
                        else
                        {
                            button53.Text = send_data.Final_answer[y].arr[4, 3].ToString();
                            button53.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 4] == 0)
                            button52.Visible = false;
                        else
                        {
                            button52.Text = send_data.Final_answer[y].arr[4, 4].ToString();
                            button52.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 5] == 0)
                            button51.Visible = false;
                        else
                        {
                            button51.Text = send_data.Final_answer[y].arr[4, 5].ToString();
                            button51.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 6] == 0)
                            button50.Visible = false;
                        else
                        {
                            button50.Text = send_data.Final_answer[y].arr[4, 6].ToString();
                            button50.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 7] == 0)
                            button49.Visible = false;
                        else
                        {
                            button49.Text = send_data.Final_answer[y].arr[4, 7].ToString();
                            button49.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 8] == 0)
                            button55.Visible = false;
                        else
                        {
                            button55.Text = send_data.Final_answer[y].arr[4, 8].ToString();
                            button55.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[4, 9] == 0)
                            button54.Visible = false;
                        else
                        {
                            button54.Text = send_data.Final_answer[y].arr[4, 9].ToString();
                            button54.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 0] == 0)
                            button12.Visible = false;
                        else
                        {
                            button12.Text = send_data.Final_answer[y].arr[5, 0].ToString();
                            button12.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 1] == 0)
                            button9.Visible = false;
                        else
                        {
                            button9.Text = send_data.Final_answer[y].arr[5, 1].ToString();
                            button9.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 2] == 0)
                            button48.Visible = false;
                        else
                        {
                            button48.Text = send_data.Final_answer[y].arr[5, 2].ToString();
                            button48.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 3] == 0)
                            button46.Visible = false;
                        else
                        {
                            button46.Text = send_data.Final_answer[y].arr[5, 3].ToString();
                            button46.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 4] == 0)
                            button44.Visible = false;
                        else
                        {
                            button44.Text = send_data.Final_answer[y].arr[5, 4].ToString();
                            button44.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 5] == 0)
                            button43.Visible = false;
                        else
                        {
                            button43.Text = send_data.Final_answer[y].arr[5, 5].ToString();
                            button43.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 6] == 0)
                            button42.Visible = false;
                        else
                        {
                            button42.Text = send_data.Final_answer[y].arr[5, 6].ToString();
                            button42.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 7] == 0)
                            button36.Visible = false;
                        else
                        {
                            button36.Text = send_data.Final_answer[y].arr[5, 7].ToString();
                            button36.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 8] == 0)
                            button64.Visible = false;
                        else
                        {
                            button64.Text = send_data.Final_answer[y].arr[5, 8].ToString();
                            button64.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[5, 9] == 0)
                            button66.Visible = false;
                        else
                        {
                            button66.Text = send_data.Final_answer[y].arr[5, 9].ToString();
                            button66.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 0] == 0)
                            button11.Visible = false;
                        else
                        {
                            button11.Text = send_data.Final_answer[y].arr[6, 0].ToString();
                            button11.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 1] == 0)
                            button8.Visible = false;
                        else
                        {
                            button8.Text = send_data.Final_answer[y].arr[6, 1].ToString();
                            button8.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 2] == 0)
                            button47.Visible = false;
                        else
                        {
                            button47.Text = send_data.Final_answer[y].arr[6, 2].ToString();
                            button47.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 3] == 0)
                            button45.Visible = false;
                        else
                        {
                            button45.Text = send_data.Final_answer[y].arr[6, 3].ToString();
                            button45.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 4] == 0)
                            button41.Visible = false;
                        else
                        {
                            button41.Text = send_data.Final_answer[y].arr[6, 4].ToString();
                            button41.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 5] == 0)
                            button40.Visible = false;
                        else
                        {
                            button40.Text = send_data.Final_answer[y].arr[6, 5].ToString();
                            button40.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 6] == 0)
                            button39.Visible = false;
                        else
                        {
                            button39.Text = send_data.Final_answer[y].arr[6, 6].ToString();
                            button39.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 7] == 0)
                            button57.Visible = false;
                        else
                        {
                            button57.Text = send_data.Final_answer[y].arr[6, 7].ToString();
                            button57.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 8] == 0)
                            button63.Visible = false;
                        else
                        {
                            button63.Text = send_data.Final_answer[y].arr[6, 8].ToString();
                            button63.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[6, 9] == 0)
                            button65.Visible = false;
                        else
                        {
                            button65.Text = send_data.Final_answer[y].arr[6, 9].ToString();
                            button65.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 0] == 0)
                            button14.Visible = false;
                        else
                        {
                            button14.Text = send_data.Final_answer[y].arr[7, 0].ToString();
                            button14.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 1] == 0)
                            place_3.Visible = false;
                        else
                        {
                            place_3.Text = send_data.Final_answer[y].arr[7, 1].ToString();
                            place_3.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 2] == 0)
                            button38.Visible = false;
                        else
                        {
                            button38.Text = send_data.Final_answer[y].arr[7, 2].ToString();
                            button38.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 3] == 0)
                            button37.Visible = false;
                        else
                        {
                            button37.Text = send_data.Final_answer[y].arr[7, 3].ToString();
                            button37.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 4] == 0)
                            button60.Visible = false;
                        else
                        {
                            button60.Text = send_data.Final_answer[y].arr[7, 4].ToString();
                            button60.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 5] == 0)
                            button59.Visible = false;
                        else
                        {
                            button59.Text = send_data.Final_answer[y].arr[7, 5].ToString();
                            button59.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 6] == 0)
                            button58.Visible = false;
                        else
                        {
                            button58.Text = send_data.Final_answer[y].arr[7, 6].ToString();
                            button58.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 7] == 0)
                            button56.Visible = false;
                        else
                        {
                            button56.Text = send_data.Final_answer[y].arr[7, 7].ToString();
                            button56.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 8] == 0)
                            button62.Visible = false;
                        else
                        {
                            button62.Text = send_data.Final_answer[y].arr[7, 8].ToString();
                            button62.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[7, 9] == 0)
                            button61.Visible = false;
                        else
                        {
                            button61.Text = send_data.Final_answer[y].arr[7, 9].ToString();
                            button61.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 0] == 0)
                            button15.Visible = false;
                        else
                        {
                            button15.Text = send_data.Final_answer[y].arr[8, 0].ToString();
                            button15.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 1] == 0)
                            button78.Visible = false;
                        else
                        {
                            button78.Text = send_data.Final_answer[y].arr[8, 1].ToString();
                            button78.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 2] == 0)
                            button77.Visible = false;
                        else
                        {
                            button77.Text = send_data.Final_answer[y].arr[8, 2].ToString();
                            button77.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 3] == 0)
                            button76.Visible = false;
                        else
                        {
                            button76.Text = send_data.Final_answer[y].arr[8, 3].ToString();
                            button76.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 4] == 0)
                            button75.Visible = false;
                        else
                        {
                            button75.Text = send_data.Final_answer[y].arr[8, 4].ToString();
                            button75.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 5] == 0)
                            button74.Visible = false;
                        else
                        {
                            button74.Text = send_data.Final_answer[y].arr[8, 5].ToString();
                            button74.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 6] == 0)
                            button73.Visible = false;
                        else
                        {
                            button73.Text = send_data.Final_answer[y].arr[8, 6].ToString();
                            button73.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 7] == 0)
                            button72.Visible = false;
                        else
                        {
                            button72.Text = send_data.Final_answer[y].arr[8, 7].ToString();
                            button72.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 8] == 0)
                            button71.Visible = false;
                        else
                        {
                            button71.Text = send_data.Final_answer[y].arr[8, 8].ToString();
                            button71.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[8, 9] == 0)
                            button70.Visible = false;
                        else
                        {
                            button70.Text = send_data.Final_answer[y].arr[8, 9].ToString();
                            button70.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 0] == 0)
                            button16.Visible = false;
                        else
                        {
                            button16.Text = send_data.Final_answer[y].arr[9, 0].ToString();
                            button16.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 1] == 0)
                            button69.Visible = false;
                        else
                        {
                            button69.Text = send_data.Final_answer[y].arr[9, 1].ToString();
                            button69.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 2] == 0)
                            button68.Visible = false;
                        else
                        {
                            button68.Text = send_data.Final_answer[y].arr[9, 2].ToString();
                            button68.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 3] == 0)
                            button67.Visible = false;
                        else
                        {
                            button67.Text = send_data.Final_answer[y].arr[9, 3].ToString();
                            button67.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 4] == 0)
                            button82.Visible = false;
                        else
                        {
                            button82.Text = send_data.Final_answer[y].arr[9, 4].ToString();
                            button82.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 5] == 0)
                            button81.Visible = false;
                        else
                        {
                            button81.Text = send_data.Final_answer[y].arr[9, 5].ToString();
                            button81.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 6] == 0)
                            button80.Visible = false;
                        else
                        {
                            button80.Text = send_data.Final_answer[y].arr[9, 6].ToString();
                            button80.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 7] == 0)
                            button79.Visible = false;
                        else
                        {
                            button79.Text = send_data.Final_answer[y].arr[9, 7].ToString();
                            button79.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 8] == 0)
                            button84.Visible = false;
                        else
                        {
                            button84.Text = send_data.Final_answer[y].arr[9, 8].ToString();
                            button84.Visible = true;
                        }
                        if (send_data.Final_answer[y].arr[9, 9] == 0)
                            button83.Visible = false;
                        else
                        {
                            button83.Text = send_data.Final_answer[y].arr[9, 9].ToString();
                            button83.Visible = true;
                        }
                    }
                    }
                }
            }



            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 343;
            this.Width = 288;
            play.Location = new Point(43, 220);
            label1.Location = new Point(43, 50);
            choice.Location = new Point(70, 90);
            label2.Location = new Point(43, 140);
            choice_her.Location = new Point(70, 180);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          //  groupBox1.BackColor = null;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }
    }
}
