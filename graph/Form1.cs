using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black,20);
            e.Graphics.DrawLine(pen, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height-1);
            Console.WriteLine("A");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal GraphPanel getGraphPanel()
        {
            return this.graphPanel1;
        }

        private void graphPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
