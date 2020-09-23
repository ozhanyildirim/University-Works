/**
*
* OZHAN NURI YILDIRIM
* B161210109
* KUTUPHANEDE RASTGELELEGI SAGLAYAN SINIF.

**/
package RASTGELEKISIURET;

public class Rastgele {
    
     private final int rastgele;     
  public Rastgele() {
        
      rastgele = (int) ((System.nanoTime() / 100) % 10); //NANOTIME FONK. KULLANILARAK RASTGELELIK OLUSTURULDU
      
    } 
    public int CallRastgeleSayi() {         //RASTGELE SAYIYI CAGIRMA
        return rastgele;
    }

    
}
