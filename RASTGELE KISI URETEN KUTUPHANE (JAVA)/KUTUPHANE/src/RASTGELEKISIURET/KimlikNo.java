/**
*
* OZHAN NURI YILDIRIM
* B161210109
* KUTUPHANEDE TC KIMLIK NUMARASINI RASTGELE OLUSTURAN VE TC KONTORULUNU YAPAN SINIF.
*
* 
**/
package RASTGELEKISIURET;

import java.util.ArrayList;


/**
 *
 * @author PC
 */
public class KimlikNo {
    
    public KimlikNo() {
        
    }
    
    public String olustur(){
        ArrayList<Integer> numlist = new ArrayList<>();
        Rastgele rnd = new Rastgele();
      
        numlist.add(1 + rnd.CallRastgeleSayi() );
        
        int numara1 = 0;
        int numara2 = 0;
     
        for (int i=1;i<9;i++){                      //rastgele fonk. kullanýlarak rastgelelik saðlanmýþtýr
            rnd = new Rastgele();
            numlist.add(rnd.CallRastgeleSayi() );
        }

        for (int i=0;i<9;i+=2){
            rnd = new Rastgele();
            numara1 += numlist.get(i);
        }

        for (int i=1;i<8;i+=2){
            rnd = new Rastgele();
            numara2 += numlist.get(i);
        }

        int sonrakam = (numara1 * 7 - numara2) % 10;
        numlist.add(sonrakam);
        sonrakam=0;
        for(int i=0;i<10;i++) 
        sonrakam+= numlist.get(i);
        sonrakam= sonrakam % 10;

        numlist.add(sonrakam);
        String tcNo = "";
        for(int i=0;i<11;i++){
            tcNo = tcNo + Integer.toString(numlist.get(i));
        }


        return tcNo;
    }
    public ArrayList<String> olustur(int sayi){
        ArrayList<String> gidecek = new ArrayList<>();
        for (int i = 0; i < sayi; i++) {
            gidecek.add(olustur());
        }
        return gidecek;
    }
    
    
    public boolean dogruMu(Long tckn) {
	try {
		String tmp = tckn.toString();
		if (tmp.length() == 11) {
			int totalOdd = 0;
			int totalEven = 0;
			for (int i = 0; i < 9; i++) {
                            int val = Integer.valueOf(tmp.substring(i, i + 1));
                            if (i % 2 == 0) {
                                    totalOdd += val;
                            } else {
                                    totalEven += val;
                            }
			}
			int total = totalOdd + totalEven + Integer.valueOf(tmp.substring(9, 10));
			int lastDigit = total % 10;
                        
			if (tmp.substring(10).equals(String.valueOf(lastDigit))) {
                            int check = (totalOdd * 7 - totalEven) % 10;
                            if (tmp.substring(9, 10).equals(String.valueOf(check))) {
                                    return true;
                            }
			}
		}
	} catch (NumberFormatException e) {
            System.out.println("Tc no kontrolünde bir hata oluþtu :"+e);
	}
 
	return false;
    }
    public boolean dogruMu(String tckn) {
	if (null!=tckn && tckn.matches("^([1-9]{1}[0-9]{10})$")) {
		return dogruMu(Long.valueOf(tckn));
	}
	return false;
    }
    
}
