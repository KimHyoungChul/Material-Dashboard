//========================================================================
// This conversion was produced by the Free Edition of
// Instant C# courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class frmMain : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.Panel1 = new System.Windows.Forms.Panel();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.btnViewSales = new System.Windows.Forms.Button();
			this.btnSales = new System.Windows.Forms.Button();
			this.btnPurchaseDetails = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnExpense = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.btnMinimize = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.DragControl1 = new WindowsApplication1.DragControlDemo.DragControl();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.btnMinimize).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.btnClose).BeginInit();
			this.Panel4.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor = System.Drawing.Color.FromArgb((int)((byte)69), (int)((byte)39), (int)((byte)160));
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.btnViewSales);
			this.Panel1.Controls.Add(this.btnSales);
			this.Panel1.Controls.Add(this.btnPurchaseDetails);
			this.Panel1.Controls.Add(this.btnUser);
			this.Panel1.Controls.Add(this.btnExpense);
			this.Panel1.Controls.Add(this.btnHome);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(299, 773);
			this.Panel1.TabIndex = 0;
			//
			//PictureBox1
			//
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(56, 29);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(187, 160);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.FlatAppearance.BorderSize = 0;
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
			this.Button1.Location = new System.Drawing.Point(251, 9);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(34, 31);
			this.Button1.TabIndex = 1;
			this.Button1.UseVisualStyleBackColor = true;
			//
			//btnViewSales
			//
			this.btnViewSales.BackColor = System.Drawing.Color.FromArgb((int)((byte)69), (int)((byte)39), (int)((byte)160));
			this.btnViewSales.FlatAppearance.BorderSize = 0;
			this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnViewSales.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.btnViewSales.ForeColor = System.Drawing.Color.FromArgb((int)((byte)238), (int)((byte)238), (int)((byte)238));
			this.btnViewSales.Image = (System.Drawing.Image)resources.GetObject("btnViewSales.Image");
			this.btnViewSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnViewSales.Location = new System.Drawing.Point(-1, 493);
			this.btnViewSales.Name = "btnViewSales";
			this.btnViewSales.Size = new System.Drawing.Size(300, 47);
			this.btnViewSales.TabIndex = 1;
			this.btnViewSales.Text = "      View Sales";
			this.btnViewSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnViewSales.UseVisualStyleBackColor = false;
			//
			//btnSales
			//
			this.btnSales.BackColor = System.Drawing.Color.FromArgb((int)((byte)69), (int)((byte)39), (int)((byte)160));
			this.btnSales.FlatAppearance.BorderSize = 0;
			this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSales.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.btnSales.ForeColor = System.Drawing.Color.FromArgb((int)((byte)238), (int)((byte)238), (int)((byte)238));
			this.btnSales.Image = (System.Drawing.Image)resources.GetObject("btnSales.Image");
			this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSales.Location = new System.Drawing.Point(-1, 437);
			this.btnSales.Name = "btnSales";
			this.btnSales.Size = new System.Drawing.Size(300, 47);
			this.btnSales.TabIndex = 1;
			this.btnSales.Text = "      Sales";
			this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSales.UseVisualStyleBackColor = false;
			//
			//btnPurchaseDetails
			//
			this.btnPurchaseDetails.BackColor = System.Drawing.Color.FromArgb((int)((byte)69), (int)((byte)39), (int)((byte)160));
			this.btnPurchaseDetails.FlatAppearance.BorderSize = 0;
			this.btnPurchaseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPurchaseDetails.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.btnPurchaseDetails.ForeColor = System.Drawing.Color.FromArgb((int)((byte)238), (int)((byte)238), (int)((byte)238));
			this.btnPurchaseDetails.Image = (System.Drawing.Image)resources.GetObject("btnPurchaseDetails.Image");
			this.btnPurchaseDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPurchaseDetails.Location = new System.Drawing.Point(-1, 380);
			this.btnPurchaseDetails.Name = "btnPurchaseDetails";
			this.btnPurchaseDetails.Size = new System.Drawing.Size(300, 47);
			this.btnPurchaseDetails.TabIndex = 1;
			this.btnPurchaseDetails.Text = "      Purchase Details";
			this.btnPurchaseDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPurchaseDetails.UseVisualStyleBackColor = false;
			//
			//btnUser
			//
			this.btnUser.BackColor = System.Drawing.Color.FromArgb((int)((byte)69), (int)((byte)39), (int)((byte)160));
			this.btnUser.FlatAppearance.BorderSize = 0;
			this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUser.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.btnUser.ForeColor = System.Drawing.Color.FromArgb((int)((byte)238), (int)((byte)238), (int)((byte)238));
			this.btnUser.Image = (System.Drawing.Image)resources.GetObject("btnUser.Image");
			this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUser.Location = new System.Drawing.Point(-1, 323);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(300, 47);
			this.btnUser.TabIndex = 1;
			this.btnUser.Text = "      Manage User";
			this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUser.UseVisualStyleBackColor = false;
			//
			//btnExpense
			//
			this.btnExpense.BackColor = System.Drawing.Color.FromArgb((int)((byte)69), (int)((byte)39), (int)((byte)160));
			this.btnExpense.FlatAppearance.BorderSize = 0;
			this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExpense.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.btnExpense.ForeColor = System.Drawing.Color.FromArgb((int)((byte)238), (int)((byte)238), (int)((byte)238));
			this.btnExpense.Image = (System.Drawing.Image)resources.GetObject("btnExpense.Image");
			this.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExpense.Location = new System.Drawing.Point(-1, 267);
			this.btnExpense.Name = "btnExpense";
			this.btnExpense.Size = new System.Drawing.Size(300, 47);
			this.btnExpense.TabIndex = 1;
			this.btnExpense.Text = "      Manage Expense";
			this.btnExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExpense.UseVisualStyleBackColor = false;
			//
			//btnHome
			//
			this.btnHome.BackColor = System.Drawing.Color.FromArgb((int)((byte)103), (int)((byte)58), (int)((byte)183));
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.btnHome.ForeColor = System.Drawing.Color.FromArgb((int)((byte)238), (int)((byte)238), (int)((byte)238));
			this.btnHome.Image = (System.Drawing.Image)resources.GetObject("btnHome.Image");
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(-1, 211);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(300, 47);
			this.btnHome.TabIndex = 1;
			this.btnHome.Text = "      Home";
			this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHome.UseVisualStyleBackColor = false;
			//
			//Timer1
			//
			this.Timer1.Interval = 10;
			//
			//Panel2
			//
			this.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new System.Drawing.Point(299, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(976, 773);
			this.Panel2.TabIndex = 1;
			//
			//Panel3
			//
			this.Panel3.BackColor = System.Drawing.Color.White;
			this.Panel3.Controls.Add(this.btnMinimize);
			this.Panel3.Controls.Add(this.btnClose);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel3.Location = new System.Drawing.Point(0, 0);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(976, 51);
			this.Panel3.TabIndex = 0;
			//
			//btnMinimize
			//
			this.btnMinimize.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
			this.btnMinimize.Location = new System.Drawing.Point(895, 8);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(32, 32);
			this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.TabStop = false;
			//
			//btnClose
			//
			this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
			this.btnClose.Location = new System.Drawing.Point(935, 8);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(32, 32);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 1;
			this.btnClose.TabStop = false;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.ForeColor = System.Drawing.Color.FromArgb((int)((byte)103), (int)((byte)58), (int)((byte)183));
			this.Label1.Location = new System.Drawing.Point(11, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(277, 29);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Material Design Dashboard";
			//
			//Panel4
			//
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Panel2);
			this.Panel4.Controls.Add(this.Panel1);
			this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel4.Location = new System.Drawing.Point(0, 0);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(1277, 775);
			this.Panel4.TabIndex = 2;
			//
			//DragControl1
			//
			this.DragControl1.SelectControl = this.Panel3;
			//
			//frmMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8.0F, 16.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1277, 775);
			this.Controls.Add(this.Panel4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.btnMinimize).EndInit();
			((System.ComponentModel.ISupportInitialize)this.btnClose).EndInit();
			this.Panel4.ResumeLayout(false);
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Timer1.Tick += new System.EventHandler(Timer1_Tick);
			Button1.Click += new System.EventHandler(Button1_Click);
			base.Load += new System.EventHandler(Form1_Load);
			btnClose.MouseLeave += new System.EventHandler(btnClose_MouseLeave);
			btnClose.MouseEnter += new System.EventHandler(btnClose_MouseEnter);
			btnClose.Click += new System.EventHandler(btnClose_Click);
			btnMinimize.MouseLeave += new System.EventHandler(btnMinimize_MouseLeave);
			btnMinimize.MouseEnter += new System.EventHandler(btnMinimize_MouseEnter);
			btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
			btnHome.Click += new System.EventHandler(btnHome_Click);
			btnExpense.Click += new System.EventHandler(btnExpense_Click);
			btnUser.Click += new System.EventHandler(btnUser_Click);
			btnPurchaseDetails.Click += new System.EventHandler(btnPurchaseDetails_Click);
			btnSales.Click += new System.EventHandler(btnSales_Click);
			btnViewSales.Click += new System.EventHandler(btnViewSales_Click);
		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Button btnHome;
		internal System.Windows.Forms.Button btnViewSales;
		internal System.Windows.Forms.Button btnSales;
		internal System.Windows.Forms.Button btnPurchaseDetails;
		internal System.Windows.Forms.Button btnUser;
		internal System.Windows.Forms.Button btnExpense;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal WindowsApplication1.DragControlDemo.DragControl DragControl1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.PictureBox btnClose;
		internal System.Windows.Forms.PictureBox btnMinimize;

	}

}