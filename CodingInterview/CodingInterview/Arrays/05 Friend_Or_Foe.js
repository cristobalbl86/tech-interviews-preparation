﻿/*
FRIEND OR FOE

Make a program that filters a list of strings and returns a list with only your friends name in it.
If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]
i.e.
    friend["Ryan", "Kieran", "Mark"]`shouldBe`["Ryan", "Mark"]
Note: keep the original order of the names in the output.

*/
function friend(friends) {

    return friends.reduce((next, cur) => {
        if (cur.length === 4)
            next.push(cur);

        return next;
    }, []);

}



//OTHER SOLUTIONS(BEST PRACTICES)
function friend(friends) {
    return friends.filter(n => n.length === 4)
}

//TEST CASES
Test.assertSimilar(friend(["Ryan", "Kieran", "Mark"]), ["Ryan", "Mark"]);
Test.assertSimilar(friend(["Ryan", "Jimmy", "123", "4", "Cool Man"]), ["Ryan"]);
Test.assertSimilar(friend(["Jimm", "Cari", "aret", "truehdnviegkwgvke", "sixtyiscooooool"]), ["Jimm", "Cari", "aret"]);
Test.assertSimilar(friend(["Love", "Your", "Face", "1"]), ["Love", "Your", "Face"]);
