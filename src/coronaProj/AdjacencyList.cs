using System; 
using System.Collections.Generic; 
  
class GFG{ 
  
// Function to insert vertices to adjacency list 

public static void insert(List<int> []adj, 
                        int u, int v) 
{ 
      
    // Insert a vertex v to vertex u 
    adj[u].Add(v); 
    
     
} 
  
// Function to display adjacency list 
 public static void printList(List<int> []adj,  
                           int V) 
{ 
    for(int i = 0; i < V-1; i++) 
    { 
        Console.Write(i); 
  
        foreach(int j in adj[i]) 
            Console.Write(" --> " + j); 
              
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
}  public static void printList(List<city> cit,List<int> []adj,  
                           int V) 
{ 
    for(int i = 0; i < V-1; i++) 
    { 
        Console.Write(cit[i].getName()); 
  
        foreach(int j in adj[i]) 
            Console.Write(" --> " + cit[j].getName()); 
              
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 
  
// Function to convert adjacency 
// list to adjacency matrix 
public static int[,] convert(List<int> []adj, 
                           int V) 
{ 
      
    // Initialize a matrix 
    int [,]matrix = new int[V, V]; 
  
    for(int i = 0; i < V-1; i++)  
    { 
        foreach(int j in adj[i]) 
            matrix[i, j] = 1; 
    } 
    return matrix; 
} 
  
// Function to display adjacency matrix 
public static void printMatrix(int[,] adj, int V) 
{ 
    for(int i = 0; i < V-1; i++)  
    { 
        for(int j = 0; j < V-1; j++) 
        { 
            Console.Write(adj[i, j] + " "); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
}} 