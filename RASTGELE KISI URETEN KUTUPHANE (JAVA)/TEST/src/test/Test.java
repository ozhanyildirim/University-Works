/**
/**
*
* OZHAN NURI YILDIRIM
* B161210109
* KUTUPHANEYI TEST ETMEK ICIN OLUSTURULAN TEST PROJESI.
*/


package test;

import RASTGELEKISIURET.IMEINo;
import RASTGELEKISIURET.KimlikNo;
import RASTGELEKISIURET.RastgeleKisi;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Test {

  
    public static void main(String[] args) throws IOException {
        
            
                 while(true){                 // ��k�� se�ilene kadar d�nen d�ng�
            ArrayList<String> kisiList =new ArrayList<>();
            System.out.println("1- Rastgele Ki�i �ret\n"+
                    "2- �retilmi� Dosya Kontrol Et\n"+
                    "3- ��k��\n");
            Scanner s = new Scanner(System.in);
            String secim = s.nextLine();
            
            
            if (secim.equals("1")) { //Rastgele ki�i �ret secildi
                System.out.print("\n�retilecek ki�i say�s�: ");
                Scanner s1 = new Scanner(System.in);
                String sayi = s1.nextLine();
                if (sayi!=null && sayi.matches("^([1-9]{1}[0-9]*)$")) { //�retilecek kisi adedi pozitif say� m� ?
                    RastgeleKisi rastgeleKisi = new RastgeleKisi(); //rasgeleKisi s�n�f�ndan nesne olusturup
                    ArrayList<String> rasgeleKisiList = rastgeleKisi.uret(Integer.valueOf(sayi)); // bu nesnenin uret fonksiyoundan istenen say�da ki�i �retildi.
                    File file = new File("Kisiler.txt");
                    if (!file.exists()) {  //dosya yoksa
                        System.out.println("Dosya yoktu olu�turuldu.\n");
                        file.createNewFile();
                    }
                    FileWriter fileWriter = new FileWriter(file, true); //Dosya varsa yeniden olu�turmaz �zerine ekleme yapar!
                    try (BufferedWriter bWriter = new BufferedWriter(fileWriter)) {
                        for (int i = 0; i < Integer.valueOf(sayi); i++) {
                            bWriter.write(rasgeleKisiList.get(i));
                            bWriter.newLine();
                        }
                        bWriter.close();
                        System.out.println("\nYazd�rma ��lemi Ba�ar�l�!\n");
                    }catch(Error e){
                        System.err.println("\nBufferedWriter olusturulurken hata! L�tfen tekrar deneyiniz.\n");
                    }
                    
                }else{
                    System.out.println("\nYanl�� Giri� Yapt�n�z!\n");
                }
            }else if(secim.equals("2")){ // �retilmis dosyay� kontrol et se�ildi.
                KimlikNo kimlikNo = new KimlikNo();
                IMEINo iMEINo = new IMEINo();
                File file = new File("Kisiler.txt");
                try (BufferedReader reader = new BufferedReader(new FileReader(file))) {
                    String satir = reader.readLine();
                    int gecerliTc=0;
                    int gecersizTc=0;
                    int gecerliImei=0;
                    int gecersizImei=0;
                    while (satir!=null) {
                        if(satir.length()>0){
                            String regex = "^[1-9]{1}[0-9]{10}"; // Tc no kontrol�
                            Pattern pattern = Pattern.compile(regex);
                            Matcher matcher = pattern.matcher(satir);
                            if (matcher.find()) { //Tc noya benzer say�lar bulunduysa
                                if (kimlikNo.dogruMu(matcher.group(0))) { //Tc noyu kontrol et
                                    gecerliTc++; // dogruysa ilgili desikeni artt�r
                                }else{
                                    gecersizTc++; // yanl�ssa yine ilgili de�iskeni artt�r
                                }
                            }else{
                                gecersizTc++; // sat�rda yok demektir.
                            }
                            
                            String regex1 = "[(]([0-9]{15})[)]$"; //imei kontrol�
                            Pattern pattern1 = pattern.compile(regex1, Pattern.MULTILINE);
                            Matcher matcher1 = pattern1.matcher(satir);
                            if (matcher1.find()) { //yukar�daki i�lemlerin tekrar�
                                if (iMEINo.dogruMu(matcher1.group(1))) {
                                    gecerliImei++;
                                }else{
                                    gecersizImei++;
                                }
                            }else{
                                gecersizImei++;
                            }
                        }
                        satir = reader.readLine();
                    }
                    reader.close();
                    System.out.println("T.C. Kimlik Kontrol\n"+ //kontrollerin ekrana yazd�r�lmas�
                            gecerliTc+"\tGe�erli\n"+
                            gecersizTc+"\tGe�ersiz\n\n"+
                            "IMEI Kontrol\n"+
                            gecerliImei+"\tGe�erli\n"+
                            gecersizImei+"\tGe�ersiz\n");
                    
                }catch(FileNotFoundException e){
                System.out.println("\nKisiler.txt Bulunamad�!\n");
                }
            }else if(secim.equals("3")){ // 3 se�ildi ��k�� yap
                System.out.println("\n��k�� Yap�l�yor!");
                break;
            }
            else {
                System.out.println("\nHatal� Se�im Yapt�n�z!\n");
            }
                
            
        }       
    } 
}
