using static E1.Basics;

namespace E1.Tests;

[TestClass]
public class BasicsTests
{
    /// <summary>
    /// تابع 
    /// Q0_Reverse
    /// باید ترتیب عناصر موجود در یک آرایه بجز اولی و آخری را معکوس کند
    /// </summary>
    [TestMethod]
    public void Q00_Reverse_Tests()
    {
        Assert.Inconclusive();
        /*
        // Test with an empty array
        int[] nums = new int[0];
        Basics.Q0_Reverse(nums);
        CollectionAssert.AreEqual(new int[0], nums);

        // Test with a single-element array
        nums = new int[] { 1 };
        Basics.Q0_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1 }, nums);

        // Test with a two-element array
        nums = new int[] { 1, 2 };
        Basics.Q0_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, nums);

        // Test with a multi-element array
        nums = new int[] { 1, 2, 3, 4, 5 };
        Basics.Q0_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 4, 3, 2, 5 }, nums);

        // Test with a multi-element array with duplicate values
        nums = new int[] { 1, 2, 2, 3, 3 };
        Basics.Q0_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 3, 2, 2, 3 }, nums);
        */
    }


    /// <summary>
    /// تابع 
    /// Q1_Reverse
    /// باید آرایه‌ای برگرداند که ترتیب عناصر موجود در آن معکوس آرایه ورودی بوده، بجز اولی و آخری
    /// دقت کنید آرایه ورودی نباید تغییر کند.
    /// </summary>
    [TestMethod]
    public void Q01_Reverse_Tests()
    {
        Assert.Inconclusive();
        /*
        // Test with an empty array
        int[] nums = new int[0];
        int[] result = Basics.Q1_Reverse(nums);
        CollectionAssert.AreEqual(new int[0], result);

        // Test with a single-element array
        nums = new int[] { 1 };
        result = Basics.Q1_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1 }, result);

        // Test with a two-element array
        nums = new int[] { 1, 2 };
        result = Basics.Q1_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, result);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, nums);

        // Test with a multi-element array
        nums = new int[] { 1, 2, 3, 4, 5 };
        result = Basics.Q1_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 4, 3, 2, 5 }, result);
        CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, nums);

        // Test with a multi-element array with duplicate values
        nums = new int[] { 1, 2, 2, 3, 3 };
        result = Basics.Q1_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 3, 2, 2, 3 }, result);
        CollectionAssert.AreEqual(new int[] { 1, 2, 2, 3, 3 }, nums);
        */
    }

    /// <summary>
    /// تابع 
    /// Q2_Reverse
    /// باید مانند 
    /// Q0_Reverse
    /// باشد. فقط برای هر نوع عنصری درست کار بکند.
    /// </summary>
    [TestMethod]
    public void Q02_Reverse_Tests()
    {
        Assert.Inconclusive();
        /*
        // Test with an empty array
        int[] nums = new int[0];
        Basics.Q2_Reverse(nums);
        CollectionAssert.AreEqual(new int[0], nums);

        // Test with a single-element array
        nums = new int[] { 1 };
        Basics.Q2_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1 }, nums);

        // Test with a two-element array
        nums = new int[] { 1, 2 };
        Basics.Q2_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, nums);

        // Test with a multi-element array
        nums = new int[] { 1, 2, 3, 4, 5 };
        Basics.Q2_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 4, 3, 2, 5 }, nums);

        // Test with a multi-element array with duplicate values
        nums = new int[] { 1, 2, 2, 3, 3 };
        Basics.Q2_Reverse(nums);
        CollectionAssert.AreEqual(new int[] { 1, 3, 2, 2, 3 }, nums);

        // Test with an array of a different type
        string[] words = new string[] { "apple", "banana", "cucumber", "orange", "cherry" };
        Basics.Q2_Reverse(words);
        CollectionAssert.AreEqual(new string[] { "apple", "orange", "cucumber", "banana", "cherry" }, words);
        */
    }

    /// <summary>
    /// کلاس 
    /// Human
    /// را به شکلی پیاده‌سازی کنید که نام و سن را در سازنده بگیرد و 
    /// تست زیر به درستی پاس شود
    /// </summary>    
    [TestMethod()]
    public void Q03_HumanTest()
    {
        //Assert.Inconclusive();
        
        Human h = new Human("Hooman", 21);
        Assert.AreEqual("Hooman", h.Name);

        h = new Human("Mozhgan", 18);
        Assert.AreEqual("Mozhgan", h.Name);
        
    }

    /// <summary>
    /// واسط 
    /// IHasAge
    /// را تعریف کرده و کلاس
    /// Human
    /// را به گونه‌ای بروز رسانی کنید که تست زیر پاس شود
    /// </summary>    
    [TestMethod()]
    public void Q04_HumanAgeTest()
    {
        Assert.Inconclusive();
        /*
        IHasAge h = new Human("Hooman", 21);
        Assert.AreEqual(21, h.GetAge());

        h = new Human("Mozhgan", 18);
        Assert.AreEqual(18, h.GetAge());
        */
    }

    /// <summary>
    /// متد 
    /// CalculateSum
    /// را بگونه‌ای پیاده‌سازی کنید که یک رشته شامل تعداد عدد و عملگر جمع را به عنوان پارامتر دریافت کرده و 
    /// مقدار معادل عددی را برگرداند.
    /// </summary>
    [TestMethod()]
    public void Q05_1_CalculateSumTest()
    {
        Assert.Inconclusive();
        
        // int result = Basics.Q5_CalculateSum("2+2");
        // Assert.AreEqual(4, result);

        // result = Basics.Q5_CalculateSum("2+4+4+3+4");
        // Assert.AreEqual(17, result);

        // result = Basics.Q5_CalculateSum("17+2+8+8+4+1+11");
        // Assert.AreEqual(51, result);
        
    }

    /// <summary>
    /// در صورتیکه رشته ورودی یک عبارت ریاضی صحیح نباشد
    /// لازم است متد
    /// CalculateTest
    /// یک
    /// Exception
    /// از نوع
    /// InvalidDataException
    /// پرتاب کند.
    /// </summary>
    [TestMethod()]
    [ExpectedException(typeof(InvalidDataException))]
    public void Q05_2_CalculateSumTestInvalid()
    {
       Assert.Inconclusive();
        
        // string exp = string.Empty;
        // int len = Random.Shared.Next(1, 10);
        // for (int i = 0; i < len; i++)
        //     exp += $"{Random.Shared.Next(1,20)}+";

        // int result = Basics.Q5_CalculateSum(exp);
        
    }

    /// <summary>
    /// همچنین لازم است در صورتیکه زیررشته موجود در عبارت بین علامت‌های جمع از نوع
    /// عدد صحیح نباشد
    /// Exception
    /// متناظر آن رخ دهد.
    /// </summary>
    [TestMethod()]
    [ExpectedException(typeof(FormatException))]
    public void Q05_3_CalculateSumTestFormatException()
    {
        Assert.Inconclusive();
        
        // int result = Basics.Q5_CalculateSum("a+b");
        
    }

    /// <summary>
    /// متد
    /// TryCalculate
    /// را به گونه‌ای پیاده‌سازی کنید که در صورت بروز خطا 
    /// false
    /// برگرداند و 
    /// در هیچ شرایطی 
    /// Exception
    /// رخ ندهد. در این متد مقدار عددی محاسبه شده بصورت یک 
    /// پارامتر از نوع 
    /// out
    /// بازگردانده می‌شود.
    /// </summary>
    [TestMethod()]
    public void Q06_TryCalculateSumTest()
    {
        Assert.Inconclusive();
        
        // int result;
        // Assert.IsFalse(Basics.Q6_TryCalculateSum("a+b", out result));
        // Assert.IsFalse(Basics.Q6_TryCalculateSum("1+", out result));

        // Assert.IsTrue(Basics.Q6_TryCalculateSum("2+2+2+2+2+1", out result));
        // Assert.AreEqual(11, result);
        
    }

    /// <summary>
    /// کلاس
    /// FullName
    /// و
    /// متد 
    /// RemoveDuplicates
    /// پیاده‌سازی شده‌اند ولی این تست  پاس نمی‌شود.
    /// کلاس 
    /// FullName
    /// را بگونه‌ای تغییر دهید که تست زیر پاس شود.
    /// متد 
    /// RemoveDuplicates
    /// نباید هیچ تغییر بکند
    /// </summary>
    // [TestMethod()]
    // public void Q07_RemoveDuplicatesDebugTest()
    // {
    //     Assert.Inconclusive();        
    //     FullName[] celbrities = new FullName[]{
    //             new FullName("مهناز", "افشار"),
    //             new FullName("سحر", "قریشی"),
    //             new FullName("بهنوش", "بختیاری"),
    //             new FullName("الناز", "شاکردوست"),
    //             new FullName("رامبد", "جوان"),
    //             new FullName("ترانه", "علیدوستی"),
    //             new FullName("بهنوش", "بختیاری"),
    //             new FullName("رامبد", "جوان"),
    //             new FullName("الناز", "شاکردوست"),
    //             new FullName("ترانه", "علیدوستی"),
    //             new FullName("سحر", "قریشی"),
    //             new FullName("ترانه", "علیدوستی"),
    //             new FullName("لیلا", "حاتمی"),
    //         };

    //     FullName[] uniqueCelbrities = new FullName[]
    //     {
    //             new FullName("مهناز", "افشار"),
    //             new FullName("سحر", "قریشی"),
    //             new FullName("بهنوش", "بختیاری"),
    //             new FullName("الناز", "شاکردوست"),
    //             new FullName("رامبد", "جوان"),
    //             new FullName("ترانه", "علیدوستی"),
    //             new FullName("لیلا", "حاتمی"),
    //     };

    //     Basics.RemoveDuplicates(ref celbrities);

    //     CollectionAssert.AreEqual(uniqueCelbrities, celbrities);

    //     FullName[] testNames = new FullName[]{
    //         new FullName("1", "2"),
    //         new FullName("1", "3"),
    //         new FullName("1", "4"),
    //         new FullName("1", "4"),
    //         new FullName("1", "5"),
    //         new FullName("1", "6"),
    //         new FullName("1", "2"),
    //     };
   
    //     FullName[] uniqueTestNames = new FullName[]{
    //         new FullName("1", "2"),
    //         new FullName("1", "3"),
    //         new FullName("1", "4"),
    //         new FullName("1", "5"),
    //         new FullName("1", "6")
    //     };
    //     Basics.RemoveDuplicates(ref testNames);
    //     CollectionAssert.AreEqual(uniqueTestNames, testNames);
    // }
}
