
# 📚 Kütüphane Yönetim Sistemi

Bu proje, bir kütüphane içindeki kitap işlemlerini yönetmek üzere geliştirilmiş bir masaüstü uygulamadır. C# (WinForms) ve SQL Server kullanılarak geliştirilmiştir. Proje, hem teknik becerilerimi hem de iş analisti perspektifimi yansıtmaktadır.

---

## 🎯 Projenin Amacı

Kütüphane iş süreçlerinin dijital ortamda yönetilmesini sağlamak:
- Kitapların eklenmesi, güncellenmesi, silinmesi
- Ödünç alma ve iade işlemleri
- Gecikme bedeli hesaplama
- Çok kriterli kitap arama
- Kullanıcı giriş kontrolü

---

## 🛠️ Kullanılan Teknolojiler

- **C#** – WinForms
- **SQL Server** – Veritabanı işlemleri (CRUD)
- **ADO.NET** – Veri erişim katmanı

---

## 🧩 Uygulama Özellikleri

- 📥 **Kullanıcı Girişi**: Veritabanında kayıtlı kullanıcılar ile doğrulama yapılır.
- 📚 **Kitap İşlemleri**: Kitap ekleme, silme, güncelleme işlemleri yapılabilir.
- 🔄 **Ödünç Verme / İade**: Kitap ödünç verildiğinde durumu güncellenir, iade edildiğinde geri alınır.
- ⌛ **Gecikme Bedeli Hesaplama**: 10 günü geçen ödünçlerde günlük 5 TL ceza hesaplanır.
- 🔍 **Gelişmiş Arama**: Kitap adı, yazar adı, ISBN, tür ve ödünç alan numarasına göre arama yapılabilir.
- 📊 **Veri Görselleştirme**: Kitaplar DataGridView aracılığıyla listelenir.

---


## 🔧 Kurulum ve Çalıştırma

1. Bu repoyu klonlayın:
```
git clone https://github.com/donduberra/KutuphaneYonetimSistemi.git
```

2. `KutuphaneYonetimSistemi.sln` dosyasını Visual Studio ile açın.

3. `DbKutuphane` adında bir SQL Server veritabanı oluşturun. `Table_Kitaplar` ve `TableKutuphaneYoneticileri` tablolarını oluşturun.

4. Giriş yapmak için `TableKutuphaneYoneticileri` tablosuna kullanıcı adı ve şifre ekleyin.

5. Uygulamayı çalıştırın (`F5`).

---

## 👩‍💼 Geliştirici

**Berra Özdemir** – Teknik İş Analisti Adayı  
[LinkedIn](https://www.linkedin.com/in/döndü-özdemir-business-analyst/) 
`C# | SQL | Business Analysis | Open Banking | API`

---

## 📌 Notlar

- Bu uygulama, iş analistlerinin teknik tarafı anlaması ve uygulamaya dökebilmesi açısından örnek teşkil etmektedir.
- Öğrenim amaçlı geliştirilmiştir.

