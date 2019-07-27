# WEB API  
###  Bu proje bir Web Api uygulamasıdır.
* Northwine örnek database'ini indirip, projeye ekledik.
* Bu örnek veri tabanı üzerinden HttpGet işlemlerini yaptık.
* İlk olarak <code>  GetAllCategories() </code> metodu ile tüm tabloyu listeledik.
* Sonrasında kullanıcıdan bir id değeri alarak kullanıcın kendi istediği veriyi döndürmek istedik.
* Bunun içinde <code> CategoryByID(int id) </code> metodu ile bu işlemi gerçekleştiren kodlamaları yapıp bu action ile çağırdık. Burada dikkat edilmesi gereken husus bu metodun başına "GET" yazmamış olmamız. Bunun bir "GET" olayı olduğunu bildirmemiz gerekiyor, bunun için metodun başına <code> [HttpGet] </code> yazdık. 
* Ya metoda giydirerek ya da metodun üzerinde belirteceğiz bu olayın bir GET  işlemi olduğunu. 
