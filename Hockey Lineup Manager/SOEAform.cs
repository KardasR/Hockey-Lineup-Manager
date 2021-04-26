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
    }
}
