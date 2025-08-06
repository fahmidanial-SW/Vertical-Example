private class nama
{
    string suka = "hhaaha";
}

private class Ilham
{
    public string Nama { get; set; }
    public int Umur { get; set; }
    public string Alamat { get; set; }

    public Ilham(string nama, int umur, string alamat)
    {
        Nama = nama;
        Umur = umur;
        Alamat = alamat;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama: {Nama}, Umur: {Umur}, Alamat: {Alamat}");
    }
}