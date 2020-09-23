
package javaapplication6;

/**
 *
 * @author OZHAN NUR� YILDIRIM ozhan.yildirim@ogr.sakarya.edu.tr
 * @since 07.03.2020
 * <p>
 * Text dosyas�n�n analizi
 * <p>
 */

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class Java�dev 
{
   public static void main(String[] args) throws IOException 
   {
       System.console().writer().println("��i����������I");    // T�rk�e karakter i�in tan�mlama
        
       
      File f1=new File("icerik.txt");       // txt dosya tan�mlamas�
      
     
      String[] words=null;
  
      FileReader fr = new FileReader(f1); 
      BufferedReader br = new BufferedReader(fr);           // dosya i�lemleri
      String s;  
      
    
      int webCount=0; 
      int wordCount =0; 
      int vowelCount =0;            // de�i�ken tan�mlar�
      int mailCount=0;
      int sentenceCount =0;
      while((s=br.readLine())!=null)   
      {
        words=s.split(" ");             //split metodu
          for (String word : words) 
          {
                 if (word.contains("www") || word.contains("http") || word.contains("https"))    // web sitesi i�in gerekli if yap�s�
                 {
                   webCount++;    
                 }
                 if (word.contains("@hotmail") || word.contains("@gmail") || word.contains("@edu")||word.contains("@outlook"))  //mail adresleri i�in gerekli if yap�s� 
                 {
                   mailCount++;    
                 }
                 
                 if (word.contains(" "))   
                 {
                 } else                     // kelime say�s� i�in gerekli yap�
                 {
                     wordCount++;   
                    }

          }
           for (int i = 0; i < s.length(); i++)
            {
                char c = s.charAt(i);

                s = s.toLowerCase();
               
             if ((c == 'a') || (c == 'e') || (c == 'i') || (c == '�') || (c == 'o') || (c == '�')
                     || (c == 'u') || (c == '�') || (c == 'A') || (c=='E') || (c=='I') || (c=='�') || (c=='O')      // sesli harf tan�mlar�
                        || (c=='�') || (c=='U') || (c=='�'))
                {
                    vowelCount++;
                }
            
                if (c == ' ')           
                {
                     if ((s.charAt(i - 1) == '.'))          //c�mle say�s� i�in if yap�s�
                    {
                        sentenceCount++;
                    }
                }
            }
     
      }
      
        System.out.println("Sesli Harf sayisi : " + vowelCount);
        System.out.println("Kelime sayisi : " + wordCount);
        System.out.println("C�mle sayisi : " + sentenceCount);              // sonu� ��kt�lar�
        System.out.println("Mail sayisi : " + mailCount);
        System.out.println("WebSitesi sayisi : " + webCount);
       
         
        
      
         fr.close();   // close
         
      
   } 
}
