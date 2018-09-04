using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Xml.Linq;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
	namespace DragControlDemo
	{
		internal class DragControl : Component
		{
			private Control handleControl;

			public Control SelectControl
			{
				get
				{
					return this.handleControl;
				}
				set
				{
					this.handleControl = value;
					handleControl.MouseDown += DragForm_MouseDown;
				}
			}
			[DllImport("user32.dll")]
			public extern static int SendMessage(IntPtr a, int msg, int wParam, int lParam);
			[DllImport("user32.dll")]
			public extern static bool ReleaseCapture();

			private void DragForm_MouseDown(object sender, MouseEventArgs e)
			{
				bool flag = e.Button == MouseButtons.Left;
				if (flag)
				{
					DragControl.ReleaseCapture();
					DragControl.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
				}
			}
		}
	}

}