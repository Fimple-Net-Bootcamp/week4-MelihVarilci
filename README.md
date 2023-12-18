[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/5N8YvsIa)
Bir önceki hafta sanal evcil hayvan bakımı API'si projesine ekleyeceğiniz ek endpointler 

### Ek Endpointler

#### Evcil Hayvan İstatistikleri:
- `GET /evcilHayvanlar/istatistikler/{evcilHayvanId}`: Belirli bir evcil hayvanın aktivite, sağlık ve beslenme istatistiklerini getirir.

#### Kullanıcı İstatistikleri:
- `GET /kullanicilar/istatistikler/{kullaniciId}`: Belirli bir kullanıcının evcil hayvanları hakkında genel istatistiklerini getirir.

#### Eğitim İşlemleri:
- `POST /egitimler`: Evcil hayvana yeni bir eğitim ekler.
- `GET /egitimler/{evcilHayvanId}`: Evcil hayvanın aldığı eğitimleri listeler.

#### Sosyal Etkileşimler:
- `POST /sosyalEtkilesimler`: Evcil hayvanlar arası sosyal etkileşim başlatır.
- `GET /sosyalEtkilesimler/{evcilHayvanId}`: Evcil hayvanın katıldığı sosyal etkileşimleri listeler.

### Teknoloji ve Tasarım Önerileri

#### DTO Kullanımı:
- Tüm endpointlerde Data Transfer Object (DTO) kullanımı sağlanmalıdır. Bu, verilerin API üzerinden nasıl transfer edileceğini standardize eder ve güvenliği artırır.

#### AutoMapper Kullanımı:
- Entity ve DTO arasındaki dönüşümler için AutoMapper kullanılmalıdır. Bu, kodun bakımını ve anlaşılabilirliğini artırır.

#### FluentValidation Kullanımı:
- Tüm input verileri için FluentValidation kullanılarak, gelen verilerin doğruluğu ve uygunluğu kontrol edilmelidir. Bu, hataları erken yakalayarak sistem güvenilirliğini artırır.

#### Ayrı Veri Katmanı ve Dependency Injection:
- Veri erişim işlemleri için ayrı bir katman (service layer) oluşturulmalı ve bu katman, API controllerlarına Dependency Injection ile enjekte edilmelidir. Bu yaklaşım, kodun modülerliğini ve test edilebilirliğini artırır.

#### Exception Middleware:
- Exception (istisna) yönetimi için bir middleware eklenmelidir.
