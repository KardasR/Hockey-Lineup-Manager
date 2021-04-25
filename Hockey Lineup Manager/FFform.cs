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
    }
}
