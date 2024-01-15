//              Instructions
/* Remove all exclamation marks from the end of sentence.*/
//codewars: link - https://www.codewars.com/kata/57faece99610ced690000165/javascript
//              Solution

function remove (string) 
    {  
        return string.replace(/!*$/g, '');
    }