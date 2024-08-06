# SOLID Prensipleri Örnek Projesi
Bu proje, C# kullanarak beş SOLID prensibini göstermektedir. Her prensip, doğru ve yanlış kullanım örnekleriyle birlikte açıklanmıştır ve anlaşılması kolay olması için ayrı dosyalara ayrılmıştır.

## SOLID Prensipleri
1.Single Responsibility Principle (SRP)

- Bir sınıfın değişmesi için yalnızca bir nedeni olmalıdır, yani bir sınıf yalnızca tek bir işi yapmalıdır.
- **[SRP_CorrectUsage.cs](srp/SRP_CorrectUsage.cs)**
- **[SRP_IncorrectUsage.cs](srp/SRP_IncorrectUsage.cs)**

2.Open/Closed Principle (OCP)

- Yazılım bileşenleri (sınıflar, modüller, fonksiyonlar vb.) genişletilmeye açık olmalı, ancak değiştirilmeye kapalı olmalıdır.
- **[OCP_CorrectUsage.cs](ocp/OCP_CorrectUsage.cs)**
- **[OCP_IncorrectUsage.cs](ocp/OCP_IncorrectUsage.cs)**

3.Liskov Substitution Principle (LSP)

- Bir programdaki nesneler, alt tiplerinin örnekleriyle değiştirilebilmeli ve programın doğruluğu bozulmamalıdır.
- **[LSP_CorrectUsage.cs](lsp/LSP_CorrectUsage.cs)**
- **[LSP_IncorrectUsage.cs](lsp/LSP_IncorrectUsage.cs)**
  
4.Interface Segregation Principle (ISP)

- Kullanıcılar, kullanmadıkları arayüzlere bağımlı olmaya zorlanmamalıdır. Bir büyük arayüz yerine, her biri bir alt modüle hizmet eden yöntem gruplarına dayalı birçok küçük arayüz tercih edilir.
- **[ISP_CorrectUsage.cs](isp/ISP_CorrectUsage.cs)**
- **[ISP_IncorrectUsage.cs](isp/ISP_IncorrectUsage.cs)**

5.Dependency Inversion Principle (DIP)

- Üst seviye modüller alt seviye modüllere bağımlı olmamalıdır. Her ikisi de soyutlamalara bağımlı olmalıdır. Soyutlamalar detaylara bağlı olmamalıdır. Detaylar soyutlamalara bağlı olmalıdır.
- **[DIP_CorrectUsage.cs](dip/DIP_CorrectUsage.cs)**
- **[DIP_IncorrectUsage.cs](dip/DIP_IncorrectUsage.cs)**
