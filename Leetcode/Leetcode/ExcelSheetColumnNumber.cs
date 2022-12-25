namespace Leetcode;

public class ExcelSheetColumnNumber
{
    public int TitleToNumber(string columnTitle)
    {
        var result = 0;
        foreach (var c in columnTitle)
        {
            result = result * 26 + c - 'A' + 1;
        }
        return result;
    }
}