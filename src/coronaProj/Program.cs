using System;
using System.Collections.Generic;
using System.IO;

namespace coronaProj
{
    class Program
    {
        static void Main(string[] args)
        {int numberOfcity = 0 ;

            List<city> cit = new List<city>();

            int i = 1 ; 
 string[] lines = System.IO.File.ReadAllLines(@"file.txt");
numberOfcity  = Int32.Parse(lines[0]);

  List<int> []adjList = new List<int>[numberOfcity]; 
    for( i = 0; i < adjList.Length; i++) 
        adjList[i] = new List<int>(); 
 i = 0; 
for(;i<numberOfcity;i++){
string[] s = lines[i+1].Split(' ');

cit.Add(new city($"{s[0]}",
             Int32.Parse(s[1]),
             Int32.Parse(s[2]),
             Int32.Parse(s[3]),
             Int32.Parse(s[4]),
             i));


}
int x = 0 , v =0;;
for(i=numberOfcity+1;i<=lines.Length-1;i++){
    string[] s = lines[i].Split(' ',',','\n');
//Console.WriteLine(s[0]);
//Console.WriteLine(s[1]);
   for (int y = 0; y < numberOfcity; y++)
   {
   city w = cit[y];
  
if (string.Compare(w.getName(),s[0])==0){
x=w.getid();
//Console.WriteLine(x);
}

if(string.Compare(w.getName(),s[1])==0){
v=w.getid();
//Console.WriteLine(v);
}

}
GFG.insert(adjList,x,v);
}
for(i=0;i<cit.Count;i++){
Console.WriteLine(cit[i].print());}
//GFG.printList(adjList,numberOfcity);
GFG.printList(cit,adjList,numberOfcity);

 int[,] xa = GFG.convert(adjList,numberOfcity);
 GFG.printMatrix(xa,numberOfcity);

}
                
 }

    }
