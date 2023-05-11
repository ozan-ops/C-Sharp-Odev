# C# Proje Odevi

* "Lokasyon.txt" dosyasını silmeyiniz, veriler bu dosyadan çekilmektedir.
* Projeyi derledikten sonra "Lokasyon.txt" dosyasını bin/Debug klasörünün içerisine kopyalayınız.
* Uygulama başlatıldığında müşteri bilgilerini (Kimlik Numarası, ad, soyad, telefon numarası, cinsiyet, engelli durumu) istemektedir.
* Kimlik Numarası ve telefon 11 haneli olduğu için uygulamada belirtilen alanlara 11 haneli sayı girilmesi gerekmektedir.
* Müşteri bilgilerinden sonra lokasyon seçimi yapılır.
* Lokasyon seçiminden sonra tarih seçimi yapılır.
* En son aktif koltuk seçilir ve tüm bilgiler ekrana yazdırılır.
* Lokasyon ve tarih bilgisi seçerken listedeki sıra numarası yazılmalıdır. Aktif koltuk seçerken de ekrana yazdırılan sayılardan bir tanesini seçmelisiniz.

Uygulama 2 interface ve 6 sınıftan oluşmaktadır:
* ILokasyon interface -> LokasyonOlustur sınıfı -> Lokasyon bilgileri için kullanılır.
* IUcak interface -> UcakOlustur sınıfı -> Ucak özelliklerini belirlemek için kullanılır.
* Musteri sınıfı -> MusteriOlustur sınıfı -> Müşteri bilgileri için kullanılır.
* LokasyonOlustur sınıfı -> "Lokasyon.txt" belgesinden verileri okumak ve lokasyon listesi oluşturmak için kullanılır.
* Rezervasyon sınıfı -> Ucret bilgisini tutar.
* UcusOlustur sınıfı -> Asıl sınıftır. Tüm bilgilerin alınması için kullanılır.
