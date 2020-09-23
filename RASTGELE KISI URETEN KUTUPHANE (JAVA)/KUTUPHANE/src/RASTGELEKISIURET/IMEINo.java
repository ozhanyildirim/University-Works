/**
*
* 
* OZHAN NURI YILDIRIM
* B161210109
* KUTUPHANEDE RASTGELE VE STANDARTLARA UYGUN IMEI NUMARASI URETEN SINIF (ALGORITMA HAZIR OLARAK ALINMISTIR).
*
* 
**/
package RASTGELEKISIURET;

import java.util.ArrayList;

public class IMEINo {

    public IMEINo() {
    }
    
    public String olustur(){
        int pos;
        int[] str = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int sum = 0;
        int final_digit;
        int t;
        int len_offset;
        int len = 15;
        String imei = "";

        String[] rbi = new String[]{"01", "10", "30", "33", "35", "44", "45", "49", "50", "51", "52", "53", "54", "86", "91", "98", "99"};
        String[] arr = rbi[(int) Math.floor(Math.random() * rbi.length)].split("");
        str[0] = Integer.parseInt(arr[0]);
        str[1] = Integer.parseInt(arr[1]);
        pos = 2;

        while (pos < len - 1) {                             // IMEI ALGORITMASI HAZIR KULLANILMISTIR
            str[pos++] = (int) (Math.floor(Math.random() * 10) % 10);
        }

        len_offset = (len + 1) % 2;
        for (pos = 0; pos < len - 1; pos++) {
            if ((pos + len_offset) % 2 != 0) {
                t = str[pos] * 2;
                if (t > 9) {
                    t -= 9;
                }
                sum += t;
            } else {
                sum += str[pos];
            }
        }

        final_digit = (10 - (sum % 10)) % 10;
        str[len - 1] = final_digit;

        for (int d : str) {
            imei += String.valueOf(d);
        }

        return imei;
    }
    public ArrayList<String> olustur(int sayi){
        ArrayList<String> gidecek = new ArrayList<>();
        for (int i = 0; i < sayi; i++) {
            gidecek.add("(" + olustur() + ")");
        }
        return gidecek;
    }
    public boolean dogruMu(String imei){
            int sum = 0;
            boolean alternate = false;
            for (int i = imei.length() - 1; i >= 0; i--)
            {
                int n = Integer.parseInt(imei.substring(i, i + 1));
                if (alternate){
                        n *= 2;
                        if (n > 9){
                                n = (n % 10) + 1;
                        }
                }
                sum += n;
                alternate = !alternate;
            }
            return (sum % 10 == 0);
        }
}
