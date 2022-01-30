void TransferArrayElem(string[] arrOfStr)
{
    int strSize = 3;
    int sizeNewArr = 0;
    for (int i = 0; i < arrOfStr.Length; i++)
    {
        if (arrOfStr[i].Length <= strSize) sizeNewArr++;
    }
    if(sizeNewArr > 0)
    {
        string[] newArrOfStr = new string[sizeNewArr];
        int index = 0;
        for(int i = 0; i < arrOfStr.Length; i++)
        {
            if (arrOfStr[i].Length <= strSize)
            {
                newArrOfStr[index] = arrOfStr[i];
                index++;
            }
        }
        Console.WriteLine("New array: [{0}]", string.Join(", ", newArrOfStr));
    }
    else Console.WriteLine("New array: []");
}

string[] arr = { "5t", "7dklb", "6789", "4e5d", "hgj", "yj", "5ghjck", "5hfls", "67h", "7sgdj", "fghjl", "tyj" };
TransferArrayElem(arr);