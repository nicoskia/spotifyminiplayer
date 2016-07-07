using System.Windows.Forms;
using System.Drawing;
using System;

namespace SpotifyAPI.Example
{

    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.ShowInTaskbar = false;
        }


        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void localControl1_Load(object sender, System.EventArgs e)
        {

        }

        private bool mouseDown;
        private Point lastLocation;

        private void ExampleForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ExampleForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ExampleForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}