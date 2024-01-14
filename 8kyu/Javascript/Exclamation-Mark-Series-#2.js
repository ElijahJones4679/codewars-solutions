//              Instructions
/* Remove all exclamation marks from the end of sentence.*/

//              Solution

function remove (string) 
    {  
        return string.replace(/!*$/g, '');
    }