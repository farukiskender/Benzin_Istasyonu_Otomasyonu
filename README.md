# ⛽ Benzin İstasyonu Otomasyonu

Masaüstü ortamda çalışan bu otomasyon uygulaması, bir benzin istasyonundaki işlemlerin (yakıt satışı, depo yönetimi, kullanıcı işlemleri) dijital ortamda kolay, hızlı ve güvenli şekilde yapılmasını sağlar.  

---

## 🚀 Özellikler

- Farklı kullanıcı rolleri:
  - 👑 Yönetici
  - 🧑‍🔧 Pompacı
  - 🏭 Depo Sorumlusu
- SQL tabanlı kullanıcı doğrulama sistemi 🔐
- Yakıt satışı ve ödeme yöntemi kaydı 💳
- Depo stok yönetimi 📦
- Yakıt fiyatı güncelleme 🔧
- İşlem geçmişi görüntüleme 🧾
- Yetkilendirme ve rol bazlı ekran erişimi 🔍

---

## 💻 Kullanılan Teknolojiler

| Teknoloji        | Açıklama                    |
|------------------|-----------------------------|
| C# (.NET)         | Uygulama geliştirme dili     |
| Windows Forms    | Masaüstü arayüz tasarımı     |
| SQL Server       | Veritabanı yönetimi          |

---

## 🧩 Modüller

### 🔐 Login Modülü
Kullanıcıların yetkilerine göre doğru panele yönlendirilmesini sağlar.

### 👑 Yönetici Paneli
- Kullanıcı yönetimi (ekle, sil, düzenle)
- Yakıt fiyatı güncelleme
- Satış ve alış geçmişini inceleme/silme

### 🧑‍🔧 Pompa Paneli
- Yakıt satışı işlemi (plaka, tür, miktar, ödeme yöntemi)
- Güncel fiyat ve stok görüntüleme

### 🏭 Depo Paneli
- Yakıt giriş işlemleri (tank dolumu)
- Stok takibi ve geçmiş görüntüleme

---

## 🛠️ Kurulum

1. Bu repoyu klonla:  
   `git clone https://github.com/kullanici-adiniz/benzin-istasyonu-otomasyonu.git`

2. Visual Studio'da projeyi aç

3. GitHub proje dosyasındaki ".bak" uzantılı Database Backup dosyasını 
   SQL Server a yükle 
  
4. Projeyi çalıştır 🟢

---

## 📌 Notlar

- Tüm SQL sorguları parametreli yazılmıştır (SQL Injection'a karşı güvenli).
- Kod yapısı modüler olacak şekilde tasarlanmıştır.
- Arayüz sade ve kullanıcı dostudur.

---
