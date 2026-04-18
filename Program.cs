using System;

public class Mahasiswa
{
    public string Nim { get; set; }
    public string Nama { get; set; }
    public float Ipk { get; set; }

    public void Registrasi()
    {
        Console.WriteLine("Nama: " + Nama);
        Console.WriteLine("NIM: " + Nim);
        Console.WriteLine("IPK: " + Ipk);
        Console.WriteLine("Telah melakukan registrasi\n");
    }

    public void IsiKrs()
    {
        Console.WriteLine(Nama + " sedang melakukan proses KRS\n");
    }
}