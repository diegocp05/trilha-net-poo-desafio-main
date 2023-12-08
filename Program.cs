using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// WRITELINE , SMARTPHONE, LIGAR, INSTALAR

Console.WriteLine("Smartphone: Nokia");
Smartphone nokia = new Nokia(numero: "1111", modelo: "ABC", imei: "123", memoria: 333);
nokia.Ligar();
nokia.InstalarAplicativo("Ifood");

Console.WriteLine("Smartphone: Iphone");
Smartphone iphone = new Iphone(numero: "2222", modelo: "CBA", imei: "321", memoria: 666);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Caixa APP");