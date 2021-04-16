// Complete the circularArrayRotation function below.
//Hackerrank puzzle
function circularArrayRotation(a, k, queries) {
    console.log(queries);
    for(let i = 0; i < k; i++){
        //move the number on the end to the front.
        let endElement = a[a.length-1];
        a.pop();
        a.splice(0,0,endElement);
    }
    let newArr = []
    for(let i = 0; i < queries.length; i++){
        newArr.push(a[queries[i]]);
    }
    
    return newArr;
}