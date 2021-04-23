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

        //------------------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------  Drag and Drop Functionallity  --------------------------------------------
        //
        //------------------------------------------------------------------------------------------------------------------------------------

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

        //--------------------------------------------  Left Defence  --------------------------------------------

        private void LD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag and drop.
            if (e.Button == MouseButtons.Right)
                LD1tb.DoDragDrop(LD1tb.Text, DragDropEffects.Copy);
        }

        private void LD1tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        private void LD1tb_DragDrop(object sender, DragEventArgs e)
        {
            LD1tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Right Defence  --------------------------------------------

        private void RD1tb_MouseDown(object sender, MouseEventArgs e)
        {
            RD1tb.DoDragDrop(RD1tb.Text, DragDropEffects.Copy);
        }

        private void RD1tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        //--------------------------------------------  Left Defence  --------------------------------------------

        private void LD2tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LD2tb.DoDragDrop(LD2tb.Text, DragDropEffects.Copy);
        }

        private void LD2tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void RD2tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void LW3tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void C3tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void RW3tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void LD3tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void RD3tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void LW4tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void C4tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void RW4tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void G1tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void G2tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        private void G2tb_DragDrop(object sender, DragEventArgs e)
        {
            G2tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Scratched  --------------------------------------------

        //--------------------------------------------  Left Wing  --------------------------------------------

        private void LW5tb_MouseDown(object sender, MouseEventArgs e)
        {
            // When the user selects the textbox with the right mouse button, start the drag drop.
            if (e.Button == MouseButtons.Right)
                LW5tb.DoDragDrop(LW5tb.Text, DragDropEffects.Copy);
        }

        private void LW5tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void C5tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void RW5tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void LD4tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
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

        private void RD4tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the text to be copied.
                e.Effect = DragDropEffects.Copy;
            else
                // Don't allow the text to be copied.
                e.Effect = DragDropEffects.None;
        }

        private void RD4tb_DragDrop(object sender, DragEventArgs e)
        {
            RD4tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //--------------------------------------------  Misc  --------------------------------------------

        /// <summary>
        /// Show user powerplay lineup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPbtn_Click(object sender, EventArgs e)
        {
            PPform pp = new PPform();
            pp.Show();
        }

        /// <summary>
        /// Save user lines to Roster folder in root project folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLinesbtn_Click(object sender, EventArgs e)
        {
            List<Player> playerList = new List<Player>();       // Hold the list of players to save information
            Player player = new Player();                       // Create a player object

            //--------------------------------------------  1st Line / 1st Pairing  --------------------------------------------
            // Save 1st line left wing
            player.Name = LW1tb.Text;
            player.ESL = new int[] { 1, 1 };    // First line, left wing

            playerList.Add(player);

            // Save 1st line center
            player = new Player();
            player.Name = C1tb.Text;
            player.ESL = new int[] { 1, 2 };    // First line, center

            playerList.Add(player);

            // Save 1st line right wing
            player = new Player();
            player.Name = RW1tb.Text;
            player.ESL = new int[] { 1, 3 };    // First line, right wing

            playerList.Add(player);

            // Save 1st pair left defence
            player = new Player();
            player.Name = LD1tb.Text;
            player.ESL = new int[] { 1, 4 };    // First pair, left defence

            playerList.Add(player);

            // Save 1st pair right defence
            player = new Player();
            player.Name = RD1tb.Text;
            player.ESL = new int[] { 1, 5 };    // First pair, right defence

            playerList.Add(player);

            //--------------------------------------------  2nd Line / 2nd Pairing  --------------------------------------------
            // Save 2nd line left wing
            player = new Player();
            player.Name = LW2tb.Text;
            player.ESL = new int[] { 2, 1 };    // Second line, left wing

            playerList.Add(player);

            // Save 2nd line center
            player = new Player();
            player.Name = C2tb.Text;
            player.ESL = new int[] { 2, 2 };    // Second line, center

            playerList.Add(player);

            // Save 2nd line right wing
            player = new Player();
            player.Name = RW2tb.Text;
            player.ESL = new int[] { 2, 3 };    // Second line, right wing

            playerList.Add(player);

            // Save 2nd pair left defence
            player = new Player();
            player.Name = LD2tb.Text;
            player.ESL = new int[] { 2, 4 };    // Second pair, left defence

            playerList.Add(player);

            // Save 2nd pair right defence
            player = new Player();
            player.Name = RD2tb.Text;
            player.ESL = new int[] { 2, 5 };    // Second pair, right defence

            playerList.Add(player);

            //--------------------------------------------  3rd Line / 3rd Pairing  --------------------------------------------
            // Save 3rd line left wing
            player = new Player();
            player.Name = LW3tb.Text;
            player.ESL = new int[] { 3, 1 };    // Third line, left wing

            playerList.Add(player);

            // Save 3rd line center
            player = new Player();
            player.Name = C3tb.Text;
            player.ESL = new int[] { 3, 2 };    // Third line, center

            playerList.Add(player);

            // Save 3rd line right wing
            player = new Player();
            player.Name = RW3tb.Text;
            player.ESL = new int[] { 3, 3 };    // Third line, right wing

            playerList.Add(player);

            // Save 3rd pair left defence
            player = new Player();
            player.Name = LD3tb.Text;
            player.ESL = new int[] { 3, 4 };    // Third pair, left defence

            playerList.Add(player);

            // Save 3rd pair right defence
            player = new Player();
            player.Name = RD3tb.Text;
            player.ESL = new int[] { 3, 5 };    // Third pair, right defence

            playerList.Add(player);

            //--------------------------------------------  4th Line / Goalies  --------------------------------------------
            // Save 4th line left wing
            player = new Player();
            player.Name = LW4tb.Text;
            player.ESL = new int[] { 4, 1 };    // Fourth line, left wing

            playerList.Add(player);

            // Save 4th line center
            player = new Player();
            player.Name = C4tb.Text;
            player.ESL = new int[] { 4, 2 };    // Fourth line, center

            playerList.Add(player);

            // Save 4th line right wing
            player = new Player();
            player.Name = RW4tb.Text;
            player.ESL = new int[] { 4, 3 };    // Fourth line, right wing

            playerList.Add(player);

            // Save starting goalie
            player = new Player();
            player.Name = G1tb.Text;
            player.ESL = new int[] { 4, 4 };    // Starting Goalie

            playerList.Add(player);

            // Save backup goalie
            player = new Player();
            player.Name = G2tb.Text;
            player.ESL = new int[] { 4, 5 };    // Backup Goalie

            playerList.Add(player);

            //--------------------------------------------  Scratched  --------------------------------------------
            // Save scratched left wing
            player = new Player();
            player.Name = LW5tb.Text;
            player.ESL = new int[] { 5, 1 };    // Scratched, left wing

            playerList.Add(player);

            // Save scratched center
            player = new Player();
            player.Name = C5tb.Text;
            player.ESL = new int[] { 5, 2 };    // Scratched, center

            playerList.Add(player);

            // Save scratched right wing
            player = new Player();
            player.Name = RW5tb.Text;
            player.ESL = new int[] { 5, 3 };    // Scratched, right wing

            playerList.Add(player);

            // Save scratched left defence
            player = new Player();
            player.Name = LD4tb.Text;
            player.ESL = new int[] { 5, 4 };    // Scratched, left defence

            playerList.Add(player);

            // Save scratched right defence
            player = new Player();
            player.Name = RD4tb.Text;
            player.ESL = new int[] { 5, 5 };    // Scratched, right defence

            playerList.Add(player);

            Team team = new Team();
            team.Name = TeamNametb.Text;
            team.Year = TeamYearlb.SelectedItem.ToString();
            team.League = NHLrb.Checked ? true : false;
            team.Roster = playerList;

            // Save the setup
            using (StreamWriter file = File.CreateText(Path.Combine("..\\..\\Rosters\\", (team.Name + ".txt"))))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, team);
            }
        }

        /// <summary>
        /// Load user lines from Roster folder in root project folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadLinesbtn_Click(object sender, EventArgs e)
        {
            string teamName = TeamNametb.Text;
            string fileContent = File.ReadAllText(Path.Combine("..\\..\\Rosters\\", (teamName + ".txt")));
            Team team = JsonConvert.DeserializeObject<Team>(fileContent);

            TeamNametb.Text = team.Name;
            // TeamYearlb.SelectedItem = team.Year; Need to think about this more as I need to also add in other years to the listbox
            NHLrb.Checked = team.League ? true : false;
            AHLrb.Checked = team.League ? false : true;

            // Go through each player in the roster and place the players in the correct locations
            foreach (Player player in team.Roster)
            {
                // Figure out what line they are on, find the position
                int line = player.ESL[0];
                int pos = player.ESL[1];
                switch (line)   // Find the line the player is on
                {
                    case 1:                                     // First Line -- First Pairing
                        switch(pos)
                        {
                            case 1:                             // Left Wing
                                LW1tb.Text = player.Name;
                                break;
                            case 2:                             // Center
                                C1tb.Text = player.Name;
                                break;
                            case 3:                             // Right Wing
                                RW1tb.Text = player.Name;
                                break;
                            case 4:                             // Left Defence
                                LD1tb.Text = player.Name;
                                break;
                            case 5:                             // Right Defence
                                RD1tb.Text = player.Name;
                                break;
                        }
                        break;
                    case 2:                                     // Second Line -- Second Pairing
                        switch (pos)
                        {
                            case 1:                             // Left Wing
                                LW2tb.Text = player.Name;
                                break;
                            case 2:                             // Center
                                C2tb.Text = player.Name;
                                break;
                            case 3:                             // Right Wing
                                RW2tb.Text = player.Name;
                                break;
                            case 4:                             // Left Defence
                                LD2tb.Text = player.Name;
                                break;
                            case 5:                             // Right Defence
                                RD2tb.Text = player.Name;
                                break;
                        }
                        break;
                    case 3:                                     // Third Line -- Third Pairing
                        switch (pos)
                        {
                            case 1:                             // Left Wing
                                LW3tb.Text = player.Name;
                                break;
                            case 2:                             // Center
                                C3tb.Text = player.Name;
                                break;
                            case 3:                             // Right Wing
                                RW3tb.Text = player.Name;
                                break;
                            case 4:                             // Left Defence
                                LD3tb.Text = player.Name;
                                break;
                            case 5:                             // Right Defence
                                RD3tb.Text = player.Name;
                                break;
                        }
                        break;
                    case 4:                                     // Forth Line and Goalies
                        switch (pos)
                        {
                            case 1:                             // Left Wing
                                LW4tb.Text = player.Name;
                                break;
                            case 2:                             // Center
                                C4tb.Text = player.Name;
                                break;
                            case 3:                             // Right Wing
                                RW4tb.Text = player.Name;
                                break;
                            case 4:                             // Starter
                                G1tb.Text = player.Name;
                                break;
                            case 5:                             // Backup
                                G2tb.Text = player.Name;
                                break;
                        }
                        break;
                    case 5:                                     // Scratched Forwards and Defence
                        switch(pos)
                        {
                            case 1:                             // Left Wing
                                LW5tb.Text = player.Name;
                                break;
                            case 2:                             // Center
                                C5tb.Text = player.Name;
                                break;
                            case 3:                             // Right Wing
                                RW5tb.Text = player.Name;
                                break;
                            case 4:                             // Left Defence
                                LD4tb.Text = player.Name;
                                break;
                            case 5:                             // Right Defence
                                RD4tb.Text = player.Name;
                                break;
                        }
                        break;
                }
            }
        }

        private void AddYearbtn_Click(object sender, EventArgs e)
        {
            //TODO: Make this button add a year to the listbox
        }
    }
    public class Player
    {
        public string   Name;                   // Name of player
        public int      Overall;                // Overall of player
        public string   Potential;              // Potential of player
        public int[]    ESL = new int[2];       // Even Strength line player is on and their position (1 = Left Wing, 2 = Center, 3 = Right Wing or 3rd String, 4 = Left Defence or Starter, 5 = Right Defence or Backup)
        public int[]    PPL = new int[2];       // Powerplay unit player is on and their position
    }
    public class Team
    {
        public string           Name;           // Name of team 
        public string           Year;           // Year of team
        public bool             League;         // Which league the team is in (1 = NHL, 0 = AHL)
        public List<Player>     Roster;         // List of players
        public string           Record;         // Record of the team
        public string           Playoff;        // How far the team made it in the playoffs and who eliminated them
    }
}
