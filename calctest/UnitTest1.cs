using System.Reflection;

namespace calctest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 10;
        int b = 20;
        int expected = 30;


        int result = Program.Add2Nos(a,b);

        Assert.Equal(expected,result);
    }
}
