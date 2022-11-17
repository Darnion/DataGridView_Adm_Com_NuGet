namespace AdmComDGVNuGet
{
    public class NuGet_WF
    {
        public NuGet_WF()
        {

        }

        public void Add<T>(T args, ref List<T> entrants)
        {
            entrants.Add(args);
        }
        public void Remove<T>(T args, ref List<T> entrants)
        {
            entrants.Remove(args);
        }

        public void Change<T>(T oldValues, T args, ref List<T> entrants)
        {
            var index = entrants.IndexOf(oldValues);
            entrants[index] = args;
        }

        public void FillEnum(Enum item, ref ComboBox comboBox)
        {
            Type type = item.GetType();

            foreach (var value in Enum.GetValues(type))
            {
                comboBox.Items.Add(value);
            }
        }
    }
}
