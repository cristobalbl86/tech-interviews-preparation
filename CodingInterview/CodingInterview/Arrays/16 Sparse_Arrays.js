function matchingStrings(strings, queries) {

    let results = [];
    let counter = 0;

    for (let q of queries) {
        for (let s of strings) {
            if (q === s) {
                counter++;
            }
        }
        results.push(counter);
        counter = 0;
    }

    return results;
}