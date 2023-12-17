
public string fizzbuzz(string number)

    //Write a public method that accepts a number
    //when the number is divisible by 3 return the word fizz
    var answer = "";
    
    if (number % 3 == 0)
    {
        answer = "fizz";
    }

    //when the number is divisible by 5 return the word buzz
    if (number % 5 == 0)
    {
        answer += "buzz";
    }
    return answer;
    //when the number is divisible by both, return the word fizzbuzz