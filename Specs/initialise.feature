Feature: Rover Initialis

The rover is initialised 

Scenario Outline: The rover is initialised in the correct position
Given "The Operator" is prompted with initialising the rover with "please enter initial coordinates and direction for rover"
When "The Operator" enters "4,7 N"
Then the rover is initialised at coordinate 4,7 facing north
And the system confirms that the rover is at 4,7 facing north "Rover is at 4,7 facing north"
And "The Operator" is prompted with instructions for movement "Please enter movement commands"


