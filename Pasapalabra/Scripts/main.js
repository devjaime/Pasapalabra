// Game logic
function IsGameOn() {

    getQuestions(function (questions) {
        if (questions.length !== 0) {
            var currentLetter = getLetter();
            var currentQuestion = getQuestionByLetter(currentLetter);
            showQuestion(currentQuestion);
        }
        // Otherwise, game over
        else {
            gameOver();
        }
    });
}

function getQuestions(callback) {
    $.ajax({
        url: '/Questions/GetQuestions',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            callback(data);
        },
        error: function (error) {
            alert("Error");
        }
    });
}

// Returns db question that matches given id from getRandomQuestion
function getQuestionByLetter(letter) {
    $.ajax({
        url: '/Questions/GetQuestionByLetter/' + letter,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            return data;
        },
        error: function (error) {
            alert("Error");
        }
    });
}

// Returns letter by its 0-26 position
function getLetter() {
    var asciiPosition = 65; // 65 = 'A'
    for (var i = 0; i < questions.length; i++) {
        if (questions[i].Letter !== null) {
            asciiPosition += i;
            break;
        }
    }
    return String.fromCharCode(asciiPosition);
}