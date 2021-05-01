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
    public partial class PKform : Form
    {
        public PKform()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------  Buttons  --------------------------------------------
        //
        //------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Load the penalty kill from the currently selected team.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            Team team = Methods.SelectCurrent();        // Copy the currently selected team to gain access to the penalty kill

            // Go through each penalty killing unit
            foreach (PenaltyKillLines unit in team.PKL)
            {
                int line = unit.Unit;
                switch(line)
                {
                    case 1:
                        PKLW1tb.Text = unit.Wing;
                        PKC1tb.Text = unit.Center;
                        PKLD1tb.Text = unit.LeftDefence;
                        PKRD1tb.Text = unit.RightDefence;
                        break;
                    case 2:
                        PKLW2tb.Text = unit.Wing;
                        PKC2tb.Text = unit.Center;
                        PKLD2tb.Text = unit.LeftDefence;
                        PKRD2tb.Text = unit.RightDefence;
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
            Team team = Methods.SelectCurrent();        // Copy the currently selected team

            //--------------------------------------------  1st Unit  --------------------------------------------
            PenaltyKillLines pkl1 = new PenaltyKillLines();
            pkl1.Unit = 1;
            pkl1.Wing = PKLW1tb.Text;
            pkl1.Center = PKC1tb.Text;
            pkl1.LeftDefence = PKLD1tb.Text;
            pkl1.RightDefence = PKRD1tb.Text;

            //--------------------------------------------  1st Line / 1st Pairing  --------------------------------------------
            PenaltyKillLines pkl2 = new PenaltyKillLines();
            pkl2.Unit = 2;
            pkl2.Wing = PKLW2tb.Text;
            pkl2.Center = PKC1tb.Text;
            pkl2.LeftDefence = PKLD1tb.Text;
            pkl2.RightDefence = PKRD1tb.Text;

            team.PKL[0] = pkl1;
            team.PKL[1] = pkl2;

            Methods.Add(team);          // Overwrite the currently selected team (only changing the penalty kill)
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
        /// Initiate the drag drop for the 1st unit wing penalty kill when the user right clicks the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKLW1tb.DoDragDrop(PKLW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLW1tb_DragDrop(object sender, DragEventArgs e)
        {
            PKLW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKC1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKC1tb.DoDragDrop(PKC1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit center textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKC1tb_DragDrop(object sender, DragEventArgs e)
        {
            PKC1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit left defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKLD1tb.DoDragDrop(PKLD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLD1tb_DragDrop(object sender, DragEventArgs e)
        {
            PKLD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit right defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKRD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKRD1tb.DoDragDrop(PKRD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKRD1tb_DragDrop(object sender, DragEventArgs e)
        {
            PKRD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  2nd Unit Penalty Kill  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit left wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKLW2tb.DoDragDrop(PKLW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLW2tb_DragDrop(object sender, DragEventArgs e)
        {
            PKLW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKC2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKC2tb.DoDragDrop(PKC2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit center textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKC2tb_DragDrop(object sender, DragEventArgs e)
        {
            PKC2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit left defence when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKLD2tb.DoDragDrop(PKLD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit left defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKLD2tb_DragDrop(object sender, DragEventArgs e)
        {
            PKLD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit right defence when the user right clicks on the texbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKRD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                PKRD2tb.DoDragDrop(PKRD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit right defence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PKRD2tb_DragDrop(object sender, DragEventArgs e)
        {
            PKRD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        
    }
}
