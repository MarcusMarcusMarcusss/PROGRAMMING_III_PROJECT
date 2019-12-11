using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace MusicPlayer_Project
{    /*
     * Name:Mark Xie
     * Student Id:p447119
     * Date:11/11/2019
     * Programming III
     */
    public partial class MoeMusicPlayer : Form
    {
        //set mysql database to global
        private string connectionString = "server=127.0.0.1;uid=root;pwd=;database=musicplayer;charset=utf8;";
        private MySqlConnection connection = new MySqlConnection();
        //storage songs full path
        List<string> musicCollection = new List<string>();
        //PanelPlaylist Hide
        int panelwidth;
        bool Hidden;
        //Moveable Screen
        Point startPoint = new Point(0, 0);
        bool drag = false;
        //startbutton image change
        private Image start;
        private Image pause;

        public MoeMusicPlayer()
        {
            InitializeComponent();
            //read data from database
            DisplayMusicPath();
            //setplaylist to hide and boolean statement to make it appear/show
            panelwidth = panelPlayList.Width;
            Hidden = false;
            LbUserName.Text = LoginInfo.UserName;
            //Using the MusicPlayer_Project.Properties.Resources.xxxx property 
            //creates a new image object, it will never match any other image 
            //So i can now compare them which allows me to show different image when it is clicked
            start = MusicPlayer_Project.Properties.Resources.start_40px;
            pause = MusicPlayer_Project.Properties.Resources.pause_25px;
            btnStart.Image = start;
        }

        //creating a display method to show songs in the listbox from LinkedList
        private void showList()
        {
            LBOutput.Items.Clear();//clear listbox

            foreach (string song in musicCollection)
            {
                //using Path.getfilename only display filename.
                LBOutput.Items.Add(System.IO.Path.GetFileName(song).ToString());

            }
        }
        //button method to extends mediaplayer and hide playlist
        private void BtnMax_Click(object sender, EventArgs e)
        {
            timerTick.Start();
        }
        //button method to minimise surrent application
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //button method to exit application
        private void Btnclose_Click(object sender, EventArgs e)
        {
            //Movie.ActiveForm.Close();
            Application.Exit();
        }

        //Able to drag and drop application to anywhere on the screen.   / Form Move freely
        private void PanelHead_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void PanelHead_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (drag)
            {   //Set Form 
                Point p = PointToScreen(e.Location);//set to mouse position
                this.Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);//set new form position
            }
        }

        private void PanelHead_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }
        //remove display message when user clicks the textbox
        private void TbSearchStore_Click(object sender, EventArgs e)
        {   //bool statement
            /*if (firstTimeClickSearch)
                {
                    firstTimeClickSearch = false;
                    TbSearchPlaylist.Clear();
                }
            */
            if (TbSearcPlayList.Text == "Search Playlist")
            {
                TbSearcPlayList.Clear();
            }
        }
        //Timer method to hide and display playlist panel
        private void TimerTick_Tick_1(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelPlayList.Width = panelPlayList.Width + 10;
                axWindowsMediaPlayer1.Width = axWindowsMediaPlayer1.Width - 10;
                if (panelPlayList.Width >= panelwidth)
                {
                    timerTick.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelPlayList.Width = panelPlayList.Width - 10;
                axWindowsMediaPlayer1.Width = axWindowsMediaPlayer1.Width + 10;
                if (panelPlayList.Width <= 0)
                {
                    timerTick.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }


        }
        //button function to stop media playing
        private void BtnStop_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.stop();
            //set start Button from pause Image to start image
            btnStart.Image = start;
        }
        /*
         * boolean statement to change button image
         * bool firstClick = true;
         * find a easy method to change start button start image and pause image
        */
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //if check if the list is filled with data
            if (musicCollection.Count > 0)
            {

                //if start button image is "Start"
                if (this.btnStart.Image == start)
                {
                    //method to check if mediaplayer is playing
                    if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        btnStart.Image = pause;

                    }
                    else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        btnStart.Image = pause;
                    }

                    //method to check if listbox item is selected
                    //if no item been selected then select first item in list and play

                    if (LBOutput.SelectedIndex < 0)
                    {
                        //play fist index in list and highlights current song in listbox
                        axWindowsMediaPlayer1.URL = musicCollection[0];
                        LBOutput.SelectedIndex = 0;
                        axWindowsMediaPlayer1.URL = musicCollection[LBOutput.SelectedIndex];
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        btnStart.Image = pause;
                    }
                    if (musicCollection[LBOutput.SelectedIndex] != axWindowsMediaPlayer1.URL)
                    {
                        axWindowsMediaPlayer1.URL = musicCollection[LBOutput.SelectedIndex];
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        btnStart.Image = pause;
                    }

                }
                //if start Image is "Pause"
                else if (this.btnStart.Image == pause)
                {
                    //method to change song when user picked another song and current playing song is not equal to the song that is been selected
                    if (musicCollection[LBOutput.SelectedIndex] != axWindowsMediaPlayer1.URL)
                    {
                        axWindowsMediaPlayer1.URL = musicCollection[LBOutput.SelectedIndex];
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        btnStart.Image = pause;
                    }
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    btnStart.Image = start;
                    //firstClick = false;
                }

            }
            //if listbox is empty
            else
            {
                //MessageBox.Show("Add file first");
            }

        }
        //function to add file to the playlist
        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();//open file 
            open.InitialDirectory = @"F:\Dance\Music";
            open.Filter = "mp4 files|*.mp4|mp3 files|*.mp3|avi files|*.avi|ALL files|*.*";//Support various audio and video formats
            open.Multiselect = true;//select multiple song at once
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)//check if the dialog is open if it is not open a message will show.
            {
                foreach (string file in open.FileNames)//loop that reads all the songs one by one 
                {
                    string newsong = file.ToString();//filepath to string,,,not important 
                    musicCollection.Add(newsong);//add song path to the list
                    showList();//display to the listbox
                }
            }
        }
        //double click function to play the song from listbox
        private void LBOutput_DoubleClick(object sender, EventArgs e)
        {//do a if statement if the element is empty to prevent 'index out range' crash
            if (LBOutput.Items.Count == 0)
            {
                MessageBox.Show("Add file to the Playlist");
                OpenFileDialog open = new OpenFileDialog();//open file
                open.InitialDirectory = @"F:\Dance\Music";
                open.Filter = "mp4 files|*.mp4|mp3 files|*.mp3|avi files|*.avi|ALL files|*.*";//Support various audio and video formats
                open.Multiselect = true;//select multiple song at once
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)//check if the dialog is open if it is not open a message will show.
                {
                    foreach (string file in open.FileNames)//loop that reads all the songs one by one 
                    {
                        string newsong = file.ToString();//filepath to string,,,not important 
                        musicCollection.Add(newsong);//add song path to the list
                        showList();//display to the listbox
                    }
                }
            }
            else
            {//do a if statement if the selected element is empty to prevent 'index out range' crash
                if (LBOutput.SelectedIndex >= 0)
                {
                    axWindowsMediaPlayer1.URL = musicCollection[LBOutput.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    //change startbutton image
                    btnStart.Image = pause;
                    //Label get media file name and Time
                    //LBLMediaName.Text = LBOutput.SelectedItem.ToString();
                    //create a timer to track time for media file
                    //LBLMediaTime.Text = axWindowsMediaPlayer1.currentMedia.durationString+"\r\n"+axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
                }
                else
                {
                    MessageBox.Show("Add file to the Playlist");
                }


            }
        }
        //delete function using context menu
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicCollection.RemoveAt(LBOutput.SelectedIndex);
            showList();
        }
        //function to play next song and when song reaches the end of the array set to start index.
        private void BtnNextSong_Click(object sender, EventArgs e)
        {

            //select index at corrent position
            int index = LBOutput.SelectedIndex;
            //clear selected indeices
            LBOutput.SelectedIndices.Clear();
            index++;
            if (index == LBOutput.Items.Count)
            {
                index = 0;
            }
            //another if statement if lboutput is empty
            if (LBOutput.Items.Count > 0)
            {
                //set index to new position
                LBOutput.SelectedIndex = index;
                axWindowsMediaPlayer1.URL = musicCollection[index];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Add File First");
            }


        }
        //bTn fuinction play previousSong
        private void BtnPreviousSong_Click(object sender, EventArgs e)
        {
            //select index at corrent position
            int index = LBOutput.SelectedIndex;
            //clear selected indeices
            LBOutput.SelectedIndices.Clear();
            index--;
            if (index < 0)
            {
                index = LBOutput.Items.Count - 1;
            }
            if (LBOutput.Items.Count > 0)
            {
                //set index to new position
                LBOutput.SelectedIndex = index;
                axWindowsMediaPlayer1.URL = musicCollection[index];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Add File First");
            }

        }
        /*
        //button function to play media forwards with Fastspeed
        private void BtnFast_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }
        //button function to play media backwards with Fastspeed
        private void BtnRewind_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }
        */
        //list<T>
        //Sorting algorithms :bubble Sort
        private void BtnSearchList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbSearcPlayList.Text) || TbSearcPlayList.Text == "Search Playlist")
            {
                MessageBox.Show("Invalid input!");
            }
            else
            {

                /* this method is basicly same as findindex method that i used below
               int index;
               for (int i = 0; i < musicCollection.Count; i++)
               {
               //linked list<String>
               //musicCollection.elementat(i) == target
                   if (musicCollection[i].Contains(TbSearcPlayList.Text))
                   {
                       index = i;
                       MessageBox.Show("searched item is find at index" + index);//index starts at 0
                       LBOutput.SetSelected(index, true);
                       break;
                   }

               }
               */

                int target = musicCollection.FindIndex(a => a.Contains(TbSearcPlayList.Text));
                
                if (target >= 0)
                {
                    MessageBox.Show(TbSearcPlayList.Text+" is find");
                    //we highlight listbox when the item is found but we need to 
                    //decrease 1 becuase system reads from 0 
                    LBOutput.SetSelected(target, true);
                }
                else
                {
                    MessageBox.Show(TbSearcPlayList.Text + " Could Not Be Find");
                }
            }
        }
        //button method to search current from the listbox and 
        //highlights searched items if it is inside listbox 
        private void TbSearcPlayList_TextChanged(object sender, EventArgs e)
        {

            //Clear selected item from other activites
            LBOutput.SelectedItems.Clear();
            for (int i = LBOutput.Items.Count - 1; i >= 0; i--)
            {
                if (LBOutput.Items[i].ToString().ToLower().Contains(TbSearcPlayList.Text.ToLower()))
                {
                    LBOutput.SetSelected(i, true);
                }
            }
        }
        //button method to sort list<string> and display all 
        //the data using methods that i have create earlier. 
        private void BtnSort_Click(object sender, EventArgs e)
        {
            bubbleSort(musicCollection, musicCollection.Count);
            //method to remove duplicates 
            removeDups(musicCollection, musicCollection.Count - 1);
            showList();
        }
        //method to sort the list<string> using bubble sort
        //The bubble is one of the simplest sorting algorithms
        //to understand and implement.it is O(n2) complexity  
        //means that its efficiency decreases dramatically on a 
        //lists of more than  a small number of elements.
        private static void bubbleSort(List<string> mylist, int max)
        {
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < (max - 1); j++)
                {
                    if (mylist.ElementAt(j).CompareTo(mylist.ElementAt(j + 1)) > 0)
                    {
                        //perform swap
                        string current = mylist[j];
                        mylist[j] = mylist[j + 1];
                        mylist[j + 1] = current;
                    }
                }
            }
        }
        //method to remove duplicate item from list<string>
        private static void removeDups(List<string> list, int index)
        {
            //if index bigger than 0
            while (0 < index)
            {
                if (list[index] == list[index - 1])
                {
                    if (index < list.Count - 1)
                        (list[index], list[list.Count - 1]) = (list[list.Count - 1], list[index]);
                    list.RemoveAt(list.Count - 1);
                    index--;
                }
                else
                    index--;
            }
        }
        //Method for user database storage
        public void StorageDatabase()
        {
            try
            {

                //convert your string array to single array
                var Datastore = String.Join("|", musicCollection);
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = "UPDATE users SET UserStorage =@Userstorage WHERE username=@username";
                MySqlCommand statement = new MySqlCommand(query, connection);
                statement.Parameters.AddWithValue("@Userstorage", Datastore);
                statement.Parameters.AddWithValue("@username", LoginInfo.UserName);
                statement.ExecuteReader();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //Form Closing function+
        private void MoeMusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            StorageDatabase();
            //to avoid the memory bloat
            start.Dispose();
            pause.Dispose();
        }

        public void DisplayMusicPath()
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = "SELECT `username`, UserStorage FROM `users` WHERE `username`= @username";
                MySqlCommand statement = new MySqlCommand(query, connection);
                statement.Parameters.AddWithValue("@username", LoginInfo.UserName);
                MySqlDataReader Check = statement.ExecuteReader();
                if (Check.Read())
                {
                    //read last stored file path
                    string getFilePath = Check.GetString("UserStorage");
                    if (getFilePath == "")
                    {
                        //if file path  is empty,do not add empty file path to the list
                    }
                    else
                    {
                        musicCollection = getFilePath.Split('|').ToList();
                        showList();
                    }

                }
                else//no result
                {

                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TimerMediaDuration_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                LBLMediaName.Text = axWindowsMediaPlayer1.currentMedia.name;
                LBLMediaTime.Text = axWindowsMediaPlayer1.currentMedia.durationString + "\r\n " + axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                
            }
        }

        private void BtnfullSize_Click(object sender, EventArgs e)
        {

            // If the player is playing, switch to full screen. 
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }

        }

        //button uP and down click to play media with hold and Fastforward and rewind
        private void BtnFast_MouseDown(object sender, MouseEventArgs e)
        {
            // If the player is playing 
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.fastForward();
            }
        }

        private void BtnFast_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //function to rewind current playing media
        private void BtnRewind_MouseDown(object sender, MouseEventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //this windowsmediaplayer fastreverse does not work which i have to set it manually
                //axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5;
            }
          
          
        }

        private void BtnRewind_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //End of button uP and down click to play media with hold and Fastforward and rewind

        //Button methods to add file to the playlist
        private void PicBoxMusicfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();//open file 
            open.InitialDirectory = @"F:\Dance\Music";
            open.Filter = "mp3 files|*.mp3|ALL files|*.*";//only accept Mp3  and file access
            open.Multiselect = true;//select multiple song at once
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)//check if the dialog is open if it is not open a message will show.
            {
                foreach (string file in open.FileNames)//loop that reads all the songs one by one 
                {
                    string newsong = file.ToString();//filepath to string,,,not important 
                    musicCollection.Add(newsong);//add song path to the list
                    showList();//display to the listbox
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            musicCollection.Clear();
            showList();
        }
    }
}
