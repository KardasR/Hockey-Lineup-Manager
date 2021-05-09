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
                        TTLD1tb.Text = unit.Wing;
                        TTRD1tb.Text = unit.Defence;
                        break;
                    case 2:
                        TTC2tb.Text = unit.Center;
                        TTLD2tb.Text = unit.Wing;
                        TTRD2tb.Text = unit.Defence;
                        break;
                    case 3:
                        TTC3tb.Text = unit.Center;
                        TTLD3tb.Text = unit.Wing;
                        TTRD3tb.Text = unit.Defence;
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
            ttl1.Wing = TTLD1tb.Text;
            ttl1.Center = TTC1tb.Text;
            ttl1.Defence = TTRD1tb.Text;

            //--------------------------------------------  2nd Unit  --------------------------------------------
            ThreeOnThreeLines ttl2 = new ThreeOnThreeLines();
            ttl2.Unit = 2;
            ttl2.Wing = TTLD2tb.Text;
            ttl2.Center = TTC2tb.Text;
            ttl2.Defence = TTRD2tb.Text;

            //--------------------------------------------  3rd Unit  --------------------------------------------
            ThreeOnThreeLines ttl3 = new ThreeOnThreeLines();
            ttl3.Unit = 3;
            ttl3.Wing = TTLD3tb.Text;
            ttl3.Center = TTC3tb.Text;
            ttl3.Defence = TTRD3tb.Text;

            team.TTL[0] = ttl1;
            team.TTL[1] = ttl2;
            team.TTL[2] = ttl3;

            Methods.Add(Methods.GetCurrentYear(), JsonConvert.SerializeObject(team));              // Overwrite the currently selected team (only changing the three on three)
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
                TTLD1tb.DoDragDrop(TTLD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD1tb_DragDrop(object sender, DragEventArgs e)
        {
            TTLD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
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
                TTRD1tb.DoDragDrop(TTRD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD1tb_DragDrop(object sender, DragEventArgs e)
        {
            TTRD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
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
                TTLD2tb.DoDragDrop(TTLD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD2tb_DragDrop(object sender, DragEventArgs e)
        {
            TTLD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
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
                TTRD2tb.DoDragDrop(TTRD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD2tb_DragDrop(object sender, DragEventArgs e)
        {
            TTRD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
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
                TTLD3tb.DoDragDrop(TTLD3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it int the 3rd unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTLD3tb_DragDrop(object sender, DragEventArgs e)
        {
            TTLD3tb.Text = (string)e.Data.GetData(DataFormats.Text);
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
                TTLD3tb.DoDragDrop(TTLD3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 3rd unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTRD3tb_DragDrop(object sender, DragEventArgs e)
        {
            TTRD3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void TTform_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length >= 1)
            {
                // Get the data of the second monitor
                var monitor = Screen.AllScreens[2].WorkingArea;
                // Change the wingow to the second monitor
                Location = monitor.Location;
            }
        }
    }
}
