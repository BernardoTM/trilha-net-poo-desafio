using DesafioPOO.Models;
Console.WriteLine("Smartphone iphone");
Iphone iphone = new Iphone(numero: "999999999", modelo: "Modelo 1", imei: "111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone nokia");
Nokia nokia = new Nokia(numero: "999999999", modelo: "Modelo 2", imei: "222222222", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
