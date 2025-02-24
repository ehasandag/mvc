
using mvc;

public class Sinif{
    public int Id { get; set; }

    public int SinifSeviye { get; set; }
    public string Sube { get; set; } = string.Empty;
    public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
}