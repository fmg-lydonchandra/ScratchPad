// var dict = new Dictionary<int, List<RuleResultTree>>();
int maxCount = 1_000_000;

var list1 = new List<string>(maxCount);
// var dict2 = new Dictionary<int, string>(maxCount);

string val = "input1.country == \"india\" AND input1.loyaltyFactor <= 2 AND input1.totalPurchasesToDate >= 5000 AND input2.totalOrders > 2 AND input3.noOfVisitsPerMonth > 2";
for (var ix = 0; ix < maxCount; ix++)
{
    list1.Add(string.Intern(val));
    // dict2.Add(ix, string.Intern(val));
}
var totalMemory = GC.GetTotalMemory(false);
Console.WriteLine(totalMemory/1024 + "KB");

Console.ReadKey();
Console.Write(list1[0]);