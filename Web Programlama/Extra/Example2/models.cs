using Basic.Models;

public class Model
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
}

/*
Models uygulamadaki verileri temsil eden katmandır. 
Veri tabanı tablosu, kullanıcıdan alınan bilgileri, iş kuralları vb. burada bulunur.
Genelde classlar şeklinde tanımlanır.
Veri doğrulama gibi kurallar içerir.
Örnek olarak tabloyu temsil eder.

Rolü:
Veriyi taşımak 
Veri doğrulama kuralları koymak.
Gerekirse iş mantığını gerçekleştirmek.
*/
