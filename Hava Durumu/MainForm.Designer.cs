/*
 * Created by SharpDevelop.
 * User: ramazan
 * Date: 4/18/2018
 * Time: 1:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hava_Durumu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cmbIller;
		private System.Windows.Forms.ComboBox cmbIlceler;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.cmbIller = new System.Windows.Forms.ComboBox();
			this.cmbIlceler = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(863, 31);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(830, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(34, 32);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// cmbIller
			// 
			this.cmbIller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbIller.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbIller.FormattingEnabled = true;
			this.cmbIller.Location = new System.Drawing.Point(13, 38);
			this.cmbIller.Name = "cmbIller";
			this.cmbIller.Size = new System.Drawing.Size(290, 25);
			this.cmbIller.TabIndex = 1;
			this.cmbIller.SelectedIndexChanged += new System.EventHandler(this.CmbIllerSelectedIndexChanged);
			// 
			// cmbIlceler
			// 
			this.cmbIlceler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbIlceler.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbIlceler.FormattingEnabled = true;
			this.cmbIlceler.Location = new System.Drawing.Point(507, 38);
			this.cmbIlceler.Name = "cmbIlceler";
			this.cmbIlceler.Size = new System.Drawing.Size(290, 25);
			this.cmbIlceler.TabIndex = 2;
			this.cmbIlceler.SelectedIndexChanged += new System.EventHandler(this.CmbIlcelerSelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 468);
			this.Controls.Add(this.cmbIlceler);
			this.Controls.Add(this.cmbIller);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		}
	}

