/* int [,] x  = new int [4,4];
int nulo=0, conulo=0;
for(int i=0;i<4;i++){
    for(int j=0;j<4;j++){
    Console.WriteLine($"Digite o elemento dsa linha {i} e coluna {j}");
    x[i,j]= Convert.ToInt32(Console.ReadLine());
    }
    if(x[i,0]==0 && x[i,1]==0 && x[i,2]==0 && x[i,3]==0){
        nulo+=1;
    }
}
for(int i=0;i<4;i++){
    if(x[0,i]==0 && x[1,i]==0 && x[2,i]==0 && x[3,i]==0){
        conulo+=1;
    }
}
Console.WriteLine(@$"Esta matriz tem {nulo} linha(s) nula(s)
Esta matriz tem {conulo} coluna(s) nula(s)"); */