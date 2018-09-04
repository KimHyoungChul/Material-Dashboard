using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace WindowsApplication1
{
	public partial class frmMain
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private int PanelWidth;
		private bool isCol;
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (isCol)
			{
				Panel1.Width = Panel1.Width + 10;
				if (Panel1.Width >= PanelWidth)
				{
					Timer1.Stop();
					isCol = false;
					this.Refresh();
				}
			}
			else
			{
				Panel1.Width = Panel1.Width - 10;
				if (Panel1.Width <= 47)
				{
					Timer1.Stop();
					isCol = true;
					this.Refresh();
				}
			}
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			Timer1.Start();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PanelWidth = Panel1.Width;
		}

		private void btnClose_MouseLeave(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.White;
		}

		private void btnClose_MouseEnter(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.FromArgb(183, 28, 28);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			System.Environment.Exit(1);
		}

		private void btnMinimize_MouseLeave(object sender, EventArgs e)
		{
			btnMinimize.BackColor = Color.White;
		}

		private void btnMinimize_MouseEnter(object sender, EventArgs e)
		{
			btnMinimize.BackColor = Color.FromArgb(67, 160, 71);
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.FromArgb(103, 58, 183);
			btnExpense.BackColor = Color.FromArgb(69, 39, 160);
			btnUser.BackColor = Color.FromArgb(69, 39, 160);
			btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160);
			btnSales.BackColor = Color.FromArgb(69, 39, 160);
			btnViewSales.BackColor = Color.FromArgb(69, 39, 160);
		}

		private void btnExpense_Click(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.FromArgb(69, 39, 160);
			btnExpense.BackColor = Color.FromArgb(103, 58, 183);
			btnUser.BackColor = Color.FromArgb(69, 39, 160);
			btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160);
			btnSales.BackColor = Color.FromArgb(69, 39, 160);
			btnViewSales.BackColor = Color.FromArgb(69, 39, 160);
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.FromArgb(69, 39, 160);
			btnExpense.BackColor = Color.FromArgb(69, 39, 160);
			btnUser.BackColor = Color.FromArgb(103, 58, 183);
			btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160);
			btnSales.BackColor = Color.FromArgb(69, 39, 160);
			btnViewSales.BackColor = Color.FromArgb(69, 39, 160);
		}

		private void btnPurchaseDetails_Click(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.FromArgb(69, 39, 160);
			btnExpense.BackColor = Color.FromArgb(69, 39, 160);
			btnUser.BackColor = Color.FromArgb(69, 39, 160);
			btnPurchaseDetails.BackColor = Color.FromArgb(103, 58, 183);
			btnSales.BackColor = Color.FromArgb(69, 39, 160);
			btnViewSales.BackColor = Color.FromArgb(69, 39, 160);
		}

		private void btnSales_Click(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.FromArgb(69, 39, 160);
			btnExpense.BackColor = Color.FromArgb(69, 39, 160);
			btnUser.BackColor = Color.FromArgb(69, 39, 160);
			btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160);
			btnSales.BackColor = Color.FromArgb(103, 58, 183);
			btnViewSales.BackColor = Color.FromArgb(69, 39, 160);
		}

		private void btnViewSales_Click(object sender, EventArgs e)
		{
			btnHome.BackColor = Color.FromArgb(69, 39, 160);
			btnExpense.BackColor = Color.FromArgb(69, 39, 160);
			btnUser.BackColor = Color.FromArgb(69, 39, 160);
			btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160);
			btnSales.BackColor = Color.FromArgb(69, 39, 160);
			btnViewSales.BackColor = Color.FromArgb(103, 58, 183);
		}

		private static frmMain _DefaultInstance;
		public static frmMain DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new frmMain();

				return _DefaultInstance;
			}
		}
	}

}