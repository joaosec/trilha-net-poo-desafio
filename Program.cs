using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "161612", modelo: "Modelo 1", imei: "2525252525", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine(" ");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "585859", modelo: "Modelo 2", imei: "3578942648", memoria: 246);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Github");

