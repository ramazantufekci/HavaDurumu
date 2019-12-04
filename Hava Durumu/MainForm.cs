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
			//MessageBox.Show(cmbIlceler.Items.Count.ToString());
			cmbIlceler.SelectedIndex = 0;
		}
		#endregion
		
		#region ilce secildigi zaman yapilacak islem
		void CmbIlcelerSelectedIndexChanged(object sender, EventArgs e)
		{
			var MerkezId = ilceler[cmbIlceler.SelectedIndex].GunlukTahminIstNo;
			List<Gunluk> gunluk = new GetirGotur().gunlukGetir(MerkezId);
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
			Image image = GetBitmapFromSVG(svgYol+"ryon-gri.svg");
			pictureBox10.Image = RotateImage(image,gunluk[0].RuzgarYonGun1);
			pictureBox9.Image = RotateImage(image,gunluk[0].RuzgarYonGun2);
			pictureBox8.Image = RotateImage(image,gunluk[0].RuzgarYonGun3);
			pictureBox7.Image = RotateImage(image,gunluk[0].RuzgarYonGun4);
			pictureBox6.Image = RotateImage(image,gunluk[0].RuzgarYonGun5);
			lblTarih1.Text = gunluk[0].TarihGun1.Replace("T00:00:00.000Z","");
			lblTarih2.Text = gunluk[0].TarihGun2.Replace("T00:00:00.000Z","");
			lblTarih3.Text = gunluk[0].TarihGun3.Replace("T00:00:00.000Z","");
			lblTarih4.Text = gunluk[0].TarihGun4.Replace("T00:00:00.000Z","");
			lblTarih5.Text = gunluk[0].TarihGun5.Replace("T00:00:00.000Z","");
			
	
		}
		#endregion
		
		#region Resim cevirme
		public static Bitmap RotateImage(Image image, PointF offset, float angle)
		{
		    if (image == null)
		        throw new ArgumentNullException("image");
		        
		    //create a new empty bitmap to hold rotated image
		    Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
		    rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
		    
		    //make a graphics object from the empty bitmap
		    Graphics g = Graphics.FromImage(rotatedBmp);
		    
		    //Put the rotation point in the center of the image
		    g.TranslateTransform(offset.X, offset.Y);
		    
		    //rotate the image
		    g.RotateTransform(angle);
		    
		    //move the image back
		    g.TranslateTransform(-offset.X, -offset.Y);
		    
		    //draw passed in image onto graphics object
		    g.DrawImage(image, new PointF(0, 0));
		    
		    return rotatedBmp;
		}
		#endregion
       public static Bitmap RotateImage(Image image, float angle)
		{
       		return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }

		
	
		

		
	}
}
