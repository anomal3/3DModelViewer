using Microsoft.Win32;
using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;


namespace wpfcomponent
{
    /// <summary>
    /// Логика взаимодействия для OBJViewer.xaml
    /// </summary>
    public partial class OBJViewer : UserControl
    {
        public OBJViewer()
        {
            InitializeComponent();
        }

        public void Load3dModelOBJ()
        {
            string fileName = "";
            try
            {
                
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = "Document"; // Default file name
                                           //ofd.DefaultExt = ".fbx"; // Default file extension
                ofd.Filter = "OBJ Wave|*.obj|3DS |*.3ds|LightWave 3D |*.lwo|GLdouble objz |*.objz|stereolithography |*.stl|Object File Format |*.off|All files |*.*"; // Filter files by extension

                // Show open file dialog box
                Nullable<bool> result = ofd.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    fileName = ofd.FileName;
                    // importer.Load(fileName);
                }

                mymodel.Content = Load(fileName);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Assembly.GetExecutingAssembly().GetName().CodeBase, MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        public static Model3DGroup Load(string path)
        {
            if (path == null)
            {
                return null;
            }

            Model3DGroup model = null;
            string ext = System.IO.Path.GetExtension(path).ToLower();
            switch (ext)
            {
                case ".3ds":
                    {
                        var r = new HelixToolkit.Wpf.StudioReader();
                        model = r.Read(path);
                        break;
                    }

                case ".lwo":
                    {
                        var r = new HelixToolkit.Wpf.LwoReader();
                        model = r.Read(path);

                        break;
                    }

                case ".obj":
                    {
                        var r = new HelixToolkit.Wpf.ObjReader();
                        model = r.Read(path);
                        break;
                    }

                case ".objz":
                    {
                        var r = new HelixToolkit.Wpf.ObjReader();
                        model = r.ReadZ(path);
                        break;
                    }

                case ".stl":
                    {
                        var r = new HelixToolkit.Wpf.StLReader();
                        model = r.Read(path);
                        break;
                    }

                case ".off":
                    {
                        var r = new HelixToolkit.Wpf.OffReader();
                        model = r.Read(path);
                        break;
                    }

                default:
                    throw new InvalidOperationException("File format not supported.");
            }

            return model;
        }

    }
}
