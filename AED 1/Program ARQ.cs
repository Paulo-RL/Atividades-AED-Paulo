using System;
using System.IO;
using System.Text;


string [] nomes = {"Perna Longa", "Pluto", "Mickey", "Bob Esponja", "Cebolinha"};
int [] voto = {0,0,0,0,0};
int nulo = 0;
try
{
    string caminhoArquivo = @"C:\Aulas - 2º semestre\AED 1\votos.txt";
    if (File.Exists(caminhoArquivo))
    {
            string [] conteudo= File.ReadAllLines(caminhoArquivo);
            Console.Clear();
            foreach(string l in conteudo){
            switch(l){
                case "0":
                    voto[0]+=1;
                    break;
                case "1":
                    voto[1]+=1;
                    break;
                case "2":
                    voto[2]+=1;
                    break;
                case "3":
                    voto[3]+=1;
                    break;
                case "4":
                    voto[4]+=1;
                    break;
                default:
                    nulo+=1;
                    break;
            }
            }
        int MA= MaisVotos(voto);
        int ME = MenosVotos(voto);
        Console.WriteLine($"O personagem mais votado é {nomes[MA]} com {voto[MA]} votos");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine($"O personagem menos votado é {nomes[ME]} com {voto[ME]} votos");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine($"Votos nulos: {nulo}");
        Console.WriteLine();
        Thread.Sleep(5000);
    }
    else
    {
        Console.WriteLine("O arquivo não existe no caminho especificado.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}

static int MaisVotos(int[]Mais){
    double m=Mais[0];
    int id = 0;
    for(int i=1;i<Mais.Length;i++){
        if(m<Mais[i]){
            m=Mais[i];
            id = i;
        }
    }
    return id;
}

static int MenosVotos(int[]Menos){
    double m=Menos[0];
    int id=0;
    for(int i=1;i<Menos.Length;i++){
        if(m>Menos[i]){
            m=Menos[i];
            id=i;
        }
    }
    return id;
}