DEPENDENCY INJECTION 

          Bu bölümde Ilog interface ile iki farklı sınıf oluşturduk biri ConsoleLog diğer TextLog bu iki sınıfı new methodu olmadan çağırmamaya çalıştık.
          Bunun için program.cs dosyası üzerinden builder.Services.AddSingelton gibi parametreler kullandık ve bunları kullanırken parametre alıp almadığına da 
          dikkat ettik. Parametre alırsa eğer çağırdığımız sınıf bunun için de ekstra kodlar olduğunu ifade ettim. 

          Controller üzerinden kodumuzu çağırdık ve bunun çalışmasını konsol üzerinden kontrol ettim.
