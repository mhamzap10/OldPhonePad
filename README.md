# OldPhonePad

The Class Program consists of Three Functions:

OldPhonePad(String Input):

	This method takes Input String in the parameter. 
	
	There are three main variables that is used. 
	Previous Letter => This Variable will hold the last input letter (Last entered button Number) Initialze it with first Character of the Input
	PressedCount => This Variable will hold the Pressed Count of that button
	Output => This Variable will store final result of this function.
	
	First We will loop through each Character of the String.
	
	Declare and Initialze CurrentLetter Variable, this will hold the letter which we are looping through such as ith index of the input string.
	Now, check if the current Character is same as Previous such as user has pressed it multiple time, than just Increment the Pressed Counter, and continue to the next character in the string
	If Current Character is not same as Previous, rather it is a * character It means we need to skip this.Assign Next Value to the Current Character and marked its Pressed Count to 0.
	Now, Let's Current Character is neither same as previous nor it is a '*'
	So, No we will find it's respective output character.
	First Check if Previous Charcter is 7 or 9, because it has 4 alphabets
	Check if pressed count > 4, Assign PressedCount -=4; such that If user has input same letter multiple time, it will cycle through
	For rest of the Numbers, Check if Pressed Count > 3, Assign PressedCount -=3,
	
	Now, Call GetAlphabet(PreviousLeter, PressedCount), method and concatinate the return alphabet to the Ouput Variable.
	
	check if current loop letter is '#' return output and end function
	else, assign PreviousLeter = CurrentLetter and PressedCount = 1;


GetAlphabet(char input, int count):

	This method takes inputNumber and its pressed Count
	Based on the Number Input and PressedCount, It will return respective alphabet
	
Main Function:

	This function just call OldPhonePad() with different input to test the program.
	
	
