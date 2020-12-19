# SOLID Princibles
Bu projede SOLID prensipleri örnekler ile anlatılmıştır. Prensiplerin ayrıntılı açıklamalarına aşağıda vereceğim gibkook hesabımdan ulaşabilrsiniz.

[**Lab1**](https://github.com/RidvanOrun/SOLIDPrincibles/tree/master/SOL%C4%B0DPrincibles/Lab1_SRP)  S— Single-responsibility     "Her sınıfın veya metodun tek bir sorumluluğu olmalı "

[**Lab2**](https://github.com/RidvanOrun/SOLIDPrincibles/tree/master/SOL%C4%B0DPrincibles/Lab2_OCP) O — Open-closed principle  " Sınıflar değişikliğe kapalı ancak gelişime açık olmalıdır"

[**Lab3**](https://github.com/RidvanOrun/SOLIDPrincibles/tree/master/SOL%C4%B0DPrincibles/Lab3_LSP) L — Liskov substitution principle        "Liskov prensibi "

[**Lab4**](https://github.com/RidvanOrun/SOLIDPrincibles/tree/master/SOL%C4%B0DPrincibles/Lab4_ISP) I — Interface segregation principle    " Ara yüzlerin ayrılması prensibi"

[**Lab5**]D — Dependency Inversion Principle  " Katmanlı mimarilerde üst seviye modüller alt seviyedeki modüllere doğruda bağımlı olmamalıdır "

![SOLİD LOGO](https://i2.wp.com/miro.medium.com/max/4000/1*hKu-BR5Ad0MIjXJhieayFg.png?resize=2000%2C860&ssl=1)

## Single-responsibility principle ; 

Bu ilke "bir sınıfın değişmesi için yalnız bir nedeninin olması gerektiğini savunur" yani bir sınıfın az ve öz sorumluluğu olmalı karmaşık yapılardan her zaman kaçınılmalıdır. Bir class oluşturulurken sürekli " bu sorumluluğu buraya vermeli miyim ?" sorusu sorulmalıdır.

## Open-closed principle;

Varlıklar(Entities) genişlemeye açık olmalı ancak değişikliğe kapalı olmalıdır. Zaten OOP genişlemeyi prensip edinilerek desteklenmiştir. Lakin bu değişikm esnasında yaratılan sınıflarda modifikasyona gerek kalmayacak şekilde mimariyi kurmamız gerekir. Bir sınıfın davraşınını değiştirmeden geliştirmemiz gerekir.

## Liskov substitution principle;

Alt sınıflar miras aldığı üst sınıfın bütün özelliklerini kullanmalı, alt sınıflarda oluşturulan nesneler üst sınıfların nesneleriyle yer değiştirdiklerinde aynı davranışı göstermeli ve herhangi bir kullanılmayan özellik olmamalıdır. Bu ilkeye göre "türetilmiş veya alt sınıflar, temel veya ebeveyn sınıflarının yerine geçebilir." 

## Interface segregation principle; 
![INTERFACE LOGO](https://blog.ndepend.com/wp-content/uploads/ISP.png)

Bu prensip SOLİD'deki sınıflar yerine arayüzler interfaceler için gerçerli olan ilk prensiptir ve  SRP-LSP prensiplerine benzemektedir. Bu ilke özet olarak şunu söyler "Hiçbir concrete sınıf kendisi ile ilgisi olmayan bir özelliği içeren arayüzden implemente edilmemelidir ". Burada asıl amacımız interfacelerin şişirilmesinden kaçınmamız olmasıdır.

## Dependency Inversion Principle; 

![DIP LOGO](https://gblobscdn.gitbook.com/assets%2F-MOg9akg5dx2Jdny6D2f%2F-MOskNAIyBz41QwMKI4F%2F-MOtP6msLqwox4RzH1TF%2FDIP2.png?alt=media&token=0f781f01-25a6-4dce-a7ca-aaec6fbc602d)

Bu ilkede yüksek seviyeli sınıflar düşük seviyeli modüllere bağlı olmamalıdır. Modül ve sınıflar soyutlamalara bağlı olmalıdır. Soyutlamalar detaylara bağlı olamamalıdır. Detaylar soyutlara bağlı olmalıdır. Bu detaydan kasıt sınıflara yüklenen görevlerdir. Bu ilkenin en can alıcı noktası bir sınıfın eylem yürütmek için kullandığı araçlar ile birleştirilmemesi gerektiğidir.

Ayrıntılı açıklamalarıma GitBook hesabımdan ulaşabilirisniz. https://ridvanorun.gitbook.io/solid/ 
