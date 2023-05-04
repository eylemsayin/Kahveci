namespace RabiaKandemir_EylemSayin_UygulamaSinavi
{
    public class Employee
    {
        public Employee(string _Name, bool _IsFree)
        {
            Name = _Name;
            IsFree = _IsFree;
        }
        public string Name { get; set; }
        public bool IsFree { get; set; }
    }
}
