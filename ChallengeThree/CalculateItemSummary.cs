using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeThree
{
    public class CalculateItemSummary
    {
        public ItemSummary[] GetSubItemSummary(string itemNumber, List<Item> allItems)
        {
            Item[] items = GetSubItems(itemNumber, allItems);
            List<ItemSummary> summaries = new List<ItemSummary>();
            foreach(Item item in items)
            {
                summaries.Add(ItemSummary.CreateItemSummary(item));
            }

            return summaries.ToArray();
        }

        /// <summary>
        /// Use recursive way to loop each item's subitems for the item which has matched itemNumber.
        /// </summary>
        /// <param name="itemNumber"></param>
        /// <param name="allItems"></param>
        /// <returns></returns>
        private Item[] GetSubItems(string itemNumber, List<Item> allItems)
        {
            List<Item> items = new List<Item>();
            foreach(Item item in allItems)
            {
                if (item.ItemNumber == itemNumber)
                {
                    items.Add(item);
                    Item[] result = GetSubItems(itemNumber, item.SubItems);
                    items.AddRange(result);
                }
            }

            return items.ToArray();
        }
    }
}
