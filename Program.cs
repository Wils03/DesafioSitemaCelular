using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone aparelhoNokia = new Nokia(numero: "12345", modelo: "Modelo Nokia 1", imei: "111111111", memoria: 64);
Smartphone aparelhoIphone= new Iphone(numero: "67890", modelo: "Modelo Iphone 1", imei: "222222222", memoria: 128);

Console.WriteLine("Smartphone Nokia:");
aparelhoNokia.Ligar();
aparelhoNokia.ReceberLigacao();
aparelhoNokia.ExibirInformacoesAparelho();
aparelhoNokia.InstalarAplicativo("Intagram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
aparelhoIphone.Ligar();
aparelhoIphone.ReceberLigacao();
aparelhoIphone.ExibirInformacoesAparelho();
aparelhoIphone.InstalarAplicativo("Youtube");
