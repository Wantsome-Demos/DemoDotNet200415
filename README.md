# DemoDotNet 2020 04 15

### Write simple programs in C#:
* Guess game: computer chooses a random number in an interval (1..10) and the user has to guess it in 3 tries.
* Celsius degrees to Kelvin and Fahrenheit

#### Guess game 

Computer chooses a random number in an interval (1..10) and the user has to guess it in 3 tries.

Step V1
- genarate number (store somewhere)
- user insert number (store somewhere)
- compare user number with generated number
	- yes: success
	- no: try again
		- user insert number (store somewhere)
			- compare user number with generated number
				- yes: success
				- no: try again
					- user insert number (store somewhere)
						- compare user number with generated number
							- yes: success
							- no: try again

Step V2
- genarate number (store somewhere)
- for
	- user insert number (store somewhere)
		- compare user number with generated number
			- yes: success
			- no: try again, go to user insert number 