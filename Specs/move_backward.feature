Feature: Rover moves backwards

Rover Moves backwards

Scenario Outline: The rover moves backwards
Given the rover is facing "North"
And is at coordinate "3,2"
And "The Operator" is being prompted for a command
When "The Operator" enters "B" 
Then "The Rover" will be at "3,1" facing "North"
And the system confirms "The rover is at 3,1 facing North"
And "The Operator" is prompted with instructions for movement "please enter movement commands"