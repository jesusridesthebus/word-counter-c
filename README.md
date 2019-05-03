# _Word Counter_

#### _Word Counter solo project 4/26/19 & 5/3/19_

#### By _**Liz Kelley**_

## Description

Use C# to gather a word and a sentence from a user, and check how frequently that word appears in the sentence.

## Specs

| Behavior | Input | Output | Input Explanation |
| ------------- |:----------------:| --------:| --------------------------:|
| Gather a word from user | hey | hey | I selected "hey" as the input because it is a simple and short word |
| Check for how frequently a word appears in a one-word sentence | hey | 1 | I selected "hey" as the input because it is a simple and short word |
| Gather a sentence from user | They said hey | They said hey | I selected this sentence as the input because it is a short sentence that includes the first word and another word that includes it within in the word ("they" includes "hey"). This will be helpful in subsequent tests in order to eliminate other words from the count that include the word being searched for.
| Check how frequently the first word appears in that sentence | They said hey | 2 | I selected this sentence as the input because when searching for the first word, it will return 2 instances because I have not further refined the test yet to exclude other words that include the first word ("they" includes "hey").
| Check how frequently the first word appears in that sentence, NOT counting when it appears as part of another word | They said hey | 1 | I selected this sentence as the input because once I narrow down the tests you can easily see how I have excluded other words that include the first word ("they").

## Setup/Installation Requirements

1. Clone GitHub
2. Run from the terminal

## Known Bugs

No known bugs

## Support and contact details

123@123.com

## Technologies Used

C#, .NET

### License

MIT

Copyright (c) 2019