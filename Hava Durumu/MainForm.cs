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
		
		#region Svg Render
		public static Bitmap GetBitmapFromSVG(string filePath)
        {
				SvgDocument de = SvgDocument.Open(filePath);
				//SvgDocument document = GetSvgDocument(filePath);
          
	            Bitmap bmp=de.Draw();
	            return bmp;
            
        }
		
		#endregion
		
		#region Form load
		void MainFormLoad(object sender, EventArgs e)
		{
			List<iller> iller = new GetirGotur().ilGetir();
			foreach (iller il in iller) {
				cmbIller.Items.Add(il.Il);
			}
		}
		#endregion
		
		#region btnKapat
		void btnKapatClick(object sender, EventArgs e)
		{
			this.Close();
	
		}
		#endregion
		
		#region Il combobox il secildigi zaman isler
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
		#endregion
		
		#region ilce secildigi zaman yapilacak islem
		void CmbIlcelerSelectedIndexChanged(object sender, EventArgs e)
		{
			var MerkezId = ilceler[cmbIlceler.SelectedIndex];
			List<Gunluk> gunluk = new GetirGotur().gunlukGetir(MerkezId.MerkezId);
			pictureBox1.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun1+".svg");
			pictureBox2.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun2+".svg");
			pictureBox3.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun3+".svg");
			pictureBox4.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun4+".svg");
			pictureBox5.Image = GetBitmapFromSVG(svgYol+gunluk[0].HadiseGun5+".svg");
			lblDus1.Text = gunluk[0].EnDusukGun1.ToString();
			lblDus2.Text = gunluk[0].EnDusukGun2.ToString();
			lblDus3.Text = gunluk[0].EnDusukGun3.ToString();
			lblDus4.Text = gunluk[0].EnDusukGun4.ToString();
			lblDus5.Text = gunluk[0].EnDusukGun5.ToString();
			lblYuk1.Text = gunluk[0].EnYuksekGun1.ToString();
			lblYuk2.Text = gunluk[0].EnYuksekGun2.ToString();
			lblYuk3.Text = gunluk[0].EnYuksekGun3.ToString();
			lblYuk4.Text = gunluk[0].EnYuksekGun4.ToString();
			lblYuk5.Text = gunluk[0].EnYuksekGun5.ToString();
			lblNemDus1.Text = gunluk[0].EnDusukNemGun1.ToString();
			lblNemDus2.Text = gunluk[0].EnDusukNemGun2.ToString();
			lblNemDus3.Text = gunluk[0].EnDusukNemGun3.ToString();
			lblNemDus4.Text = gunluk[0].EnDusukNemGun4.ToString();
			lblNemDus5.Text = gunluk[0].EnDusukNemGun5.ToString();
			lblNemYuk1.Text = gunluk[0].EnYuksekNemGun1.ToString();
			lblNemYuk2.Text = gunluk[0].EnYuksekNemGun2.ToString();
			lblNemYuk3.Text = gunluk[0].EnYuksekNemGun3.ToString();
			lblNemYuk4.Text = gunluk[0].EnYuksekNemGun4.ToString();
			lblNemYuk5.Text = gunluk[0].EnYuksekNemGun5.ToString();
			lblHiz1.Text = gunluk[0].RuzgarHizGun1.ToString();
			lblHiz2.Text = gunluk[0].RuzgarHizGun2.ToString();
			lblHiz3.Text = gunluk[0].RuzgarHizGun3.ToString();
			lblHiz4.Text = gunluk[0].RuzgarHizGun4.ToString();
			lblHiz5.Text = gunluk[0].RuzgarHizGun5.ToString();
			
	
		}
		#endregion
		
	}
}
