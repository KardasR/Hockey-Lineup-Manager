using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Hockey_Lineup_Manager
{
    public partial class ESform : Form
    {
        public ESform()
        {
            InitializeComponent();
        }

        //--------------------------------------------  1st Line  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st line left wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LW1tb.DoDragDrop(LW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Check the given data to make sure it's the correct format and has the copy effect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LW1tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st line left wing textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LW1tb_DragDrop(object sender, DragEventArgs e)
        {
            LW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st line center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C1TB_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                C1tb.DoDragDrop(C1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Check the given data to make sure it is a correct format and has the copy effect. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C1TB_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st line center textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C1TB_DragDrop(object sender, DragEventArgs e)
        {
            C1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st line right wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RW1tb.DoDragDrop(RW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Check  the given data to make sure it is a correct format and has the copy effect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW1tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st line right wing textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW1tb_DragDrop(object sender, DragEventArgs e)
        {
            RW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  2nd Line  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd line left wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LW2tb.DoDragDrop(LW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Check the given data to make sure it is a correct format and has the copy effect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LW2tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd line left wing textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LW2tb_DragDrop(object sender, DragEventArgs e)
        {
            LW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd line center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                C2tb.DoDragDrop(C2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Check the given data to make sure it is a correct format and has the copy effect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C2tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd line center textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C2tb_DragDrop(object sender, DragEventArgs e)
        {
            C2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd line right wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RW2tb.DoDragDrop(RW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Check the given data to make sure it is a acorrect format and has the copy effect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW2tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd line right wing textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW2tb_DragDrop(object sender, DragEventArgs e)
        {
            RW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Misc  --------------------------------------------

        /// <summary>
        /// Show user powerplay lineup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PPform pp = new PPform();
            pp.Show();
        }

        private void SLbtn_Click(object sender, EventArgs e)
        {
            // TODO: SAVE LINES THROUGH JSON SERIALIZATION
            List<Player> playerList = new List<Player>();       // Hold the list of players to save information
            Player player = new Player();                       // Create a player object

            // Save 1st line left wing
            player.Name = LW1tb.Text;
            player.ESL = new int[] { 1, 1 };    // First line, left wing

            playerList.Add(player);

            // Save 1st line center
            player = new Player();
            player.Name = C1tb.Text;
            player.ESL = new int[] { 1, 2 };    // First line, center

            playerList.Add(player);

            string output = JsonConvert.SerializeObject(playerList);

            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hockey League Manager\\Rosters\\";
            // E:\Programming\C#\Hockey Lineup Manager\Hockey Lineup Manager\Rosters\

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(Path.Combine("..\\..\\Rosters\\", "Test Team 1.txt")))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, playerList);
            }
        }
    }
    public class Player
    {
        public string   Name;                   // Name of player
        public int      Overall;                // Overall of player
        public string   Potential;              // Potential of player
        public int[]    ESL = new int[2];       // Even Strength line player is on and their position (1 = Left Wing or Starter, 2 = Center or Backup, 3 = Right Wing or 3rd String, 4 = Left Defence, 5 = Right Defence)
        public int[]    PPL = new int[2];       // Powerplay unit player is on and their position
    }
}
