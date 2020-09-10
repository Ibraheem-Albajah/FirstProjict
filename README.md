# FirstProjict
Cora graph 
Goals of the Task:

1. Get the intern familiar with the Graph Data structure 
2. Get the intern familiar with inheritance and interfaces in c#
3. Get The intern familiar with Generics in c#. 
4. improve intern's coding skills through intensive code review. 

Task: 

We need to create a (unweighted, undirected) graph data structure that represent a map between cities.

1. implement two the graph in the following representation methods:
    1. Adjacency matrix
    2. Adjacency list 

    see: [https://www.geeksforgeeks.org/graph-and-its-representations/](https://www.geeksforgeeks.org/graph-and-its-representations/)

2. Each Node of the graph should represent a city with that has the following info:
    1. City Name 
    2. City Population
    3. Number of Corona active cases
    4. number of death cases
    5. number of hospitals in that city 

3. We need to read the map from a file with the following format:

    ```csharp
    5  // First line represent number of cities 
    Nablus 100000 300 5 4 // cityName population activeCases deathCases numOfHodpitals
    Jenin 50000 65 4 3 
    Ramallah 200000 535 6 6 
    Hebron 500000 1345 10 8 
    Tulkarm 150000 453 2 4 //
    Ramallah Nablus // After the cities to the end of the file each line represent a path between tose cities
    Nablus Jenin
    Jenin Tulkarm
    Hebron Ramallah

    ```

4. Other Requirements to be added
