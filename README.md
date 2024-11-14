# **"CarBook Araç Kiralama Projesi"**

Bu proje, ASP.NET Core 8.0 kullanılarak geliştirilmiş bir Web API ve MVC uygulamasıdır. Onion mimarisi kullanılarak tasarlanmış olup, **"Asp.Net Core Api 8.0 Onion Architecture ile BookCar Projesi"** araç kiralama işlemlerinin gerçekleştirildiği, araç fiyatlarının listelendiği ve araçlar hakkında detaylı bilgi alabildiğiniz bir web uygulamasıdır. 
Backend tarafından **Onion**, **CQRS** ve **Mediator** desenleri kullanılmıştır. **MSSQL** veritabanı kullanılmış ve kullanıcı/rol yetkilendirmeleri **JWT** ile sağlanmıştır.
Admin paneli için ayrı bir vitrin oluşturmuştur. Rezervasyon işlemi gerçekleştirebilir, araç detaylarını görebilir, kullanıcıların, seçilen lokasyona göre müsait araçları görme, bloglara yorum yapma, vb. gibi işlemlerden de yararlanabilirler. Admin paneline sahip olan kullanıcılar inceleyebilirler.

## **"Proje Şeması:"**

- **CarBook.Domain**: Temel varlıklar ve iş mantığını içerir.
- **CarBook.Application**: DTO'ları, enumları, CQRS, Mediator, repository tasarım desenini ve doğrulama kurallarını içerir.
- **CarBook.Persistence**: Repository sınıflarını ve veritabanı işlemlerini gerçekleştirir.
- **CarBook.WebApi**: API metodlarını barındırır ve dış dünya ile iletişim sağlar.
- **CarBook.Dto**: Frontend ile eşleştirilecek DTO (Data Transfer Object) yapılarını sağlar.
- **CarBook.WebUI**: MVC ile tasarlanmış kullanıcı arayüzüdür. Admin paneli için ayrı bir alan (area) kullanılmıştır.

## **"Kullanılan Teknolojiler:"**

- **ASP.NET Core 8**: Web uygulamaları ve API geliştirme için kullanılan .NET'in en son sürümüdür.
- **Web API**: HTTP protokolü üzerinden veri alışverişini sağlayan RESTful servislerdir.
- **Onion Architecture**: Katmanlı bir yapı sunarak uygulamanın bağımlılıklarını azaltır.
- **CQRS Pattern**: Komut ve sorgu işlemlerini ayırarak performansı artırır.
- **Mediator Pattern**: Bileşenler arası iletişimi merkezileştirerek kodu basitleştirir.
- **Repository Pattern**: Veri erişim işlemlerini soyutlayarak veritabanı bağımlılığını azaltır.
- **MSSQL**: Veritabanı işlemleri için kullanılan Microsoft SQL Server'dır.
- **Bootstrap**: Responsive ve modern arayüzler oluşturmak için kullanılan CSS framework'üdür.
- **JWT (JSON Web Token)**: Kullanıcı doğrulama ve yetkilendirme işlemlerini sağlayan token tabanlı kimlik doğrulama mekanizmasıdır.
- **SignalR**: Gerçek zamanlı web uygulamaları geliştirmek için kullanılan bir kütüphanedir.
- **Pivot Table**: Verilerin özet tablolar halinde düzenlenmesini sağlayan bir veri görselleştirme aracıdır.
- **Fluent Validation**: Veri doğrulama işlemlerini kolaylaştıran bir doğrulama kütüphanesidir.
- **HTML/CSS**: Web sayfası yapısı ve stil özelliklerini tanımlamak için kullanılan işaretleme dilleri.
- **JavaScript**: Web sayfalarına dinamik işlevler eklemek için kullanılan betik dilidir.
- **MVC**: Uygulama yapısını Model-View-Controller bölünmesiyle düzenleyen bir yazılım mimarisi deseni.





https://github.com/user-attachments/assets/94730bdb-6fff-448f-af11-c9eb8590ac56

![Ekran görüntüsü 2024-11-11 032116](https://github.com/user-attachments/assets/c3e5001c-61cf-4c5e-90fe-9c1a6093231e)

![Ekran görüntüsü 2024-11-11 032143](https://github.com/user-attachments/assets/ab7a01b8-5f6f-4957-b353-5f006836f233)

![Ekran görüntüsü 2024-11-11 032210](https://github.com/user-attachments/assets/ee5c84e7-b3db-4f5a-969a-7ad3c0cc18df)

![Ekran görüntüsü 2024-11-11 032238](https://github.com/user-attachments/assets/f35b811f-451c-4f48-b0f8-07cc48bae69b)
![image](https://github.com/user-attachments/assets/d83b8ffb-5ca0-4367-b3f8-0ca696275654)

![Ekran görüntüsü 2024-11-11 032257](https://github.com/user-attachments/assets/5b12ee3a-05bd-4fea-a81a-d11281092824)

![Ekran görüntüsü 2024-11-11 032341](https://github.com/user-attachments/assets/2fa7ab59-1914-4e92-9d58-2e21992b1277)

![Ekran görüntüsü 2024-11-11 032421](https://github.com/user-attachments/assets/303f9edb-9bbd-466e-9bd1-12268a619e18)

![Ekran görüntüsü 2024-11-11 032442](https://github.com/user-attachments/assets/615878ea-b9c4-44a3-9e9d-c7d0a9e5bca9)

![Ekran görüntüsü 2024-11-11 032503](https://github.com/user-attachments/assets/86efc358-9da8-40a2-97f4-25dfd0ed0079)

![Ekran görüntüsü 2024-11-11 032519](https://github.com/user-attachments/assets/fd13540a-f0d6-4ce8-98c6-5c40a67d19bb)

![Ekran görüntüsü 2024-11-11 032545](https://github.com/user-attachments/assets/0d0ddedc-39e3-427c-96bf-9ca1823da6f5)

![Ekran görüntüsü 2024-11-11 034244](https://github.com/user-attachments/assets/63b0212a-fcd7-4bac-b6ac-825d5050ff01)

![Ekran görüntüsü 2024-11-11 034539](https://github.com/user-attachments/assets/2d1c5f61-4f3a-4689-9eee-4c31abef166e)

![349184024-a9fcfc2d-9981-401f-b92a-33feff896308](https://github.com/user-attachments/assets/20766e3d-d9f1-46b4-b786-53164bfc8356)

![Ekran görüntüsü 2024-11-11 031914](https://github.com/user-attachments/assets/1d36cc11-d01b-4f4f-8e2f-2bc8df4238a5)








