// In this challenge, you must first implement a queue using two stacks. Then process  queries, where each query is one of the following  types:

// 1 x: Enqueue element  into the end of the queue.
// 2: Dequeue the element at the front of the queue.
// 3: Print the element at the front of the queue.

function processData(input) {
    //Enter your code here
    //1 - put on the end
    //2 - dequeue the element at front
    //3 - print the element at front
    let arr = input.split("\n");
    let q = [];
    for(let i = 1; i < arr.length; i++){
        if(arr[i].startsWith(1)){
            let num = arr[i].split(" ");
            let result = num[1];
            q.push(result);
        }
        if(arr[i] === '3'){
            console.log(q[0]);
        }
        if(arr[i] === '2'){
            q.shift();
        }
    }
} 
