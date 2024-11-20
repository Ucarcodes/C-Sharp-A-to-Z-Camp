// See https://aka.ms/new-console-template for more information

using ConstructorMethod;

string kAdi, kSoyadi, kMeslegi;
int kYasi;

Console.Write("Lütfen kullanıcı adını giriniz: ");
kAdi = Console.ReadLine();
Console.Write("Lütfen kullanıcı soyadını giriniz: ");
kSoyadi = Console.ReadLine();
Console.Write("Lütfen kullanıcı yaşını giriniz: ");
kYasi = int.Parse(Console.ReadLine());
Console.Write("Lütfen kullanıcı mesleğini giriniz: ");
kMeslegi = Console.ReadLine();

UserInfo kb = new UserInfo(kAdi, kSoyadi, kYasi, kMeslegi);
