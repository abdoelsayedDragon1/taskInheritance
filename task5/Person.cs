namespace task5
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public Person (string Name, int Age, string Address,string Nationality)
        {
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
            this.Nationality = Nationality;

        }
    }
}
