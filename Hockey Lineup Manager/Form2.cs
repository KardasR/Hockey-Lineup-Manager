﻿using System;
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
    public partial class PPform : Form
    {
        public PPform()
        {
            InitializeComponent();
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
        /// Check the given data to make sure it is a correct format and has the copy effect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPLW1tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the drag drop to finish
                e.Effect = DragDropEffects.Copy;
            else
                // Don't finish the drag drop
                e.Effect = DragDropEffects.None;
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
        /// Get the data from the drag drop and paste it into the 1st unit center textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPC1tb_DragEnter(object sender, DragEventArgs e)
        {
            // Make sure the data recieved is in the correct format.
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                // Allow the drag drop to finish
                e.Effect = DragDropEffects.Copy;
            else
                // Don't finish the drag drop
                e.Effect = DragDropEffects.None;
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
    }
}