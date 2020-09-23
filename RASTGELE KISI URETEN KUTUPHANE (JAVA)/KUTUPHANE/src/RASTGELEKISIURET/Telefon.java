/**
*
* OZHAN NURI YILDIRIM
* B161210109

* KUTUPHANEDE KISILERIN TELEFON NUMARASINI TURKIYE STANDARTLARINDA
  VE RASTGELE OLUSTURAN SINIF.



**/
package RASTGELEKISIURET;

import java.util.ArrayList;


/**
 *
 * @author PC
 */
public class Telefon {

    public Telefon() {
    }
    
    public String olustur(){
        Rastgele rnd = new Rastgele();
     
        String no = "";
        no = "05";
         if (rnd.CallRastgeleSayi() < 5 ){              
            no += rnd.CallRastgeleSayi()+ 30 ;          //TELEFON NUMARASI URETME BÖLÜMÜ
        }
        if (rnd.CallRastgeleSayi() >5 ){
             no += rnd.CallRastgeleSayi()+ 50 ;
        }
        no += rnd.CallRastgeleSayi()+ 30 ;
        no += rnd.CallRastgeleSayi()*100 ;
        no += 99-rnd.CallRastgeleSayi()*10 ;
        no += 99-rnd.CallRastgeleSayi();
        
        return no;
    }
    public ArrayList<String> olustur(int sayi){
        ArrayList<String> gidecek = new ArrayList<>();
        for (int i = 0; i < sayi; i++) {
            gidecek.add(olustur());
        }
        
        return gidecek;
    }
}
