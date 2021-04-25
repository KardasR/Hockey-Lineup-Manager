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
    }
}
