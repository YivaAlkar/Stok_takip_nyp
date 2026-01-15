# 🏗️ Stok ve Satış Takip Sistemi

Bu proje, bir inşaat firması için geliştirilmiş; **stok yönetimi**, **müşteri takibi**, **satış işlemleri** ve **raporlama** süreçlerini dijital ortamda yönetmeyi amaçlayan bir **Windows Forms** masaüstü uygulamasıdır.

**Katmanlı mimari** yapısı sayesinde sürdürülebilir, geliştirilebilir ve düzenli bir kod yapısı sunar.

---

## 📌 Proje Özellikleri

### 🔐 Kullanıcı Girişi ve Yetkilendirme
* **Roller:** Yönetici, Satış Personeli ve Depo Görevlisi.
* **Güvenlik:** Role göre ekran ve yetki kısıtlamaları.

### 📦 Ürün Yönetimi
* **İşlemler:** Ürün ekleme, güncelleme ve silme.
* **Stok Takibi:** Stok miktarı ve minimum stok limiti kontrolü.
* **Uyarılar:** Kritik stok seviyesine düşen ürünler için uyarı sistemi.

### 👥 Müşteri Yönetimi
* **İşlemler:** Müşteri ekleme, güncelleme ve silme.
* **Analiz:** Toplam alış tutarına göre müşteri analizi.
* **Sıralama:** En çok alışveriş yapan müşterilerin listelenmesi.

### 💰 Satış İşlemleri
* **Sepet Mantığı:** Ürün seçimi ve sepet oluşturma.
* **Stok Entegrasyonu:** Satış onaylandığında otomatik stok düşme.
* **Veritabanı:** Satış detaylarının (Fiyat, Adet, Tarih) veritabanına işlenmesi.

### 📊 Raporlama ve Dashboard
* **Özet Veriler:** Toplam ciro, Günlük satış sayısı.
* **Kritik Durum:** Kritik stoktaki ürünlerin listesi.
* **Grafikler:** Stok dağılımı ve ürün kârlılık analizi.

---

## 📐 Sınıf (Class) Diyagramı

<img width="100%" alt="Sınıf Diyagramı" src="https://github.com/user-attachments/assets/916a70bf-63c0-4992-8936-725e0ce91813" />

---

## 📂 Kullanılan Teknolojiler

* **Dil:** C# (.NET Framework)
* **Arayüz:** Windows Forms (Masaüstü)
* **Veritabanı:** MySQL
* **Mimari:** Katmanlı Mimari
    * **DAL:** Data Access Layer (Veri Erişim Katmanı)
    * **BLL:** Business Logic Layer (İş Mantığı Katmanı)
    * **Entities:** Veri Modelleri
    * **UI:** User Interface (Kullanıcı Arayüzü)
* **Sorgu:** LINQ
* **Versiyon Kontrol:** Git & GitHub

---

## 🛠️ Proje Yapısı


stokSatis_Akay
│

├── BLL        → İş kuralları ve iş mantığı

├── DAL        → Veritabanı işlemleri

├── Entities   → Veri modelleri

├── UI         → Windows Forms arayüzler

├── App.config → Yapılandırma dosyası

├── Program.cs → Başlangıç noktası

└── stokSatis_Akay.csproj

## 📸 Ekran Görüntüleri
## Giriş Ekranı

<img width="800" alt="Giriş Ekranı" src="https://github.com/user-attachments/assets/7a3b67e5-3b21-4cc2-9d5b-b1cf71a1c363" />



## Ana Panel (Dashboard)

<img width="800" alt="Dashboard" src="https://github.com/user-attachments/assets/b177a0cd-b6c3-4df2-bca7-d393a7a44aba" />



## Ürün Yönetimi

<img width="800" alt="Ürün Yönetimi" src="https://github.com/user-attachments/assets/60c9a520-e097-4326-9863-4642ec205fef" />




## Müşteri Yönetimi

<img width="800" alt="Müşteri Yönetimi" src="https://github.com/user-attachments/assets/8fdb5db5-6d7c-4f23-9d4e-99b9e261e1ae" />



## Satış Ekranı

<img width="800" alt="Satış Ekranı" src="https://github.com/user-attachments/assets/97fbeef2-d9cd-4c8f-99b7-0206237db34b" />



## Raporlama

<img width="800" alt="Raporlama" src="https://github.com/user-attachments/assets/f45a373d-5320-4343-96ed-055fa609276a" />


## 🚀 Kurulum ve Kullanım
Projeyi Klonlayın:

Bash

git clone (https://github.com/YivaAlkar/nvp.git)

Projeyi Açın: Visual Studio ile stokSatis_Akay.sln dosyasını açın.

Veritabanı Ayarları: App.config dosyasında MySQL bağlantı bilgilerini kendi sunucunuza göre düzenleyin.

Veritabanını Oluşturun: MySQL üzerinde aşağıdaki tabloları oluşturun:

kullanici

musteriler

urunler

satis

satisDetay

Çalıştırın: Projeyi derleyin ve başlatın (F5).

## 🎯 Proje Amaçları
✅ Stok ve satış süreçlerini dijitalleştirmek.

✅ Hatalı manuel işlemleri azaltmak.

✅ Satış ve stok verilerini analiz edilebilir hale getirmek.

✅ Gerçek hayata uygun bir kurumsal otomasyon sistemi geliştirmek.

## 📌 Geliştirilebilecek Özellikler
Excel / PDF rapor çıktısı alma özelliği.

Kullanıcı şifrelerinin hashlenerek (SHA-256 vb.) saklanması.

## 👤 Geliştirici
Ad Soyad: Muhammed AKAY

Üniversite: Uludağ Üniversitesi

Bölüm: Yönetim Bilişim Sistemleri

GitHub: https://github.com/YivaAlkar

## 🎥 Video

ajkbasjk

## 📌 Not
Bu proje eğitim ve akademik amaçlarla geliştirilmiştir.
