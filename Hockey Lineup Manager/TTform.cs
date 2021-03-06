using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_Lineup_Manager
{
    public partial class TTform : Form
    {
        public TTform()
        {
            InitializeComponent();
        }

        private void TTform_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length >= 1)
            {
                // Get the data of the second monitor
                var monitor = Screen.AllScreens[2].WorkingArea;
                // Change the window to the second monitor and lower the form so it doesn't start ontop of the even strength one
                Location = new Point(monitor.Location.X, monitor.Location.Y + 785);       // Lower the position of the form by the max Y of an even strength form.
            }

            // Check to make sure the team is not empty before setting textbox's
            NHLTeam nhlteam = (Methods.SelectCurrent() != null) ? JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent()) : new NHLTeam();
            if (nhlteam.TTL[0] != null)
            {
                // Go through each powerplay unit
                foreach (ThreeOnThreeLines unit in nhlteam.TTL)
                {
                    int line = unit.Unit;
                    switch (line)
                    {
                        case 1:
                            TTC1tb.Text = unit.Center;
                            TTW1tb.Text = unit.Wing;
                            TTD1tb.Text = unit.Defence;
                            break;
                        case 2:
                            TTC2tb.Text = unit.Center;
                            TTW2tb.Text = unit.Wing;
                            TTD2tb.Text = unit.Defence;
                            break;
                        case 3:
                            TTC3tb.Text = unit.Center;
                            TTW3tb.Text = unit.Wing;
                            TTD3tb.Text = unit.Defence;
                            break;
                    }
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------  Buttons  --------------------------------------------
        //
        //------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Load the three on three from the currently selected team.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent());        // Copy the currently selected team

            // Go through each powerplay unit
            foreach (ThreeOnThreeLines unit in team.TTL)
            {
                int line = unit.Unit;
                switch (line)
                {
                    case 1:
                        TTC1tb.Text = unit.Center;
                        TTW1tb.Text = unit.Wing;
                        TTD1tb.Text = unit.Defence;
                        break;
                    case 2:
                        TTC2tb.Text = unit.Center;
                        TTW2tb.Text = unit.Wing;
                        TTD2tb.Text = unit.Defence;
                        break;
                    case 3:
                        TTC3tb.Text = unit.Center;
                        TTW3tb.Text = unit.Wing;
                        TTD3tb.Text = unit.Defence;
                        break;
                }
            }
        }

        /// <summary>
        /// Overwrite the currently selected team's three on three with the current three on three.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent());            // Copy the currently selected team

            //--------------------------------------------  1st Unit  --------------------------------------------
            ThreeOnThreeLines ttl1 = new ThreeOnThreeLines();
            ttl1.Unit = 1;
            ttl1.Wing = TTW1tb.Text;
            ttl1.Center = TTC1tb.Text;
            ttl1.Defence = TTD1tb.Text;

            //--------------------------------------------  2nd Unit  --------------------------------------------
            ThreeOnThreeLines ttl2 = new ThreeOnThreeLines();
            ttl2.Unit = 2;
            ttl2.Wing = TTW2tb.Text;
            ttl2.Center = TTC2tb.Text;
            ttl2.Defence = TTD2tb.Text;

            //--------------------------------------------  3rd Unit  --------------------------------------------
            ThreeOnThreeLines ttl3 = new ThreeOnThreeLines();
            ttl3.Unit = 3;
            ttl3.Wing = TTW3tb.Text;
            ttl3.Center = TTC3tb.Text;
            ttl3.Defence = TTD3tb.Text;

            team.TTL[0] = ttl1;
            team.TTL[1] = ttl2;
            team.TTL[2] = ttl3;

            Methods.Add(Methods.GetCurrentYear(), JsonConvert.SerializeObject(team));              // Overwrite the currently selected team (only changing the three on three)
        }

        private void ClearLinesbtn_Click(object sender, EventArgs e)
        {
            // Clear Centers
            TTC1tb.Text = "";
            TTC2tb.Text = "";
            TTC3tb.Text = "";

            // Clear Wingers
            TTW1tb.Text = "";
            TTW2tb.Text = "";
            TTW3tb.Text = "";

            // Clear Defence
            TTD1tb.Text = "";
            TTD2tb.Text = "";
            TTD3tb.Text = "";
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

        //--------------------------------------------  1st Unit 3 on 3  --------------------------------------------

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTC1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTC1tb.DoDragDrop(TTC1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTC1tb_DragDrop(object sender, DragEventArgs e)
        {
            TTC1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit left defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTW1tb.DoDragDrop(TTW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD1tb_DragDrop(object sender, DragEventArgs e)
        {
            TTW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit right defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTD1tb.DoDragDrop(TTD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD1tb_DragDrop(object sender, DragEventArgs e)
        {
            TTD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  2nd Unit 3 on 3  --------------------------------------------

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTC2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTC2tb.DoDragDrop(TTC2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTC2tb_DragDrop(object sender, DragEventArgs e)
        {
            TTC2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit left defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTW2tb.DoDragDrop(TTW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD2tb_DragDrop(object sender, DragEventArgs e)
        {
            TTW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit right defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTD2tb.DoDragDrop(TTD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD2tb_DragDrop(object sender, DragEventArgs e)
        {
            TTD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  3rd Unit 3 on 3  --------------------------------------------

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 3rd unit center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTC3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTC3tb.DoDragDrop(TTC3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 3rd unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTC3tb_DragDrop(object sender, DragEventArgs e)
        {
            TTC3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 3rd unit left defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTW3tb.DoDragDrop(TTW3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it int the 3rd unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD3tb_DragDrop(object sender, DragEventArgs e)
        {
            TTW3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------
        
        /// <summary>
        /// Initiate the drag drop for the 3rd unit right defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                TTW3tb.DoDragDrop(TTW3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 3rd unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD3tb_DragDrop(object sender, DragEventArgs e)
        {
            TTD3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }    }
}
