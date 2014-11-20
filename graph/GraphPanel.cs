using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    

    public partial class GraphPanel : UserControl
    {
        Point[] pts = new Point[1000];
        int count = 0;

        protected LinkedList<Point> data;
        protected int MAX_SIZE = 2000;

        public GraphPanel()
        {
            data = new LinkedList<Point>();
            InitializeComponent();
        }

        public void clearData() {
            data.Clear();
        }

        /// <summary>
        /// <para>If queue is full, it will remove the first in the queue and
        /// will add the new data element to the end of the graph's data. </para>
        /// </summary>
        /// <param name="d"></param>
        public void addData(Point d)
        {
            if (data.Count > MAX_SIZE)
            {
                data.RemoveFirst();
            }
            data.AddLast(d);
            this.Invoke((MethodInvoker)delegate
            {
                this.Refresh();
            });
            count++;
        }

        private void GraphPanel_Load(object sender, EventArgs e)
        {

        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            LinkedList<Point>.Enumerator curr = data.GetEnumerator();
            LinkedList<Point>.Enumerator prev = data.GetEnumerator();
            Pen graphPen = new Pen(Color.Black,3);
            Font f = new Font("tahoma", 12);
            Brush b = new SolidBrush(Color.Black);

            if(curr.MoveNext() == false)
            {
                return;

            }
            else
            {
            for (int i = 0; i < count; ++i)
            {
                 if (i != 0 )
                 {
                     e.Graphics.DrawLine(graphPen, a. );
                 }
                 else
                 {
                     e.Graphics.DrawLine(graphPen, );
                 }
            }
            //e.Graphics.DrawString(data.Last.Value+"", f, b, 0, 20);
            }
        }
    }
}
