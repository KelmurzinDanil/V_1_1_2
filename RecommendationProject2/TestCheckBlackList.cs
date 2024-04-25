using DB_993;
using design;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestRecommendationProject
{
    [TestFixture]
    internal class TestCheckBlackList
    {
        [Test]
        public void TestCheckBlackListMethod()
        {
            MainWindow mainWindow = new MainWindow();
            using (var context = new ApplicationContex())
            {
                var newBL = new BlackListTable
                {
                    Id_Realty = 1
                };
                context.BlackLists.Add(newBL);
                context.SaveChanges();
                var newBL2 = new BlackListTable
                {
                    Id_Realty = 2
                };
                context.BlackLists.Add(newBL2);
                context.SaveChanges();
                var bl = context.BlackLists.ToList();
                List<int> list = new List<int>();
                foreach (var item in bl)
                {
                    list.Add(item.Id_Realty);
                }
                mainWindow.I = 1;


                Assert.That(mainWindow.CheckBlackList(list), Is.False);
            }
        }
    }
}
