using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Currency
{

    class Program
    {


        static void Main(string[] args)
        {
           
            float CONSTANT_DOLLAR = 5.6f;
            float CONSTANT_EURO = 6.4f;
            float number;
            float result;
            string usd;
        Bas:
            Console.WriteLine("USD ve EUR birisini seçiniz. \n-------------------------------------");
            Console.Write("Lütfen İşlem Yapmak İstediğiniz Kuru Giriniz = ");
            usd = Console.ReadLine();

            if (usd.ToUpper()!= "USD")
            {
                if(usd.ToUpper()!="EUR")
                {
                    Console.WriteLine("----Yeniden doğru şekilde kur seçiniz ----");
                    goto Bas;
                } 
            }
            
                Console.Write("Hesaplanacak Tutarını Giriniz:");
                number = float.Parse(Console.ReadLine());
                if (usd.ToUpper()=="USD")
                {
                    result = CONSTANT_DOLLAR * number;
                    Console.WriteLine("Hesaplama sonucu: " + number + "  USD   " + result + "  TL dir.");
                }
                else
                {
                    result = CONSTANT_EURO * number;
                    Console.WriteLine("Hesaplama sonucu: " + number + "  EUR   " + result + "  TL dir.");
                }
            Console.WriteLine("             ");
            string[] words = {
                "Ben bazı derslerin sınavlarını geçemedim; ama arkadaşım hepsini geçti. O şimdi Microsoft'ta başarılı bir mühendis ben Microsoft'un sahibiyim. - Bill Gates",
                "İyi bir mühendis olmak istiyorsanız sınavlara çalışmaya daima geç başlayın; bu size zaman yönetimini ve acil durumlarla başa çıkmayı öğretir. -Bill Gates",
                "Mantık sizi A noktasından B noktasına götürür. Hayal gücü ise her yere. - Albert Einstein",
                "Mutlu olmak için tüm ihtiyacımız heveslenecek bir şey bulmakken rahat ve lüks hayatın baş gereksinimlerindenmiş gibi davranıyoruz. - Albert Einstein",
                "İnsanın tüm umutsuzluğu bir tek şeyden kaynaklanır; odasında kendisiyle baş başa kalmayı başaramamasından. - Blaise Pascal",
                "Nefretiniz elektriğe dönüştürülebilseydi bütün dünyayı aydınlatırdı. - Nikola Tesla",
                "Yaşlanmadan önce, iyi yaşamak; yaşlandıktan sonra da, iyi ölmek istedim. - Seneca",
                "Az şeye sahip olan değil, çok fazla şey isteyen fakirdir. - Seneca",
                "İyi olan tek şey bilgi ve kötü olan tek şey de cehalettir. - Sokrates",
                "Bilgili olduğumuz oranda özgür oluruz. - Sokrates",
                "İnsan, geride bıraktıklarını özler, sahip olduğundan sıkılır, ulaşamadığına tutulur. Ve ulaşılmaz olan hep aşk olur. - Lucius Annaeus Seneca",
                "Endişelerinizden kurtulmak istiyorsanız, yaşamaktan en çok korktuğunuz şeyin bir gün başınıza geleceğini kabul edin. - Sokrates",
                "Ben bilmediğimi bildiğim için, öteki insanlardan akıllıyım. - Sokrates",
                "Bir şeyleri değiştirmek isteyen insan önce kendisinden başlamalıdır. - Sokrates",
                "Dünyada her şey için, medeniyet için, hayat için, başarı için, en hakiki mürşit bilimdir, fendir.-Atatürk",
                "Eğer bir gün benim sözlerim bilimle ters düşerse bilimi seçin.-Atatürk",
                "“Niyeti kötü olan insandan değil,Niyetinin kötü olduğunu gizleyen insandan kork..”—  Hz.Mevlana",
                " Mal kaybeden, bir şey kaybetmistir, onurunu kaybeden birçok şey kaybetmiştir. Fakat cesaretini kaybeden her şeyini kaybetmistir. (Goethe)",
                " Herşeyi bildiğini sanma! gerçekte çok bilgili olsanda kendine Cahilim diyebilecek cesaretin olmalı. (Ivan Pavlov)",
                "İnsanlar başaklara benzerler, içleri boşken başları havadadır, içleri doldukça eğilirler. (Montaigne)"
            };
                Random rastgelesoz = new Random();
                int no = rastgelesoz.Next(0, words.Length);
                Console.WriteLine("\"" + words[no] + "\"");
            
            Console.Write("\n\nYeniden Denemek istiyormusunuz (E/H)");
            char dene = Convert.ToChar(Console.ReadLine());
            if (dene == 'e' || dene == 'E')
            {
                Console.Clear();
                goto Bas;

            }
            else
            {
                System.Environment.Exit(-1);

            }

        }

    }
 }




    


        
        


    

