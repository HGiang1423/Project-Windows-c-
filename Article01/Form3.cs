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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //public void Write(InfoWindows iw)
        //{
        //    XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
        //    StreamWriter file = new StreamWriter(path);
        //    writer.Serialize(file, iw);
        //    file.Close();
        //}
        //public InfoWindows Read()
        //{
        //    XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
        //    StreamWriter file = new StreamWriter(path);
        //    InfoWindows iw = (InfoWindows)reader.Deserialize(file);
        //    file.Close();
        //    return iw;
        //}

        private void Form3_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            int width = this.Size.Width;
            int height = this.Size.Height;
            //Write(iw);
        }
        private void Form3_ResizeEnd(object sender, System.EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            int width = this.Size.Width;
            int height = this.Size.Height;
            //Write(iw);
        }
    }
}
