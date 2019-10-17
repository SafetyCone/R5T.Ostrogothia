using System;


namespace R5T.Ostrogothia
{
    public class Organization : IOrganization
    {
        public string Name { get; set; }


        public Organization()
        {
        }

        public Organization(string name)
        {
            this.Name = name;
        }
    }
}
