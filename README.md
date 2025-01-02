# Uçak Serbest Atış Animasyonu Projesi

Bu proje, 2021 yılında İnternet Tabanlı Programlama dersi kapsamında 1. ödev olarak geliştirilmiş bir Windows Forms uygulamasıdır. Uygulama, bir uçağın belirli bir yükseklikten bomba bırakma simülasyonunu gerçekleştirmektedir.
## Görseller

![image](https://github.com/user-attachments/assets/db8fbdf6-36d0-4427-a565-f36aa791d0aa)

![image](https://github.com/user-attachments/assets/c72ec008-a399-40c8-8743-100c3bdeea0d)

![image](https://github.com/user-attachments/assets/b7926c56-fd30-4073-a931-fe3742311a1d)


## Özellikler

- Rastgele belirlenen yükseklik ve hızda hareket eden uçak animasyonu
- Lazer mesafe ölçümü
- Hedef bölgeye atış yapabilme
- Başarılı/Başarısız atış değerlendirmesi
- Tekrar başlatma özelliği

## Nasıl Çalışır?

1. Program başlatıldığında uçak, rastgele belirlenen bir yükseklikte ve hızda hareket etmeye başlar
2. Uçak belirli bir konuma geldiğinde "ATEŞ" butonu kırmızı renk alır
3. "ATEŞ" butonuna tıklandığında bomba bırakılır
4. Bomba yere düştüğünde:
   - Hedef bölgeye isabet etmişse "BAŞARILI" mesajı (yeşil)
   - Hedef bölgeyi ıskalarsa "BAŞARISIZ" mesajı (kırmızı) görüntülenir
5. Simülasyon bittiğinde "TEKRAR" butonu ile yeniden başlatılabilir

## Teknik Detaylar

- Uçak hızı: 5-10 km/h arasında rastgele belirlenir
- Yükseklik: 0-400m arasında rastgele belirlenir
- Lazer mesafesi: Hedef ile uçak arasındaki mesafe sürekli hesaplanır
- Hedef bölge: 855-1150 piksel arasındaki x koordinatları

## Gereksinimler

- Windows işletim sistemi
- .NET Framework 4.5 veya üzeri

## Kurulum

1. Projeyi bilgisayarınıza indirin
2. WindowsFormsApp1.sln dosyasını Visual Studio ile açın
3. Projeyi derleyin ve çalıştırın

## Proje Yapısı

- `Form1.cs`: Ana uygulama mantığı
- `Form1.Designer.cs`: Form tasarım kodları
- `Program.cs`: Uygulama başlangıç noktası 
