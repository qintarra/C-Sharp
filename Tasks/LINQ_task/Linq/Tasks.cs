using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;

namespace Linq
{
    public static class Tasks
    {
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length > 1 && s.First().Equals(c) && s.Last().Equals(c));
        }

        public static IEnumerable<int> Task2(IEnumerable<string> stringList)
        {
            return stringList.Select(s => s.Length).OrderBy(s => s);
        }

        public static IEnumerable<string> Task3(IEnumerable<string> stringList)
        {
            return stringList.Select(s => s.First().ToString() + s.Last().ToString());
        }

        public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length == k && char.IsDigit(s.Last())).OrderBy(s => s);
        }

        public static IEnumerable<string> Task5(IEnumerable<int> integerList)
        {
            return integerList.Where(i => i % 2 == 1).OrderBy(i => i).Select(i => i.ToString());
        }

        #endregion

        #region Middle

        public static IEnumerable<string> Task6(IEnumerable<int> numbers, IEnumerable<string> stringList)
        {
            return numbers.Select(x => stringList.FirstOrDefault(i => i.Count() == x && i.Any() && char.IsDigit(i[0])) ?? "Not found");
        }

        public static IEnumerable<int> Task7(int k, IEnumerable<int> integerList)
        {
            return integerList.Where(i => i % 2 == 0).Except(integerList.Skip(k)).Reverse();
        }
        
        public static IEnumerable<int> Task8(int k, int d, IEnumerable<int> integerList)
        {
            return integerList.TakeWhile(i => i <= d).Union(integerList.Skip(k)).OrderByDescending(i => i);
        }

        public static IEnumerable<string> Task9(IEnumerable<string> stringList)
        {
            return stringList.GroupBy(i => i.First()).Select(x => x.Aggregate((a, b) => a + b)).OrderByDescending(i => i.Count()).ThenBy(i => i.First()).Select(i => $"{i.Count()}-{i.First()}");
        }

        public static IEnumerable<string> Task10(IEnumerable<string> stringList)
        {
            return stringList.OrderBy(i => i).GroupBy(i => i.Count()).Select(i => i.Aggregate("", (a, b) => (a + b[^1]).ToUpper())).OrderByDescending(i => i.Count());
        }

        #endregion

        #region Advance

        public static IEnumerable<YearSchoolStat> Task11(IEnumerable<Entrant> nameList)
        {
            return nameList.GroupBy(y => y.Year).Select(n => new YearSchoolStat { Year = n.Key, NumberOfSchools = n.Select(s => s.SchoolNumber).Distinct().Count() }).OrderBy(n => n.NumberOfSchools).ThenBy(y => y.Year);
        }
		
        public static IEnumerable<NumberPair> Task12(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
        {
            return integerList1.SelectMany(x => integerList2.Where(y => x % 10 == y % 10), (x, y) => new NumberPair { Item1 = x, Item2 = y }).OrderBy(p => p.Item1).ThenBy(p => p.Item2);
        }

        public static IEnumerable<YearSchoolStat> Task13(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
        {
            return yearList.Select(n => new YearSchoolStat { Year = n, NumberOfSchools = nameList.Where(y => y.Year == n).Select(s => s.SchoolNumber).Distinct().Count()}).OrderBy(n => n.NumberOfSchools).ThenBy(y => y.Year);
        }
		
        public static IEnumerable<MaxDiscountOwner> Task14(IEnumerable<Supplier> supplierList,
                IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            return supplierList.Join(supplierDiscountList, 
                supplier => supplier.Id, 
                supplierDiscount => supplierDiscount.SupplierId, 
                (supplier, supplierDiscount) => new { Supplier = supplier, SupplierDiscount = supplierDiscount })
                .GroupBy(joined => joined.SupplierDiscount.ShopName)
                .Select(group => new MaxDiscountOwner
                {
                    Discount = group.Max(joined => joined.SupplierDiscount.Discount), 
                    ShopName = group.Key, 
                    Owner = group
                    .Where(joined => joined.SupplierDiscount.Discount == group.Max(subgroup => subgroup.SupplierDiscount.Discount))
                    .OrderBy(joined => joined.Supplier.Id)
                    .Select(joined => joined.Supplier)
                    .First()
                })
                .OrderBy(maxDiscountOwner => maxDiscountOwner.ShopName);
        }
		
        public static IEnumerable<CountryStat> Task15(IEnumerable<Good> goodList,
            IEnumerable<StorePrice> storePriceList)
        {
            return  goodList
                    .GroupBy(good => good.Country)
                    .Select(group => new CountryStat
                    {
                        Country = group.Key,
                        StoresNumber = storePriceList
                            .Where(sp => group.Any(good => good.Id == sp.GoodId))
                            .Select(sp => sp.Shop)
                            .Distinct()
                            .Count(),
                        MinPrice = storePriceList
                            .Where(sp => group.Any(good => good.Id == sp.GoodId))
                            .Select(sp => sp.Price)
                            .DefaultIfEmpty(0)
                            .Min()
                    })
                    .OrderBy(stat => stat.Country);
        }

        #endregion
    }
}
