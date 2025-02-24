namespace mvc;
public class Ogrenci
{
    
    public int Id { get; set; }
    public string Ad { get; set; } = string.Empty;
    public string Soyad { get; set; } = string.Empty;
    public int OkulNumarasi { get; set; }
    public Sinif? Sinif { get; set; }
    public int SinifId { get; set; }
}