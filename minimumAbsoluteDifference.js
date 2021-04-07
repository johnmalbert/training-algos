function minimumAbsoluteDifference(arr) {
    let min = Infinity;
    for(let i = 0; i < arr.length; i++){
        for(let j = i + 1; j < arr.length; j++){
            let num = Math.abs(arr[i] - arr[j]);
            if(num < min){
                min = num;
            }
        }
        if(min === 0){
            return min;
        }
    }
    return min;
}
/*
The absolute difference is the positive difference between two values a=3 and b=2 , is written  or  and they are equal. If  and , . Given an array of integers, find the minimum absolute difference between any two elements in the array.

Example. arr=[-2,2,4], should return 2.

There are  pairs of numbers:  and . The absolute differences for these pairs are ,  and . The minimum absolute difference is .

Function Description

Complete the minimumAbsoluteDifference function in the editor below. It should return an integer that represents the minimum absolute difference between any pair of elements.
*/

// Complete the minimumAbsoluteDifference function below.