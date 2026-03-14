using DesafioPOO.Models;
Smartphone nokia= new Nokia(numero:"11998245351", modelo:"9",imei:"1111111", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Iphone iphone = new Iphone(numero:"5199999999", modelo: "13",imei: "22222222", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");