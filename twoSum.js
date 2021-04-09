// Ice cream parlor problem on hackerrank!
/*
Each time Sunny and Johnny take a trip to the Ice Cream Parlor, they pool their money to buy ice cream. On any given day, the parlor offers a line of flavors. Each flavor has a cost associated with it.

Given the value of  and the  of each flavor for  trips to the Ice Cream Parlor, help Sunny and Johnny choose two distinct flavors such that they spend their entire pool of money during each visit. ID numbers are the 1- based index number associated with a . For each trip to the parlor, print the ID numbers for the two types of ice cream that Sunny and Johnny purchase as two space-separated integers on a new line. You must print the smaller ID first and the larger ID second.

Example



They would purchase flavor ID's  and  for a cost of . Use  based indexing for your response.

Note:

Two ice creams having unique IDs  and  may have the same cost (i.e., ).
There will always be a unique solution.

*/

// Complete the whatFlavors function below.
function whatFlavors(cost, money) {
    //use hash map
    var dict = {};    
    for(let i = 0; i < cost.length; i++){
        let diff = money - cost[i];
        if(diff in dict){
            console.log(dict[diff] + " " + (i+1))
            return
        }
        dict[cost[i]] = i + 1;
    }
    console.log(dict)
}

whatFlavors([2,4,3,1,8],7)