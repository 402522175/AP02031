// namespace E2.Tests;

// /// <summary>
// /// کلاس به نام
// /// SpecialNumberNotifierContainer
// /// را به گونه‌ای پیاده‌سازی کنید که تست‌های زیر پاس شود
// /// بطور خلاصه این کلاس باید
// /// قابلیت اضافه کردن و بازیابی اعداد را داشته باشد.
// /// علاوه بر آن باید بتواند 
// /// شرطی را به عنوان یک 
// /// delegate
// /// دریافت کند و طبق آن شرط
// /// اگر عددی به مجموعه اضافه شد که در آن شرط صدق می‌کند
// /// event
// /// مشخص شده را صدا بزند
// /// </summary>

// [TestClass]
// public class SpecialNumberNotifierContainerTest
// {
//     [TestMethod]
//     public void AddTest()
//     {
//         Assert.Inconclusive();        
//         ISpecialNumberNotifierContainer snnc = new SpecialNumberNotifierContainer();
//         for (int i = 0; i < 100; i++)
//             snnc.add(i);

//         for (int i = 0; i < 100; i++)
//             Assert.AreEqual(i, snnc[i]);

//         int x = Random.Shared.Next();
//         snnc.add(x);
//         Assert.AreEqual(snnc[100], x);

//         x = Random.Shared.Next();
//         snnc.add(x);
//         Assert.AreEqual(snnc[101], x);        
//     }

//     [TestMethod]
//     public void NotifyTest()
//     {
//         Assert.Inconclusive();        
//         ISpecialNumberNotifierContainer snnc = new SpecialNumberNotifierContainer();
//         snnc.SpecialNumberIdentifier = x => (x % 3 == 0) && (x % 5 == 0);
//         bool called = false;
//         var fnc = x =>
//         {
//             called = true;
//             Assert.IsTrue((x % 3 == 0) && (x % 5 == 0));
//         };
//         snnc.SpecialNumberAdded += fnc;
//         for (int i = 1; i < 14; i++)
//             snnc.add(i);
//         Assert.IsFalse(called);
//         snnc.add(15);
//         Assert.IsTrue(called);
//         called = false;
//         for (int i = 31; i < 45; i++)
//             snnc.add(i);
//         Assert.IsFalse(called);
//         snnc.add(45);
//         Assert.IsTrue(called);     

//         snnc.SpecialNumberIdentifier = x => (x % 100 == 0);
//         snnc.SpecialNumberAdded -= fnc;
//         snnc += x => called = true;
//         called = false;
//         snnc.add(101);
//         Assert.IsFalse(called);
//         snnc.add(1200);
//         Assert.IsTrue(called);
//     }    
// }