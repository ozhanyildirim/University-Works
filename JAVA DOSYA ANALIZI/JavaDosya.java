
package javaapplication6;

/**
 *
 * @author OZHAN NURÝ YILDIRIM ozhan.yildirim@ogr.sakarya.edu.tr
 * @since 07.03.2020
 * <p>
 * Text dosyasýnýn analizi
 * <p>
 */

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class JavaÖdev 
{
   public static void main(String[] args) throws IOException 
   {
       System.console().writer().println("üðiþçöýÜÐÝÞÇÖI");    // Türkçe karakter için tanýmlama
        
       
      File f1=new File("icerik.txt");       // txt dosya tanýmlamasý
      
     
      String[] words=null;
  
      FileReader fr = new FileReader(f1); 
      BufferedReader br = new BufferedReader(fr);           // dosya iþlemleri
      String s;  
      
    
      int webCount=0; 
      int wordCount =0; 
      int vowelCount =0;            // deðiþken tanýmlarý
      int mailCount=0;
      int sentenceCount =0;
      while((s=br.readLine())!=null)   
      {
        words=s.split(" ");             //split metodu
          for (String word : words) 
          {
                 if (word.contains("www") || word.contains("http") || word.contains("https"))    // web sitesi için gerekli if yapýsý
                 {
                   webCount++;    
                 }
                 if (word.contains("@hotmail") || word.contains("@gmail") || word.contains("@edu")||word.contains("@outlook"))  //mail adresleri için gerekli if yapýsý 
                 {
                   mailCount++;    
                 }
                 
                 if (word.contains(" "))   
                 {
                 } else                     // kelime sayýsý için gerekli yapý
                 {
                     wordCount++;   
                    }

          }
           for (int i = 0; i < s.length(); i++)
            {
                char c = s.charAt(i);

                s = s.toLowerCase();
               
             if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'ý') || (c == 'o') || (c == 'ö')
                     || (c == 'u') || (c == 'ü') || (c == 'A') || (c=='E') || (c=='I') || (c=='Ý') || (c=='O')      // sesli harf tanýmlarý
                        || (c=='Ö') || (c=='U') || (c=='Ü'))
                {
                    vowelCount++;
                }
            
                if (c == ' ')           
                {
                     if ((s.charAt(i - 1) == '.'))          //cümle sayýsý için if yapýsý
                    {
                        sentenceCount++;
                    }
                }
            }
     
      }
      
        System.out.println("Sesli Harf sayisi : " + vowelCount);
        System.out.println("Kelime sayisi : " + wordCount);
        System.out.println("Cümle sayisi : " + sentenceCount);              // sonuç çýktýlarý
        System.out.println("Mail sayisi : " + mailCount);
        System.out.println("WebSitesi sayisi : " + webCount);
       
         
        
      
         fr.close();   // close
         
      
   } 
}
