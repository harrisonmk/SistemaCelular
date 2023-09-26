// See https://aka.ms/new-console-template for more information

using SistemaCelular.modelo;

Iphone iphone = new Iphone();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Nokia nokia = new Nokia();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");





