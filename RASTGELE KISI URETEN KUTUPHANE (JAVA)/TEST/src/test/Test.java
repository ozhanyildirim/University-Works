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
        
            
                 while(true){                 // Çýkýþ seçilene kadar dönen döngü
            ArrayList<String> kisiList =new ArrayList<>();
            System.out.println("1- Rastgele Kiþi Üret\n"+
                    "2- Üretilmiþ Dosya Kontrol Et\n"+
                    "3- Çýkýþ\n");
            Scanner s = new Scanner(System.in);
            String secim = s.nextLine();
            
            
            if (secim.equals("1")) { //Rastgele kiþi üret secildi
                System.out.print("\nÜretilecek kiþi sayýsý: ");
                Scanner s1 = new Scanner(System.in);
                String sayi = s1.nextLine();
                if (sayi!=null && sayi.matches("^([1-9]{1}[0-9]*)$")) { //üretilecek kisi adedi pozitif sayý mý ?
                    RastgeleKisi rastgeleKisi = new RastgeleKisi(); //rasgeleKisi sýnýfýndan nesne olusturup
                    ArrayList<String> rasgeleKisiList = rastgeleKisi.uret(Integer.valueOf(sayi)); // bu nesnenin uret fonksiyoundan istenen sayýda kiþi üretildi.
                    File file = new File("Kisiler.txt");
                    if (!file.exists()) {  //dosya yoksa
                        System.out.println("Dosya yoktu oluþturuldu.\n");
                        file.createNewFile();
                    }
                    FileWriter fileWriter = new FileWriter(file, true); //Dosya varsa yeniden oluþturmaz üzerine ekleme yapar!
                    try (BufferedWriter bWriter = new BufferedWriter(fileWriter)) {
                        for (int i = 0; i < Integer.valueOf(sayi); i++) {
                            bWriter.write(rasgeleKisiList.get(i));
                            bWriter.newLine();
                        }
                        bWriter.close();
                        System.out.println("\nYazdýrma Ýþlemi Baþarýlý!\n");
                    }catch(Error e){
                        System.err.println("\nBufferedWriter olusturulurken hata! Lütfen tekrar deneyiniz.\n");
                    }
                    
                }else{
                    System.out.println("\nYanlýþ Giriþ Yaptýnýz!\n");
                }
            }else if(secim.equals("2")){ // Üretilmis dosyayý kontrol et seçildi.
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
                            String regex = "^[1-9]{1}[0-9]{10}"; // Tc no kontrolü
                            Pattern pattern = Pattern.compile(regex);
                            Matcher matcher = pattern.matcher(satir);
                            if (matcher.find()) { //Tc noya benzer sayýlar bulunduysa
                                if (kimlikNo.dogruMu(matcher.group(0))) { //Tc noyu kontrol et
                                    gecerliTc++; // dogruysa ilgili desikeni arttýr
                                }else{
                                    gecersizTc++; // yanlýssa yine ilgili deðiskeni arttýr
                                }
                            }else{
                                gecersizTc++; // satýrda yok demektir.
                            }
                            
                            String regex1 = "[(]([0-9]{15})[)]$"; //imei kontrolü
                            Pattern pattern1 = pattern.compile(regex1, Pattern.MULTILINE);
                            Matcher matcher1 = pattern1.matcher(satir);
                            if (matcher1.find()) { //yukarýdaki iþlemlerin tekrarý
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
                    System.out.println("T.C. Kimlik Kontrol\n"+ //kontrollerin ekrana yazdýrýlmasý
                            gecerliTc+"\tGeçerli\n"+
                            gecersizTc+"\tGeçersiz\n\n"+
                            "IMEI Kontrol\n"+
                            gecerliImei+"\tGeçerli\n"+
                            gecersizImei+"\tGeçersiz\n");
                    
                }catch(FileNotFoundException e){
                System.out.println("\nKisiler.txt Bulunamadý!\n");
                }
            }else if(secim.equals("3")){ // 3 seçildi çýkýþ yap
                System.out.println("\nÇýkýþ Yapýlýyor!");
                break;
            }
            else {
                System.out.println("\nHatalý Seçim Yaptýnýz!\n");
            }
                
            
        }       
    } 
}
