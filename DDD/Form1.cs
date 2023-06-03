using System.Windows.Forms;
using System.IO;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Drawing.Imaging;


namespace DDD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFile();

        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFile();

        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void OpenFile()
        {
            openFileDialog3.InitialDirectory = "";
            openFileDialog3.FileName = "";

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {

                //try-catch loop to create a variable holding the file and
                //using a streamwriter to open said file in notepad
                try
                {
                    string filePath = openFileDialog3.FileName;
                    using Stream str = openFileDialog3.OpenFile();
                    Process.Start("notepad.exe", filePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error! Can't open this file" + e);
                }
            }

        }
        private void SaveFile()
        {
            //saving diary entry name with date and time
            saveFileDialog1.InitialDirectory = @"C:\Users\lexim\VS Projects\DDD\Diary Entries";
            saveFileDialog1.Filter = "Text |*.txt";
            saveFileDialog1.FileName = "Diary entry_" + DateTime.Now;
            saveFileDialog1.ShowDialog();

            //saves text from textbox into file
            File.WriteAllText(saveFileDialog1.FileName, diaryEntry.Text);

            //saves picturess from picturebox into a jpeg file
            saveFileDialog1.InitialDirectory = @"C:\Users\lexim\VS Projects\DDD\Mood Pics";
            saveFileDialog1.FileName = "Entry Mood: " + DateTime.Now;
            saveFileDialog1.Filter = "JPEG |*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string savePath = saveFileDialog1.FileName;

                Bitmap bmp = new(pictureBox1.Image);

                bmp.Save(savePath, ImageFormat.Jpeg);

                MessageBox.Show("Image Saved!");
            }
        }
        private void NewFile()
        {
            diaryEntry.Text = null;
            pictureBox1 = null;

        }
        private void addPict_MouseHover(object sender, EventArgs e)
        {
            addPict.BackColor = Color.MistyRose;
        }

        private void addPict_Click(object sender, EventArgs e)
        {
            addPict.BackColor = Color.MistyRose;
            openFileDialog1.FileName = "Choose a picture: ";
            openFileDialog1.InitialDirectory = @"C:\Users\lexim\OneDrive\Pictures";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image.Save(openFileDialog1.FileName);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
            else if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Are you sure you don't want to add a picture?", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFile();

        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            createButton.BackColor = Color.MistyRose;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this diary entry?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result =
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) { this.Close(); }
            if (result == DialogResult.No)
            {
                //do nothing
            }

        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.MistyRose;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                memOrMeh.SizeMode = PictureBoxSizeMode.StretchImage;
                memOrMeh.Image = Properties.Resources.happy;
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                memOrMeh.SizeMode = PictureBoxSizeMode.StretchImage;
                memOrMeh.Image = Properties.Resources.sadGhost;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}