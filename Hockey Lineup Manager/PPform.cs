using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_Lineup_Manager
{
    public partial class PPform : Form
    {
        public PPform(string data)
        {
            InitializeComponent();
            TeamNamelbl.Text = data;
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------  Drag and Drop Functionallity  --------------------------------------------
        //
        //------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Make sure the data given is in the correct format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckDataFormat(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        //--------------------------------------------  1st Unit Powerplay  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit left wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPLW1tb.DoDragDrop(PPLW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLW1tb_DragDrop(object sender, DragEventArgs e)
        {
            PPLW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPC1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPC1tb.DoDragDrop(PPC1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPC1tb_DragDrop(object sender, DragEventArgs e)
        {
            PPC1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit right wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPRW1tb.DoDragDrop(PPRW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRW1tb_DragDrop(object sender, DragEventArgs e)
        {
            PPRW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit left defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPLD1tb.DoDragDrop(PPLD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLD1tb_DragDrop(object sender, DragEventArgs e)
        {
            PPLD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit right defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPRD1tb.DoDragDrop(PPRD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRD1tb_DragDrop(object sender, DragEventArgs e)
        {
            PPRD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  2nd Unit Powerplay  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit left wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPLW2tb.DoDragDrop(PPLW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLW2tb_DragDrop(object sender, DragEventArgs e)
        {
            PPLW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPC2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPC2tb.DoDragDrop(PPC2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPC2tb_DragDrop(object sender, DragEventArgs e)
        {
            PPC2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit right wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPRW2tb.DoDragDrop(PPRW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRW2tb_DragDrop(object sender, DragEventArgs e)
        {
            PPRW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit left defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPLD2tb.DoDragDrop(PPLD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLD2tb_DragDrop(object sender, DragEventArgs e)
        {
            PPLD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit right defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PPRD2tb.DoDragDrop(PPRD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPRD2tb_DragDrop(object sender, DragEventArgs e)
        {
            PPRD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        /// <summary>
        /// Load the lines from the JSON and place the players in their correct textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            string fileContent = File.ReadAllText(Path.Combine("..\\..\\Roster\\", (TeamNamelbl.Text + ".txt")));
            Team team = JsonConvert.DeserializeObject<Team>(fileContent);

            // Go through each player in the roster and place the players in the correct locations
            foreach (Player player in team.Roster)
            {
                // Figure out what line they're on, find the position
                int unit = player.PPL[0];
                int pos = player.PPL[1];
                switch (unit)       // Find the unit the player is on
                {
                    case 1:                     // First Unit
                        switch(pos)
                        {
                            case 1:             // Left Wing
                                PPLW1tb.Text = player.Name;
                                break;
                            case 2:             // Center
                                PPC1tb.Text = player.Name;
                                break;
                            case 3:             // Right Wing
                                PPRW1tb.Text = player.Name;
                                break;
                            case 4:             // Left Defence
                                PPLD1tb.Text = player.Name;
                                break;
                            case 5:             // Right Defence
                                PPRD1tb.Text = player.Name;
                                break;
                        }
                        break;
                    case 2:                     // Second Unit
                        switch(pos)
                        {
                            case 1:             // Left Wing
                                PPLW2tb.Text = player.Name;
                                break;
                            case 2:             // Center
                                PPC2tb.Text = player.Name;
                                break;
                            case 3:             // Right Wing
                                PPRW2tb.Text = player.Name;
                                break;
                            case 4:             // Left Defence
                                PPLD2tb.Text = player.Name;
                                break;
                            case 5:             // Right Defence
                                PPRD2tb.Text = player.Name;
                                break;
                        }
                        break;
                }    
            }
        }

        /// <summary>
        /// Save the lines to JSON file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLinesbtn_Click(object sender, EventArgs e)
        {
            List<Player> playerList = new List<Player>();           // Hold the list of players to save information
            Player player = new Player();                           // Create a player object

            //--------------------------------------------  1st Line / 1st Pairing  --------------------------------------------
            // Save 1st line left wing
            
        }
    }
}
