/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI…...:	1. ÖDEV
** ÖĞRENCİ ADI...............: ÖZHAN NURİ YILDIRIM
** ÖĞRENCİ NUMARASI.: B161210109 
** DERS GRUBU…………:		1/A
****************************************************************************/




// ConsoleApplication1.cpp : Bu dosya 'main' işlevi içeriyor. Program yürütme orada başlayıp biter.
//
#include <windows.h>
#include <fstream>
#include <iostream>
#include <stdio.h>
#include <string>
#include <iomanip>
using namespace std;

int main(int argc, char* argv[])
{


	setlocale(LC_ALL, "Turkish");			// TURKCE KARAKTER DESTEKLENMESI ICIN KOD
		
	int secim, i = 1;
	string urunAdi;
	string marka;					
	string urunNo;
	string birimFiyat;						// TANIMLAMALAR
	string birim;

	string tarih;
	
	char cevap = 'e';

	string projeNo;
	string projeAdi;
	string firma;
	string sorumlu;
	string kontrol;

	string hakedis;



	do {
		cout << " Ne yapmak istiyorsunuz ? " << endl;				// URUN VE PROJE BOLUMU ICIN 2 AYRI GIRIS
		cout << " 1) ÜRÜNLERE GİRİŞ " << endl;
		cout << " 2) PROJEYE GİRİŞ " << endl;

		cin >> secim;
		system("cls");
	} while (secim != 1 && secim != 2);						// SECENEKLER ICIN DO WHILE KULLANILDI

	if (secim == 1)
	{


		do {
			cout << " Ne yapmak istiyorsunuz ? " << endl;
			cout << " 1) Ürün ekleme " << endl;							//	URUN MENUSU
			cout << " 2) Ürün Sil " << endl;
			cout << " 3) Ürün Arama " << endl;
			cout << " 4) Ürün Raporla" << endl;



			cin >> secim;


		} while (secim != 1 && secim != 2 && secim != 3 && secim != 4);

		if (secim == 1)
		{
			ofstream DosyaYaz;
			DosyaYaz.open("Urun.txt", ios::app);

			do
			{

				cout << "\n ÜRÜN NO :"; cin >> urunNo;
				cout << "\n ÜRÜN ADI :"; cin >> urunAdi;
				cout << "\n ÜRÜN MARKASI :"; cin >> marka;
				cout << "\n BİRİM :"; cin >> birim;
				cout << "\n BİRİM FİYAT :"; cin >> birimFiyat;
				DosyaYaz << urunNo << " " << urunAdi << " " << marka << " " << birim << " " << birimFiyat << " " << endl;

				cout << "\n baska ürün ekleyecek misin? (e/h) "; cin >> cevap;

			} while (!(cevap == 'h'));
			DosyaYaz.close();
			cout << "ürün ekleme tamamlandi. ";

		}

		if (secim == 2)
		{
			string urun_No;
			cout << " ÜRÜN NO :"; cin >> urun_No;
			fstream DosyaOku, DosyaYaz;

			DosyaOku.open("Urun.txt", ios::in); DosyaYaz.open("gecici.txt", ios::out | ios::app);

			if (DosyaOku.is_open() == 1) {		// Üzerine yazarak silinme metodu kullanildi.
				if (DosyaYaz.is_open() == 1) {
					while (DosyaOku >> urunNo >> urunAdi >> marka >> birim >> birimFiyat)
					{
						if (urun_No != urunNo) {
							DosyaYaz << urunNo << " " << urunAdi << " " << marka << " " << birim << " " << birimFiyat << " " << endl;


						}

					}
				}		cout << "silme islemi tamamlandi";
				// / *DOSYALAMA BİTİSİ * /
				DosyaOku.close(); DosyaYaz.close();
				remove("Urun.txt");
				rename("gecici.txt", "Urun.txt");

			}



		}
		if (secim == 3)
		{
			string urun_No; cout << " Urun No :"; cin >> urun_No;
			ifstream DosyaOku("Urun.txt");
			while (!DosyaOku.eof())
			{
				DosyaOku >> urunNo >> urunAdi >> marka >> birim >> birimFiyat;

				if (urun_No == urunNo)

				{
					cout << "\nAradığınız Ürün \n";
					cout << "--------------------------------" << endl;
					cout << "ÜRÜN NO :" << urunNo << endl;
					cout << "ÜRÜN ADI :" << urunAdi << endl;
					cout << "ÜRÜN MARKASI :" << marka << endl;
					cout << "BİRİM :" << birim << endl;
					cout << "BİRİM FİYAT :" << birimFiyat << endl;
					cout << "-------------------------------- \n";



					
				}

			}
			DosyaOku.close();

		}










		if (secim == 4)
		{
			string satir = " ";
			cout << "TÜM ÜRÜNLER \n";
			ifstream DosyaOku("Urun.txt");

			while (getline(DosyaOku, satir))
			{
				//DosyaOku >> urunNo >> urunAdi >> marka >> birim >> birimFiyat;

				cout << satir << endl;
				/*cout << "--------------------------------" << endl;
				cout << "ÜRÜN NO :" << urunNo << endl;
				cout << "ÜRÜN ADI :" << urunAdi << endl;
				cout << "ÜRÜN MARKASI :" << marka << endl;
				cout << "BİRİM :" << birim << endl;
				cout << "BİRİM FİYAT :" << birimFiyat << endl;
				cout << "--------------------------------" << endl;*/



			}
			DosyaOku.close();
			system("PAUSE");
			exit(1);

		}
		system("PAUSE");
		exit(1);
		
	}


	// PROJE BÖLÜMÜ 

	if (secim == 2)
	{
		cout << "-------------------------------\n";
		cout << "PROJE BÖLÜMÜNE GİRİŞ YAPILDI \n";
		cout << "-------------------------------\n";

		do {
			cout << " Ne yapmak istiyorsunuz ? " << endl;
			cout << " 1) Proje Ekle " << endl;
			cout << " 2) Proje Sil " << endl;
			cout << " 3) Proje Arama " << endl;
			cout << " 4) Proje Raporla" << endl;
			cout << " 5) Hakedis Ekle" << endl;
			cout << " 6) Hakedis islemleri " << endl;


			cin >> secim;


		} while (secim != 1 && secim != 2 && secim != 3 && secim != 4 && secim != 5 && secim != 6);

		if (secim == 1)
		{
			ofstream DosyaYaz;
			DosyaYaz.open("Proje.txt", ios::app);
			do
			{


				cout << "\n PROJE NO : "; cin >> projeNo;
				cout << "\n PROJE ADI :"; cin >> projeAdi;
				cout << "\n PROJE YÜRÜTÜCÜ FİRMA :"; cin >> firma;
				cout << "\n PROJE SORUMLUSU:"; cin >> sorumlu;
				cout << "\n PROJE KONTROLÖRÜ :"; cin >> kontrol;
				DosyaYaz << projeNo << " " << projeAdi << " " << firma << " "
					<< sorumlu << " " << kontrol << endl;
				cout << "\n baska proje ekleyecek misin? (e/h) ";
				cin >> cevap;

			} while (!(cevap == 'h'));

			DosyaYaz.close();
			cout << "proje ekleme tamamlandi. ";
		}

		if (secim == 2) {

			string proje_No;
			cout << " PROJE NO :"; cin >> proje_No;
			fstream DosyaOku, DosyaYaz;

			DosyaOku.open("Proje.txt", ios::in); DosyaYaz.open("gecici.txt", ios::out | ios::app);

			if (DosyaOku.is_open() == 1) {		// Üzerine yazarak silinme metodu kullanildi.
				if (DosyaYaz.is_open() == 1) {
					while (DosyaOku >> projeNo >> projeAdi >> firma >> sorumlu >> kontrol) {
						if (proje_No != projeNo) {
							DosyaYaz << projeNo << " " << projeAdi << " " << firma << " "
								<< sorumlu << " " << kontrol << endl;


						}

					}
				}			cout << "silme islemi tamamlandi";
				// / *DOSYALAMA BİTİSİ * /
				DosyaOku.close(); DosyaYaz.close();
				remove("Proje.txt");
				rename("gecici.txt", "Proje.txt");
			}
		}

		if (secim == 3)
		{
			string proje_no; cout << " Proje No :"; cin >> proje_no;
			ifstream DosyaOku("Proje.txt");										// PROJE DOSYA OKUMA
			while (!DosyaOku.eof())
			{
				DosyaOku >> projeNo >> projeAdi >> firma >> sorumlu >> kontrol;
				if (proje_no == projeNo)									// PROJE MENU GIRIS
				{
					cout << "\nAradığınız Proje \n";
					cout << "--------------------------------" << endl;
					cout << "PROJE NO :" << projeNo << endl;
					cout << "PROJE ADI :" << projeAdi << endl;
					cout << "PROJE YÜRÜTÜCÜ FİRMA :" << firma << endl;
					cout << "PROJE SORUMLUSU :" << sorumlu << endl;
					cout << "PROJE KONTROLORÜ :" << kontrol << endl;
					cout << "-------------------------------- " << endl;
				}
			}
		}
		if (secim == 4)
		{
			cout << "TÜM PROJELER \n";
			ifstream DosyaOku("Proje.txt");
			while (!DosyaOku.eof())
			{
				DosyaOku >> projeNo >> projeAdi >> firma >> sorumlu >> kontrol;

				cout << "--------------------------------" << endl;
				cout << "PROJE NO :" << projeNo << endl;
				cout << "PROJE ADI :" << projeAdi << endl;
				cout << "PROJE YÜRÜTÜCÜ FİRMA :" << firma << endl;
				cout << "PROJE SORUMLUSU :" << sorumlu << endl;
				cout << "PROJE KONTROLORÜ :" << kontrol << endl;
				cout << "-------------------------------- \n";

			}
		}
		string projeno, urunno, birim1, birimFiyat1;
		if (secim == 5)
		{

			cout << " Proje No :"; cin >> projeno;

			ifstream DosyaOku("Proje.txt");
			while (!DosyaOku.eof())
			{
				DosyaOku >> projeNo;
				if (projeno == projeNo)
				{
					DosyaOku.close();

					ofstream DosyaYaz;
					DosyaYaz.open("Hakedis.txt", ios::app);											//HAKEDIS ISLEMLERI
					cout << "HAKEDIS SURESI EKLEYINIZ (orn : 1 )" << endl; cin >> hakedis;


					cout << "URUN NO GIRINIZ " << endl;  cin >> urunno;
					ifstream DosyaOku("Urun.txt");
					while (!DosyaOku.eof())
					{
						DosyaOku >> urunNo;

						if (urunno == urunNo)							// HAKEDIS URUN EKLEME URUN NUMARASI ALINARAK YAPILDI
						{
							DosyaOku.close();

							cout << "URUN ADEDI EKLE  :  " << endl; cin >> birim1;
							cout << "BIRIM FIYAT   :" << endl; cin >> birimFiyat1;

							DosyaYaz << projeno << " " << hakedis << " " << urunno << " " << birim1 << " " << birimFiyat1 << endl;
							DosyaYaz.close();

							cout << "HAKEDIS EKLEME ISLEMI BASARILI " << endl;
							system("PAUSE");
							exit(1);

						}
					}

				}
			}

		}

		if (secim == 6)
		{
			do {

				cout << "YAPMAK ISTEDIGINIZ ISLEM " << endl;
				cout << " 1) URUNLERI SIL \n";										// HAKEDIS ISLEM MENUSU URUN NUMARASINA GORE YAPILDI
				cout << " 2) URUNLERI GUNCELLE \n";
				cout << " 3) URUNLERI LISTELE \n";
				cout << " 4) URUNLERDE ARAMA YAP \n";
				cin >> secim;


			} while (secim != 1 && secim != 2 && secim != 3 && secim != 4);

			if (secim == 1)
			{
				string urun_no;
				cout << " HAKEDISTEKI URUN NO :"; cin >> urun_no;
				fstream DosyaOku, DosyaYaz;

				DosyaOku.open("Hakedis.txt", ios::in); DosyaYaz.open("gecici.txt", ios::out | ios::app);

				if (DosyaOku.is_open() == 1) {		// Üzerine yazarak silinme metodu kullanildi.
					if (DosyaYaz.is_open() == 1) {
						while (DosyaOku >> projeno >> hakedis >> urunno >> birim1 >> birimFiyat1) {

							if (urun_no != urunno) {

								DosyaYaz << projeno << " " << hakedis << " " << urunno << " " << birim1 << " " << birimFiyat1 << endl;

							}

						}
					}			cout << "silme islemi tamamlandi";
					// / *DOSYALAMA BİTİSİ * /
					DosyaOku.close(); DosyaYaz.close();
					remove("Hakedis.txt");
					rename("gecici.txt", "Hakedis.txt");
				}
			}

			if (secim == 2)
			{
				string urun_noo;
				system("cls");  //Ekran temizleme komutu

				cout << "******  HAKEDIS URUN GUNCELLEME  ******" << endl;

				ifstream DosyaOku("Hakedis.txt"); //Dosya çıkışı yapabilmek için gerekli kodu yazdım.
				ofstream DosyaYaz("gecici.tmp");//Gecici bir dosya açılır
				// DosyaYaz.open("gecici.tmp",ios::app); //gecici.tmp adımda dosya oluşturup dosya ekleme modunda açtım

				cout << "URUN NO...:"; cin >> urun_noo; //düzenlenecek urun numarasını sorgulattım.

				int gcc = 0;
				while (!(DosyaOku.eof())) //DosyaOku da belirttiğim Hakedis.txt dosyasını sonuna kadar okuttum.
				{
					DosyaOku >> projeno >> hakedis >> urunno >> birim1 >> birimFiyat1;//Hakedis.txt dosyasındaki kayıtlar okunur

					if (urun_noo == urunno)//Sorgulanan urun numarası varsa Hakedis bilgilerini gösterir.
					{
						cout << "========== Hasta Bilgileri ==========" << endl << endl;//Hakedis bilgieri yazdırılır.

						cout << "\nAradığınız Urun \n";
						cout << "--------------------------------" << endl;
						cout << "PROJE NO :" << projeno << endl;
						cout << "HAKEDIS NO :" << hakedis << endl;
						cout << "URUN NO :" << urun_noo << endl;
						cout << "BIRIM :" << birim1 << endl;
						cout << "BIRIM FIYAT :" << birimFiyat1 << endl;
						cout << "-------------------------------- " << endl;

						cout << "Birim ve Birim Fiyat Bilgilerini Yenileyiniz..." << endl << endl;//Hakedis bilgilerini dışardan girdirilir
				

						cout << "\n DEGISTIRILECEK BIRIM :"; cin >> birim1;
						cout << "\n DEGISTIRILECEK BIRIM FIYAT :"; cin >> birimFiyat1;

						DosyaYaz << projeno << " " << hakedis << " " << urunno << " " << birim1 << " " << birimFiyat1 << endl;//Düzenlenen dosya bilgileri yazdırılır.

						gcc = 1;
					}
					else
					{
						DosyaYaz << projeno << " " << hakedis << " " << urunno << " " << birim1 << " " << birimFiyat1 << endl;
					}
				
				if (gcc == 0)
					cout << "Boyle Bir Kayit Bulunamamistir..." << endl;


				cout << "GUNCELLEME İŞLEMİ TAMAMLANDI \n";
				DosyaYaz.close();
				DosyaOku.close();
				}
				remove("Hakedis.txt");// Hakedis.txt dosyası silinirken
				rename("gecici.tmp", "Hakedis.txt");//gecici.tmp dosyası Hakedis.txt dosyası olarak değiştirirlir.
			}

			
			if (secim == 3)
			{
				string satir = " ";
				cout << "TÜM ÜRÜNLER \n";
				ifstream DosyaOku("Hakedis.txt");

				while (getline(DosyaOku, satir))
				{
	
					cout << satir << endl;
			
				}
				DosyaOku.close();
				system("PAUSE");
				exit(1);


				
			}
			if (secim == 4)
			{
				string urun_no1; cout << " Urun No :"; cin >> urun_no1;
				ifstream DosyaOku("Hakedis.txt");
				while (!DosyaOku.eof())
				{
					DosyaOku >> projeno >> hakedis >> urunno >> birim1 >> birimFiyat1;
					if (urun_no1 == urunno)
					{
						cout << "\nAradığınız Urun \n";
						cout << "--------------------------------" << endl;
						cout << "PROJE NO :" << projeno << endl;
						cout << "HAKEDIS NO :" << hakedis << endl;
						cout << "URUN NO :" << urunno << endl;
						cout << "BIRIM :" << birim1 << endl;
						cout << "BIRIM FIYAT :" << birimFiyat1 << endl;
						cout << "-------------------------------- " << endl;
					}
				}
				DosyaOku.close();
			}

		}
	}


}
