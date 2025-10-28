# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
The camera stays in place and the cat moves around the world with the player's view stuck.
### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1. r, g, and b values are floats since the RBG system is from 0-1 and floats allow for decimals

2. the _bounce variable is an int as bounces are cout in whole numbers

3. The error tels you the line number and ; expected

### W3

parameters: sanity int
Return: void
metaphor: Batman is our class and his gadgets are the member variables. His ability to use those variables are his methods. He can attach himself to the
botmobile to control its functions like attaching a script to a gameobject to make it a component.

2. There is no set limit to the brightness so it will scale brightness until white

### W4
Table 16
Line 17: creates a private, boolean, member variable that is set to true
Line 28: An if statement to check if the space key is down AND the _isgrounded member variable is true
Line 32: Sets the _isgrounded to false at the end of the if statement

1. The cat and ball has a rigidbody and the goal has trigger on.
2. I had ParticleSystem.Play() instead of _goalvfx.Play(), had to figure out to put the particle rather than the class

### W5
Question: How do you use the component reference.

Answer: The get component method gets the component itself as a reference. For example in MG4, using the on collision method, the BallW3 script was obtained 
and that reference could be used to call methods from that script

Plan: create a serialize field of the player game object, get the player transform component form that game object. 
Get the navmesh agent component from the deer and use setdestination to have the deer follow the transform position of the player using the gameobject reference
(this is in update)

Member variables: _cat gameObject & _catTransform of the Transform component
Methods: update method



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 

Hello World