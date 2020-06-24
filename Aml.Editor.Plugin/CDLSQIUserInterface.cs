using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using YamlDotNet.RepresentationModel;


namespace Aml.Editor.Plugin
{
    public partial class CDLSQIUserInterface : UserControl
    {
        private CDLSQIcontroller cDLSQIcontroller;

        public CDLSQIUserInterface()
        {
            InitializeComponent();
        }

        public CDLSQIUserInterface(CDLSQIcontroller cDLSQIcontroller)
        {
            this.cDLSQIcontroller = cDLSQIcontroller;
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "YML Files(*.yml )|*.yml; ";

                if (open.ShowDialog() == DialogResult.OK)
                {
                   string filePath = Path.GetDirectoryName(open.FileName);
                   var reader = new StreamReader(open.FileName);

                   var yaml = new YamlStream();
                   yaml.Load(reader);

                    // Examine the stream
                    /* var mapping =
                         (YamlMappingNode)yaml.Documents[0].RootNode;

                     foreach (var entry in mapping.Children)
                     {

                     }*/

                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
