/*
A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) of the exact same type. There are three types of matched pairs of brackets: [], {}, and ().

A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. For example, {[(])} is not balanced because the contents in between { and } are not balanced. The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].
*/
// Complete the isBalanced function below.
function isBalanced(s) {
    // ()
    // ()}
    let stack = [];
    if(s[0] === ']' || s[0] === '}' || s[0] === ')'){
        return "NO"
    }
    for(let i = 0; i < s.length; i++){
        
        if(s[i] === '{' || s[i] === '(' || s[i] === '['){
            stack.push(s[i])
        }else{
            let last = stack.pop();
            if(last === '(' && s[i] !== ')'){
                return "NO"
            }
            if(last === '{' && s[i] !== '}'){
                return "NO"
            }
            if(last === '[' && s[i] !== ']'){
                return "NO"
            }            
        }
    }
    if(stack.length !== 0){
        return "NO"
    }
    return "YES"
}
