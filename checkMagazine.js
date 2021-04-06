/*

Harold is a kidnapper who wrote a ransom note, but now he is worried it will be traced back to him through his handwriting. He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note. The words in his note are case-sensitive and he must use only whole words available in the magazine. He cannot use substrings or concatenation to create the words he needs.

Given the words in the magazine and the words in the ransom note, print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No.

*/

// Complete the checkMagazine function below.
function checkMagazine(magazine, note) {
    var dict = {}
    for(let i = 0; i < magazine.length; i++){
        if(dict[magazine[i]]){
            dict[magazine[i]]++;
        }else{
            dict[magazine[i]] = 1;
        }
    }
    // console.log(dict);
    for(let j = 0; j < note.length; j++){
        if(!dict[note[j]] || dict[note[j]] < 1){
            console.log("No");
            return;
        }else{
            dict[note[j]]--;
        }
    }
    // console.log(dict);
    console.log("Yes");
    return;
}


var magazine = "give me one grand today night";
var note = "give one grand today";

checkMagazine(magazine, note);