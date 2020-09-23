/**
*
* OZHAN NURI YILDIRIM
* B161210109
* KUTUPHANEDE KISI URETEN VE BELLI KISILERI RASTGELE TUTAN SINIF.

**/
package RASTGELEKISIURET;

import java.io.IOException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author PC
 */
public class RastgeleKisi {

    public RastgeleKisi() {
    }
    
    public ArrayList<String> uret(int sayi){
        try {
            ArrayList<String> gidecek = new ArrayList<>();
            
            KimlikNo kimlikNo = new KimlikNo();
            Kisi kisi = new Kisi();
            Telefon telefon = new Telefon();
            IMEINo iMEINo = new IMEINo();
            
            ArrayList<String> kimlikNoList = kimlikNo.olustur(sayi);
            ArrayList<String> kisiList = kisi.olustur(sayi);
            ArrayList<String> telefonList = telefon.olustur(sayi);                  //RASTGELE KISI URETME
            ArrayList<String> imeiList = iMEINo.olustur(sayi);
            
            for (int i = 0; i < sayi; i++) {
                gidecek.add(kimlikNoList.get(i) + " " + 
                        kisiList.get(i) + " " + 
                        telefonList.get(i)+ " " +
                        imeiList.get(i));   
            }
            return gidecek;
        } catch (IOException ex) {
            Logger.getLogger(RastgeleKisi.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
}
