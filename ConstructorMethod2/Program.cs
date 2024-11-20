// See https://aka.ms/new-console-template for more information

using ConstructorMethod2;

IdentityInfo kb = new IdentityInfo();

Console.WriteLine(kb.adLower);
Console.WriteLine(kb.soyadUpper);
Console.WriteLine(kb.memleketCapsule);
Console.WriteLine(kb.cinsiyetCapsule);
Console.WriteLine(kb.yasCapsule);

Console.WriteLine(" \nDeğer atamaları yapıldıktan sonra \n");
kb.adLower = "Ad";
Console.WriteLine(kb.adLower);
kb.soyadUpper = "Soyad";
Console.WriteLine(kb.soyadUpper);
kb.memleketCapsule = "Memleket";
Console.WriteLine(kb.memleketCapsule);
kb.cinsiyetCapsule = "Cinsiyet";
Console.WriteLine(kb.cinsiyetCapsule);
kb.yasCapsule = 18;
Console.WriteLine(kb.yasCapsule);
