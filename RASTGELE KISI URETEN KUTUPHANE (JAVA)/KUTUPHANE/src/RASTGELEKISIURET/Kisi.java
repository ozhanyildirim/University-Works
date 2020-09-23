/**
*
 OZHAN NURI YILDIRIM
 B161210109
 KUTUPHANEDE KISININ ADINI SOYADINI RASTGELE DOSYADAN CEKEN VE
 0-100 ARASI RASTGELE YAS OLUSTURAN SINIF
*
* 
* 
**/
package RASTGELEKISIURET;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;



/**
 *
 * @author PC
 */
public class Kisi {

    public Kisi() {
    }
    
    public ArrayList<String> olustur(int sayi) throws IOException{ 

        ArrayList<String> dosyaToplam = new ArrayList<>();
        String file = "random_isimler.txt";                     //random isimler dosyasý kontrolü
        try {
            BufferedReader reader = new BufferedReader(new FileReader(file));
            String satir = reader.readLine();
            while (satir!=null) {
                if(satir.length()>0){
                    dosyaToplam.add(satir);
                }
                satir = reader.readLine();                
            } 
            reader.close();
        } catch (FileNotFoundException ex) {
            System.err.println("random_isimler.txt Bulunamadý! ");
            return null;
        }
        
        
        
        String kisi="";
        Rastgele rnd ;
        
       ArrayList<String> gidecek = new ArrayList<>();           //RASTGELE KISI CEEKILIYOR
        for (int i = 0; i < sayi; i++) {
            rnd= new Rastgele();
            kisi="";
            kisi+=dosyaToplam.get(rnd.CallRastgeleSayi());
            
            kisi+=" "+(rnd.CallRastgeleSayi() +1 + rnd.CallRastgeleSayi());
            gidecek.add(kisi);
        }
        
        return gidecek;
    }
    
    
}
