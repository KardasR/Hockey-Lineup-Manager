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
    public partial class AHLform : Form
    {
        public AHLform()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the AHL lines from the currently selected team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam nhlteam = (Methods.SelectCurrent() != null) ? JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent()) : new NHLTeam();
            AHLTeam team = (nhlteam.AHLLines != null) ? nhlteam.AHLLines : new AHLTeam();


            // Load team info
            TeamNametb.Text = team.Name;

            NHLrb.Checked = team.League ? true : false;
            AHLrb.Checked = team.League ? false : true;

            Recordtb.Text = team.Record;
            Playofftb.Text = team.Playoff;

            // Load Goalies
            G1tb.Text = team.goalies.Starter.Name;
            G1OVRtb.Text = team.goalies.Starter.Overall.ToString();
            G2tb.Text = team.goalies.Backup.Name;
            G2OVRtb.Text = team.goalies.Backup.Overall.ToString();
            G3tb.Text = team.goalies.ThirdString.Name;
            G3OVRtb.Text = team.goalies.ThirdString.Overall.ToString();
            

            // Load Player Lines
            foreach (EvenStrengthLines line in team.ESL)
            {
                int unit = line.Line;
                switch(unit)
                {
                    case 1:                                                     // First Line
                        LW1tb.Text = line.LeftWing.Name;
                        LW1OVRtb.Text = line.LeftWing.Overall.ToString();
                        C1tb.Text = line.Center.Name;
                        C1OVRtb.Text = line.Center.Overall.ToString();
                        RW1tb.Text = line.RightWing.Name;
                        RW1OVRtb.Text = line.RightWing.Overall.ToString();
                        LD1tb.Text = line.LeftDefence.Name;
                        LD1OVRtb.Text = line.LeftDefence.Overall.ToString();
                        RD1tb.Text = line.RightDefence.Name;
                        RD1OVRtb.Text = line.RightDefence.Overall.ToString();
                        break;
                    case 2:                                                     // Second Line
                        LW2tb.Text = line.LeftWing.Name;
                        LW2OVRtb.Text = line.LeftWing.Overall.ToString();
                        C2tb.Text = line.Center.Name;
                        C2OVRtb.Text = line.Center.Overall.ToString();
                        RW2tb.Text = line.RightWing.Name;
                        RW2OVRtb.Text = line.RightWing.Overall.ToString();
                        LD2tb.Text = line.LeftDefence.Name;
                        LD2OVRtb.Text = line.LeftDefence.Overall.ToString();
                        RD2tb.Text = line.RightDefence.Name;
                        RD2OVRtb.Text = line.RightDefence.Overall.ToString();
                        break;
                    case 3:                                                     // Third Line
                        LW3tb.Text = line.LeftWing.Name;
                        LW3OVRtb.Text = line.LeftWing.Overall.ToString();
                        C3tb.Text = line.Center.Name;
                        C3OVRtb.Text = line.Center.Overall.ToString();
                        RW3tb.Text = line.RightWing.Name;
                        RW3OVRtb.Text = line.RightWing.Overall.ToString();
                        LD3tb.Text = line.LeftDefence.Name;
                        LD3OVRtb.Text = line.LeftDefence.Overall.ToString();
                        RD3tb.Text = line.RightDefence.Name;
                        RD3OVRtb.Text = line.RightDefence.Overall.ToString();
                        break;
                    case 4:                                                     // Forth Line
                        LW4tb.Text = line.LeftWing.Name;
                        LW4OVRtb.Text = line.LeftWing.Overall.ToString();
                        C4tb.Text = line.Center.Name;
                        C4OVRtb.Text = line.Center.Overall.ToString();
                        RW4tb.Text = line.RightWing.Name;
                        RW4OVRtb.Text = line.RightWing.Overall.ToString();
                        break;
                    case 5:                                                     // Scratched
                        LW5tb.Text = line.LeftWing.Name;
                        LW5OVRtb.Text = line.LeftWing.Overall.ToString();
                        C5tb.Text = line.Center.Name;
                        C5OVRtb.Text = line.Center.Overall.ToString();
                        RW5tb.Text = line.RightWing.Name;
                        RW5OVRtb.Text = line.RightWing.Overall.ToString();
                        LD4tb.Text = line.LeftDefence.Name;
                        LD4OVRtb.Text = line.LeftDefence.Overall.ToString();
                        RD4tb.Text = line.RightDefence.Name;
                        RD4OVRtb.Text = line.RightDefence.Overall.ToString();
                        break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLinesbtn_Click(object sender, EventArgs e)
        {
            NHLTeam nhlteam = (Methods.SelectCurrent() != null) ? JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent()) : new NHLTeam();
            AHLTeam team = (nhlteam.AHLLines != null) ? nhlteam.AHLLines : new AHLTeam();

            // Save team info
            team.Name = TeamNametb.Text;
            team.League = NHLrb.Checked ? true : false;
            team.Record = Recordtb.Text.ToString();
            team.Playoff = Playofftb.Text.ToString();

            //--------------------------------------------  1st Line / 1st Pairing  --------------------------------------------
            EvenStrengthLines line1 = new EvenStrengthLines();
            line1.Line = 1;

            // Save 1st line left wing
            Player player = new Player();                       // Create a player object
            player.Name = LW1tb.Text;
            player.Overall = String.IsNullOrEmpty(LW1OVRtb.Text) ? 0 : int.Parse(LW1OVRtb.Text);

            line1.LeftWing = player;

            // Save 1st line center
            player = new Player();
            player.Name = C1tb.Text;
            player.Overall = String.IsNullOrEmpty(C1OVRtb.Text) ? 0 : int.Parse(C1OVRtb.Text);

            line1.Center = player;

            // Save 1st line right wing
            player = new Player();
            player.Name = RW1tb.Text;
            player.Overall = String.IsNullOrEmpty(RW1OVRtb.Text) ? 0 : int.Parse(RW1OVRtb.Text);

            line1.RightWing = player;

            // Save 1st pair left defence
            player = new Player();
            player.Name = LD1tb.Text;
            player.Overall = String.IsNullOrEmpty(LD1OVRtb.Text) ? 0 : int.Parse(LD1OVRtb.Text);

            line1.LeftDefence = player;

            // Save 1st pair right defence
            player = new Player();
            player.Name = RD1tb.Text;
            player.Overall = String.IsNullOrEmpty(RD1OVRtb.Text) ? 0 : int.Parse(RD1OVRtb.Text);

            line1.RightDefence = player;

            //--------------------------------------------  2nd Line / 2nd Pairing  --------------------------------------------
            EvenStrengthLines line2 = new EvenStrengthLines();
            line2.Line = 2;

            // Save 2nd line left wing
            player = new Player();
            player.Name = LW2tb.Text;
            player.Overall = String.IsNullOrEmpty(LW2OVRtb.Text) ? 0 : int.Parse(LW2OVRtb.Text);

            line2.LeftWing = player;

            // Save 2nd line center
            player = new Player();
            player.Name = C2tb.Text;
            player.Overall = String.IsNullOrEmpty(C2OVRtb.Text) ? 0 : int.Parse(C2OVRtb.Text);

            line2.Center = player;

            // Save 2nd line right wing
            player = new Player();
            player.Name = RW2tb.Text;
            player.Overall = String.IsNullOrEmpty(RW2OVRtb.Text) ? 0 : int.Parse(RW2OVRtb.Text);

            line2.RightWing = player;

            // Save 2nd pair left defence
            player = new Player();
            player.Name = LD2tb.Text;
            player.Overall = String.IsNullOrEmpty(LD2OVRtb.Text) ? 0 : int.Parse(LD2OVRtb.Text);

            line2.LeftDefence = player;

            // Save 2nd pair right defence
            player = new Player();
            player.Name = RD2tb.Text;
            player.Overall = String.IsNullOrEmpty(RD2OVRtb.Text) ? 0 : int.Parse(RD2OVRtb.Text);

            line2.RightDefence = player;

            //--------------------------------------------  3rd Line / 3rd Pairing  --------------------------------------------
            EvenStrengthLines line3 = new EvenStrengthLines();
            line3.Line = 3;

            // Save 3rd line left wing
            player = new Player();
            player.Name = LW3tb.Text;
            player.Overall = String.IsNullOrEmpty(LW3OVRtb.Text) ? 0 : int.Parse(LW3OVRtb.Text);

            line3.LeftWing = player;

            // Save 3rd line center
            player = new Player();
            player.Name = C3tb.Text;
            player.Overall = String.IsNullOrEmpty(C3OVRtb.Text) ? 0 : int.Parse(C3OVRtb.Text);

            line3.Center = player;

            // Save 3rd line right wing
            player = new Player();
            player.Name = RW3tb.Text;
            player.Overall = String.IsNullOrEmpty(RW3OVRtb.Text) ? 0 : int.Parse(RW3OVRtb.Text);

            line3.RightWing = player;

            // Save 3rd pair left defence
            player = new Player();
            player.Name = LD3tb.Text;
            player.Overall = String.IsNullOrEmpty(LD3OVRtb.Text) ? 0 : int.Parse(LD3OVRtb.Text);

            line3.LeftDefence = player;

            // Save 3rd pair right defence
            player = new Player();
            player.Name = RD3tb.Text;
            player.Overall = String.IsNullOrEmpty(RD3OVRtb.Text) ? 0 : int.Parse(RD3OVRtb.Text);

            line3.RightDefence = player;

            //--------------------------------------------  4th Line  --------------------------------------------
            EvenStrengthLines line4 = new EvenStrengthLines();
            line4.Line = 4;

            // Save 4th line left wing
            player = new Player();
            player.Name = LW4tb.Text;
            player.Overall = String.IsNullOrEmpty(LW4OVRtb.Text) ? 0 : int.Parse(LW4OVRtb.Text);

            line4.LeftWing = player;

            // Save 4th line center
            player = new Player();
            player.Name = C4tb.Text;
            player.Overall = String.IsNullOrEmpty(C4OVRtb.Text) ? 0 : int.Parse(C4OVRtb.Text);

            line4.Center = player;

            // Save 4th line right wing
            player = new Player();
            player.Name = RW4tb.Text;
            player.Overall = String.IsNullOrEmpty(RW4OVRtb.Text) ? 0 : int.Parse(RW4OVRtb.Text);

            line4.RightWing = player;

            //--------------------------------------------  Goalies  --------------------------------------------
            Goalies goalies = new Goalies();

            // Save starting goalie
            player = new Player();
            player.Name = G1tb.Text;
            player.Overall = String.IsNullOrEmpty(G1OVRtb.Text) ? 0 : int.Parse(G1OVRtb.Text);

            goalies.Starter = player;

            // Save backup goalie
            player = new Player();
            player.Name = G2tb.Text;
            player.Overall = String.IsNullOrEmpty(G2OVRtb.Text) ? 0 : int.Parse(G2OVRtb.Text);

            goalies.Backup = player;

            // Save third string
            player = new Player();
            player.Name = G3tb.Text;
            player.Overall = String.IsNullOrEmpty(G3OVRtb.Text) ? 0 : int.Parse(G3OVRtb.Text);

            goalies.ThirdString = player;

            //--------------------------------------------  Scratched  --------------------------------------------
            EvenStrengthLines scratched = new EvenStrengthLines();
            scratched.Line = 5;

            // Save scratched left wing
            player = new Player();
            player.Name = LW5tb.Text;
            player.Overall = String.IsNullOrEmpty(LW5OVRtb.Text) ? 0 : int.Parse(LW5OVRtb.Text);

            scratched.LeftWing = player;

            // Save scratched center
            player = new Player();
            player.Name = C5tb.Text;
            player.Overall = String.IsNullOrEmpty(C5OVRtb.Text) ? 0 : int.Parse(C5OVRtb.Text);

            scratched.Center = player;

            // Save scratched right wing
            player = new Player();
            player.Name = RW5tb.Text;
            player.Overall = String.IsNullOrEmpty(RW5OVRtb.Text) ? 0 : int.Parse(RW5OVRtb.Text);

            scratched.RightWing = player;

            // Save scratched left defence
            player = new Player();
            player.Name = LD4tb.Text;
            player.Overall = String.IsNullOrEmpty(LD4OVRtb.Text) ? 0 : int.Parse(LD4OVRtb.Text);

            scratched.LeftDefence = player;

            // Save scratched right defence
            player = new Player();
            player.Name = RD4tb.Text;
            player.Overall = String.IsNullOrEmpty(RD4OVRtb.Text) ? 0 : int.Parse(RD4OVRtb.Text);

            scratched.RightDefence = player;

            team.ESL[0] = line1;
            team.ESL[1] = line2;
            team.ESL[2] = line3;
            team.ESL[3] = line4;
            team.ESL[4] = scratched;
            team.goalies = goalies;

            nhlteam.AHLLines = team;

            Methods.Add(Methods.GetCurrentYear(), JsonConvert.SerializeObject(nhlteam));
        }

        private void AHLform_Load(object sender, EventArgs e)
        {
            // Put form on my second monitor
            if (Screen.AllScreens.Length >= 1)
            {
                // Get the data of the second monitor
                var monitor = Screen.AllScreens[2].WorkingArea;
                // Change the wingow to the second monitor
                Location = monitor.Location;
            }

            NHLTeam nhlteam = (Methods.SelectCurrent() != null) ? JsonConvert.DeserializeObject<NHLTeam>(Methods.SelectCurrent()) : new NHLTeam();
            if (nhlteam.AHLLines != null)
            {
                AHLTeam team = nhlteam.AHLLines;

                // Load team info
                TeamNametb.Text = team.Name;

                NHLrb.Checked = team.League ? true : false;
                AHLrb.Checked = team.League ? false : true;

                Recordtb.Text = team.Record;
                Playofftb.Text = team.Playoff;

                // Load Goalies
                G1tb.Text = team.goalies.Starter.Name;
                G1OVRtb.Text = team.goalies.Starter.Overall.ToString();
                G2tb.Text = team.goalies.Backup.Name;
                G2OVRtb.Text = team.goalies.Backup.Overall.ToString();
                G3tb.Text = team.goalies.ThirdString.Name;
                G3OVRtb.Text = team.goalies.ThirdString.Overall.ToString();


                // Load Player Lines
                foreach (EvenStrengthLines line in team.ESL)
                {
                    int unit = line.Line;
                    switch (unit)
                    {
                        case 1:                                                     // First Line
                            LW1tb.Text = line.LeftWing.Name;
                            LW1OVRtb.Text = line.LeftWing.Overall.ToString();
                            C1tb.Text = line.Center.Name;
                            C1OVRtb.Text = line.Center.Overall.ToString();
                            RW1tb.Text = line.RightWing.Name;
                            RW1OVRtb.Text = line.RightWing.Overall.ToString();
                            LD1tb.Text = line.LeftDefence.Name;
                            LD1OVRtb.Text = line.LeftDefence.Overall.ToString();
                            RD1tb.Text = line.RightDefence.Name;
                            RD1OVRtb.Text = line.RightDefence.Overall.ToString();
                            break;
                        case 2:                                                     // Second Line
                            LW2tb.Text = line.LeftWing.Name;
                            LW2OVRtb.Text = line.LeftWing.Overall.ToString();
                            C2tb.Text = line.Center.Name;
                            C2OVRtb.Text = line.Center.Overall.ToString();
                            RW2tb.Text = line.RightWing.Name;
                            RW2OVRtb.Text = line.RightWing.Overall.ToString();
                            LD2tb.Text = line.LeftDefence.Name;
                            LD2OVRtb.Text = line.LeftDefence.Overall.ToString();
                            RD2tb.Text = line.RightDefence.Name;
                            RD2OVRtb.Text = line.RightDefence.Overall.ToString();
                            break;
                        case 3:                                                     // Third Line
                            LW3tb.Text = line.LeftWing.Name;
                            LW3OVRtb.Text = line.LeftWing.Overall.ToString();
                            C3tb.Text = line.Center.Name;
                            C3OVRtb.Text = line.Center.Overall.ToString();
                            RW3tb.Text = line.RightWing.Name;
                            RW3OVRtb.Text = line.RightWing.Overall.ToString();
                            LD3tb.Text = line.LeftDefence.Name;
                            LD3OVRtb.Text = line.LeftDefence.Overall.ToString();
                            RD3tb.Text = line.RightDefence.Name;
                            RD3OVRtb.Text = line.RightDefence.Overall.ToString();
                            break;
                        case 4:                                                     // Forth Line
                            LW4tb.Text = line.LeftWing.Name;
                            LW4OVRtb.Text = line.LeftWing.Overall.ToString();
                            C4tb.Text = line.Center.Name;
                            C4OVRtb.Text = line.Center.Overall.ToString();
                            RW4tb.Text = line.RightWing.Name;
                            RW4OVRtb.Text = line.RightWing.Overall.ToString();
                            break;
                        case 5:                                                     // Scratched
                            LW5tb.Text = line.LeftWing.Name;
                            LW5OVRtb.Text = line.LeftWing.Overall.ToString();
                            C5tb.Text = line.Center.Name;
                            C5OVRtb.Text = line.Center.Overall.ToString();
                            RW5tb.Text = line.RightWing.Name;
                            RW5OVRtb.Text = line.RightWing.Overall.ToString();
                            LD4tb.Text = line.LeftDefence.Name;
                            LD4OVRtb.Text = line.LeftDefence.Overall.ToString();
                            RD4tb.Text = line.RightDefence.Name;
                            RD4OVRtb.Text = line.RightDefence.Overall.ToString();
                            break;
                    }
                }
            }
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

        //--------------------------------------------  1st Line / 1st Pair --------------------------------------------

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
        /// Get the data from the drag drop and paste it into the 1st line right wing textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW1tb_DragDrop(object sender, DragEventArgs e)
        {
            RW1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        private void LD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag and drop.
            if (e.Button == MouseButtons.Right)
                LD1tb.DoDragDrop(LD1tb.Text, DragDropEffects.Copy);
        }

        private void LD1tb_DragDrop(object sender, DragEventArgs e)
        {
            LD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        private void RD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                RD1tb.DoDragDrop(RD1tb.Text, DragDropEffects.Copy);
        }

        private void RD1tb_DragDrop(object sender, DragEventArgs e)
        {
            RD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  2nd Line / 2nd Pair --------------------------------------------

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
        /// Get the data from the drag drop and paste it into the 2nd line right wing textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RW2tb_DragDrop(object sender, DragEventArgs e)
        {
            RW2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        private void LD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LD2tb.DoDragDrop(LD2tb.Text, DragDropEffects.Copy);
        }

        private void LD2tb_DragDrop(object sender, DragEventArgs e)
        {
            LD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        private void RD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RD2tb.DoDragDrop(RD2tb.Text, DragDropEffects.Copy);
        }

        private void RD2tb_DragDrop(object sender, DragEventArgs e)
        {
            RD2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Third Line / Third Pair --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        private void LW3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LW3tb.DoDragDrop(LW3tb.Text, DragDropEffects.Copy);
        }

        private void LW3tb_DragDrop(object sender, DragEventArgs e)
        {
            LW3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        private void C3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                C3tb.DoDragDrop(C3tb.Text, DragDropEffects.Copy);
        }

        private void C3tb_DragDrop(object sender, DragEventArgs e)
        {
            C3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        private void RW3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RW3tb.DoDragDrop(RW3tb.Text, DragDropEffects.Copy);
        }

        private void RW3tb_DragDrop(object sender, DragEventArgs e)
        {
            RW3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        private void LD3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LD3tb.DoDragDrop(LD3tb.Text, DragDropEffects.Copy);
        }

        private void LD3tb_DragDrop(object sender, DragEventArgs e)
        {
            LD3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        private void RD3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RD3tb.DoDragDrop(RD3tb.Text, DragDropEffects.Copy);
        }

        private void RD3tb_DragDrop(object sender, DragEventArgs e)
        {
            RD3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  4th Line / Goalies  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        private void LW4tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LW4tb.DoDragDrop(LW4tb.Text, DragDropEffects.Copy);
        }

        private void LW4tb_DragDrop(object sender, DragEventArgs e)
        {
            LW4tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        private void C4tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                C4tb.DoDragDrop(C4tb.Text, DragDropEffects.Copy);
        }

        private void C4tb_DragDrop(object sender, DragEventArgs e)
        {
            C4tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        private void RW4tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RW4tb.DoDragDrop(RW4tb.Text, DragDropEffects.Copy);
        }

        private void RW4tb_DragDrop(object sender, DragEventArgs e)
        {
            RW4tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Starter  --------------------------------------------

        private void G1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                G1tb.DoDragDrop(G1tb.Text, DragDropEffects.Copy);
        }

        private void G1tb_DragDrop(object sender, DragEventArgs e)
        {
            G1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Backup  --------------------------------------------

        private void G2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                G2tb.DoDragDrop(G2tb.Text, DragDropEffects.Copy);
        }

        private void G2tb_DragDrop(object sender, DragEventArgs e)
        {
            G2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void G3tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbob with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                G3tb.DoDragDrop(G3tb.Text, DragDropEffects.Copy);
        }

        private void G3tb_DragDrop(object sender, DragEventArgs e)
        {
            G3tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Scratched  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        private void LW5tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LW5tb.DoDragDrop(LW5tb.Text, DragDropEffects.Copy);
        }

        private void LW5tb_DragDrop(object sender, DragEventArgs e)
        {
            LW5tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Center  --------------------------------------------

        private void C5tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                C5tb.DoDragDrop(C5tb.Text, DragDropEffects.Copy);
        }

        private void C5tb_DragDrop(object sender, DragEventArgs e)
        {
            C5tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Wing  --------------------------------------------

        private void RW5tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RW5tb.DoDragDrop(RW5tb.Text, DragDropEffects.Copy);
        }

        private void RW5tb_DragDrop(object sender, DragEventArgs e)
        {
            RW5tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Left Defence  --------------------------------------------

        private void LD4tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LD4tb.DoDragDrop(LD4tb.Text, DragDropEffects.Copy);
        }

        private void LD4tb_DragDrop(object sender, DragEventArgs e)
        {
            LD4tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        private void RD4tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                RD4tb.DoDragDrop(RD4tb.Text, DragDropEffects.Copy);
        }

        private void RD4tb_DragDrop(object sender, DragEventArgs e)
        {
            RD4tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }
    }
}
