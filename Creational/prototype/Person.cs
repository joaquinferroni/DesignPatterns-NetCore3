using System;
namespace prototype
{
    public class Person : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person()
        {
            
        }
        public Person(int id, string name, string latName, Address adress)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = LastName;
            this.Address = adress;
        }
        public object Clone()
        {
            Person person = (Person)this.MemberwiseClone();
            person.Address = new Address(this.Address.Id, this.Address.Street, this.Address.Number);
            return person;
        }

        public override string ToString(){
            return $"id: {this.Id} - FullName: {this.Name} {this.LastName} - Address {this.Address.ToString()}";
        }
    }

    public class Address{
        public int Id { get; set; }
        public string Street {get;set;}
        public int Number {get;set;}

        public Address(int id, string street,int number)
        {
            this.Id = id;
            this.Street = street;
            this.Number = number;
        }

        public override string ToString(){
            return $"Street: {this.Street} {this.Number}";
        }
    }
}