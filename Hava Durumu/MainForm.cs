/*
 * Created by SharpDevelop.
 * User: ramazan
 * Date: 4/16/2018
 * Time: 5:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Svg;
using Newtonsoft.Json;
namespace Hava_Durumu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string svgYol = @"Resimler\Hadiseler\";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static Bitmap GetBitmapFromSVG(string filePath)
        {
				SvgDocument de = SvgDocument.Open(filePath);
				//SvgDocument document = GetSvgDocument(filePath);
          
	            Bitmap bmp=de.Draw();
	            return bmp;
            
        }
		void MainFormLoad(object sender, EventArgs e)
		{
			List<iller> iller = new GetirGotur().ilGetir();
			foreach (iller il in iller) {
				cmbIller.Items.Add(il.Il);
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
	
		}
		List<iller> ilceler = new List<iller>();
		void CmbIllerSelectedIndexChanged(object sender, EventArgs e)
		{
			ilceler = new GetirGotur().ilceGetir(cmbIller.SelectedItem.ToString());
			cmbIlceler.Items.Clear();
			foreach (iller ilce in ilceler) {
				cmbIlceler.Items.Add(ilce.Ilce);
			}
			cmbIlceler.SelectedIndex = 0;
		}
		/*void CmbIlcelerSelectedIndexChanged(object sender, EventArgs e)
		{
			var MerkezId = ilceler[cmbIlceler.SelectedIndex];
			List<Gunluk> gunluk = new GetirGotur().gunlukGetir(MerkezId.MerkezId);
			pictureBox1.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun1+".svg");
			pictureBox2.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun2+".svg");
			pictureBox3.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun3+".svg");
			pictureBox4.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun4+".svg");
			pictureBox5.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun5+".svg");
			
	
		}*/
		
	}
}
