using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "Tijolão", imei: "NK123", memoria: 4);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "456", modelo: "Maça", imei: "IP456", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");