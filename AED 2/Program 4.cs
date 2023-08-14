string s; char c; int i, posicao, rep=0, rpi;

Console.WriteLine("Digite uma sentença");
s=Console.ReadLine();
Console.WriteLine("Digite um caracter");
c=Convert.ToChar(Console.ReadKey(true).KeyChar);
Console.WriteLine(@"
Digite uma posição");
i=Convert.ToInt32(Console.ReadLine());
posicao=s.IndexOf(c,i);
if(posicao!=-1){
    rpi=posicao;
    for(int j=posicao;j<s.Length;j++){
        posicao=s.IndexOf(c,j);
        if(posicao!=rpi){
            rep+=1;
            rpi=posicao;
        }
    }
    Console.WriteLine($"Esse caracter se repete {rep} vezes na frase");
}
else{
    Console.WriteLine("Caracter não existente na sentença");
}