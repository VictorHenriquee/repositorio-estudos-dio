using desafio_poo_smartphone_dio.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new("987771751", "Modelo1", "3143143113", 34);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new("987721751", "Modelo2", "3143143113", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");