***EF Core Migration Akışı (Adım Adım)

Model oluştur / güncelle
→ class, DbSet, ilişkiler tanımlanır

Migration oluştur
→ Add-Migration MigrationAdi

Migration kontrol et
→ Migrations klasörü oluşur

Veritabanını güncelle
→ Update-Database

***Veri Ekleme Akışı

Entity oluştur
→ Personel personel = new Personel()

Context’e ekle
→ _context.Personeller.Add(personel)

Kaydet
→ _context.SaveChanges()

***Veri Güncelleme Akışı

Kaydı bul
→ _context.Personeller.Find(id)

Alanları değiştir
→ personel.Ad = "Ahmet"

Kaydet
→ _context.SaveChanges()

***Veri Silme Akışı

Kaydı bul
→ _context.Personeller.Find(id)

Context’ten sil
→ _context.Personeller.Remove(personel)

Kaydet
→ _context.SaveChanges()

***Migration Geri Alma Akışı

Mevcut migration’ları listele
→ Get-Migration

Önceki migration’a dön
→ Update-Database OncekiMigration

Son migration’ı sil
→ Remove-Migration

***CLI (dotnet ef) Akışı

Migration ekle
→ dotnet ef migrations add MigrationAdi

Veritabanını güncelle
→ dotnet ef database update
