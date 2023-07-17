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
using System.Xml.Serialization;

namespace Article01
{
    public partial class Form2 : Form
    {
        string path = @"D:\form.xml";
        public Form2()
        {
            InitializeComponent();
        }

        public void Write(InfoWindows iw) 
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }

        void Form2_Load(object sender, System.EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            int width = this.Size.Width;
            int height = this.Size.Height;
            Write(iw);
        }

        private void Form2_ResizeEnd(object sender, System.EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            int width = this.Size.Width;
            int height = this.Size.Height;
            Write(iw);
        }
    }
}
