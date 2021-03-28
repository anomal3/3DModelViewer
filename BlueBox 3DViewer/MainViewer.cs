using System;
using System.Reflection;
using System.Windows.Forms;

namespace BlueBox_3DViewer
{
    public partial class MainViewer : Form
    {
        public MainViewer()
        {
            InitializeComponent();
            bOpenOBJ.Click += Open3DModelOBJ;
            bOpenFBX.Enabled = !bOpenFBX.Enabled; //TODO : Add fbx open function
            this.Text = "BlueBox 3D Model Viewer v." + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void Open3DModelOBJ(object sender, EventArgs e)
        {
            objViewer1.Load3dModelOBJ();
        }
    }
}
