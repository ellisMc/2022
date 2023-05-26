bool isHarshad(int number)
{
    string holder = number.ToString();
    int total = 0;
    foreach(char c in holder)
    {
        total += ((int)c - 48);
    }
    if(number % total == 0)
    {
        return true;
    }
    return false;
}

int getHarshad(int n)
{
    int count = 0;
    int nth = 0;
    while(nth < n)
    {
        count++;
        if (isHarshad(count))
        {
            nth++;
        }
    }
    return count;
}

Console.WriteLine(getHarshad(600));
