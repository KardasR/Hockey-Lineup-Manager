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
    public partial class FFform : Form
    {
        public FFform()
        {
            InitializeComponent();
        }

        private void FFform_Load(object sender, EventArgs e)
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
            if(nhlteam.FFL[0] != null)
            {
                // Go through each four on four unit
                foreach (FourOnFourLines unit in nhlteam.FFL)
                {
                    int line = unit.Unit;
                    switch (line)
                    {
                        case 1:
                            FourLW1tb.Text = unit.Wing;
                            FourC1tb.Text = unit.Center;
                            FourLD1tb.Text = unit.LeftDefence;
                            FourRD1tb.Text = unit.RightDefence;
                            break;
                        case 2:
                            FourLW2tb.Text = unit.Wing;
                            FourC2tb.Text = unit.Center;
                            FourLD2tb.Text = unit.LeftDefence;
                            FourRD2tb.Text = unit.RightDefence;
                            break;
                        case 3:
                            FourLW3tb.Text = unit.Wing;
                            FourC3tb.Text = unit.Center;
                            FourLD3tb.Text = unit.LeftDefence;
                            FourRD3tb.Text = unit.RightDefence;
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
        /// Load the four on four from the currently selected team.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent());        // Copy the currently selected team to gain access to the four on four
            
            // Go through each four on four unit
            foreach (FourOnFourLines unit in team.FFL)
            {
                int line = unit.Unit;
                switch (line)
                {
                    case 1:
                        FourLW1tb.Text = unit.Wing;
                        FourC1tb.Text = unit.Center;
                        FourLD1tb.Text = unit.LeftDefence;
                        FourRD1tb.Text = unit.RightDefence;
                        break;
                    case 2:
                        FourLW2tb.Text = unit.Wing;
                        FourC2tb.Text = unit.Center;
                        FourLD2tb.Text = unit.LeftDefence;
                        FourRD2tb.Text = unit.RightDefence;
                        break;
                    case 3:
                        FourLW3tb.Text = unit.Wing;
                        FourC3tb.Text = unit.Center;
                        FourLD3tb.Text = unit.LeftDefence;
                        FourRD3tb.Text = unit.RightDefence;
                        break;
                }
            }
        }

        /// <summary>
        /// Overwrite the currently selected team's penalty kill with the current penalty kill.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent());        // Copy the currently selected team to gain access to the four on four

            //--------------------------------------------  1st Unit  --------------------------------------------
            FourOnFourLines ff1 = new FourOnFourLines();
            ff1.Unit = 1;
            ff1.Wing = FourLW1tb.Text;
            ff1.Center = FourC1tb.Text;
            ff1.LeftDefence = FourLD1tb.Text;
            ff1.RightDefence = FourRD1tb.Text;

            //--------------------------------------------  2nd Unit  --------------------------------------------
            FourOnFourLines ff2 = new FourOnFourLines();
            ff2.Unit = 2;
            ff2.Wing = FourLW2tb.Text;
            ff2.Center = FourC2tb.Text;
            ff2.LeftDefence = FourLD2tb.Text;
            ff2.RightDefence = FourRD2tb.Text;

            //--------------------------------------------  3rd Unit  --------------------------------------------
            FourOnFourLines ff3 = new FourOnFourLines();
            ff3.Unit = 3;
            ff3.Wing = FourLW3tb.Text;
            ff3.Center = FourC3tb.Text;
            ff3.LeftDefence = FourLD3tb.Text;
            ff3.RightDefence = FourRD3tb.Text;

            team.FFL[0] = ff1;
            team.FFL[1] = ff2;
            team.FFL[2] = ff3;

            Methods.Add(Methods.GetCurrentYear(), JsonConvert.SerializeObject(team));
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------  Drag and Drop Functionallity  --------------------------------------------
        //
        //------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Make sure the data is in the correct format before sending to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckDataFormat(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit left wing 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourLW1tb.DoDragDrop(FourLW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLW1tb_DragDrop(object sender, DragEventArgs e)
        {
            FourLW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit center 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourC1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourC1tb.DoDragDrop(FourC1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourC1tb_DragDrop(object sender, DragEventArgs e)
        {
            FourC1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Left Defence  --------------------------------------------
        
        /// <summary>
        /// Initiate the drag drop for the 1st unit left defence 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourLD1tb.DoDragDrop(FourLD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLD1tb_DragDrop(object sender, DragEventArgs e)
        {
            FourLD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit right defence 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourRD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourRD1tb.DoDragDrop(FourRD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourRD1tb_DragDrop(object sender, DragEventArgs e)
        {
            FourRD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  2nd Unit  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit left wing 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourLW2tb.DoDragDrop(FourLW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLW2tb_DragDrop(object sender, DragEventArgs e)
        {
            FourLW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit center 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourC2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourC2tb.DoDragDrop(FourC2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourC2tb_DragDrop(object sender, DragEventArgs e)
        {
            FourC2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit left defence 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourLD2tb.DoDragDrop(FourLD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the date from the drag drop and paste it into the 2nd unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLD2tb_DragDrop(object sender, DragEventArgs e)
        {
            FourLD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit right defence 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourRD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourRD2tb.DoDragDrop(FourRD2tb.Text, DragDropEffects.Copy);
        }
        
        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourRD2tb_DragDrop(object sender, DragEventArgs e)
        {
            FourRD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  3rd Unit  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 3rd unit left wing 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLW3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourLW3tb.DoDragDrop(FourLW3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 3rd unit left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLW3tb_DragDrop(object sender, DragEventArgs e)
        {
            FourLW3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 3rd unit center 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourC3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourC3tb.DoDragDrop(FourC3tb.Text, DragDropEffects.Copy);
        }
        
        /// <summary>
        /// Get the data from the drag drop and paste it into the 3rd unit center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourC3tb_DragDrop(object sender, DragEventArgs e)
        {
            FourC3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 3rd unit left defence 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLD3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourLD3tb.DoDragDrop(FourLD3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 3rd unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourLD3tb_DragDrop(object sender, DragEventArgs e)
        {
            FourLD3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 3rd unit right defence 4 on 4 when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourRD3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FourRD3tb.DoDragDrop(FourRD3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 3rd unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourRD3tb_DragDrop(object sender, DragEventArgs e)
        {
            FourRD3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void ClearLinesbtn_Click(object sender, EventArgs e)
        {
            // Clear Centers
            FourC1tb.Text = "";
            FourC2tb.Text = "";
            FourC3tb.Text = "";

            // Clear Wingers
            FourLW1tb.Text = "";
            FourLW2tb.Text = "";
            FourLW3tb.Text = "";

            // Clear Defence
            FourLD1tb.Text = "";
            FourLD2tb.Text = "";
            FourLD3tb.Text = "";

            FourRD1tb.Text = "";
            FourRD2tb.Text = "";
            FourRD3tb.Text = "";
        }
    }
}
