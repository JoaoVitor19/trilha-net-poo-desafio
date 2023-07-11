using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "69 992126622", modelo: "Tijolão", imei: "11111111", memoria: 4);
Smartphone.Ligar();
Smartphone.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Nokia(numero: "69 992126622", modelo: "Maçã", imei: "2222222222", memoria: 8);
Smartphone.Ligar();
Smartphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

