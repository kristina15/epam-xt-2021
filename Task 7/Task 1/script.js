function taskFunc(str)
{
    var separator = ["?", "!", ":", ";", ",", ".", " ", "\t"];
    var arr = str.split(''), letters = {}, start = 0, words = [], result;
    
    arr.forEach(function (letter, i) {
        if (separator.indexOf(letter) != -1) {
            words.push(str.substr(start, i - start));
            start = i + 1;
        }
    });

    words.push(str.substr(start));
    words.forEach(function (word) {
        word.split('').forEach(function (letter, i) {
            if (!letters[letter] && -1 != word.indexOf(letter, i + 1)) {
                letters[letter] = 1;
            }
        });
    });

    result = arr.filter(function (v) {
        return !letters[v];
    }).join('');

    alert(result);
}