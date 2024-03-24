tepe:
Console.Write("Mesajınızı Giriniz : ");
String mesaj = Console.ReadLine();
Console.WriteLine("Mesajınız {0} karakterden oluşmaktadır.", mesaj.Length);
Console.WriteLine("");
if (mesaj.Length == 0)
{
    Console.WriteLine("Lütfen Karakter Giriniz.");
    Console.WriteLine("");
    goto tepe;
    
}
else if (mesaj.Length <= 200)
{
    Console.WriteLine("Mesajınız Başarıyla Gönderilmiştir.");
}
else if (mesaj.Length > 200)
{
    Console.WriteLine("Mesajınız En Fazla 200 Karakter İçermelidir.");
}
Console.WriteLine("");
Console.WriteLine("Sistemi Kapatmak İçin 'ENTER' Basınız.");

Console.ReadLine();