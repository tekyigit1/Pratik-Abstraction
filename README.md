# Çalışan Görev Sistemi - Abstraction Ödevi

Bu projede, bir şirkette çalışan farklı pozisyonlardaki çalışanların görevlerini belirten soyut (abstract) yapılar kullanılmıştır. C# dilinde **Abstraction (Soyutlama)** konusu uygulamalı olarak ele alınmıştır.

##  Konu Özeti

- Ortak özelliklere sahip bir `Employee` (Çalışan) soyut sınıfı tanımlanmıştır.
- Her çalışan, `FirstName`, `LastName`, `Department` özelliklerine sahiptir.
- `Duty()` adında soyut bir metot, çalışanların görevini belirtmek için oluşturulmuştur.
- Her pozisyon (`Developer`, `ProjectManager`, `SalesRepresentative`) bu metodu kendine göre override etmiştir.

## Kullanılan Yapılar

- `abstract class`
- `abstract method`
- `override`
- `List<>` kullanımı
- `foreach` döngüsü

##  Çalışan Sınıfları

- `Employee`: Soyut temel sınıf
- `Developer`: Yazılım geliştirici
- `ProjectManager`: Proje yöneticisi
- `SalesRepresentative`: Satış temsilcisi

## Uygulama Çıktısı

Program çalıştırıldığında her çalışanın adı, soyadı, departmanı ve görev mesajı ekrana yazdırılır:

