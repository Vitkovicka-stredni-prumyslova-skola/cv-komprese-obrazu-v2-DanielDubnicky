using MessagingToolkit;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;

namespace Komprese
{
    public class KompreseObrazu{

        public static void Main (String [] args){
        

        //Cesta k testovacímu souboru
        String testFilePath = @"C:\Users\DanielDubnický\github-classroom\Vitkovicka-stredni-prumyslova-skola\cv-komprese-obrazu-v2-DanielDubnicky\KompreseObrazu\CSV\obr1-10.csv";
        
        //vytvoření instance třídy Obrazek
        Obrazek inputCSV = new Obrazek(testFilePath);

        
        
        //Test metody, která spočítá počet řádků vstupního obrázku
        Console.WriteLine("Počet vertikálních řádků {0}",inputCSV.CountLines(testFilePath));
        
        //Test metody, která spočítá počet symbolů vstupního obrázku v prvním řádku
        Console.WriteLine("Počet horizontální řádků {0}",inputCSV.CountSymbolInLine(testFilePath));

        inputCSV.vypisImg();


        
        
        
        var file = @"C:\Users\DanielDubnický\github-classroom\Vitkovicka-stredni-prumyslova-skola\cv-komprese-obrazu-v2-DanielDubnicky\KompreseObrazu\CSV\67be03eabd6d041592d435a28c61e835.png";
        Bitmap bitmap = new Bitmap(file);
        MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
        var text = decoder.Decode(new QRCodeBitmapImage(bitmap));
        Console.WriteLine(text);
        
        
    



    }
    // QR Code result 


    }
// QR Code result
    
    
    
}