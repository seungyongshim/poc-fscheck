using FsCheck;
using FsCheck.Fluent;
using FsCheck.Xunit;
using static Sample.Prelude;

namespace Sample.Tests;

public class PreludeSpec
{
    [Property]
    public Property Muliply_2_Is_Same_As_Adding_Same_Number(int x) =>
        (x * 2 == add(x)(x)).ToProperty();

    [Property]
    public Property Adding_Tow_Number_Doesnt_Order() =>
        Prop.ForAll((int x, int y) => add(x)(y) == add(y)(x));
            
}
