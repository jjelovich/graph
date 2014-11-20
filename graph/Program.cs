using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Program p = new Program();
            p.start();
        }


        Form1 gui;
        public Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            this.gui = new Form1();
        }

        public void start()
        {
            // GUI has to be in a separate thread or else it locks main thread.
            Thread guiThread = new Thread(RunGui);
            guiThread.Start();
           
            TrueRandom rand = new TrueRandom();

            // When the GUI closes, stop updating it.
            while (!gui.IsDisposed)
            {
                // Call the ADD Data method of the graph panel.
                // This is how we will plot the different metrics
                // onto the Graph. More options for the graph will
                // be available in the constructor later. For now,
                // this will work. 
                gui.getGraphPanel().addData(rand.Next()%100);

                // Don't murder the processor.
                Thread.Sleep(100);
            }
        }
        // This wrapper is needed because of how the threads are instantiated. 
        public void RunGui()
        {
            Application.Run(gui);
        }
    }
}
