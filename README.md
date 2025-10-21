# in-class-activities
## Devlogs
### W1
Hello World!

### W2
1.The r, g, and b variable are floats because these values are fractions and not whole numbers, true or false, or text. 
2.The _bounce variable is an int because it's value is a whole number, and bounces the same way every single time, hence _bounce++;
3.The error that I got after step X of Part 2 reminded me to use a semicolon at the end of the line of code I made. This is similar to punctuation and is necessary for the computer to understand what I'm trying to code in order for it to work properly

### W3
Table #18
Table answer:

void SetLightDimness (float x) {
    float light = 100 * x
}
Since the method is not being returned, it starts with void. The parameter is the sanity level of the player which is multiplied by 100 and stored in a light variable to adjust the ingame light accordingly.

The relationship between classes and components are like a tree. The scene makes up a game, which is made up of game objects, which have components. A component can be a script which is made up of classes which can be defined as a monobehaviour. In classes, methods are defined and called within which have variables and sets of code.

The balls get extremely bright because the ball is getting multiplied by a brightness multiplier

### W4
Table #18
Lines 17, 28, and 32.
Line 17 is a private boolean member variable under the CatW4 class
Line 28 is an if statement, checking whether the user is pressing space and is on the ground, so if if they're jumping, _isGrounded is false
Line 32  _isGrounded member variable set to false, BECAUSE user is jumping

The objects that we added to the rigidbodies are the cat and ball. I checked IsTrigger on the goal. 

My game didn't work when I did this, because when I collided with the goal my cat started spinning. This was because I didnt freeze the Z Axis on my cat, so it wouldn't stop. It also depended on my specific capsule collider size. 



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 