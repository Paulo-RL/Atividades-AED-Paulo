/* int [] x  = new int [5];
int [] y = new int [5];

for(int i=0;i<x.Length;i++){
    Console.WriteLine($"Digite o {i+1}º número de X");
    x[i]= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Digite o {i+1}º número de Y");
    y[i]= Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");
Console.WriteLine("Qual Operação deseja:\nsoma(+)\nsubtração(-)\nmultiplicação(*)\ndivisão(/)");
char op = Convert.ToChar(Console.ReadLine());
switch(op){
    case '+':
        for(int i=0; i<x.Length;i++){
            Console.WriteLine($"{i+1}º resultado {x[i]+y[i]}");
        }
        break;
    case '-':
        for(int i=0; i<x.Length;i++){
            Console.WriteLine($"{i+1}º resultado {x[i]-y[i]}");
        }
        break;
    case '*':
        for(int i=0; i<x.Length;i++){
            Console.WriteLine($"{i+1}º resultado {x[i]*y[i]}");
        }
        break;
    case '/':
        for(int i=0; i<x.Length;i++){
            double resultado = x[i]/y[i];
            Console.WriteLine($"{i+1}º resultado {resultado}");
        }
        break;
} */