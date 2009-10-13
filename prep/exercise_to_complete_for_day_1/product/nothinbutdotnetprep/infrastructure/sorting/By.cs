using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class by<ItemToSort, ItemProperty> where ItemProperty:IComparable<ItemProperty>
    {
        private Func<ItemToSort, ItemProperty> property_accessor;
        private IComparer<ItemProperty> comparer;
        public by(Func<ItemToSort, ItemProperty> property_accessor_pa,  IComparer<ItemProperty> comparer_pa)
        {   
            this.property_accessor = property_accessor_pa;
            this.comparer = comparer_pa;
        }


        public IComparer<ItemToSort> then_by(ItemToSort item) 
        {
            //.Compare();
            //return property_accessor(item);
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return this.comparer.Compare(property_accessor(x), property_accessor(y));
        }

    }

    public class ThenBy<T>:IComparable<T>
    {
        private 

        public ThenBy ascending(ItemProperty prop)
        {
            return this;
        }

        public ThenBy descending(ItemProperty prop)
        {

        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}