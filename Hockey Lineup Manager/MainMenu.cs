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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SelTeambtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "E:\\Programming\\C#\\Hockey Lineup Manager\\Hockey Lineup Manager\\Rosters";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;     // Will reopen where last user closed it.

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    fileContent = File.ReadAllText(filePath);
                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }
            //org = JsonConvert.Des
            Dictionary<string, NHLTeam> org = JsonConvert.DeserializeObject<Dictionary<string, NHLTeam>>(fileContent);      // Read the file and place data in dictionary

            foreach (var item in org)
            {
                // Check if year is not already in the dictionary before adding the team
                if (!Methods.SetCurrent(item.Key))
                    Methods.Add(item.Key, JsonConvert.SerializeObject(item.Value));
            }

            ESform esform = new ESform();
            esform.Show();
        }

        private void NewTeambtn_Click(object sender, EventArgs e)
        {
            ESform esform = new ESform();
            esform.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
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
