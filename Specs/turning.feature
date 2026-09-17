Feature: Rover Turns Left

Given the rover is facing "North"
And is at coordinate "3,2"
And "The Operator" is being prompted for a command
When "The Operator" enters "L" 
Then "The Rover" will be at "3,2" facing "West"
And the system confirms "The rover is at 3,2 facing West"
And "The Operator" is prompted with instructions for movement "please enter movement commands"
