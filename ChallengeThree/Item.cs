using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeThree
{
    public class Item
    {
        public string ItemNumber { get; set; } // it's not unique, multiple items may share the same item number
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
        public int Prop3 { get; set; }
        public int Prop4 { get; set; }
        public int Prop5 { get; set; }
        public int Prop6 { get; set; }

        public List<Item> SubItems = new List<Item>();
    }

    public class ItemSummary
    {
        public int PropSummary { get; set; }
        public static ItemSummary CreateItemSummary(Item item)
        {
            return new ItemSummary { PropSummary = item.Prop1 + item.Prop2 + item.Prop3 + item.Prop4 + item.Prop5 + item.Prop6 };
        }
    }
}
