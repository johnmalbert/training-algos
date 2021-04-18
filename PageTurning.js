//calculate the minimum number of page turns required to get to a given page p
function pageCount(n, p) {
    /*
     * Write your code here. 1,2-3,4-5,6-7
     */
    let min = n;
    let counter = 0;
    //loop from start
    let start = 1;
    while(start < p){
        start += 2; //page turn
        console.log(start);
        counter++;
    }
    min = counter;
    start = n;
    counter = 0;
    if(n % 2 === 1){
        start--;
    }
    while(start > p){
        start -= 2;
        console.log(start);
        counter++;
    }
    if(counter < min){
        min = counter;
    }
    //loop from back
    return min;
}