using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMini
{
    public partial class FormBeginGame : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        FormGame game = new FormGame();
        public FormBeginGame()
        {
            InitializeComponent();

            player.SoundLocation = "firstdaywav.wav";
            
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormBeginGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit game ???", "Notification", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_play_MouseMove(object sender, MouseEventArgs e)
        {
            button_play.BackColor = Color.Green;
            button_play.ForeColor = Color.Yellow;
        }

        private void button_play_MouseLeave(object sender, EventArgs e)
        {
            button_play.BackColor= Color.Transparent;
            button_play.ForeColor = Color.AliceBlue;
        }

        private void button_list_word_MouseMove(object sender, MouseEventArgs e)
        {
            button_list_word.BackColor = Color.Green;
            button_list_word.ForeColor = Color.Yellow;
        }

        private void button_list_word_MouseLeave(object sender, EventArgs e)
        {
            button_list_word.ForeColor = Color.AliceBlue;
            button_list_word.BackColor = Color.Transparent;
        }

        private void button_scoreboard_MouseMove(object sender, MouseEventArgs e)
        {
            button_scoreboard.BackColor = Color.Green;
            button_scoreboard.ForeColor = Color.Yellow;
        }

        private void button_scoreboard_MouseLeave(object sender, EventArgs e)
        {
            button_scoreboard.ForeColor = Color.AliceBlue;
            button_scoreboard.BackColor = Color.Transparent;
        }

        private void button_list_word_Click(object sender, EventArgs e)
        {
            panel_word_list.Visible = true;
        }

        private void button_Exit_Word_List_Click(object sender, EventArgs e)
        {
            panel_word_list.Visible = false;
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Category.Text == "Animals")
            {
                pictureBox_Category.BackgroundImage = Properties.Resources.animal;
            }

            if (comboBox_Category.Text == "Jobs")
            {
                pictureBox_Category.BackgroundImage = Properties.Resources.jobs;
            }

            if (comboBox_Category.Text == "Fruits")
            {
                pictureBox_Category.BackgroundImage = Properties.Resources.fruits;
            }
        }

        int check_Sound = 0;
        private void button_music_MouseClick(object sender, MouseEventArgs e)
        {
            if(check_Sound == 0)
            {   
                check_Sound = 1;  
                button_music.BackgroundImage = Properties.Resources.volume; 
                player.Play();
            }   
            else
            {
                check_Sound = 0;
                button_music.BackgroundImage = Properties.Resources.mute;
                player.Stop();
            }
        }

        private void button_scoreboard_Click(object sender, EventArgs e)
        {
            panel_rank.Visible = true;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            //FormGame game = new FormGame();
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        private void button_exit_rank_Click(object sender, EventArgs e)
        {
            panel_rank.Visible = false; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Animals")
            {
                dataGridView.DataSource = game.dtAnimal;
                dataGridView.Sort(dataGridView.Columns[2], ListSortDirection.Descending);
                dataGridView.Visible = true;
            }

            if (comboBox1.Text == "Jobs")
            {
                dataGridView.DataSource = game.dtJobs;
                dataGridView.Sort(dataGridView.Columns[2], ListSortDirection.Descending);
                dataGridView.Visible = true;
            }

            if (comboBox1.Text == "Fruits")
            {
                dataGridView.DataSource = game.dtFruit;
                dataGridView.Sort(dataGridView.Columns[2], ListSortDirection.Descending);
                dataGridView.Visible = true;
            }
        }
    }
}