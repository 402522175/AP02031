// namespace E2.Tests;

// [TestClass]
// public class ExtensionTests
// {
//     /// <summary>
//     /// Extension Method
//     /// به نام
//     /// To
//     /// را به شکلی پیاده سازی کنید که تست زیر پاس شود
//     /// </summary>
//     [TestMethod]
//     public void ToTest()
//     {
//         Assert.Inconclusive();

//         int c = 0;
//         foreach (var i in 10.To(20))
//             Assert.AreEqual(10 + c++, i);

//         c = 2;
//         foreach (var i in c.To(5))
//             Assert.AreEqual(c++, i);

//         c = 0;
//         foreach (var _ in 0.To(1_000_000))
//             c++;
//         Assert.AreEqual(c, 1_000_001);
//     }

//     /// <summary>
//     /// Extension Method
//     /// به نام 
//     /// NextPrime
//     /// را به شکلی پیاده سازی کنید که تست زیر پاس شود
//     /// </summary>
//     [TestMethod]
//     public void NextPrimeTest()
//     {
//         Assert.Inconclusive();

//         Assert.AreEqual(2.NextPrime(), 3);
//         Assert.AreEqual(5.NextPrime(), 7);
//         Assert.AreEqual(27.NextPrime(), 29);
//     }

// }