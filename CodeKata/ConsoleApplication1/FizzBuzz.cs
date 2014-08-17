using System;

public class FizzBuzzKata : IFizzBuzzKata
{
    public string Answer(int i)
    {
        string answer = "";
        if (i % 3 == 0) { answer += "Fizz"; }
        if (i % 5 == 0) { answer += "Buzz"; }
        return answer;
    }
}

public interface IFizzBuzzKata
{
    string Answer(int number);
}