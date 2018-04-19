/*
 * Created by SharpDevelop.
 * User: ramazan
 * Date: 4/17/2018
 * Time: 3:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Hava_Durumu
{
	/// <summary>
	/// Description of GetirGotur.
	/// </summary>
	public class GetirGotur
	{
		string illerUrl = "https://servis.mgm.gov.tr/api/merkezler/iller";
		string ilceUrl = "https://servis.mgm.gov.tr/api/merkezler/ililcesi?il=";
		string gunlukUrl = "https://servis.mgm.gov.tr/api/tahminler/gunluk?istno=";

		public List<iller> ilGetir()
		{
			List<iller> Iller = new List<iller>();
			try {
					using(WebClient wClient = new WebClient())
				{
					wClient.Encoding = Encoding.UTF8;
					var response = wClient.DownloadString(illerUrl);
					Iller = JsonConvert.DeserializeObject<List<iller>>(response);
					
				}
				
			} catch (Exception) {
				
				System.Windows.Forms.MessageBox.Show("illeri çekerken sorun oldu!!!");
			} 
			return Iller;
		}
		
		public List<iller> ilceGetir(string ilce)
		{
			List<iller> ilceler = new List<iller>();
			try {
				using(WebClient wClient = new WebClient())
				{
					wClient.Encoding = Encoding.UTF8;
					var response = wClient.DownloadString(ilceUrl+ilce);
					ilceler = JsonConvert.DeserializeObject<List<iller>>(response);
					
				}
				
			} catch (Exception ex) {
				
				System.Windows.Forms.MessageBox.Show("ilçeleri çekerken sorun oldu!!!"+ex.Message);
			} 
			return ilceler;
		}
		
		public List<Gunluk> gunlukGetir(int merkezId)
		{
			List<Gunluk> gunluk = new List<Gunluk>();
			try {
				using(WebClient wClient = new WebClient())
				{
					wClient.Encoding = Encoding.UTF8;
					var response = wClient.DownloadString(gunlukUrl+merkezId);
					gunluk = JsonConvert.DeserializeObject<List<Gunluk>>(response);
					
				}
				
			} catch (Exception ex) {
				
				System.Windows.Forms.MessageBox.Show("Günlük hava durumunu çekerken sorun oldu!!!"+ex.Message);
			} 
			return gunluk;
		}
		public GetirGotur()
		{
		}
	}
}
