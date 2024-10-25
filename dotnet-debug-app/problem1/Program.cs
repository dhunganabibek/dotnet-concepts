List<int> list = [1, 2, 3];
// Function declartion
bool isOddFD(int num)
{
    return num % 2 == 0;
}

//function expression
Func<int, bool> isOddFE = num => num % 2 == 0;

list.Where(isOddFD);
