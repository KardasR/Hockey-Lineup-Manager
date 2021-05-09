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
    public partial class SOEAform : Form
    {
        public SOEAform()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------  Buttons  --------------------------------------------
        //
        //------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Load the extra attackers and shootout lineup from the currently selected team.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent());            // Copy the currently selected team

            // Go through each extra attacker then the shootout lineup
            EA1tb.Text = team.SOEA.ExtraA1;
            EA2tb.Text = team.SOEA.ExtraA2;

            SO1tb.Text = team.SOEA.Shooter1;
            SO2tb.Text = team.SOEA.Shooter2;
            SO3tb.Text = team.SOEA.Shooter3;
            SO4tb.Text = team.SOEA.Shooter4;
            SO5tb.Text = team.SOEA.Shooter5;
        }

        /// <summary>
        /// Overwrite the currently selected team's extra attackers and shootout lineup with the current extra attackers and shootout lineup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent());                // Copy the currently selected team

            // Go through the extra attackers then the shootout lineup
            ShootoutExtraAttacker soea = new ShootoutExtraAttacker();
            soea.ExtraA1 = EA1tb.Text;
            soea.ExtraA2 = EA2tb.Text;

            soea.Shooter1 = SO1tb.Text;
            soea.Shooter2 = SO2tb.Text;
            soea.Shooter3 = SO3tb.Text;
            soea.Shooter4 = SO4tb.Text;
            soea.Shooter5 = SO5tb.Text;

            team.SOEA = soea;

            Methods.Add(Methods.GetCurrentYear(), JsonConvert.SerializeObject(team));
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

        //--------------------------------------------  Extra Attackers  --------------------------------------------

        //--------------------------------------------  EA 1  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the extra attacker 1 when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EA1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                EA1tb.DoDragDrop(EA1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the extra attacker 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EA1tb_DragDrop(object sender, DragEventArgs e)
        {
            EA1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  EA 2  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the extra attacker 2 when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EA2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                EA2tb.DoDragDrop(EA2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the extra attacker 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EA2tb_DragDrop(object sender, DragEventArgs e)
        {
            EA2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  Shootout  --------------------------------------------

        //--------------------------------------------  SO 1  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the first shooter when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                SO1tb.DoDragDrop(SO1tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the first shooter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO1tb_DragDrop(object sender, DragEventArgs e)
        {
            SO1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  SO 2  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the second shooter when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                SO2tb.DoDragDrop(SO2tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the second shooter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO2tb_DragDrop(object sender, DragEventArgs e)
        {
            SO2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  SO 3  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the third shooter when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                SO3tb.DoDragDrop(SO3tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the third shooter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO3tb_DragDrop(object sender, DragEventArgs e)
        {
            SO3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  SO 4  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the fourth shooter when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO4tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                SO4tb.DoDragDrop(SO4tb.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// Get the data from the drag drop and paste it into the fourth shooter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO4tb_DragDrop(object sender, DragEventArgs e)
        {
            SO4tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        //--------------------------------------------  SO 5  --------------------------------------------

        /// <summary>
        /// Initiate the drag drop for the fifth shooter when the user right clicks on the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO5tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop
            if (e.Button == MouseButtons.Right)
                SO5tb.DoDragDrop(SO5tb.Text, DragDropEffects.Copy);
        }
        
        /// <summary>
        /// Get the data from the drag drop and paste it into the shooter fifth.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SO5tb_DragDrop(object sender, DragEventArgs e)
        {
            SO5tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void SOEAform_Load(object sender, EventArgs e)
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
