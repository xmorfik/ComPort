namespace Manager
{
    [Serializable]
    internal class ValueMeaning
    {
        public byte Value { get; set; }
        public string Meaning { get; set; }
        public ValueMeaning()
        {
            Value = 0;
            Meaning = "";
        }
        public ValueMeaning(byte data, string meaning)
        {
            this.Value = data;
            this.Meaning = meaning;
        }
    }
}
