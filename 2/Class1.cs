namespace tesstik
{
    public class Class1
    {

            public bool CompareCollectionsByOrder<T>(List<T> collection1, List<T> collection2)
            {
                if (collection1.Count != collection2.Count)
                    return false;

                for (int i = 0; i < collection1.Count; i++)
                {
                    if (!collection1[i].Equals(collection2[i]))
                        return false;
                }

                return true;
            }
    }
    public class Class2
    {
        public bool CompareCollectionsIgnoreOrder<T>(List<T> collection1, List<T> collection2)
        {
            if (collection1.Count != collection2.Count)
                return false;

            var set1 = new HashSet<T>(collection1);
            var set2 = new HashSet<T>(collection2);

            return set1.SetEquals(set2);
        }
    }
    public class Class3
    {
        public double CalculatePercent(double initialValue, double finalValue)
        {

            double delta = finalValue - initialValue;

            double percent = (delta / initialValue) * 100;

            return percent;
        }
    }
}