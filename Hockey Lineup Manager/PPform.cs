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

        public PPform()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------  Buttons  --------------------------------------------
        //
        //------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Load the powerplay from the currently selected team.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            Team team = Methods.SelectCurrent();                    // Copy the currently selected team

            // Go through each powerplay unit
            foreach (PowerPlayLines unit in team.PPL)
            {
                int line = unit.Unit;
                switch (line)
                {
                    case 1:                                                 // First Unit
                        PPLW1tb.Text = unit.LeftWing;
                        PPC1tb.Text = unit.Center;
                        PPRW1tb.Text = unit.RightWing;
                        PPLD1tb.Text = unit.LeftDefence;
                        PPRD1tb.Text = unit.RightDefence;
                        break;
                    case 2:                                                 // Second Unit
                        PPLW2tb.Text = unit.LeftWing;
                        PPC2tb.Text = unit.Center;
                        PPRW2tb.Text = unit.RightWing;
                        PPLD2tb.Text = unit.LeftDefence;
                        PPRD2tb.Text = unit.RightDefence;
                        break;
                    case 3:                                                 // First Unit (Four-man powerplay)
                        FPLW1tb.Text = unit.LeftWing;
                        FPC1tb.Text = unit.Center;
                        FPRW1tb.Text = unit.RightWing;
                        FPD1tb.Text = unit.LeftDefence;
                        break;
                    case 4:                                                 // Second Unit (Four-man powerplay)
                        FPLW2tb.Text = unit.LeftWing;
                        FPC2tb.Text = unit.Center;
                        FPRW2tb.Text = unit.RightWing;
                        FPD2tb.Text = unit.LeftDefence;
                        break;
                }
            }
        }

        /// <summary>
        /// Overwrite the currently selected team's powerplay with the current powerplay.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLinesbtn_Click(object sender, EventArgs e)
        {
            Team team = Methods.SelectCurrent();            // Copy the currently selected team

            //--------------------------------------------  1st Unit  --------------------------------------------
            PowerPlayLines ppl1 = new PowerPlayLines();
            ppl1.Unit = 1;
            ppl1.LeftWing = PPLW1tb.Text;
            ppl1.Center = PPC1tb.Text;
            ppl1.RightWing = PPRW1tb.Text;
            ppl1.LeftDefence = PPLD1tb.Text;
            ppl1.RightDefence = PPRD1tb.Text;

            //--------------------------------------------  2nd Unit  --------------------------------------------
            PowerPlayLines ppl2 = new PowerPlayLines();
            ppl2.Unit = 2;
            ppl2.LeftWing = PPLW2tb.Text;
            ppl2.Center = PPC2tb.Text;
            ppl2.RightWing = PPRW2tb.Text;
            ppl2.LeftDefence = PPLD2tb.Text;
            ppl2.RightDefence = PPRD2tb.Text;

            //--------------------------------------------  1st Unit Four-man  --------------------------------------------
            PowerPlayLines ppl3 = new PowerPlayLines();
            ppl3.Unit = 3;
            ppl3.LeftWing = FPLW1tb.Text;
            ppl3.Center = FPC1tb.Text;
            ppl3.RightWing = FPRW1tb.Text;
            ppl3.LeftDefence = FPD1tb.Text;

            //--------------------------------------------  2nd Unit Four-man  --------------------------------------------
            PowerPlayLines ppl4 = new PowerPlayLines();
            ppl4.Unit = 4;
            ppl4.LeftWing = FPLW2tb.Text;
            ppl4.Center = FPC2tb.Text;
            ppl4.RightWing = FPRW2tb.Text;
            ppl4.LeftDefence = FPD2tb.Text;


            team.PPL[0] = ppl1;
            team.PPL[1] = ppl2;
            team.PPL[2] = ppl3;
            team.PPL[3] = ppl4;

            Methods.Add(team);              // Overwrite the currently selected team (only changing the powerplay)
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

        //--------------------------------------------  1st Unit Four-man Powerplay  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit four-man left wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPLW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPLW1tb.DoDragDrop(FPLW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit four-man left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPLW1tb_DragDrop(object sender, DragEventArgs e)
        {
            FPLW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit four-man center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPC1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPC1tb.DoDragDrop(FPC1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit four-man center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPC1tb_DragDrop(object sender, DragEventArgs e)
        {
            FPC1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit four-man right wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPRW1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPRW1tb.DoDragDrop(FPRW1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit four-man right wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPRW1tb_DragDrop(object sender, DragEventArgs e)
        {
            FPRW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 1st unit four-man defenceman when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPD1tb.DoDragDrop(FPD1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 1st unit four-man defenceman.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPD1tb_DragDrop(object sender, DragEventArgs e)
        {
            FPD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  2nd Unit Four-man Powerplay  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit four-man left wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPLW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPLW2tb.DoDragDrop(FPLW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit four-man left wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPLW2tb_DragDrop(object sender, DragEventArgs e)
        {
            FPLW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit four-man center when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPC2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPC2tb.DoDragDrop(FPC2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit four-man center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPC2tb_DragDrop(object sender, DragEventArgs e)
        {
            FPC2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit four-man right wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPRW2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPRW2tb.DoDragDrop(FPRW2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit four-man right wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPRW2tb_DragDrop(object sender, DragEventArgs e)
        {
            FPRW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Defence  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the 2nd unit four-man right wing when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the texbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                FPD2tb.DoDragDrop(FPD2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the 2nd unit four-man right wing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FPD2tb_DragDrop(object sender, DragEventArgs e)
        {
            FPD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }
    }
}
