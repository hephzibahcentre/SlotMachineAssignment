# SlotMachineAssignment

# ITEC140-A06

At the end of this assignment you should have an application like this:

<img width="500" alt="Finished Program" src="https://user-images.githubusercontent.com/6656242/197042203-11efe93d-0d4c-4850-aa1d-836d72a989b9.png">

Notes:
- If you encounter rounding errors for the double data type, use either Math.Round(dblVariable, 2) OR switch to decimal data types which are better data types for dealing with money.
- The assignment requires you to make 6 git commits, make more if you need to.

Ensure you are:
- Naming all controls and variables with proper meaningful names
- Commenting on your code
- Completing each step before moving on to the next step
- Making a Git commit at each step that is required

## Step One - Do some planning
- Access draw.io from your browser and make a flow chart
  - A check to see if the first spinner is equal to the second and third spinner (A = B = C) 
  - If this is NOT TRUE the user will lose the money they bet. 
  - When this condition is TRUE a nested if statement will check the number and save a double value in memory that will be used to multiply the bet and provide a payout.

Once complete attach the flowchart below in this readme file, to replace the placeholder image below:

![400](https://user-images.githubusercontent.com/6656242/197043364-94933448-40f7-43f2-9b76-4af179176c7f.png)

(It is suggested to just edit the readme file in Github, ask for a demo on how to do this, if I forget...)

## Step Two - Build the basics

- Place 3 labels on the form to act as spinners.
- Create a Random object field variable for the whole form to access.
- Create three integer values also scoped to the entire form, these will hold the spinner values. (e.g. intSpin1, intSpin2, intSpin3)
- Add a button to "spin" the machine.  
  * When the button is pressed we will generate three random values between 1 and 6 inclusive (Random.Next(1,7) in C#.NET) 
  * The values will be stored in memory at the variables declared previously and also displayed on the screen as three labels
- When you are successfully generating three numbers and displaying them on the screen, Make a git commit: ***Step Two Complete***

<img width="402" alt="Basics" src="https://user-images.githubusercontent.com/6656242/197044444-83ff204b-f436-46f6-98d4-b2db051a968d.png">

## Step Three - Build the basics

- Make sure you made a git commit of the work you did in step 2.
- Create three double variables scoped to the entire form to keep track of:
  - Money won
  - Money lost
  - Net amount (Money won - Money lost)
- Note here that money won and money lost both keep incrementing as positive numbers
- Make a label on the form for each of the double variables we declared
- Create four buttons that will represent the current amount of money being bet
  - Five cents
  - Ten cents
  - Twenty five cents
  - One dollar
- Create a double variable in memory that will hold the value of the button that is selected {0.05, 0.10, 0.25, 1.00} this variable represents the amount of money that will be bet.
  - Note that only one of these four values will be stored as the bet amount at any given time.
  - When one of the four buttons is pressed, that buttons BackColor property will change to your favorite color to show that it is selected, all other buttons will return to gray or white.
- Make a git commit: **Step Three Complete**

<img width="438" alt="Bets" src="https://user-images.githubusercontent.com/6656242/197047798-ce378560-5221-435b-bd9d-09c6efef3270.png">

## Step Four - Keep Track of Money

- Make sure the work you completed in step 3 is comitted to github.
- In the spin button click event, after we are generating numbers for the spinners we should check to see if spinner1 = spinner2 and spinner1 = spinner3 (all spinners have the same value)
  - If the condition above is TRUE add the value currently set in the bet amount to the variable you declared in step Three for **Money won**.
  - Else, if the condition is FALSE add the value in the bet amount to the variable you declared in step Three for **Money lost**.
  - Just below the if statement above calculate the new value for the last variable declared in step Three **Winnings minus losses**
- Display the values of Money won, Money lost, and Net amount on the form

<img width="440" alt="Money" src="https://user-images.githubusercontent.com/6656242/197049075-45e268c5-25f6-436c-91d6-6a3c1efd82ea.png">

## Step Five - Multiply the Winnings

- In the previous step Four we added the winnings to our Money won variable, just before that statement add if and if else statements to check the value that is currently in one of spinner1,spinner2,spinner3 (they are all the same value at this point).  Use this reference to check values and assign the correct multiplier:
1. 2.00
2. 3.25
3. 4.5
4. 5.75
5. 8.25
6. 16.00

- So for example if all three spinners are equal to 3, the multiplier variable will become 4.5
- Modify the statement where Bet amount is being added to the Money won variable to include the newly defined multiplier.
- Note the multiplier will not apply to Money lost
- Make a git commit: **Step 5 Complete**

## Step Six - Bells and Whistles

Ensure the progress you made in Step Five is comitted to Github.

Image properties can be assigned using the Bitmap object... ```Bitmap imgFile = new Bitmap("../../../resources/path_to_file.png");```

```cs
//example of defining the orange and bell
Bitmap orange = new Bitmap("../../../resources/orange.png");
Bitmap bell = new Bitmap("../../../resources/bell.png");
```

- Change the spin button property: BackgroundImage to show handle.png
- Note the command is: ```btnSpin.BackgroundImage = new Bitmap("handle.png");```
- BackgroundImageLayout property can be used to stretch so the image fits correctly
- Choose 6 images from the files provided in the bin debug folder
  - bar.png
  - bell.png
  - cherry.png
  - grape.png
  - lemon.png
  - melon.png
  - orange.png
  - plum.png
  - seven.png
- Assign each image a number on paper not in code yet {1 to 6} for example 1 = melon.png, 2 = orange.png, etc
- Where the three spinner labels currently exist, create three picture boxes
- Instead of using the Click event on the button split the existing functionality two events:
  - Mouse Down Event
    - Change the image of each spinner picture box to the provided spinning.gif
    - Change the spin buttons BackgroundImage to the provided handle_compressed.png
- Mouse Up Event
  - All of the existing logic from the click event
  - Change the spin button back to the provided handle.png
- Change the image of each spinner picture box to the corresponding image you have generated {1-6} using three if statements

At this point your assignment is complete, here is a screenshot to show what controls you should have in the applciation:

<img width="500" alt="Controls Labeled" src="https://user-images.githubusercontent.com/6656242/197052151-a2d76438-628c-4212-86c9-bd3cf5437ea1.png">


Here is an example of a previous students working program:

https://user-images.githubusercontent.com/6656242/197054201-a818a601-fd42-4a7e-a641-439d6255e2d4.mp4


## Hand-In
Please download the finished code from Github and upload it to Blackboard before the due date.

 
## Expectations
This assignment should be completed individually, please ask your instructor for clarification where needed.  Receiving help or feedback from classmates is okay, but do not share or copy any materials that will be added to the assignment submission.  Help your classmates learn to program but, do not share code/files.  Any code that you find on the internet can be referenced in comments, where necessary.
