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
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		//private System.Windows.Forms.Label label9;
		//private System.Windows.Forms.Label label1;
		//private System.Windows.Forms.Label label2;
		
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
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnKapat = new System.Windows.Forms.Button();
			this.cmbIller = new System.Windows.Forms.ComboBox();
			this.cmbIlceler = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel1.Controls.Add(this.btnKapat);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(863, 31);
			this.panel1.TabIndex = 0;
			// 
			// btnKapat
			// 
			this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
			this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnKapat.FlatAppearance.BorderSize = 0;
			this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKapat.Location = new System.Drawing.Point(830, 0);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(34, 32);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.UseVisualStyleBackColor = true;
			this.btnKapat.Click += new System.EventHandler(this.btnKapatClick);
			// 
			// cmbIller
			// 
			this.cmbIller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbIller.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbIller.FormattingEnabled = true;
			this.cmbIller.Location = new System.Drawing.Point(196, 38);
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
			this.cmbIlceler.Location = new System.Drawing.Point(558, 38);
			this.cmbIlceler.Name = "cmbIlceler";
			this.cmbIlceler.Size = new System.Drawing.Size(290, 25);
			this.cmbIlceler.TabIndex = 2;
			this.cmbIlceler.SelectedIndexChanged += new System.EventHandler(this.CmbIlcelerSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(489, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "ilçe seç :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(145, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "il seç :";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(145, 91);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(703, 365);
			this.panel2.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Maroon;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(3, 310);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(174, 55);
			this.label8.TabIndex = 5;
			this.label8.Text = "label8";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Maroon;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(3, 250);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(174, 55);
			this.label7.TabIndex = 4;
			this.label7.Text = "label7";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Maroon;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(3, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(174, 55);
			this.label6.TabIndex = 3;
			this.label6.Text = "label6";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Maroon;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(3, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(174, 55);
			this.label5.TabIndex = 2;
			this.label5.Text = "label5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Maroon;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(3, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 55);
			this.label4.TabIndex = 1;
			this.label4.Text = "label4";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Maroon;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 63);
			this.label3.TabIndex = 0;
			this.label3.Text = "TARIH";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Maroon;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(183, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(520, 20);
			this.label9.TabIndex = 6;
			this.label9.Text = "TARIH";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Maroon;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(183, 23);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 43);
			this.label10.TabIndex = 7;
			this.label10.Text = "TARIH";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 468);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbIlceler);
			this.Controls.Add(this.cmbIller);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}