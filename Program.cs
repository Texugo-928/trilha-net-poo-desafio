using DesafioPOO.Models;
﻿using System.Text;

//TODO: Testar no VSCode...

Console.OutputEncoding = Encoding.UTF8;

// Cria um Nokia
Nokia nokia = new Nokia(numero: "1", modelo: "Z5", imei: "ASDAX", memoria: 6);

// Cria um Iphone
Iphone iphone = new Iphone(numero: "2", modelo: "i15", imei: "DFGDVCX", memoria: 12);

// Testa o Objeto nokia
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Android");
Console.WriteLine($"NOKIA --- Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}");

// Testa o Objeto iphone
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotfy");
Console.WriteLine($"IPHONE --- Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}");
