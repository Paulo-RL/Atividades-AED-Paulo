double [] n= new double[5];
for(int i=0; i < n.Length;i++){
    Console.WriteLine($"Digite o {i+1}º número");
    n[i]=Convert.ToDouble(Console.ReadLine());
}
double menor=Menor(n);
int ind=0;
for(int i=0; i<n.Length;i++){
    if(menor==n[i]){
        ind=i;
    }
}
double pri= n[0];
n[0]=n[ind];
n[ind]= pri;
for(int i=0;i<n.Length;i++){
    Console.WriteLine(n[i]);
}


static double Menor(double [] n){
    double m=n[0];
    for(int i= 1; i<n.Length;i++){
        if(n[i]<m){
            m=n[i];
        }
    }
    return m;
}
