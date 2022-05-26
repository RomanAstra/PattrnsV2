namespace Other.Soilid
{
    internal sealed class Test
    {
        private void NameMethod(Unit unit)
        {
            if (unit is ITreatable doc)
            {
                doc.Treat(100);
            }
        }
    }
}
