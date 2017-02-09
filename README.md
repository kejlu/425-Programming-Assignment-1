Name: Kevin Lu
Assignment Name: Programming Assignment 1, Part I

To see my work in Unity after opening it:
Under Project...
Assets -> _scenes -> Minigame

A. Required Elements:
- Use WASD or arrow keys to tilt board
- Maneuver the ball into green circle to win
- Hit 'R' to restart
- Hit 'Q' or 'ESC' to quit

B. Additional Elements:
- Particles emit 90 degrees upward, regardless of board tilt (not quite extra tho worth mentioning amirite)
- Created rotating pickup items that disappear when ball contacts
- Added music from another video game, hehe

C. Known Issues:
- Board can get stuck at a tilt (e.g. when starting, first going in upmost leftmost direction. The board however does not seem to get stuck if you go in any other direction first before going back to upmost leftmost)
- Green circle does not display wholely when tilting board

D. External Resources:
- Unity's Roll-a-ball tutorial videos
- Game Design HQX's tilt maze puzzle game tutorial videos
- HowToMakeMobileGames's video tutorial on how to add music
- Bravely Default music

E. Non-issues tho worth mentioning or concerns:
- With Unity's default settings, a restart ('R') will restart as intended but the lighting will be different.
To restart lighting too:
Window -> Lighting -> Lightmaps Tab -> Disable Continuous Baking -> Build
- The ball (Physic Material with 0.5 bounciness) seems much more bouncy than the ball in Dr. Mount's executable.
To fix, simply reduce Physic Material bounciness

