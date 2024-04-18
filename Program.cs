using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123-123","1234","123456",8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("123-123","1234","123456",8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
// TODO: Realizar os testes com as classes Nokia e Iphone