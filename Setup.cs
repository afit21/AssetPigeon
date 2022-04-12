using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigeonAssetManager
{
    public partial class Setup : Form
    {
        string credFilePath;
        public Setup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    credFilePath = openFileDialog.FileName;
                }
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            AssetManager.sheetsconnection = new GoogleSheetsConnection(credFilePath, SheetIdBox.Text);
        }
    }
}
