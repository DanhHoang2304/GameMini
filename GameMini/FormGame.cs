using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GameMini
{
    public partial class FormGame : Form
    {
        public DataTable dtAnimal = new DataTable();
        public DataTable dtFruit = new DataTable();
        public DataTable dtJobs = new DataTable();
        public FormGame()
        {
            InitializeComponent();
            dtAnimal.Columns.Add("ID", typeof(int));
            dtAnimal.Columns.Add("Name", typeof(string));
            dtAnimal.Columns.Add("Score", typeof(int));
            dtAnimal.Columns.Add("Time", typeof(int));
            dtFruit.Columns.Add("ID", typeof(int));
            dtFruit.Columns.Add("Name", typeof(string));
            dtFruit.Columns.Add("Score", typeof(int));
            dtFruit.Columns.Add("Time", typeof(int));
            dtJobs.Columns.Add("ID", typeof(int));
            dtJobs.Columns.Add("Name", typeof(string));
            dtJobs.Columns.Add("Score", typeof(int));
            dtJobs.Columns.Add("Time", typeof(int));
        }

        private void button_Exit_Game_Click(object sender, EventArgs e)
        {
            this.Close();
            textBox_name_player.Text = "";
        }

        private void button_start_MouseMove(object sender, MouseEventArgs e)
        {
            button_start.BackColor = Color.Green;
            button_start.ForeColor = Color.Yellow;
        }

        private void button_start_MouseLeave(object sender, EventArgs e)
        {
            button_start.BackColor = Color.Transparent;
            button_start.ForeColor = Color.Red;
        }

        int check_name(string s)
        {
            for (int i = 0; i < dtAnimal.Rows.Count; i++)
            {
                if (s == dtAnimal.Rows[i].ItemArray[1].ToString()) return 1;
            }
            for (int i = 0; i < dtFruit.Rows.Count; i++)
            {
                if (s == dtFruit.Rows[i].ItemArray[1].ToString()) return 1;
            }
            for (int i = 0; i < dtJobs.Rows.Count; i++)
            {
                if (s == dtJobs.Rows[i].ItemArray[1].ToString()) return 1;
            }
            return 0;
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            if(textBox_name_player.Text == "")
            {
                MessageBox.Show("Please Write Your Name Again!!!", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if(check_name(textBox_name_player.Text) == 1)
            {
                MessageBox.Show("Player name already exists \n Please Write Your Name Again!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                panel_Write_name.Visible = false;
                panel_choose_category.Visible = true;
                //this.AcceptButton = button_next_image_animal;
            }    
        }

        //Game animals
        #region Game Animals
        private void button_animal_category_Click(object sender, EventArgs e)
        {
            panel_choose_category.Visible = false;
            panel_animal_game.Visible = true;
        }
     
        private void textBox_animal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }
     
        private void button_return_animal_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("The game is still running!!! \n Do you want to exit the game ???","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                panel_animal_game.Visible = false;
                panel_choose_category.Visible = true;
                dice_animal = 0;
                count_animal = 0;
                flag1 = 0;
                flag2 = 0;
                flag3 = 0;
                flag4 = 0;
                flag5 = 0;
                flag6 = 0;
                flag7 = 0;
                flag8 = 0;
                flag9 = 0;
                flag10 = 0;
                flag11 = 0;
                flag12 = 0;
                total_score_animal = 0;
                giay1 = 60;
                timer1.Stop();
                label_time_animal.Text = "01:00";
                label_time_animal.Visible = false;
                button_next_image_animal.Visible = true;
                button_back_animal.Visible = true;
                button_return_animal.Visible = false;
                textBox_animal.Visible = false;
                pictureBox_game_animal.BackgroundImage = null;
                button_next_image_animal.BackgroundImage = Properties.Resources.start;
                textBox_animal.Text = "";
            }
            
        }

        private void button_exit_animal_Click(object sender, EventArgs e)
        {
            panel_choose_category.Visible = true;
            panel_total_score_animal.Visible = false;
            label_time_animal.Visible = false;
        }
        int dice_animal = 0;
        int count_animal = 0;
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int flag4 = 0;
        int flag5 = 0;
        int flag6 = 0;
        int flag7 = 0;
        int flag8 = 0;
        int flag9 = 0;
        int flag10 = 0;
        int flag11 = 0;
        int flag12 = 0;
        int total_score_animal = 0;
        int id_animal = 0;

        private void button_next_image_animal_Click(object sender, EventArgs e)
        {
            label_time_animal.Visible = true;
            button_return_animal.Visible = true;
            button_back_animal.Visible = false;
            if (giay1 == 0)
                timer1.Stop();
            else
                timer1.Start();
            if (count_animal > 0)
            {
                switch (dice_animal)
                {
                    case 1:
                        if (textBox_animal.Text.ToLower() == "duck" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 2:
                        if (textBox_animal.Text.ToLower() == "cat" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 3:
                        if (textBox_animal.Text.ToLower() == "dog" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 4:
                        if (textBox_animal.Text.ToLower() == "elephant" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 5:
                        if (textBox_animal.Text.ToLower() == "fox" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 6:
                        if (textBox_animal.Text.ToLower() == "hippo" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 7:
                        if (textBox_animal.Text.ToLower() == "horse" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 8:
                        if (textBox_animal.Text.ToLower() == "panda" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 9:
                        if (textBox_animal.Text.ToLower() == "parrot" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 10:
                        if (textBox_animal.Text.ToLower() == "rhino" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 11:
                        if (textBox_animal.Text.ToLower() == "tiger" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                    case 12:
                        if (textBox_animal.Text.ToLower() == "turtle" && giay1 > 0)
                            total_score_animal += 20;
                        break;
                }
            }
            if (count_animal > 4)
            {
                int a = 60 - giay1;
                id_animal++;
                label_total_score_animal.Text = total_score_animal.ToString();
                label_total_time_animal.Text = a.ToString();
                panel_total_score_animal.Visible = true;
                panel_animal_game.Visible = false;
                dtAnimal.Rows.Add(id_animal, textBox_name_player.Text, total_score_animal, a);
                dice_animal = 0;
                count_animal = 0;
                flag1 = 0;
                flag2 = 0;
                flag3 = 0;
                flag4 = 0;
                flag5 = 0;
                flag6 = 0;
                flag7 = 0;
                flag8 = 0;
                flag9 = 0;
                flag10 = 0;
                flag11 = 0;
                flag12 = 0;
                total_score_animal = 0;
                giay1 = 60;
                timer1.Stop();
                label_time_animal.Text = "01:00";
                button_next_image_animal.Visible = true;
                button_back_animal.Visible = true;
                button_return_animal.Visible = false;
                textBox_animal.Visible = false;
                pictureBox_game_animal.BackgroundImage = null;
                button_next_image_animal.BackgroundImage = Properties.Resources.start;
                textBox_animal.Text = "";
                return;
            }
            button_next_image_animal.BackgroundImage = Properties.Resources.next;
            textBox_animal.Visible = true;

            Random rand = new Random();
            List<int> list = new List<int>(12) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            do
            {
                dice_animal = rand.Next(list.Count + 1);
            }
            while ((dice_animal == 1 && flag1 == 1)
               || (dice_animal == 2 && flag2 == 1)
               || (dice_animal == 3 && flag3 == 1)
               || (dice_animal == 4 && flag4 == 1)
               || (dice_animal == 5 && flag5 == 1)
               || (dice_animal == 6 && flag6 == 1)
               || (dice_animal == 7 && flag7 == 1)
               || (dice_animal == 8 && flag8 == 1)
               || (dice_animal == 9 && flag9 == 1)
               || (dice_animal == 10 && flag10 == 1)
               || (dice_animal == 11 && flag11 == 1)
               || (dice_animal == 12 && flag12 == 1)
               );
            switch (dice_animal)
            {
                case 1:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.duck;
                    flag1 = 1;
                    count_animal++;
                    break;
                case 2:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.cat;
                    flag2 = 1;
                    count_animal++;
                    break;
                case 3:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.corgi;
                    flag3 = 1;
                    count_animal++;
                    break;
                case 4:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.elephant;
                    flag4 = 1;
                    count_animal++;
                    break;
                case 5:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.fox;
                    flag5 = 1;
                    count_animal++;
                    break;
                case 6:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.hippo;
                    flag6 = 1;
                    count_animal++;
                    break;
                case 7:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.horse;
                    flag7 = 1;
                    count_animal++;
                    break;
                case 8:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.panda;
                    flag8 = 1;
                    count_animal++;
                    break;
                case 9:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.parrot;
                    flag9 = 1;
                    count_animal++;
                    break;
                case 10:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.rhino;
                    flag10 = 1;
                    count_animal++;
                    break;
                case 11:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.tiger;
                    flag11 = 1;
                    count_animal++;
                    break;
                case 12:
                    pictureBox_game_animal.BackgroundImage = Properties.Resources.turtle;
                    flag12 = 1;
                    count_animal++;
                    break;
            }
            textBox_animal.Text = "";
        }

        int giay1 = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            giay1--;
            label_time_animal.Text = "00:" + giay1.ToString();
            if (giay1 == 0)
                timer1.Stop();
        }

        private void button_exit_category_Click(object sender, EventArgs e)
        {
            panel_choose_category.Visible = false;
            panel_Write_name.Visible = true;
        }

        private void button_back_animal_Click(object sender, EventArgs e)
        {
            panel_animal_game.Visible = false;
            panel_choose_category.Visible = true;
        }
        #endregion

        //Game Jobs
        #region Game Jobs
        private void button_job_category_Click(object sender, EventArgs e)
        {
            panel_choose_category.Visible = false;
            panel_jobs_game.Visible = true;
        }

        int dice_jobs = 0;
        int count_jobs = 0;
        int flag13 = 0;
        int flag14 = 0;
        int flag15 = 0;
        int flag16 = 0;
        int flag17 = 0;
        int flag18 = 0;
        int flag19 = 0;
        int flag20 = 0;
        int flag21 = 0;
        int flag22 = 0;
        int flag23 = 0;
        int flag24 = 0;
        int total_score_jobs = 0;
        int giay2 = 60;
        int id_jobs = 0;

        private void button_next_image_jobs_Click(object sender, EventArgs e)
        {
            label_time_jobs.Visible = true;
            button_return_jobs.Visible = true;
            button_back_jobs.Visible = false;
            if (giay2 == 0)
                timer2.Stop();
            else
                timer2.Start();
            if (count_jobs > 0)
            {
                switch (dice_jobs)
                {
                    case 1:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "actor" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 2:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "artist" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 3:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "baker" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 4:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "chef" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 5:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "dentist" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 6:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "doctor" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 7:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "firefighter" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 8:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "flightatendant" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 9:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "pilot" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 10:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "police" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 11:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "singer" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                    case 12:
                        if (textBox_jobs.Text.ToLower().Replace(" ", "") == "teacher" && giay2 > 0)
                            total_score_jobs += 20;
                        break;
                }
            }
            if (count_jobs > 4)
            {
                int a = 60 - giay2;
                id_jobs++;
                label_total_score_jobs.Text = total_score_jobs.ToString();
                label_total_time_jobs.Text = a.ToString();
                panel_total_score_jobs.Visible = true;
                panel_jobs_game.Visible = false;
                dtJobs.Rows.Add(id_jobs, textBox_name_player.Text, total_score_jobs, a);
                dice_jobs = 0;
                count_jobs = 0;
                flag13 = 0;
                flag14 = 0;
                flag15 = 0;
                flag16 = 0;
                flag17 = 0;
                flag18 = 0;
                flag19 = 0;
                flag20 = 0;
                flag21 = 0;
                flag22 = 0;
                flag23 = 0;
                flag24 = 0;
                total_score_jobs = 0;
                giay2 = 60;
                timer2.Stop();
                label_time_jobs.Text = "01:00";
                button_next_image_jobs.Visible = true;
                button_back_jobs.Visible = true;
                button_return_jobs.Visible = false;
                textBox_jobs.Visible = false;
                pictureBox_game_jobs.BackgroundImage = null;
                button_next_image_jobs.BackgroundImage = Properties.Resources.start;
                textBox_jobs.Text = "";
                return;
            }
            button_next_image_jobs.BackgroundImage = Properties.Resources.next;
            textBox_jobs.Visible = true;

            Random rand = new Random();
            List<int> list = new List<int>(12) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            do
            {
                dice_jobs = rand.Next(list.Count + 1);
            }
            while ((dice_jobs == 1 && flag13 == 1)
               || (dice_jobs == 2 && flag14 == 1)
               || (dice_jobs == 3 && flag15 == 1)
               || (dice_jobs == 4 && flag16 == 1)
               || (dice_jobs == 5 && flag17 == 1)
               || (dice_jobs == 6 && flag18 == 1)
               || (dice_jobs == 7 && flag19 == 1)
               || (dice_jobs == 8 && flag20 == 1)
               || (dice_jobs == 9 && flag21 == 1)
               || (dice_jobs == 10 && flag22 == 1)
               || (dice_jobs == 11 && flag23 == 1)
               || (dice_jobs == 12 && flag24 == 1)
               );
            switch (dice_jobs)
            {
                case 1:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.actor;
                    flag13 = 1;
                    count_jobs++;
                    break;
                case 2:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.artist;
                    flag14 = 1;
                    count_jobs++;
                    break;
                case 3:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.baker;
                    flag15 = 1;
                    count_jobs++;
                    break;
                case 4:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.chef;
                    flag16 = 1;
                    count_jobs++; ;
                    break;
                case 5:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.dentist;
                    flag17 = 1;
                    count_jobs++;
                    break;
                case 6:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.doctor;
                    flag18 = 1;
                    count_jobs++;
                    break;
                case 7:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.firefighter;
                    flag19 = 1;
                    count_jobs++;
                    break;
                case 8:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.flight_attendant;
                    flag20 = 1;
                    count_jobs++;
                    break;
                case 9:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.pilot;
                    flag21 = 1;
                    count_jobs++;
                    break;
                case 10:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.police_officer;
                    flag22 = 1;
                    count_jobs++;
                    break;
                case 11:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.singer;
                    flag23 = 1;
                    count_jobs++;
                    break;
                case 12:
                    pictureBox_game_jobs.BackgroundImage = Properties.Resources.teacher;
                    flag24 = 1;
                    count_jobs++;
                    break;
            }
            textBox_jobs.Text = "";
        }

        private void button_return_jobs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The game is still running!!! \n Do you want to exit the game ???", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                panel_jobs_game.Visible = false;
                panel_choose_category.Visible = true;
                dice_jobs = 0;
                count_jobs = 0;
                flag13 = 0;
                flag14 = 0;
                flag15 = 0;
                flag16 = 0;
                flag17 = 0;
                flag18 = 0;
                flag19 = 0;
                flag20 = 0;
                flag21 = 0;
                flag22 = 0;
                flag23 = 0;
                flag24 = 0;
                total_score_jobs = 0;
                giay2 = 60;
                timer2.Stop();
                label_time_jobs.Text = "01:00";
                label_time_jobs.Visible = false;
                button_next_image_jobs.Visible = true;
                button_back_jobs.Visible = true;
                button_return_jobs.Visible = false;
                textBox_jobs.Visible = false;
                pictureBox_game_jobs.BackgroundImage = null;
                button_next_image_jobs.BackgroundImage = Properties.Resources.start;
                textBox_jobs.Text = "";
            }
        }

        private void button_back_jobs_Click(object sender, EventArgs e)
        {
            panel_jobs_game.Visible = false;
            panel_choose_category.Visible = true;
        }

        private void button_exit_jobs_Click(object sender, EventArgs e)
        {
            panel_choose_category.Visible = true;
            panel_total_score_jobs.Visible = false;
            label_time_jobs.Visible = false;
        }

        private void textBox_jobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !( (e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            giay2--;
            label_time_jobs.Text = "00:" + giay2.ToString();
            if (giay2 == 0)
                timer2.Stop();
        }

        #endregion

        //Game Fruits
        #region Game Fruits
        private void button_fruit_category_Click(object sender, EventArgs e)
        {
            panel_choose_category.Visible = false;
            panel_fruits_game.Visible = true;
        }

        private void button_back_fruits_Click(object sender, EventArgs e)
        {
            panel_fruits_game.Visible = false;
            panel_choose_category.Visible = true;
        }

        private void button_return_fruits_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The game is still running!!! \n Do you want to exit the game ???", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                panel_fruits_game.Visible = false;
                panel_choose_category.Visible = true;
                dice_fruits = 0;
                count_fruits = 0;
                flag25 = 0;
                flag26 = 0;
                flag27 = 0;
                flag28 = 0;
                flag29 = 0;
                flag30 = 0;
                flag31 = 0;
                flag32 = 0;
                flag33 = 0;
                flag34 = 0;
                flag35 = 0;
                flag36 = 0;
                total_score_fruits = 0;
                giay3 = 60;
                timer3.Stop();
                label_time_fruits.Text = "01:00";
                label_time_fruits.Visible = false;
                button_next_image_fruits.Visible = true;
                button_back_fruits.Visible = true;
                button_return_fruits.Visible = false;
                textBox_frutis.Visible = false;
                pictureBox_game_fruits.BackgroundImage = null;
                button_next_image_fruits.BackgroundImage = Properties.Resources.start;
                textBox_frutis.Text = "";
            }
        }

        int dice_fruits = 0;
        int count_fruits = 0;
        int flag25 = 0;
        int flag26 = 0;
        int flag27 = 0;
        int flag28 = 0;
        int flag29 = 0;
        int flag30 = 0;
        int flag31 = 0;
        int flag32 = 0;
        int flag33 = 0;
        int flag34 = 0;
        int flag35 = 0;
        int flag36 = 0;
        int total_score_fruits = 0;
        int giay3 = 60;
        int id_fruits = 0;
        private void button_next_image_fruits_Click(object sender, EventArgs e)
        {
            label_time_fruits.Visible = true;
            button_return_fruits.Visible = true;
            button_back_fruits.Visible = false;
            if (giay3 == 0)
                timer3.Stop();
            else
                timer3.Start();
            if (count_fruits > 0)
            {
                switch (dice_fruits)
                {
                    case 1:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "apple" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 2:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "banana" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 3:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "carrot" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 4:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "grape" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 5:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "lemon" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 6:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "mango" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 7:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "onion" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 8:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "orange" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 9:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "peach" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 10:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "potato" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 11:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "tomato" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                    case 12:
                        if (textBox_frutis.Text.ToLower().Replace(" ", "") == "watermelon" && giay3 > 0)
                            total_score_fruits += 20;
                        break;
                }
            }
            if (count_fruits > 4)
            {
                int a = 60 - giay3;
                id_fruits++;
                label_total_score_fruits.Text = total_score_fruits.ToString();
                label_total_time_fruits.Text = a.ToString();
                panel_total_score_fruits.Visible = true;
                panel_fruits_game.Visible = false;
                dtFruit.Rows.Add(id_fruits, textBox_name_player.Text, total_score_fruits, a);
                dice_fruits = 0;
                count_fruits = 0;
                flag25 = 0;
                flag26 = 0;
                flag27 = 0;
                flag28 = 0;
                flag29 = 0;
                flag30 = 0;
                flag31 = 0;
                flag32 = 0;
                flag33 = 0;
                flag34 = 0;
                flag35 = 0;
                flag36 = 0;
                total_score_fruits = 0;
                giay3 = 60;
                timer3.Stop();
                label_time_fruits.Text = "01:00";
                button_next_image_fruits.Visible = true;
                button_back_fruits.Visible = true;
                button_return_fruits.Visible = false;
                textBox_frutis.Visible = false;
                pictureBox_game_fruits.BackgroundImage = null;
                button_next_image_fruits.BackgroundImage = Properties.Resources.start;
                textBox_frutis.Text = "";
                return;
            }
            button_next_image_fruits.BackgroundImage = Properties.Resources.next;
            textBox_frutis.Visible = true;

            Random rand = new Random();
            List<int> list = new List<int>(12) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            do
            {
                dice_fruits = rand.Next(list.Count + 1);
            }
            while ((dice_fruits == 1 && flag25 == 1)
               || (dice_fruits == 2 && flag26 == 1)
               || (dice_fruits == 3 && flag27 == 1)
               || (dice_fruits == 4 && flag28 == 1)
               || (dice_fruits == 5 && flag29 == 1)
               || (dice_fruits == 6 && flag30 == 1)
               || (dice_fruits == 7 && flag31 == 1)
               || (dice_fruits == 8 && flag32 == 1)
               || (dice_fruits == 9 && flag33 == 1)
               || (dice_fruits == 10 && flag34 == 1)
               || (dice_fruits == 11 && flag35 == 1)
               || (dice_fruits == 12 && flag36 == 1)
               );
            switch (dice_fruits)
            {
                case 1:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.apple;
                    flag25 = 1;
                    count_fruits++;
                    break;
                case 2:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.banana;
                    flag26 = 1;
                    count_fruits++;
                    break;
                case 3:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.carrot;
                    flag27 = 1;
                    count_fruits++;
                    break;
                case 4:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.grape;
                    flag28 = 1;
                    count_fruits++;
                    break;
                case 5:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.lemon;
                    flag29 = 1;
                    count_fruits++;
                    break;
                case 6:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.mango;
                    flag30 = 1;
                    count_fruits++;
                    break;
                case 7:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.onion;
                    flag31 = 1;
                    count_fruits++;
                    break;
                case 8:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.orange;
                    flag32 = 1;
                    count_fruits++;
                    break;
                case 9:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.peach;
                    flag33 = 1;
                    count_fruits++;
                    break;
                case 10:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.potato1;
                    flag34 = 1;
                    count_fruits++;
                    break;
                case 11:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.tomato;
                    flag35 = 1;
                    count_fruits++;
                    break;
                case 12:
                    pictureBox_game_fruits.BackgroundImage = Properties.Resources.watermelon;
                    flag36 = 1;
                    count_fruits++;
                    break;
            }
            textBox_frutis.Text = "";
        }

       

        private void textBox_frutis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            giay3--;
            label_time_fruits.Text = "00:" + giay3.ToString();
            if (giay3 == 0)
                timer3.Stop();
        }

        private void button_exit_fruits_Click(object sender, EventArgs e)
        {
            panel_choose_category.Visible = true;
            panel_total_score_fruits.Visible = false;
            label_time_fruits.Visible = false;
        }
        #endregion

        private void button_animal_category_MouseMove(object sender, MouseEventArgs e)
        {
            button_animal_category.BackColor = Color.Green;
        }

        private void button_animal_category_MouseLeave(object sender, EventArgs e)
        {
            button_animal_category.BackColor = Color.Transparent;
        }

        private void button_fruit_category_MouseMove(object sender, MouseEventArgs e)
        {
            button_fruit_category.BackColor = Color.Green;
        }

        private void button_fruit_category_MouseLeave(object sender, EventArgs e)
        {
            button_fruit_category.BackColor = Color.Transparent;
        }

        private void button_job_category_MouseMove(object sender, MouseEventArgs e)
        {
            button_job_category.BackColor = Color.Green;
        }

        private void button_job_category_MouseLeave(object sender, EventArgs e)
        {
            button_job_category.BackColor = Color.Transparent;
        }
    }
}
