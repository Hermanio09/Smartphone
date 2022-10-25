using Desafio.Models;

System.Console.WriteLine("Smartphone Nokia");
Nokia celular = new Nokia(numero: "51847511544", modelo: "C20", imei: "1546456546521", memoria: 64);
celular.Ligar();
celular.ReceberLigacao();
celular.InstalarAplicativo("");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone");
Iphone celular2 = new Iphone(numero: "50548580147", modelo: "XR", imei: "54654615213854", memoria: 64);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Ifood");