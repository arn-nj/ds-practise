# GRAPH THEORY

## Common Problems 

```
Ask Yourself First for any Graph problems

1. Directed/Undirected
2. Weighted/Unweighted
3. Sparse/Dense with edges
4. Adjacency matrix, adjacency list or edge list or other
```

## Problems

| PROBLEM                       | ALGORITHM                                                    |
| ----------------------------- | ------------------------------------------------------------ |
| Shortest Path Problem         | BFS, Dijkstra's, Bellman-Ford, Floyd-Warshall, A*, and many more |
| Connectivity                  | Use Union find data structure or any search algorithm using DFS/BFS |
| Negative Cycles               | Bellman-Ford & Floyd-Warshall                                |
| Strongly Connected Components | Tarjans' and Kosaraju's algorithm                            |
| Traveling Salesman            | Held-Karp, Branch and Bound and Many apporximation algorithm (Ant colony optimization) |
| Bridges                       | DFS                                                          |
| articulation points           | DFS                                                          |
| Minimum Spanning Tree         | Kuskals, Prim's & Buruvka's algorithm                        |
| Network flow: Max flow        | Ford-Fulkerson, Edmonds-Karp & Dinic's algorithm             |

## DEPTH FIRST SEARCH

Explore nodes and edges of a graph. Used for Traversing

- As the name suggest, DFS plunges Depth first into graph  without regard for which edge it takes next until it cannot go any further at which point it backtracks and continues

![](/Users/Zara/Library/Application Support/typora-user-images/image-20200608224236552.png)

- Start at node 0 arbitartily pick any connected node

- While traversing if we visit any already visited node, then backtrack

  ### PSEUDOCODE FOR DFS

  ![](/Users/Zara/Library/Application Support/typora-user-images/image-20200608224829070.png)

  ### PSEUDOCODE CONNECTED COMPONENTS

  ![](/Users/Zara/Library/Application Support/typora-user-images/image-20200608225249990.png)

  ### WHAT ELSE with DFS?

  ![image-20200608225457073](/Users/Zara/Library/Application Support/typora-user-images/image-20200608225457073.png)

## BREADTH FIRST SEARCH

- A BFS starts at some arbitary node of the graph and explores neighbour node first, before moving to next level neighbours

- It maintains a queue like below

  ![image-20200608225901881](/Users/Zara/Library/Application Support/typora-user-images/image-20200608225901881.png)

- BFS uses queue data strcuture to track which node to visit next. Upon reaching the a new node, algorith adds to the queue and visit later

  ### PSEUDOCODE for BFS

  ![image-20200608230234304](/Users/Zara/Library/Application Support/typora-user-images/image-20200608230234304.png)

  ![image-20200608230259073](/Users/Zara/Library/Application Support/typora-user-images/image-20200608230259073.png)

  ![image-20200608230441227](/Users/Zara/Library/Application Support/typora-user-images/image-20200608230441227.png)

