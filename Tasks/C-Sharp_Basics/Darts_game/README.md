## Darts Game

Implement a *GetScore* method that calculates the earned points in a single toss of a Darts game. In the game, the target is rewards with 4 different amounts of points, depending on where the dart lands:
- if the dart lands outside the target, a player earns no points (0 points);
- if the dart lands in the outer circle of the target, a player earns 1 point;
- if the dart lands in the middle circle of the target, a player earns 5 points;
- if the dart lands in the inner circle of the target, a player earns 10 points.  
The outer circle has a radius of 10 units (This is equivalent to the total radius for the entire target), the middle circle has a radius of 5 units, and the inner circle has a radius of 1. Of course, they are all centered to the same point (That is, the circles are concentric) defined by the coordinates (0, 0).