double [] num= new double[5];
Console.WriteLine("Digite 5 valores para o vetor");
for(int i=0; i< num.Length;i++){
    num[i]= Convert.ToDouble(Console.ReadLine());
}
bool sair = false;
while(!sair){
    Console.Clear();
Console.WriteLine("1) Exibir maior;\n2) Exibir menor;\n3) Exibir média;\n4) Sair;");
var op = Convert.ToInt32(Console.ReadLine());
Console.Clear();
switch (op){
    case 1:
        double MAIOR = ObterMaior(num);
        Console.WriteLine(MAIOR);
        Console.ReadLine();
        break;
    case 2:
        double MENOR = ObterMenor(num);
        Console.WriteLine(MENOR);
        Console.ReadLine();
        break;
    case 3:
        double MEDIA = CalcularMedia(num);
        Console.WriteLine(MEDIA);
        Console.ReadLine();
        break;
    case 4:
        Console.WriteLine("Tenha um bom dia");
            Thread.Sleep(3000);
        sair=true;
        break;
    default:
    Console.WriteLine("Opção invalida");
        break;
}
}

static double ObterMaior(double[]Maior){
    double m=Maior[0];
    for(int i=1;i<Maior.Length;i++){
        if(m<Maior[i]){
            m=Maior[i];
        }
    }
    return m;
}

static double ObterMenor(double[]Menor){
    double m=Menor[0];
    for(int i=1;i<Menor.Length;i++){
        if(m>Menor[i]){
            m=Menor[i];
        }
    }
    return m;
}

static double CalcularMedia(double[]Vetor){
    double soma=0;
    for(int i=0;i<Vetor.Length;i++){
        soma+=Vetor[i];
    }
    double media= soma/Vetor.Length;
    return media;
}