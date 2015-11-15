//using System.Collections.Generic;
//using NUnit.Framework;
//using FindMyPastTechTest.Controllers;

//namespace FindMyPastTechTest.Tests.Tests
//{
//    [TestFixture]
//    class GeneratorController
//    {
//        [Test]
//        public void Generate_List_From_Controller()
//        {
//            var list = FindMyPastTechTest.Controllers.GeneratorController.GenerateListOfNumbers(5);

//            Assert.AreEqual(list.count , 5);
//            Assert.IsInstanceOf<List<int>>(list);
//        }
//    }
//}

// Test only works when controller action is made static but then the action is not acessible from the Ajax Jquery, 
//needs re working. left in to show test was writen and code built around test
//return type has also since changed from list to jsonresult test would need fully refactoring